namespace BitLocker_Helper
{
    partial class withoutTPM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withoutTPM));
            this.textBox_withoutTPM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_withoutTPM
            // 
            this.textBox_withoutTPM.Location = new System.Drawing.Point(12, 12);
            this.textBox_withoutTPM.Multiline = true;
            this.textBox_withoutTPM.Name = "textBox_withoutTPM";
            this.textBox_withoutTPM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_withoutTPM.Size = new System.Drawing.Size(776, 426);
            this.textBox_withoutTPM.TabIndex = 0;
            this.textBox_withoutTPM.Text = resources.GetString("textBox_withoutTPM.Text");
            // 
            // withoutTPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_withoutTPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "withoutTPM";
            this.Text = "BitLocker without TPM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_withoutTPM;
    }
}