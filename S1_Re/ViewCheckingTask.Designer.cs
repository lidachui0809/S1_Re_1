
namespace S1_Re
{
    partial class ViewCheckingTask
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
            this.myLab3 = new S1_Re.MyLab();
            this.myLab4 = new S1_Re.MyLab();
            this.sea_btn = new S1_Re.MyBtn();
            this.war_name = new S1_Re.MyCb();
            this.task_type = new S1_Re.MyCb();
            this.task_status = new S1_Re.MyCb();
            this.myLabTit1 = new S1_Re.MyLabTit();
            this.task_dgv = new S1_Re.MyDgv();
            this.myLab2 = new S1_Re.MyLab();
            this.startBtn = new S1_Re.MyBtn();
            this.imp_re_btn = new S1_Re.MyBtn();
            this.view_in_Btn = new S1_Re.MyBtn();
            ((System.ComponentModel.ISupportInitialize)(this.task_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab1.Location = new System.Drawing.Point(62, 113);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(119, 20);
            this.myLab1.TabIndex = 0;
            this.myLab1.Text = "Warehouse：";
            // 
            // myLab3
            // 
            this.myLab3.AutoSize = true;
            this.myLab3.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab3.Location = new System.Drawing.Point(656, 111);
            this.myLab3.Name = "myLab3";
            this.myLab3.Size = new System.Drawing.Size(79, 20);
            this.myLab3.TabIndex = 2;
            this.myLab3.Text = "Status:";
            // 
            // myLab4
            // 
            this.myLab4.AutoSize = true;
            this.myLab4.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab4.Location = new System.Drawing.Point(376, 113);
            this.myLab4.Name = "myLab4";
            this.myLab4.Size = new System.Drawing.Size(109, 20);
            this.myLab4.TabIndex = 3;
            this.myLab4.Text = "Task Type:";
            // 
            // sea_btn
            // 
            this.sea_btn.Font = new System.Drawing.Font("楷体", 15F);
            this.sea_btn.Location = new System.Drawing.Point(969, 97);
            this.sea_btn.Name = "sea_btn";
            this.sea_btn.Size = new System.Drawing.Size(135, 39);
            this.sea_btn.TabIndex = 4;
            this.sea_btn.Text = "Search";
            this.sea_btn.UseVisualStyleBackColor = true;
            this.sea_btn.Click += new System.EventHandler(this.sea_btn_Click);
            // 
            // war_name
            // 
            this.war_name.Font = new System.Drawing.Font("楷体", 12F);
            this.war_name.FormattingEnabled = true;
            this.war_name.Location = new System.Drawing.Point(177, 108);
            this.war_name.Name = "war_name";
            this.war_name.Size = new System.Drawing.Size(193, 28);
            this.war_name.TabIndex = 5;
            this.war_name.SelectedIndexChanged += new System.EventHandler(this.war_name_SelectedIndexChanged);
            // 
            // task_type
            // 
            this.task_type.Font = new System.Drawing.Font("楷体", 12F);
            this.task_type.FormattingEnabled = true;
            this.task_type.Location = new System.Drawing.Point(491, 105);
            this.task_type.Name = "task_type";
            this.task_type.Size = new System.Drawing.Size(146, 28);
            this.task_type.TabIndex = 6;
            this.task_type.SelectedIndexChanged += new System.EventHandler(this.task_type_SelectedIndexChanged);
            // 
            // task_status
            // 
            this.task_status.Font = new System.Drawing.Font("楷体", 12F);
            this.task_status.FormattingEnabled = true;
            this.task_status.Location = new System.Drawing.Point(741, 105);
            this.task_status.Name = "task_status";
            this.task_status.Size = new System.Drawing.Size(146, 28);
            this.task_status.TabIndex = 7;
            this.task_status.SelectedIndexChanged += new System.EventHandler(this.task_status_SelectedIndexChanged);
            // 
            // myLabTit1
            // 
            this.myLabTit1.AutoSize = true;
            this.myLabTit1.Font = new System.Drawing.Font("楷体", 18F);
            this.myLabTit1.Location = new System.Drawing.Point(353, 31);
            this.myLabTit1.Name = "myLabTit1";
            this.myLabTit1.Size = new System.Drawing.Size(433, 30);
            this.myLabTit1.TabIndex = 8;
            this.myLabTit1.Text = "View Inventory Checking Task";
            // 
            // task_dgv
            // 
            this.task_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.task_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.task_dgv.Font = new System.Drawing.Font("楷体", 12F);
            this.task_dgv.Location = new System.Drawing.Point(66, 236);
            this.task_dgv.Name = "task_dgv";
            this.task_dgv.RowHeadersVisible = false;
            this.task_dgv.RowHeadersWidth = 51;
            this.task_dgv.RowTemplate.Height = 27;
            this.task_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.task_dgv.Size = new System.Drawing.Size(989, 379);
            this.task_dgv.TabIndex = 9;
            this.task_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.task_dgv_CellContentClick);
            // 
            // myLab2
            // 
            this.myLab2.AutoSize = true;
            this.myLab2.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab2.Location = new System.Drawing.Point(87, 200);
            this.myLab2.Name = "myLab2";
            this.myLab2.Size = new System.Drawing.Size(239, 20);
            this.myLab2.TabIndex = 10;
            this.myLab2.Text = "Inventory checking task";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("楷体", 15F);
            this.startBtn.Location = new System.Drawing.Point(224, 647);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(146, 41);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // imp_re_btn
            // 
            this.imp_re_btn.Font = new System.Drawing.Font("楷体", 15F);
            this.imp_re_btn.Location = new System.Drawing.Point(391, 647);
            this.imp_re_btn.Name = "imp_re_btn";
            this.imp_re_btn.Size = new System.Drawing.Size(324, 41);
            this.imp_re_btn.TabIndex = 12;
            this.imp_re_btn.Text = "Input Inventory Result";
            this.imp_re_btn.UseVisualStyleBackColor = true;
            this.imp_re_btn.Click += new System.EventHandler(this.imp_re_btn_Click);
            // 
            // view_in_Btn
            // 
            this.view_in_Btn.Font = new System.Drawing.Font("楷体", 15F);
            this.view_in_Btn.Location = new System.Drawing.Point(721, 647);
            this.view_in_Btn.Name = "view_in_Btn";
            this.view_in_Btn.Size = new System.Drawing.Size(334, 41);
            this.view_in_Btn.TabIndex = 13;
            this.view_in_Btn.Text = "View Inventory Checking Report";
            this.view_in_Btn.UseVisualStyleBackColor = true;
            this.view_in_Btn.Click += new System.EventHandler(this.view_in_Btn_Click);
            // 
            // ViewCheckingTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 700);
            this.Controls.Add(this.view_in_Btn);
            this.Controls.Add(this.imp_re_btn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.myLab2);
            this.Controls.Add(this.task_dgv);
            this.Controls.Add(this.myLabTit1);
            this.Controls.Add(this.task_status);
            this.Controls.Add(this.task_type);
            this.Controls.Add(this.war_name);
            this.Controls.Add(this.sea_btn);
            this.Controls.Add(this.myLab4);
            this.Controls.Add(this.myLab3);
            this.Controls.Add(this.myLab1);
            this.Name = "ViewCheckingTask";
            this.Text = "ViewCheckingTask";
            this.Load += new System.EventHandler(this.ViewCheckingTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.task_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLab myLab1;
        private MyLab myLab3;
        private MyLab myLab4;
        private MyBtn sea_btn;
        private MyCb war_name;
        private MyCb task_type;
        private MyCb task_status;
        private MyLabTit myLabTit1;
        private MyDgv task_dgv;
        private MyLab myLab2;
        private MyBtn startBtn;
        private MyBtn imp_re_btn;
        private MyBtn view_in_Btn;
    }
}