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
    public partial class ViewCheckTaskForm : BaseForm
    {
        List<Color> colors = new List<Color>
            {
                Color.Red,
                Color.DarkRed,
                Color.IndianRed,
                Color.MediumVioletRed,
                Color.OrangeRed,
            };

        public ViewCheckTaskForm()
        {
            InitializeComponent();
        }

        private void ViewCheckTaskForm_Load(object sender, EventArgs e)
        {
            GetS1Entities().Warehouse.ToList().ForEach(a => ware_name.Items.Add(a.Name));
            ware_name.SelectedIndex = 0;
        }


        private void loadWarInfo(int warId)
        {
            var data = GetS1Entities().Warehouse.Where(a => a.Id == warId).FirstOrDefault();
            wareInfo.Text=$"Warehouse Name:{data.Name}                       Phone:{data.Phone}" +
                $"\nArea:{data.Area}                                 Address：{data.Address}" +
                $"\nWarehouse Keeper：{GetS1Entities().Staff.Where(a=>a.Id==data.Manager).FirstOrDefault().FirstName} {GetS1Entities().Staff.Where(a => a.Id == data.Manager).FirstOrDefault().LastName}                        "
                + $"Last Checking Date:{GetS1Entities().InventoryCheckingTask.Where(a => a.WarehouseId == data.Id).OrderByDescending(a => a.FinishDate).FirstOrDefault().FinishDate}";
        }

        private void loadWarelayout(int warId)
        {
            ware_lay_p.Controls.Clear();
            var data = GetS1Entities().Zone.Where(a => a.WarehouseId == warId).ToList();
            int i = 0;
            foreach(var item in data)
            {
                MyBtn mybn = new MyBtn
                {
                    Location = new Point(item.UpperLeftX / 5, item.UpperLeftY / 5),
                    Height = item.Height / 5,
                    Width = item.Width / 5,
                    Text = item.Name,
                    BackColor = getColor(++i),
                    Tag=item.Id
                };
                mybn.Click += zoneBtnClick;
                ware_lay_p.Controls.Add(mybn);
            }
        }

        private void zoneBtnClick(object sender, EventArgs e)
        {
            MyBtn myBtn = sender as MyBtn;
            int zoneId = (int)myBtn.Tag;
            loadPartInfo(zoneId);
        }

        private void ware_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ware_name.SelectedIndex + 1;
            loadWarInfo(id);
            loadWarelayout(id);
        }


        public Color getColor(int index)
        {
           
            if (index > colors.Count - 1)
            {
                index = 0;
            }
            return colors[index];
        }


        public void loadPartInfo(int zoneId)
        {
            
            var data = GetS1Entities().PartStorage.Where(a => a.ZoneId == zoneId).Include(a => a.Part).Select(a => new
            {
                PartName=a.Part.Name,
                Category=a.Part.PartCategory.Name,
                a.Part.Specification,
                a.Amount,
                a.Part.MinInventory
            }).ToList();
            part_dgv.DataSource = data;
        }

        private void myBtn1_Click(object sender, EventArgs e)
        {
            startFrom(new CreateTaskForm());
        }
    }
}
