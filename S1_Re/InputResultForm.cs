using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Text.RegularExpressions;

namespace S1_Re
{
    public partial class InputResultForm : BaseForm
    {
        int taskId;
        Timer timer;

        System.Windows.Forms.CheckBox lastBox;
        InventoryCheckingTask task;

        public InputResultForm(int wareId)
        {
            InitializeComponent();
            this.taskId = wareId;
            task = GetS1Entities().InventoryCheckingTask.Where(a => a.Id == taskId).FirstOrDefault();
            lastBox = au_5_cb;
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1*60*1000;
            timer.Tick += onTimeTask;
            timer.Start();
        }

        private void onTimeTask(object sender, EventArgs e)
        {
            saveData(true);
        }

        private void InputResultForm_Load(object sender, EventArgs e)
        {
            var data = GetS1Entities().InventoryCheckingTask.Where(a => a.Id == taskId).Include(a => a.TaskType).FirstOrDefault();
            task_info.Text = $"Warehouse Name:{GetS1Entities().Warehouse.Where(a => a.Id == data.WarehouseId).FirstOrDefault().Name}" +
                $"                       Task Type:{data.TaskType.Name}\n                 " +
                $"                 Task Name:{data.TaskName}";
            loadInfo();    
        }

        private void loadInfo()
        {
            int index = 1;
            var data = s1Entities.TaskDetail.Where(a => a.TaskId == taskId);
            if (only_cheched.Checked)
            {
                data = data.Where(a => a.IsChecked != 1);
            }
            var data2 = s1Entities.PartStorage.Where(a => a.Zone.WarehouseId == task.WarehouseId).Include(a => a.Part);
            var result = data.Join(data2, a => a.PartId, b => b.PartId, (a, b) => new
            {
                Zone = b.Zone.Name,
                Category = a.Part.PartCategory.Name,
                PartName = a.Part.Name,
                a.Part.Unit,
                a.Part.Specification,
                a.StockAmount,
                a.CheckAmount,
                TaskDetailId = a.Id
            }).ToList().OrderBy(a=>a.Zone).ThenBy(a=>a.PartName).Select(a => new {
                Seq=index++,
                a.Zone,
                Category = a.Category,
                PartName = a.PartName,
                a.Unit,
                a.Specification,
                a.StockAmount,
                SCheckAmount=a.CheckAmount,
                a.TaskDetailId
            }).ToList();        
            task_dgv.Columns.Clear();
            task_dgv.DataSource = result;
            task_dgv.Columns["SCheckAmount"].Visible = false;
            //task_dgv.Columns["IsChecked"].Visible = false;
            task_dgv.Columns["TaskDetailId"].Visible = false;
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                HeaderText = "CheckAmount",
                Name= "CheckAmount"
            };
            task_dgv.Columns.Insert(task_dgv.Columns.Count - 1, column);
            foreach (DataGridViewRow row in task_dgv.Rows)
            {
                row.Cells["CheckAmount"].Value = row.Cells["SCheckAmount"].Value;
            }
            //计算进度条
            int count = data.Count(a => a.IsChecked == 0);
            //已经盘点
            int count2 = data.Count(a => a.IsChecked == 1);
            float sum = count + count2;
            btn1.Size = new Size((int)(pro_cont.Width * (count2 / sum)),pro_cont.Height);
            btn2.Size = new Size(pro_cont.Width - btn1.Width, pro_cont.Height);
            btn1.Text = count2.ToString();
            btn2.Text = count.ToString();
            btn2.Location = new Point(btn1.Width + btn1.Location.X, 0);
        }


        private void saveData(bool isAuto=false)
        {
            int alertCpunt = 0;
            foreach (DataGridViewRow row in task_dgv.Rows)
            {
                if (row.Cells["TaskDetailId"]?.Value?.ToString() == null)
                {
                    continue;
                }
                alertCpunt++;
                int taskDetilId=Convert.ToInt32(row.Cells["TaskDetailId"].Value);
                int checkAmount= Convert.ToInt32(row.Cells["CheckAmount"].Value);
                GetS1Entities().TaskDetail.Where(a => a.Id == taskDetilId).FirstOrDefault().CheckAmount=checkAmount;
            }
            if(GetS1Entities().SaveChanges() > 0)
            {
                if (!isAuto)
                {
                    showDia("保存成功！");
                }
            }
            else
            {
                if (!isAuto)
                {
                    showDia("请先输入盘点数据后在尝试保存.保存失败！");
                }
            }
        }

        private void subData()
        {
            task.StatusId = 3;
            if (GetS1Entities().SaveChanges() > 0)
            {
                showDia("提交成功！");
            }
            else
            {
                showDia("提交失败！");
            }
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            bool isright = true;
            foreach(DataGridViewRow row in task_dgv.Rows)
            {
                if (row.Cells["CheckAmount"]?.Value==null)
                {
                    showDia("请先完成盘点任务!");
                    isright = false;
                    break;
                }
            }
            if(isright)
                subData();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void au_5_cb_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == lastBox)
            {
                checkBox.Checked=true;
                return;
            }
                
            lastBox.Checked = false;
            lastBox = checkBox;
            int spilt = Convert.ToInt32(checkBox.Tag);
            timer.Interval = spilt * 60 * 1000;
        }

        private void down_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "选择保存位置",
                FileName = "表格1.xls",
                Filter = "(*.xls)|(*.xls)"
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sheet = workbook.Sheets.Add()[1];

            for(int i = 0; i < task_dgv.Columns.Count; i++)
            {
                sheet.Rows[1, i + 1].Value = task_dgv.Columns[i].HeaderText;
            }
            for(int i = 0; i < task_dgv.Columns.Count; i++)
            {
                for(int j = 0; j < task_dgv.Rows.Count; j++)
                {
                    sheet.Rows[i + 2, j + 1].Value = task_dgv.Rows[i].Cells[j].Value;
                }
            }

            try
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }
            catch(Exception ex)
            {
                showDia("下载失败！");
            }
            showDia("下载成功！");
            app.Quit();
        }

        private void imp_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "选择表格",
                Filter = "(*.xls)|(*.xls)"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Open(openFileDialog.FileName);
                Microsoft.Office.Interop.Excel.Worksheet sheet = workbook.Sheets.get_Item(1);
                int shouldCount = 0, actCount = 0, errorCount = 0;
                Regex regex = new Regex(@"^\d*$");
                for (int i = 0; i < task_dgv.Columns.Count; i++)
                {
                    shouldCount++;
                    if (sheet.Columns[1, i + 1].Value != "CheckAmount")
                        continue;
                    for (int j = 0; j < task_dgv.Rows.Count; j++)
                    {
                        String value = sheet.Rows[j + 2, i + 1].Value;
                        if (regex.IsMatch(value))
                        {
                            errorCount++;
                            continue;
                        }
                        task_dgv.Rows[j].Cells[i].Value = value;
                        actCount++;
                    }
                }
                showDia("导入成功！");
            }
            catch(Exception ex)
            {
                showDia("数据表格式错误！");
            }
        }
    }
}
