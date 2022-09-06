
namespace S1_Re
{
    partial class InventoryReportForm
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
            this.staock_amt_udg = new S1_Re.MyDgv();
            this.need_udg = new S1_Re.MyDgv();
            this.myLab1 = new S1_Re.MyLab();
            this.myLab2 = new S1_Re.MyLab();
            this.myLab3 = new S1_Re.MyLab();
            this.myLabTit1 = new S1_Re.MyLabTit();
            this.inv_tab = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.staock_amt_udg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.need_udg)).BeginInit();
            this.SuspendLayout();
            // 
            // staock_amt_udg
            // 
            this.staock_amt_udg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staock_amt_udg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staock_amt_udg.Font = new System.Drawing.Font("楷体", 12F);
            this.staock_amt_udg.Location = new System.Drawing.Point(42, 320);
            this.staock_amt_udg.Name = "staock_amt_udg";
            this.staock_amt_udg.RowHeadersVisible = false;
            this.staock_amt_udg.RowHeadersWidth = 51;
            this.staock_amt_udg.RowTemplate.Height = 23;
            this.staock_amt_udg.Size = new System.Drawing.Size(458, 375);
            this.staock_amt_udg.TabIndex = 0;
            // 
            // need_udg
            // 
            this.need_udg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.need_udg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.need_udg.Font = new System.Drawing.Font("楷体", 12F);
            this.need_udg.Location = new System.Drawing.Point(546, 320);
            this.need_udg.MultiSelect = false;
            this.need_udg.Name = "need_udg";
            this.need_udg.RowHeadersVisible = false;
            this.need_udg.RowHeadersWidth = 51;
            this.need_udg.RowTemplate.Height = 23;
            this.need_udg.Size = new System.Drawing.Size(503, 375);
            this.need_udg.TabIndex = 1;
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab1.Location = new System.Drawing.Point(59, 282);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(309, 20);
            this.myLab1.TabIndex = 2;
            this.myLab1.Text = "Stock Amount form Check Amount";
            // 
            // myLab2
            // 
            this.myLab2.AutoSize = true;
            this.myLab2.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab2.Location = new System.Drawing.Point(543, 282);
            this.myLab2.Name = "myLab2";
            this.myLab2.Size = new System.Drawing.Size(219, 20);
            this.myLab2.TabIndex = 3;
            this.myLab2.Text = "Need replenished Part";
            // 
            // myLab3
            // 
            this.myLab3.AutoSize = true;
            this.myLab3.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab3.Location = new System.Drawing.Point(59, 74);
            this.myLab3.Name = "myLab3";
            this.myLab3.Size = new System.Drawing.Size(229, 20);
            this.myLab3.TabIndex = 4;
            this.myLab3.Text = "Inventry checking info";
            // 
            // myLabTit1
            // 
            this.myLabTit1.AutoSize = true;
            this.myLabTit1.Font = new System.Drawing.Font("楷体", 18F);
            this.myLabTit1.Location = new System.Drawing.Point(342, 20);
            this.myLabTit1.Name = "myLabTit1";
            this.myLabTit1.Size = new System.Drawing.Size(358, 30);
            this.myLabTit1.TabIndex = 5;
            this.myLabTit1.Text = "Inventory Checking Task";
            // 
            // inv_tab
            // 
            this.inv_tab.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.inv_tab.ColumnCount = 4;
            this.inv_tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inv_tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inv_tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inv_tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inv_tab.Location = new System.Drawing.Point(63, 112);
            this.inv_tab.Name = "inv_tab";
            this.inv_tab.RowCount = 3;
            this.inv_tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.inv_tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.inv_tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.inv_tab.Size = new System.Drawing.Size(986, 147);
            this.inv_tab.TabIndex = 6;
            // 
            // InventoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 745);
            this.Controls.Add(this.inv_tab);
            this.Controls.Add(this.myLabTit1);
            this.Controls.Add(this.myLab3);
            this.Controls.Add(this.myLab2);
            this.Controls.Add(this.myLab1);
            this.Controls.Add(this.need_udg);
            this.Controls.Add(this.staock_amt_udg);
            this.Name = "InventoryReportForm";
            this.Text = "InventoryReportForm";
            this.Load += new System.EventHandler(this.InventoryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staock_amt_udg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.need_udg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDgv staock_amt_udg;
        private MyDgv need_udg;
        private MyLab myLab1;
        private MyLab myLab2;
        private MyLab myLab3;
        private MyLabTit myLabTit1;
        private System.Windows.Forms.TableLayoutPanel inv_tab;
    }
}