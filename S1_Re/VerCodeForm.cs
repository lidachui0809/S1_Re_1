using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Re
{
    public partial class VerCodeForm : BaseForm
    {

        bool isRight;
        public EventBus eventBus;

        public VerCodeForm()
        {
            InitializeComponent();
        }

        private void VerCodeForm_Load(object sender, EventArgs e)
        {

            ranLoac();

        }

        public int getX()
        {
            int x = new Random().Next(0, myPan1.Width / 2);
            return x;
        }

        public int getY()
        {
            int y = new Random().Next(0, myPan1.Height - btn1.Width);
            return y;
        }

        public void ranLoac()
        {
            int x = getX();
            int y = getY();
            btn1.Location = new Point(x, y);
            btn2.Location = new Point(new Random().Next(btn1.Location.X + btn1.Width, myPan1.Width - btn1.Width), y);
            trackBar1.Maximum = btn2.Location.X;
            trackBar1.Minimum = btn1.Location.X;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (btn2.Location.X - btn1.Location.X <= 2)
            {
                isRight = true;
                eventBus.sendDaa(true);
                return;
            }
            btn1.Location = new Point(trackBar1.Value, btn1.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ranLoac();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isRight)
            {
                MessageBox.Show("验证成功！");
            }
            else
            {
                trackBar1.Value = trackBar1.Minimum;
                btn1.Location = new Point(trackBar1.Minimum, btn1.Location.Y);
            }
        }
    }
}
