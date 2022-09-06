
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
            this.myDgv1 = new S1_Re.MyDgv();
            this.myDgv2 = new S1_Re.MyDgv();
            this.myLab1 = new S1_Re.MyLab();
            this.myLab2 = new S1_Re.MyLab();
            ((System.ComponentModel.ISupportInitialize)(this.myDgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // myDgv1
            // 
            this.myDgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDgv1.Font = new System.Drawing.Font("楷体", 12F);
            this.myDgv1.Location = new System.Drawing.Point(42, 320);
            this.myDgv1.Name = "myDgv1";
            this.myDgv1.RowHeadersVisible = false;
            this.myDgv1.RowTemplate.Height = 23;
            this.myDgv1.Size = new System.Drawing.Size(403, 375);
            this.myDgv1.TabIndex = 0;
            // 
            // myDgv2
            // 
            this.myDgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDgv2.Font = new System.Drawing.Font("楷体", 12F);
            this.myDgv2.Location = new System.Drawing.Point(546, 320);
            this.myDgv2.Name = "myDgv2";
            this.myDgv2.RowHeadersVisible = false;
            this.myDgv2.RowTemplate.Height = 23;
            this.myDgv2.Size = new System.Drawing.Size(448, 375);
            this.myDgv2.TabIndex = 1;
            // 
            // myLab1
            // 
            this.myLab1.AutoSize = true;
            this.myLab1.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab1.Location = new System.Drawing.Point(59, 282);
            this.myLab1.Name = "myLab1";
            this.myLab1.Size = new System.Drawing.Size(248, 16);
            this.myLab1.TabIndex = 2;
            this.myLab1.Text = "Stock Amount form Check Amount";
            // 
            // myLab2
            // 
            this.myLab2.AutoSize = true;
            this.myLab2.Font = new System.Drawing.Font("楷体", 12F);
            this.myLab2.Location = new System.Drawing.Point(543, 282);
            this.myLab2.Name = "myLab2";
            this.myLab2.Size = new System.Drawing.Size(48, 16);
            this.myLab2.TabIndex = 3;
            this.myLab2.Text = "Need ";
            // 
            // InventoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 745);
            this.Controls.Add(this.myLab2);
            this.Controls.Add(this.myLab1);
            this.Controls.Add(this.myDgv2);
            this.Controls.Add(this.myDgv1);
            this.Name = "InventoryReportForm";
            this.Text = "InventoryReportForm";
            this.Load += new System.EventHandler(this.InventoryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDgv myDgv1;
        private MyDgv myDgv2;
        private MyLab myLab1;
        private MyLab myLab2;
    }
}