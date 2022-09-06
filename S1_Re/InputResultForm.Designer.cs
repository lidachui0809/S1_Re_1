
namespace S1_Re
{
    partial class InputResultForm
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
            this.myPan1 = new S1_Re.MyPan();
            this.SuspendLayout();
            // 
            // myPan1
            // 
            this.myPan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPan1.Location = new System.Drawing.Point(651, 35);
            this.myPan1.Name = "myPan1";
            this.myPan1.Size = new System.Drawing.Size(440, 53);
            this.myPan1.TabIndex = 0;
            // 
            // InputResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 523);
            this.Controls.Add(this.myPan1);
            this.Name = "InputResultForm";
            this.Text = "InputResultForm";
            this.Load += new System.EventHandler(this.InputResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyPan myPan1;
    }
}