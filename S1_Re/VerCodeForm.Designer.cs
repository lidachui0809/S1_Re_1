
namespace S1_Re
{
    partial class VerCodeForm
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myLab1 = new S1_Re.MyLab();
            this.myPan1 = new S1_Re.MyPan();
            this.btn2 = new S1_Re.MyBtn();
            this.btn1 = new S1_Re.MyBtn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.myPan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(49, 190);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(443, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(49, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 26);
            this.panel2.TabIndex = 3;
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 15F);
            this.myLab1.Location = new System.Drawing.Point(162, 9);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(209, 20);
            this.myLab1.TabIndex = 0;
            this.myLab1.Text = "Securly Verification";
            // 
            // myPan1
            // 
            this.myPan1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.myPan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPan1.Controls.Add(this.btn2);
            this.myPan1.Controls.Add(this.btn1);
            this.myPan1.Location = new System.Drawing.Point(49, 49);
            this.myPan1.Name = "myPan1";
            this.myPan1.Size = new System.Drawing.Size(443, 135);
            this.myPan1.TabIndex = 4;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("楷体", 18F);
            this.btn2.Location = new System.Drawing.Point(328, 42);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(83, 37);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "B";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("楷体", 18F);
            this.btn1.Location = new System.Drawing.Point(0, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(83, 37);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "A";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::S1_Re.Properties.Resources.icon_refresh;
            this.pictureBox1.Location = new System.Drawing.Point(486, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // VerCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 283);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myPan1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.myLab1);
            this.Name = "VerCodeForm";
            this.Text = "VerCodeForm";
            this.Load += new System.EventHandler(this.VerCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.myPan1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLab myLab1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private MyPan myPan1;
        private MyBtn btn2;
        private MyBtn btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}