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
    public partial class InputResultForm : BaseForm
    {
        int taskId;

        public InputResultForm(int wareId)
        {
            InitializeComponent();
            this.taskId = wareId;
        }

        private void InputResultForm_Load(object sender, EventArgs e)
        {
            int index = 1;
            var data2 =GetS1Entities().PartStorage.Include(a=>a.Zone).Include(a=>a.Part).OrderByDescending(a=>a.Zone.Name).ThenBy(a=>a.Part.Name);
            var data = GetS1Entities().TaskDetail.Where(a => a.TaskId == taskId).ToList().Join(data2, a => a.PartId, b => b.PartId, (a, b) => new
            {
                Sep=index++,
                Zone=b.Zone.Name,
                Category=b.Part.PartCategory.Name,
                PartName=b.Part.Name,
                b.Part.Unit,
                b.Part.Specification,
                a.StockAmount,
                a.CheckAmount
            }).ToList();
            
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
