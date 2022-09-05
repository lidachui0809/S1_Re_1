
namespace S1_Re
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tele_v = new S1_Re.MyConText();
            this.pwd_v = new S1_Re.MyConText();
            this.myLab1 = new S1_Re.MyLab();
            this.myLab2 = new S1_Re.MyLab();
            this.logBtn = new S1_Re.MyBtn();
            this.myLab3 = new S1_Re.MyLab();
            this.myBtn1 = new S1_Re.MyBtn();
            this.SuspendLayout();
            // 
            // tele_v
            // 
            this.tele_v.Font = new System.Drawing.Font("楷体", 12F);
            this.tele_v.Location = new System.Drawing.Point(274, 139);
            this.tele_v.Name = "tele_v";
            this.tele_v.Size = new System.Drawing.Size(276, 26);
            this.tele_v.TabIndex = 0;
            // 
            // pwd_v
            // 
            this.pwd_v.Font = new System.Drawing.Font("楷体", 12F);
            this.pwd_v.Location = new System.Drawing.Point(274, 214);
            this.pwd_v.Name = "pwd_v";
            this.pwd_v.Size = new System.Drawing.Size(276, 26);
            this.pwd_v.TabIndex = 1;
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 15F);
            this.myLab1.Location = new System.Drawing.Point(146, 145);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(109, 20);
            this.myLab1.TabIndex = 2;
            this.myLab1.Text = "Telephone:";
            // 
            // myLab2
            // 
            this.myLab2.AutoSize = true;
            this.myLab2.Font = new System.Drawing.Font("楷体", 15F);
            this.myLab2.Location = new System.Drawing.Point(169, 220);
            this.myLab2.Name = "myLab2";
            this.myLab2.Size = new System.Drawing.Size(99, 20);
            this.myLab2.TabIndex = 3;
            this.myLab2.Text = "Password:";
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("楷体", 18F);
            this.logBtn.Location = new System.Drawing.Point(173, 284);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(178, 56);
            this.logBtn.TabIndex = 4;
            this.logBtn.Text = "Login";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // myLab3
            // 
            this.myLab3.AutoSize = true;
            this.myLab3.Font = new System.Drawing.Font("楷体", 15F);
            this.myLab3.Location = new System.Drawing.Point(363, 45);
            this.myLab3.Name = "myLab3";
            this.myLab3.Size = new System.Drawing.Size(59, 20);
            this.myLab3.TabIndex = 5;
            this.myLab3.Text = "Login";
            // 
            // myBtn1
            // 
            this.myBtn1.Font = new System.Drawing.Font("楷体", 18F);
            this.myBtn1.Location = new System.Drawing.Point(418, 284);
            this.myBtn1.Name = "myBtn1";
            this.myBtn1.Size = new System.Drawing.Size(178, 56);
            this.myBtn1.TabIndex = 6;
            this.myBtn1.Text = "Cancel";
            this.myBtn1.UseVisualStyleBackColor = true;
            this.myBtn1.Click += new System.EventHandler(this.myBtn1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myBtn1);
            this.Controls.Add(this.myLab3);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.myLab2);
            this.Controls.Add(this.myLab1);
            this.Controls.Add(this.pwd_v);
            this.Controls.Add(this.tele_v);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyConText tele_v;
        private MyConText pwd_v;
        private MyLab myLab1;
        private MyLab myLab2;
        private MyBtn logBtn;
        private MyLab myLab3;
        private MyBtn myBtn1;
    }
}