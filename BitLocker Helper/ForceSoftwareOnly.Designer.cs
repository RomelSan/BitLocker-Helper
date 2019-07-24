namespace BitLocker_Helper
{
    partial class ForceSoftwareOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForceSoftwareOnly));
            this.textBox_ForceSoftwareOnly = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_ForceSoftwareOnly
            // 
            this.textBox_ForceSoftwareOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ForceSoftwareOnly.Location = new System.Drawing.Point(12, 12);
            this.textBox_ForceSoftwareOnly.Multiline = true;
            this.textBox_ForceSoftwareOnly.Name = "textBox_ForceSoftwareOnly";
            this.textBox_ForceSoftwareOnly.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ForceSoftwareOnly.Size = new System.Drawing.Size(776, 426);
            this.textBox_ForceSoftwareOnly.TabIndex = 0;
            this.textBox_ForceSoftwareOnly.TabStop = false;
            this.textBox_ForceSoftwareOnly.Text = resources.GetString("textBox_ForceSoftwareOnly.Text");
            // 
            // ForceSoftwareOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_ForceSoftwareOnly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForceSoftwareOnly";
            this.Text = "Software Encryption Only";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ForceSoftwareOnly;
    }
}