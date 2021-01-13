namespace BitLocker_Helper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_unit = new System.Windows.Forms.Label();
            this.textBox_Unit = new System.Windows.Forms.TextBox();
            this.button_status = new System.Windows.Forms.Button();
            this.button_statusUnit = new System.Windows.Forms.Button();
            this.button_Lock = new System.Windows.Forms.Button();
            this.button_turnOff = new System.Windows.Forms.Button();
            this.comboBox_Protectors = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox_encryption = new System.Windows.Forms.ComboBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_addProtector = new System.Windows.Forms.Button();
            this.button_removeProtector = new System.Windows.Forms.Button();
            this.checkBox_usedSpace = new System.Windows.Forms.CheckBox();
            this.button_repair = new System.Windows.Forms.Button();
            this.button_ForceSoftwareOnly = new System.Windows.Forms.Button();
            this.button_disableAutoUnlock = new System.Windows.Forms.Button();
            this.button_enableAutoUnlock = new System.Windows.Forms.Button();
            this.button_ClearAutoKeys = new System.Windows.Forms.Button();
            this.button_withoutTPMinfo = new System.Windows.Forms.Button();
            this.label_protector = new System.Windows.Forms.Label();
            this.label_encryption = new System.Windows.Forms.Label();
            this.textBox_protectorID = new System.Windows.Forms.TextBox();
            this.label_protectorID = new System.Windows.Forms.Label();
            this.button_getProtectors = new System.Windows.Forms.Button();
            this.label_resultCMD = new System.Windows.Forms.Label();
            this.label_resultPowerShell = new System.Windows.Forms.Label();
            this.textBox_cmdResult = new System.Windows.Forms.TextBox();
            this.textBox_pshellResult = new System.Windows.Forms.TextBox();
            this.label_path = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(51, 24);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(29, 15);
            this.label_unit.TabIndex = 0;
            this.label_unit.Text = "Unit";
            // 
            // textBox_Unit
            // 
            this.textBox_Unit.Location = new System.Drawing.Point(86, 21);
            this.textBox_Unit.MaxLength = 256;
            this.textBox_Unit.Name = "textBox_Unit";
            this.textBox_Unit.Size = new System.Drawing.Size(138, 21);
            this.textBox_Unit.TabIndex = 1;
            this.textBox_Unit.Text = "C:";
            // 
            // button_status
            // 
            this.button_status.Location = new System.Drawing.Point(388, 20);
            this.button_status.Name = "button_status";
            this.button_status.Size = new System.Drawing.Size(113, 23);
            this.button_status.TabIndex = 2;
            this.button_status.Text = "General Status";
            this.button_status.UseVisualStyleBackColor = true;
            this.button_status.Click += new System.EventHandler(this.Button_status_Click);
            // 
            // button_statusUnit
            // 
            this.button_statusUnit.Location = new System.Drawing.Point(242, 20);
            this.button_statusUnit.Name = "button_statusUnit";
            this.button_statusUnit.Size = new System.Drawing.Size(113, 23);
            this.button_statusUnit.TabIndex = 3;
            this.button_statusUnit.Text = "Unit Status";
            this.button_statusUnit.UseVisualStyleBackColor = true;
            this.button_statusUnit.Click += new System.EventHandler(this.Button_statusUnit_Click);
            // 
            // button_Lock
            // 
            this.button_Lock.Location = new System.Drawing.Point(388, 49);
            this.button_Lock.Name = "button_Lock";
            this.button_Lock.Size = new System.Drawing.Size(113, 23);
            this.button_Lock.TabIndex = 4;
            this.button_Lock.Text = "Lock Unit";
            this.toolTip1.SetToolTip(this.button_Lock, "Ejects the BitLocker session.\r\nSo you have to enter the password again to \r\nunloc" +
        "k the volume or drive.");
            this.button_Lock.UseVisualStyleBackColor = true;
            this.button_Lock.Click += new System.EventHandler(this.Button_Lock_Click);
            // 
            // button_turnOff
            // 
            this.button_turnOff.ForeColor = System.Drawing.Color.Red;
            this.button_turnOff.Location = new System.Drawing.Point(86, 223);
            this.button_turnOff.Name = "button_turnOff";
            this.button_turnOff.Size = new System.Drawing.Size(138, 23);
            this.button_turnOff.TabIndex = 5;
            this.button_turnOff.Text = "Turn Off BitLocker";
            this.button_turnOff.UseVisualStyleBackColor = true;
            this.button_turnOff.Click += new System.EventHandler(this.Button_turnOff_Click);
            // 
            // comboBox_Protectors
            // 
            this.comboBox_Protectors.FormattingEnabled = true;
            this.comboBox_Protectors.Items.AddRange(new object[] {
            "Password",
            "Recovery Password",
            "Recovery Key"});
            this.comboBox_Protectors.Location = new System.Drawing.Point(86, 137);
            this.comboBox_Protectors.Name = "comboBox_Protectors";
            this.comboBox_Protectors.Size = new System.Drawing.Size(138, 23);
            this.comboBox_Protectors.TabIndex = 6;
            this.comboBox_Protectors.Text = "Select Protector";
            this.toolTip1.SetToolTip(this.comboBox_Protectors, "Password: Uses a normal password\r\nRecovery Password: Uses a random 48 digit as un" +
        "locker\r\nRecovery Key: Uses an external file as unlocker");
            // 
            // comboBox_encryption
            // 
            this.comboBox_encryption.FormattingEnabled = true;
            this.comboBox_encryption.Items.AddRange(new object[] {
            "AES 256",
            "AES 128",
            "XTS AES 256",
            "XTS AES 128"});
            this.comboBox_encryption.Location = new System.Drawing.Point(86, 91);
            this.comboBox_encryption.Name = "comboBox_encryption";
            this.comboBox_encryption.Size = new System.Drawing.Size(138, 23);
            this.comboBox_encryption.TabIndex = 8;
            this.comboBox_encryption.Text = "Select Encryption";
            this.toolTip1.SetToolTip(this.comboBox_encryption, "256 bits should be stronger.\r\n128 bits should be OK but faster.\r\nXTS adds a layer" +
        " of protection.");
            // 
            // button_encrypt
            // 
            this.button_encrypt.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_encrypt.Location = new System.Drawing.Point(242, 91);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(113, 23);
            this.button_encrypt.TabIndex = 10;
            this.button_encrypt.Text = "Encrypt Unit";
            this.toolTip1.SetToolTip(this.button_encrypt, "Initializes a BitLocker encrypted volume or drive.");
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.Button_encrypt_Click);
            // 
            // button_addProtector
            // 
            this.button_addProtector.Location = new System.Drawing.Point(242, 137);
            this.button_addProtector.Name = "button_addProtector";
            this.button_addProtector.Size = new System.Drawing.Size(113, 23);
            this.button_addProtector.TabIndex = 11;
            this.button_addProtector.Text = "Add Protector";
            this.toolTip1.SetToolTip(this.button_addProtector, "Adds another form of unlocking.\r\nFor example: you could have a password unlocker " +
        "and a\r\n48 digit passwordrecovery unlocker.\r\nSo you can unlock a volume using one" +
        " of the protectors.");
            this.button_addProtector.UseVisualStyleBackColor = true;
            this.button_addProtector.Click += new System.EventHandler(this.Button_addProtector_Click);
            // 
            // button_removeProtector
            // 
            this.button_removeProtector.Location = new System.Drawing.Point(242, 185);
            this.button_removeProtector.Name = "button_removeProtector";
            this.button_removeProtector.Size = new System.Drawing.Size(113, 23);
            this.button_removeProtector.TabIndex = 12;
            this.button_removeProtector.Text = "Remove Protector";
            this.toolTip1.SetToolTip(this.button_removeProtector, "Remove a Protector by ID.\r\nNote: To get the protector ID you must click\r\n\"List Pr" +
        "otectors\" button.");
            this.button_removeProtector.UseVisualStyleBackColor = true;
            this.button_removeProtector.Click += new System.EventHandler(this.Button_removeProtector_Click);
            // 
            // checkBox_usedSpace
            // 
            this.checkBox_usedSpace.AutoSize = true;
            this.checkBox_usedSpace.Checked = true;
            this.checkBox_usedSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_usedSpace.Location = new System.Drawing.Point(388, 93);
            this.checkBox_usedSpace.Name = "checkBox_usedSpace";
            this.checkBox_usedSpace.Size = new System.Drawing.Size(119, 19);
            this.checkBox_usedSpace.TabIndex = 15;
            this.checkBox_usedSpace.Text = "Used space only.";
            this.toolTip1.SetToolTip(this.checkBox_usedSpace, "Encrypts faster.");
            this.checkBox_usedSpace.UseVisualStyleBackColor = true;
            // 
            // button_repair
            // 
            this.button_repair.Location = new System.Drawing.Point(388, 185);
            this.button_repair.Name = "button_repair";
            this.button_repair.Size = new System.Drawing.Size(207, 23);
            this.button_repair.TabIndex = 23;
            this.button_repair.Text = "Repair BitLocker Drive";
            this.toolTip1.SetToolTip(this.button_repair, "Rapairs damaged BitLocker drive.\r\nReplace X: with a volume letter of a NEW DISK.");
            this.button_repair.UseVisualStyleBackColor = true;
            this.button_repair.Click += new System.EventHandler(this.Button_repair_Click);
            // 
            // button_ForceSoftwareOnly
            // 
            this.button_ForceSoftwareOnly.Location = new System.Drawing.Point(388, 243);
            this.button_ForceSoftwareOnly.Name = "button_ForceSoftwareOnly";
            this.button_ForceSoftwareOnly.Size = new System.Drawing.Size(207, 23);
            this.button_ForceSoftwareOnly.TabIndex = 25;
            this.button_ForceSoftwareOnly.Text = "Disable Hardware Encryption";
            this.toolTip1.SetToolTip(this.button_ForceSoftwareOnly, "BitLocker enforced to use software encryption.");
            this.button_ForceSoftwareOnly.UseVisualStyleBackColor = true;
            this.button_ForceSoftwareOnly.Click += new System.EventHandler(this.Button_ForceSoftwareOnly_Click);
            // 
            // button_disableAutoUnlock
            // 
            this.button_disableAutoUnlock.Location = new System.Drawing.Point(527, 21);
            this.button_disableAutoUnlock.Name = "button_disableAutoUnlock";
            this.button_disableAutoUnlock.Size = new System.Drawing.Size(127, 23);
            this.button_disableAutoUnlock.TabIndex = 26;
            this.button_disableAutoUnlock.Text = "Disable Auto Unlock";
            this.toolTip1.SetToolTip(this.button_disableAutoUnlock, "Disables automatic unlocking for a BitLocker volume.");
            this.button_disableAutoUnlock.UseVisualStyleBackColor = true;
            this.button_disableAutoUnlock.Click += new System.EventHandler(this.Button_disableAutoUnlock_Click);
            // 
            // button_enableAutoUnlock
            // 
            this.button_enableAutoUnlock.Location = new System.Drawing.Point(527, 49);
            this.button_enableAutoUnlock.Name = "button_enableAutoUnlock";
            this.button_enableAutoUnlock.Size = new System.Drawing.Size(127, 23);
            this.button_enableAutoUnlock.TabIndex = 27;
            this.button_enableAutoUnlock.Text = "Enable Auto Unlock";
            this.toolTip1.SetToolTip(this.button_enableAutoUnlock, "Enables automatic unlocking for a BitLocker volume.");
            this.button_enableAutoUnlock.UseVisualStyleBackColor = true;
            this.button_enableAutoUnlock.Click += new System.EventHandler(this.Button_enableAutoUnlock_Click);
            // 
            // button_ClearAutoKeys
            // 
            this.button_ClearAutoKeys.Location = new System.Drawing.Point(527, 78);
            this.button_ClearAutoKeys.Name = "button_ClearAutoKeys";
            this.button_ClearAutoKeys.Size = new System.Drawing.Size(127, 23);
            this.button_ClearAutoKeys.TabIndex = 28;
            this.button_ClearAutoKeys.Text = "Clear Saved Keys";
            this.toolTip1.SetToolTip(this.button_ClearAutoKeys, "Removes all automatic unlocking keys.");
            this.button_ClearAutoKeys.UseVisualStyleBackColor = true;
            this.button_ClearAutoKeys.Click += new System.EventHandler(this.Button_ClearAutoKeys_Click);
            // 
            // button_withoutTPMinfo
            // 
            this.button_withoutTPMinfo.Location = new System.Drawing.Point(388, 214);
            this.button_withoutTPMinfo.Name = "button_withoutTPMinfo";
            this.button_withoutTPMinfo.Size = new System.Drawing.Size(207, 23);
            this.button_withoutTPMinfo.TabIndex = 24;
            this.button_withoutTPMinfo.Text = "How to use BitLocker without TPM";
            this.button_withoutTPMinfo.UseVisualStyleBackColor = true;
            this.button_withoutTPMinfo.Click += new System.EventHandler(this.Button_withoutTPMinfo_Click);
            // 
            // label_protector
            // 
            this.label_protector.AutoSize = true;
            this.label_protector.Location = new System.Drawing.Point(24, 140);
            this.label_protector.Name = "label_protector";
            this.label_protector.Size = new System.Drawing.Size(56, 15);
            this.label_protector.TabIndex = 7;
            this.label_protector.Text = "Protector";
            // 
            // label_encryption
            // 
            this.label_encryption.AutoSize = true;
            this.label_encryption.Location = new System.Drawing.Point(16, 94);
            this.label_encryption.Name = "label_encryption";
            this.label_encryption.Size = new System.Drawing.Size(64, 15);
            this.label_encryption.TabIndex = 9;
            this.label_encryption.Text = "Encryption";
            // 
            // textBox_protectorID
            // 
            this.textBox_protectorID.Location = new System.Drawing.Point(86, 186);
            this.textBox_protectorID.MaxLength = 256;
            this.textBox_protectorID.Name = "textBox_protectorID";
            this.textBox_protectorID.Size = new System.Drawing.Size(138, 21);
            this.textBox_protectorID.TabIndex = 14;
            this.textBox_protectorID.Text = "{0000-0000-0000}";
            // 
            // label_protectorID
            // 
            this.label_protectorID.AutoSize = true;
            this.label_protectorID.Location = new System.Drawing.Point(9, 188);
            this.label_protectorID.Name = "label_protectorID";
            this.label_protectorID.Size = new System.Drawing.Size(71, 15);
            this.label_protectorID.TabIndex = 13;
            this.label_protectorID.Text = "Protector ID";
            // 
            // button_getProtectors
            // 
            this.button_getProtectors.Location = new System.Drawing.Point(242, 49);
            this.button_getProtectors.Name = "button_getProtectors";
            this.button_getProtectors.Size = new System.Drawing.Size(113, 23);
            this.button_getProtectors.TabIndex = 16;
            this.button_getProtectors.Text = "List Protectors";
            this.button_getProtectors.UseVisualStyleBackColor = true;
            this.button_getProtectors.Click += new System.EventHandler(this.Button_getProtectors_Click);
            // 
            // label_resultCMD
            // 
            this.label_resultCMD.AutoSize = true;
            this.label_resultCMD.Location = new System.Drawing.Point(9, 277);
            this.label_resultCMD.Name = "label_resultCMD";
            this.label_resultCMD.Size = new System.Drawing.Size(76, 15);
            this.label_resultCMD.TabIndex = 17;
            this.label_resultCMD.Text = "CMD Result:";
            // 
            // label_resultPowerShell
            // 
            this.label_resultPowerShell.AutoSize = true;
            this.label_resultPowerShell.Location = new System.Drawing.Point(9, 329);
            this.label_resultPowerShell.Name = "label_resultPowerShell";
            this.label_resultPowerShell.Size = new System.Drawing.Size(111, 15);
            this.label_resultPowerShell.TabIndex = 18;
            this.label_resultPowerShell.Text = "PowerShell Result:";
            // 
            // textBox_cmdResult
            // 
            this.textBox_cmdResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cmdResult.Location = new System.Drawing.Point(12, 295);
            this.textBox_cmdResult.Name = "textBox_cmdResult";
            this.textBox_cmdResult.Size = new System.Drawing.Size(680, 21);
            this.textBox_cmdResult.TabIndex = 19;
            // 
            // textBox_pshellResult
            // 
            this.textBox_pshellResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pshellResult.Location = new System.Drawing.Point(12, 347);
            this.textBox_pshellResult.Multiline = true;
            this.textBox_pshellResult.Name = "textBox_pshellResult";
            this.textBox_pshellResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_pshellResult.Size = new System.Drawing.Size(680, 82);
            this.textBox_pshellResult.TabIndex = 20;
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(385, 140);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(32, 15);
            this.label_path.TabIndex = 21;
            this.label_path.Text = "Path";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(423, 138);
            this.textBox_path.MaxLength = 256;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(231, 21);
            this.textBox_path.TabIndex = 22;
            this.textBox_path.Text = "D:\\Secret";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button_ClearAutoKeys);
            this.Controls.Add(this.button_enableAutoUnlock);
            this.Controls.Add(this.button_disableAutoUnlock);
            this.Controls.Add(this.button_ForceSoftwareOnly);
            this.Controls.Add(this.button_withoutTPMinfo);
            this.Controls.Add(this.button_repair);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.textBox_pshellResult);
            this.Controls.Add(this.textBox_cmdResult);
            this.Controls.Add(this.label_resultPowerShell);
            this.Controls.Add(this.label_resultCMD);
            this.Controls.Add(this.button_getProtectors);
            this.Controls.Add(this.checkBox_usedSpace);
            this.Controls.Add(this.textBox_protectorID);
            this.Controls.Add(this.label_protectorID);
            this.Controls.Add(this.button_removeProtector);
            this.Controls.Add(this.button_addProtector);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.label_encryption);
            this.Controls.Add(this.comboBox_encryption);
            this.Controls.Add(this.label_protector);
            this.Controls.Add(this.comboBox_Protectors);
            this.Controls.Add(this.button_turnOff);
            this.Controls.Add(this.button_Lock);
            this.Controls.Add(this.button_statusUnit);
            this.Controls.Add(this.button_status);
            this.Controls.Add(this.textBox_Unit);
            this.Controls.Add(this.label_unit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 600);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.Text = "Bitlocker Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.TextBox textBox_Unit;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Button button_statusUnit;
        private System.Windows.Forms.Button button_Lock;
        private System.Windows.Forms.Button button_turnOff;
        private System.Windows.Forms.ComboBox comboBox_Protectors;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_protector;
        private System.Windows.Forms.Label label_encryption;
        private System.Windows.Forms.ComboBox comboBox_encryption;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_addProtector;
        private System.Windows.Forms.Button button_removeProtector;
        private System.Windows.Forms.TextBox textBox_protectorID;
        private System.Windows.Forms.Label label_protectorID;
        private System.Windows.Forms.CheckBox checkBox_usedSpace;
        private System.Windows.Forms.Button button_getProtectors;
        private System.Windows.Forms.Label label_resultCMD;
        private System.Windows.Forms.Label label_resultPowerShell;
        private System.Windows.Forms.TextBox textBox_cmdResult;
        private System.Windows.Forms.TextBox textBox_pshellResult;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_repair;
        private System.Windows.Forms.Button button_withoutTPMinfo;
        private System.Windows.Forms.Button button_ForceSoftwareOnly;
        private System.Windows.Forms.Button button_disableAutoUnlock;
        private System.Windows.Forms.Button button_enableAutoUnlock;
        private System.Windows.Forms.Button button_ClearAutoKeys;
    }
}

