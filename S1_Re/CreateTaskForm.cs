
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
    public partial class CreateTaskForm : BaseForm
    {
        public CreateTaskForm()
        {
            InitializeComponent();
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            GetS1Entities().Warehouse.ToList().ForEach(a => war_name.Items.Add(a.Name));
            GetS1Entities().TaskType.ToList().ForEach(a => task_type_comb.Items.Add(a.Name));
            war_name.SelectedIndex = 0;
            task_type_comb.SelectedIndex = 0;
        }




        private void loadTaskName()
        {
            String str = $"Inventory Checking Task of {war_name.SelectedItem},{start_date.Value.ToString("yyyy-MM")}";
            task_name.Text = str;
        }

        private void war_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTaskName();
            loadPartInfo();
            loadZone();
        }

        private void loadZone()
        {
            int id = war_name.SelectedIndex + 1;
            var data = GetS1Entities().Zone.Where(a => a.WarehouseId == id).ToList();
            int dexof = 0;
            int X = (part_zone_cont.Width) / data.Count;
            foreach (var item in data)
            {
                MyBtn btn = new MyBtn
                {
                    Location = new Point(X * dexof++, 0),
                    Size = new Size(X, part_zone_cont.Height),
                    Tag = item.Name,
                    Text = item.Name
                };
                btn.Click += onZoneBtnClick;
                part_zone_cont.Controls.Add(btn);
            }
        }

        private void onZoneBtnClick(object sender, EventArgs e)
        {
            MyBtn btn = sender as MyBtn;
            loadPartInfo(btn.Tag.ToString());
        }

        private void loadPartInfo(String zoneNmae = "")
        {
            int warId = war_name.SelectedIndex + 1;
            int index = 1;
            S1Entities s1 = GetS1Entities();
            var result = s1.PartStorage.Include(a => a.Part)
            .Include(a => a.Zone).Where(a => a.Zone.WarehouseId == warId);
            if (zoneNmae.Length != 0)
            {
                result = result.Where(a => a.Zone.Name == zoneNmae);
            }
            var result2 = result.OrderByDescending(a => a.Zone.Name).ThenByDescending(a => a.Part.Name).ToList()
                .Select(a => new
                {
                    Sep = index++,
                    Zone = a.Zone.Name,
                     a.PartId,
                    PartName = a.Part.Name,
                    a.Part.Unit,
                    a.Part.Specification,
                    StockAmount = a.Amount,
                }).ToList();
            part_dgv.DataSource = result2;
            part_info.Text = $"Part to be Check({result2.Count})";
        }

        private void task_type_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (task_type_comb.SelectedIndex == 0)
            {
                part_zone_cont.Visible = false;
            }
            else
            {
                part_zone_cont.Visible = true;
            }
            loadZone();
            loadPartInfo();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            InventoryCheckingTask inventory = new InventoryCheckingTask 
            { 
                TaskName=task_name.V,
                WarehouseId=war_name.SelectedIndex+1,
                TaskTypeId=task_type_comb.SelectedIndex+1,
                CreateTime=start_date.Value,
                StatusId=1,
                StartDate=start_date.Value
            };
            foreach (DataGridViewRow item in part_dgv.Rows)
            {
                TaskDetail taskDetail = new TaskDetail
                {
                    PartId = Convert.ToInt32(item.Cells["PartId"].Value),
                    StockAmount= Convert.ToInt32(item.Cells["StockAmount"].Value),
                    IsChecked=0,
                };
                inventory.TaskDetail.Add(taskDetail);
            }
            GetS1Entities().InventoryCheckingTask.Add(inventory);
            if (GetS1Entities().SaveChanges() > 0)
            {
                showDia("保存成功！");
            }
            else
            {
                showDia("保存失败！");
            }
        }

    }
 }


