
namespace S1_Re
{
    partial class BaseForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.myPan1 = new S1_Re.MyPan();
            this.myLab1 = new S1_Re.MyLab();
            this.au_5_cb = new System.Windows.Forms.CheckBox();
            this.au_10_cb = new System.Windows.Forms.CheckBox();
            this.au_1_cb = new System.Windows.Forms.CheckBox();
            this.myLabTit1 = new S1_Re.MyLabTit();
            this.myPan2 = new S1_Re.MyPan();
            this.dwon_btn = new S1_Re.MyBtn();
            this.imp_btn = new S1_Re.MyBtn();
            this.myLab2 = new S1_Re.MyLab();
            this.myLab3 = new S1_Re.MyLab();
            this.myPan3 = new S1_Re.MyPan();
            this.btn1 = new S1_Re.MyBtn();
            this.btn2 = new S1_Re.MyBtn();
            this.only_checke_btn = new System.Windows.Forms.CheckBox();
            this.myDgv1 = new S1_Re.MyDgv();
            this.sub_btn = new S1_Re.MyBtn();
            this.save_btn = new S1_Re.MyBtn();
            this.myPan1.SuspendLayout();
            this.myPan2.SuspendLayout();
            this.myPan3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // myPan1
            // 
            this.myPan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPan1.Controls.Add(this.au_1_cb);
            this.myPan1.Controls.Add(this.au_10_cb);
            this.myPan1.Controls.Add(this.au_5_cb);
            this.myPan1.Controls.Add(this.myLab1);
            this.myPan1.Location = new System.Drawing.Point(589, 82);
            this.myPan1.Name = "myPan1";
            this.myPan1.Size = new System.Drawing.Size(571, 65);
            this.myPan1.TabIndex = 0;
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab1.Location = new System.Drawing.Point(19, 22);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(89, 20);
            this.myLab1.TabIndex = 0;
            this.myLab1.Text = "AutoSave";
            // 
            // au_5_cb
            // 
            this.au_5_cb.AutoSize = true;
            this.au_5_cb.Location = new System.Drawing.Point(124, 19);
            this.au_5_cb.Name = "au_5_cb";
            this.au_5_cb.Size = new System.Drawing.Size(131, 24);
            this.au_5_cb.TabIndex = 1;
            this.au_5_cb.Text = "Auto 10min";
            this.au_5_cb.UseVisualStyleBackColor = true;
            // 
            // au_10_cb
            // 
            this.au_10_cb.AutoSize = true;
            this.au_10_cb.Location = new System.Drawing.Point(268, 18);
            this.au_10_cb.Name = "au_10_cb";
            this.au_10_cb.Size = new System.Drawing.Size(131, 24);
            this.au_10_cb.TabIndex = 2;
            this.au_10_cb.Text = "Auto 5 min";
            this.au_10_cb.UseVisualStyleBackColor = true;
            // 
            // au_1_cb
            // 
            this.au_1_cb.AutoSize = true;
            this.au_1_cb.Location = new System.Drawing.Point(417, 21);
            this.au_1_cb.Name = "au_1_cb";
            this.au_1_cb.Size = new System.Drawing.Size(121, 24);
            this.au_1_cb.TabIndex = 3;
            this.au_1_cb.Text = "Auto 1min";
            this.au_1_cb.UseVisualStyleBackColor = true;
            // 
            // myLabTit1
            // 
            this.myLabTit1.AutoSize = true;
            this.myLabTit1.Font = new System.Drawing.Font("楷体", 18F);
            this.myLabTit1.Location = new System.Drawing.Point(331, 23);
            this.myLabTit1.Name = "myLabTit1";
            this.myLabTit1.Size = new System.Drawing.Size(493, 30);
            this.myLabTit1.TabIndex = 1;
            this.myLabTit1.Text = " Input Inventory Checking Result";
            // 
            // myPan2
            // 
            this.myPan2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPan2.Controls.Add(this.myLab2);
            this.myPan2.Location = new System.Drawing.Point(12, 178);
            this.myPan2.Name = "myPan2";
            this.myPan2.Size = new System.Drawing.Size(813, 110);
            this.myPan2.TabIndex = 2;
            // 
            // dwon_btn
            // 
            this.dwon_btn.Font = new System.Drawing.Font("楷体", 15F);
            this.dwon_btn.Location = new System.Drawing.Point(832, 222);
            this.dwon_btn.Name = "dwon_btn";
            this.dwon_btn.Size = new System.Drawing.Size(157, 66);
            this.dwon_btn.TabIndex = 3;
            this.dwon_btn.Text = "Download Import Template";
            this.dwon_btn.UseVisualStyleBackColor = true;
            // 
            // imp_btn
            // 
            this.imp_btn.Font = new System.Drawing.Font("楷体", 15F);
            this.imp_btn.Location = new System.Drawing.Point(1003, 222);
            this.imp_btn.Name = "imp_btn";
            this.imp_btn.Size = new System.Drawing.Size(157, 66);
            this.imp_btn.TabIndex = 4;
            this.imp_btn.Text = "Import Result";
            this.imp_btn.UseVisualStyleBackColor = true;
            // 
            // myLab2
            // 
            this.myLab2.AutoSize = true;
            this.myLab2.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab2.Location = new System.Drawing.Point(47, 44);
            this.myLab2.Name = "myLab2";
            this.myLab2.Size = new System.Drawing.Size(69, 20);
            this.myLab2.TabIndex = 0;
            this.myLab2.Text = "myLab2";
            // 
            // myLab3
            // 
            this.myLab3.AutoSize = true;
            this.myLab3.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab3.Location = new System.Drawing.Point(8, 333);
            this.myLab3.Name = "myLab3";
            this.myLab3.Size = new System.Drawing.Size(79, 20);
            this.myLab3.TabIndex = 5;
            this.myLab3.Text = "Prosses";
            // 
            // myPan3
            // 
            this.myPan3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPan3.Controls.Add(this.btn2);
            this.myPan3.Controls.Add(this.btn1);
            this.myPan3.Location = new System.Drawing.Point(100, 315);
            this.myPan3.Name = "myPan3";
            this.myPan3.Size = new System.Drawing.Size(500, 50);
            this.myPan3.TabIndex = 6;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1.Font = new System.Drawing.Font("楷体", 15F);
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(250, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "myBtn3";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Chocolate;
            this.btn2.Font = new System.Drawing.Font("楷体", 15F);
            this.btn2.Location = new System.Drawing.Point(250, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(250, 50);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "myBtn4";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // only_checke_btn
            // 
            this.only_checke_btn.AutoSize = true;
            this.only_checke_btn.Location = new System.Drawing.Point(832, 342);
            this.only_checke_btn.Name = "only_checke_btn";
            this.only_checke_btn.Size = new System.Drawing.Size(261, 24);
            this.only_checke_btn.TabIndex = 8;
            this.only_checke_btn.Text = "Only show checked pasrt";
            this.only_checke_btn.UseVisualStyleBackColor = true;
            // 
            // myDgv1
            // 
            this.myDgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDgv1.Font = new System.Drawing.Font("楷体", 12F);
            this.myDgv1.Location = new System.Drawing.Point(12, 427);
            this.myDgv1.Name = "myDgv1";
            this.myDgv1.RowHeadersVisible = false;
            this.myDgv1.RowHeadersWidth = 51;
            this.myDgv1.RowTemplate.Height = 27;
            this.myDgv1.Size = new System.Drawing.Size(1148, 284);
            this.myDgv1.TabIndex = 9;
            // 
            // sub_btn
            // 
            this.sub_btn.Font = new System.Drawing.Font("楷体", 15F);
            this.sub_btn.Location = new System.Drawing.Point(360, 727);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(157, 35);
            this.sub_btn.TabIndex = 10;
            this.sub_btn.Text = "Submit";
            this.sub_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("楷体", 15F);
            this.save_btn.Location = new System.Drawing.Point(589, 727);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(157, 35);
            this.save_btn.TabIndex = 11;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 764);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.myDgv1);
            this.Controls.Add(this.only_checke_btn);
            this.Controls.Add(this.myPan3);
            this.Controls.Add(this.myLab3);
            this.Controls.Add(this.imp_btn);
            this.Controls.Add(this.dwon_btn);
            this.Controls.Add(this.myPan2);
            this.Controls.Add(this.myLabTit1);
            this.Controls.Add(this.myPan1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseFrom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.myPan1.ResumeLayout(false);
            this.myPan1.PerformLayout();
            this.myPan2.ResumeLayout(false);
            this.myPan2.PerformLayout();
            this.myPan3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyPan myPan1;
        private System.Windows.Forms.CheckBox au_1_cb;
        private System.Windows.Forms.CheckBox au_10_cb;
        private System.Windows.Forms.CheckBox au_5_cb;
        private MyLab myLab1;
        private MyLabTit myLabTit1;
        private MyPan myPan2;
        private MyLab myLab2;
        private MyBtn dwon_btn;
        private MyBtn imp_btn;
        private MyLab myLab3;
        private MyPan myPan3;
        private MyBtn btn2;
        private MyBtn btn1;
        private System.Windows.Forms.CheckBox only_checke_btn;
        private MyDgv myDgv1;
        private MyBtn sub_btn;
        private MyBtn save_btn;
    }
}

