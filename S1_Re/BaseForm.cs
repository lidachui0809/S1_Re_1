using System;
using System.Windows.Forms;

namespace S1_Re
{
    public partial class BaseForm : Form
    {
        public S1Entities s1Entities = new S1Entities();

        public BaseForm()
        {
            InitializeComponent();
            this.FormClosed += FromCloed;
        }

        private void FromCloed(object sender, FormClosedEventArgs e)
        {
            this.Owner?.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        public void showDia(string content)
        {
            MessageBox.Show(content);
        }

        public S1Entities GetS1Entities()
        {
            return s1Entities;
        }

        public void startFrom(Form form)
        {
            this.Hide();
            form.Owner = this;
            form.Show();       
        }


    }
}
