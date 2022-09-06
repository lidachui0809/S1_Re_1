
namespace S1_Re
{
    partial class ViewCheckTaskForm
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
            this.myLabTit1 = new S1_Re.MyLabTit();
            this.myLab1 = new S1_Re.MyLab();
            this.ware_name = new S1_Re.MyCb();
            this.myLab2 = new S1_Re.MyLab();
            this.myPan1 = new S1_Re.MyPan();
            this.wareInfo = new S1_Re.MyLab();
            this.myLab3 = new S1_Re.MyLab();
            this.myLab4 = new S1_Re.MyLab();
            this.ware_lay_p = new S1_Re.MyPan();
            this.part_dgv = new S1_Re.MyDgv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myBtn1 = new S1_Re.MyBtn();
            this.myPan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.part_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // myLabTit1
            // 
            this.myLabTit1.AutoSize = true;
            this.myLabTit1.Font = new System.Drawing.Font("楷体", 18F);
            this.myLabTit1.Location = new System.Drawing.Point(385, 26);
            this.myLabTit1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabTit1.Name = "myLabTit1";
            this.myLabTit1.Size = new System.Drawing.Size(253, 30);
            this.myLabTit1.TabIndex = 2;
            this.myLabTit1.Text = "Warehoure Detail";
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab1.Location = new System.Drawing.Point(48, 88);
            this.myLab1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(119, 20);
            this.myLab1.TabIndex = 3;
            this.myLab1.Text = "Warehourse:";
            // 
            // ware_name
            // 
            this.ware_name.Font = new System.Drawing.Font("楷体", 12F);
            this.ware_name.FormattingEnabled = true;
            this.ware_name.Location = new System.Drawing.Point(184, 88);
            this.ware_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ware_name.Name = "ware_name";
            this.ware_name.Size = new System.Drawing.Size(336, 28);
            this.ware_name.TabIndex = 4;
            this.ware_name.SelectedIndexChanged += new System.EventHandler(this.ware_name_SelectedIndexChanged);
            // 
            // myLab2
            // 
            this.myLab2.AutoSize = true;
            this.myLab2.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab2.Location = new System.Drawing.Point(48, 160);
            this.myLab2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLab2.Name = "myLab2";
            this.myLab2.Size = new System.Drawing.Size(219, 20);
            this.myLab2.TabIndex = 5;
            this.myLab2.Text = "Warehoure Information";
            // 
            // myPan1
            // 
            this.myPan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPan1.Controls.Add(this.wareInfo);
            this.myPan1.Location = new System.Drawing.Point(52, 199);
            this.myPan1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myPan1.Name = "myPan1";
            this.myPan1.Size = new System.Drawing.Size(1190, 146);
            this.myPan1.TabIndex = 6;
            // 
            // wareInfo
            // 
            this.wareInfo.AutoSize = true;
            this.wareInfo.Font = new System.Drawing.Font("楷体", 12F);
            this.wareInfo.Location = new System.Drawing.Point(36, 24);
            this.wareInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wareInfo.Name = "wareInfo";
            this.wareInfo.Size = new System.Drawing.Size(69, 20);
            this.wareInfo.TabIndex = 0;
            this.wareInfo.Text = "myLab5";
            // 
            // myLab3
            // 
            this.myLab3.AutoSize = true;
            this.myLab3.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab3.Location = new System.Drawing.Point(48, 389);
            this.myLab3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLab3.Name = "myLab3";
            this.myLab3.Size = new System.Drawing.Size(219, 20);
            this.myLab3.TabIndex = 7;
            this.myLab3.Text = "Warehoure Information";
            // 
            // myLab4
            // 
            this.myLab4.AutoSize = true;
            this.myLab4.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab4.Location = new System.Drawing.Point(556, 389);
            this.myLab4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLab4.Name = "myLab4";
            this.myLab4.Size = new System.Drawing.Size(219, 20);
            this.myLab4.TabIndex = 8;
            this.myLab4.Text = "Warehoure Information";
            // 
            // ware_lay_p
            // 
            this.ware_lay_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ware_lay_p.Location = new System.Drawing.Point(52, 424);
            this.ware_lay_p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ware_lay_p.Name = "ware_lay_p";
            this.ware_lay_p.Size = new System.Drawing.Size(399, 500);
            this.ware_lay_p.TabIndex = 9;
            // 
            // part_dgv
            // 
            this.part_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.part_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.part_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.part_dgv.Font = new System.Drawing.Font("楷体", 12F);
            this.part_dgv.Location = new System.Drawing.Point(536, 424);
            this.part_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.part_dgv.Name = "part_dgv";
            this.part_dgv.RowHeadersVisible = false;
            this.part_dgv.RowHeadersWidth = 51;
            this.part_dgv.RowTemplate.Height = 23;
            this.part_dgv.Size = new System.Drawing.Size(707, 500);
            this.part_dgv.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(29, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 36);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(537, 372);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 36);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(29, 144);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 36);
            this.panel3.TabIndex = 13;
            // 
            // myBtn1
            // 
            this.myBtn1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myBtn1.Location = new System.Drawing.Point(849, 943);
            this.myBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myBtn1.Name = "myBtn1";
            this.myBtn1.Size = new System.Drawing.Size(373, 48);
            this.myBtn1.TabIndex = 14;
            this.myBtn1.Text = "Create Inventory Checking Task";
            this.myBtn1.UseVisualStyleBackColor = true;
            this.myBtn1.Click += new System.EventHandler(this.myBtn1_Click);
            // 
            // ViewCheckTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 1004);
            this.Controls.Add(this.myBtn1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.part_dgv);
            this.Controls.Add(this.ware_lay_p);
            this.Controls.Add(this.myLab4);
            this.Controls.Add(this.myLab3);
            this.Controls.Add(this.myPan1);
            this.Controls.Add(this.myLab2);
            this.Controls.Add(this.ware_name);
            this.Controls.Add(this.myLab1);
            this.Controls.Add(this.myLabTit1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ViewCheckTaskForm";
            this.Text = "ViewCheckTaskForm";
            this.Load += new System.EventHandler(this.ViewCheckTaskForm_Load);
            this.myPan1.ResumeLayout(false);
            this.myPan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.part_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLabTit myLabTit1;
        private MyLab myLab1;
        private MyCb ware_name;
        private MyLab myLab2;
        private MyPan myPan1;
        private MyLab myLab3;
        private MyLab myLab4;
        private MyPan ware_lay_p;
        private MyDgv part_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MyLab wareInfo;
        private MyBtn myBtn1;
    }
}