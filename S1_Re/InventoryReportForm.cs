using System;
using System.Collections;
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
    public partial class InventoryReportForm : BaseForm
    {
        int taskId;
        ArrayList array;

        public InventoryReportForm(int taskId)
        {
            InitializeComponent();
            this.taskId = taskId;
        }

        private void InventoryReportForm_Load(object sender, EventArgs e)
        {
            loadPartInfo();
            var data = s1Entities.InventoryCheckingTask.Where(a => a.Id == taskId).FirstOrDefault();
            array = new ArrayList()
            {
                $"Warehourse:",
                $"{s1Entities.Warehouse.Where(a=>a.Id==data.WarehouseId).FirstOrDefault().Name}",
                $"Inventory Checking Task:",
                $"{data.TaskName}",
                $"Task Type:" ,
                $"{data.TaskType.Name}",
                $"Create Time：",
                $"{data.CreateTime}",
                $"Start Date：" ,
                $"{data.StartDate}",
                $"Finish Date：",
                $"{data.FinishDate}",
                $"Status：",
                $"{data.TaskStatus.Name}"
            };
            loadTaskInfo();
        }

        private void loadPartInfo()
        {
            var data = s1Entities.TaskDetail.Where(a => a.TaskId == taskId).Include(a => a.Part);
            var data1=data.Select(a => new
            {
                PartName = a.Part.Name,
                a.Part.Specification,
                a.StockAmount,
                a.CheckAmount
            }).ToList();
            data1.RemoveAll(a => a.CheckAmount == a.StockAmount);
            staock_amt_udg.DataSource = data1;
            var data2 = data.Select(a => new
            {
                PartName=a.Part.Name,
                a.Part.Specification,
                a.CheckAmount,
                a.Part.MinInventory,
            }).ToList();
            data2.RemoveAll(a => a.CheckAmount> a.MinInventory);
            need_udg.DataSource = data2;
        }

        private void loadTaskInfo()
        {
            int index = 0;
            for(int i = 0; i < inv_tab.RowCount; i++)
            {
               for(int j = 0; j < inv_tab.ColumnCount; j++)
               {
                    MyLab myLab = new MyLab
                    {
                        Text = array[index++].ToString(),
                        Dock = DockStyle.Fill,
                        TextAlign=ContentAlignment.MiddleCenter
                    };
                    inv_tab.Controls.Add(myLab, j, i);
               }
            }
        }
    }
}
