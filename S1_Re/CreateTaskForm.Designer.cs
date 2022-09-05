
namespace S1_Re
{
    partial class CreateTaskForm
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
            this.myLab1 = new S1_Re.MyLab();
            this.myLab2 = new S1_Re.MyLab();
            this.war_name = new S1_Re.MyCb();
            this.task_name = new S1_Re.MyConText();
            this.myLabTit1 = new S1_Re.MyLabTit();
            this.c = new S1_Re.MyLab();
            this.task_type_comb = new S1_Re.MyCb();
            this.myLab3 = new S1_Re.MyLab();
            this.start_date = new S1_Re.MyDateTP();
            this.part_info = new S1_Re.MyLab();
            this.part_dgv = new S1_Re.MyDgv();
            this.sub_btn = new S1_Re.MyBtn();
            this.part_zone_cont = new S1_Re.MyPan();
            ((System.ComponentModel.ISupportInitialize)(this.part_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab1.Location = new System.Drawing.Point(41, 73);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(96, 16);
            this.myLab1.TabIndex = 0;
            this.myLab1.Text = "Warehoure :";
            // 
            // myLab2
            // 
            this.myLab2.AutoSize = true;
            this.myLab2.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab2.Location = new System.Drawing.Point(44, 112);
            this.myLab2.Name = "myLab2";
            this.myLab2.Size = new System.Drawing.Size(88, 16);
            this.myLab2.TabIndex = 1;
            this.myLab2.Text = "Task Name:";
            // 
            // war_name
            // 
            this.war_name.Font = new System.Drawing.Font("楷体", 12F);
            this.war_name.FormattingEnabled = true;
            this.war_name.Location = new System.Drawing.Point(152, 70);
            this.war_name.Name = "war_name";
            this.war_name.Size = new System.Drawing.Size(208, 24);
            this.war_name.TabIndex = 2;
            this.war_name.SelectedIndexChanged += new System.EventHandler(this.war_name_SelectedIndexChanged);
            // 
            // task_name
            // 
            this.task_name.Font = new System.Drawing.Font("楷体", 12F);
            this.task_name.Location = new System.Drawing.Point(152, 112);
            this.task_name.Name = "task_name";
            this.task_name.Size = new System.Drawing.Size(395, 26);
            this.task_name.TabIndex = 3;
            // 
            // myLabTit1
            // 
            this.myLabTit1.AutoSize = true;
            this.myLabTit1.Font = new System.Drawing.Font("楷体", 18F);
            this.myLabTit1.Location = new System.Drawing.Point(222, 20);
            this.myLabTit1.Name = "myLabTit1";
            this.myLabTit1.Size = new System.Drawing.Size(370, 24);
            this.myLabTit1.TabIndex = 4;
            this.myLabTit1.Text = "Create Inventory Checking Task";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("楷体", 12F);
            this.c.Location = new System.Drawing.Point(44, 171);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(88, 16);
            this.c.TabIndex = 5;
            this.c.Text = "Task Type:";
            // 
            // task_type_comb
            // 
            this.task_type_comb.Font = new System.Drawing.Font("楷体", 12F);
            this.task_type_comb.FormattingEnabled = true;
            this.task_type_comb.Location = new System.Drawing.Point(152, 168);
            this.task_type_comb.Name = "task_type_comb";
            this.task_type_comb.Size = new System.Drawing.Size(208, 24);
            this.task_type_comb.TabIndex = 6;
            this.task_type_comb.SelectedIndexChanged += new System.EventHandler(this.task_type_comb_SelectedIndexChanged);
            // 
            // myLab3
            // 
            this.myLab3.AutoSize = true;
            this.myLab3.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab3.Location = new System.Drawing.Point(402, 176);
            this.myLab3.Name = "myLab3";
            this.myLab3.Size = new System.Drawing.Size(96, 16);
            this.myLab3.TabIndex = 7;
            this.myLab3.Text = "Start Date:";
            // 
            // start_date
            // 
            this.start_date.CustomFormat = "yyyy/MM/dd";
            this.start_date.Font = new System.Drawing.Font("楷体", 12F);
            this.start_date.Location = new System.Drawing.Point(522, 168);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(200, 26);
            this.start_date.TabIndex = 8;
            // 
            // part_info
            // 
            this.part_info.AutoSize = true;
            this.part_info.Font = new System.Drawing.Font("楷体", 12F);
            this.part_info.Location = new System.Drawing.Point(41, 246);
            this.part_info.Name = "part_info";
            this.part_info.Size = new System.Drawing.Size(168, 16);
            this.part_info.TabIndex = 9;
            this.part_info.Text = "Part to be Check(80)";
            // 
            // part_dgv
            // 
            this.part_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.part_dgv.Font = new System.Drawing.Font("楷体", 12F);
            this.part_dgv.Location = new System.Drawing.Point(44, 283);
            this.part_dgv.Name = "part_dgv";
            this.part_dgv.RowHeadersVisible = false;
            this.part_dgv.RowTemplate.Height = 23;
            this.part_dgv.Size = new System.Drawing.Size(678, 285);
            this.part_dgv.TabIndex = 10;
            // 
            // sub_btn
            // 
            this.sub_btn.Font = new System.Drawing.Font("楷体", 15F);
            this.sub_btn.Location = new System.Drawing.Point(318, 595);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(128, 35);
            this.sub_btn.TabIndex = 11;
            this.sub_btn.Text = "Submit";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // part_zone_cont
            // 
            this.part_zone_cont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.part_zone_cont.Location = new System.Drawing.Point(522, 252);
            this.part_zone_cont.Name = "part_zone_cont";
            this.part_zone_cont.Size = new System.Drawing.Size(200, 31);
            this.part_zone_cont.TabIndex = 12;
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.part_zone_cont);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.part_dgv);
            this.Controls.Add(this.part_info);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.myLab3);
            this.Controls.Add(this.task_type_comb);
            this.Controls.Add(this.c);
            this.Controls.Add(this.myLabTit1);
            this.Controls.Add(this.task_name);
            this.Controls.Add(this.war_name);
            this.Controls.Add(this.myLab2);
            this.Controls.Add(this.myLab1);
            this.Name = "CreateTaskForm";
            this.Text = "CreateTaskForm";
            this.Load += new System.EventHandler(this.CreateTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.part_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLab myLab1;
        private MyLab myLab2;
        private MyCb war_name;
        private MyConText task_name;
        private MyLabTit myLabTit1;
        private MyLab c;
        private MyCb task_type_comb;
        private MyLab myLab3;
        private MyDateTP start_date;
        private MyLab part_info;
        private MyDgv part_dgv;
        private MyBtn sub_btn;
        private MyPan part_zone_cont;
    }
}