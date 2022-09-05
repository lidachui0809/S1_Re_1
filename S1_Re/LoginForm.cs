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
    public partial class LoginForm : BaseForm,EventBus
    {
        int count = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (count >= 3)
            {
                VerCodeForm verCodeForm = new VerCodeForm();
                verCodeForm.eventBus = this;
                startFrom(verCodeForm);
                return;
            }

            if (tele_v.checkNull||pwd_v.checkNull)
            {
                showDia("Plase send your info!");
            }
            else
            {
                count++;
                var user = GetS1Entities().Staff.Where(a => a.Telephone == tele_v.V && a.Password == pwd_v.V).FirstOrDefault();
                if (user != null)
                {
                    startFrom(new ViewCheckTaskForm());
                }
                else
                {
                    showDia("你的密码或账号有误！");
                }
            }

        }

        public void sendDaa(object obj)
        {
            if ((bool)obj)
            {
                count = 0;
            }
        }



        public void checkRole(int roleId)
        {
            switch (roleId)
            {
                case 1:
                case 4:

                    break;
                case 2:
                case 3:
                    break;
            }
        }

        private void myBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
