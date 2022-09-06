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

namespace S1_Re
{
    public partial class ViewCheckingTask : BaseForm
    {
        int userId;

        public ViewCheckingTask(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ViewCheckingTask_Load(object sender, EventArgs e)
        {
            GetS1Entities().Warehouse.Where(a=>a.Manager==userId ).ToList().ForEach(a => war_name.Items.Add(a.Name));
            GetS1Entities().TaskType.ToList().ForEach(a => task_type.Items.Add(a.Name));
            GetS1Entities().TaskStatus.ToList().ForEach(a => task_status.Items.Add(a.Name));
            war_name.Items.Insert(0, "All");
            task_type.Items.Insert(0, "All");
            task_status.Items.Insert(0, "All");
            war_name.SelectedIndex = 0;
            task_type.SelectedIndex = 0;
            task_status.SelectedIndex = 0;
        }
         
        private void loadTask()
        {
            var data = GetS1Entities().Warehouse.AsQueryable();
                //.Where(a => a.Manager == userId);
            var data2 = GetS1Entities().InventoryCheckingTask.AsQueryable();
            if (war_name.SelectedIndex != -1 && war_name.SelectedIndex != 0)
            {
                String name = war_name.SelectedItem.ToString();
                data=data.Where(a => a.Name == name);
            }
            if (task_status.SelectedIndex != -1 && task_status.SelectedIndex != 0)
            {
                int id = task_status.SelectedIndex ;
                data2=data2.Where(a => a.StatusId == id);
            }
            if (task_type.SelectedIndex != -1 && task_type.SelectedIndex != 0)
            {
                int id = task_type.SelectedIndex;
                data2=data2.Where(a => a.TaskTypeId == id);
            }
            int index = 1;
            var result=  data.ToList()
                .Join(data2, a => a.Id, b => b.WarehouseId, (a, b) => new
                {
                    Req=index++,
                    TaskId=b.Id,
                    WarehouseName=a.Name,
                    TaskName=b.TaskName,
                    TaskType=b.TaskType.Name,
                    b.CreateTime,
                    b.FinishDate,
                    Stauts=b.TaskStatus.Name
                }).ToList();
            task_dgv.DataSource = result;
            task_dgv.Columns["TaskId"].Visible = false;
        }

        private void war_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTask();
        }

        private void task_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTask();
        }

        private void task_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTask();
        }

        private void sea_btn_Click(object sender, EventArgs e)
        {
            loadTask();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if( task_dgv.SelectedRows[0].Cells["Stauts"].Value.ToString()=="NoStart")
            {
                int taskId =Convert.ToInt32( task_dgv.SelectedRows[0].Cells["TaskId"].Value.ToString());
                GetS1Entities().InventoryCheckingTask.Where(a => a.Id == taskId).FirstOrDefault().StatusId = 2;
                if (GetS1Entities().SaveChanges() > 0)
                {
                    showDia("修改成功！");
                    loadTask();
                }
            }
            else
            {
                showDia("清选择状态为NoStart的项目！");
            }
        }

        private void task_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void imp_re_btn_Click(object sender, EventArgs e)
        {

            if (task_dgv.SelectedRows[0].Cells["Stauts"].Value.ToString() == "Ongoing")
            {
                int taskId = Convert.ToInt32(task_dgv.SelectedRows[0].Cells["TaskId"].Value);
                startFrom(new InputResultForm(taskId));
            }
            else
            {
                showDia("清选择状态为Ongoing的项目！");
            }
          
        }

        private void view_in_Btn_Click(object sender, EventArgs e)
        {
            if (task_dgv.SelectedRows[0].Cells["Stauts"].Value.ToString() == "Finished")
            {
                int taskId = Convert.ToInt32(task_dgv.SelectedRows[0].Cells["TaskId"].Value);
                startFrom(new InventoryReportForm(taskId));
            }
            else
            {
                showDia("清选择状态为Finished的项目！");
            }
        }

        
    }
}
