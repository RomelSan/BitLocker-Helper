using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitLocker_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        // Form Variables for initialization
        private withoutTPM form2;
        private ForceSoftwareOnly form3;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Forms Initialization
            form2 = new withoutTPM();
            form3 = new ForceSoftwareOnly();
        }


        private void Button_status_Click(object sender, EventArgs e)
        {
            textBox_cmdResult.Text = "manage-bde -status";
            textBox_pshellResult.Text = "Get-BitLockerVolume" + "\r\n\r\n" +
                "Get-BitLockerVolume | select MountPoint,CapacityGB,VolumeStatus,EncryptionMethod,KeyProtector | ft -AutoSize";
        }

        private void Button_statusUnit_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            textBox_cmdResult.Text = "manage-bde –status " + unit;
            textBox_pshellResult.Text = "Get-BitLockerVolume -MountPoint " + unit;
        }

        private void Button_getProtectors_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            textBox_cmdResult.Text = "manage-bde -protectors -get " + unit;
            textBox_pshellResult.Text = "Get-BitLockerVolume -MountPoint " + unit + " | Select-Object -ExpandProperty KeyProtector";
        }

        private void Button_Lock_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            textBox_cmdResult.Text = "manage-bde –lock " + unit;
            textBox_pshellResult.Text = "Lock-BitLocker -MountPoint " + unit;
        }

        private void Button_encrypt_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            string encryption = "";
            string encryptionPS = "";
            string protectorPS = "";
            object selectedProtector = null;
            try
            {
                var selectedEncryption = comboBox_encryption.SelectedItem;
                if (selectedEncryption.ToString() == "AES 256") { encryption = "aes256"; encryptionPS = "Aes256"; }
                if (selectedEncryption.ToString() == "AES 128") { encryption = "aes128"; encryptionPS = "Aes128"; }
                if (selectedEncryption.ToString() == "XTS AES 256") { encryption = "xts_aes256"; encryptionPS = "XtsAes256"; }
                if (selectedEncryption.ToString() == "XTS AES 128") { encryption = "xts_aes128"; encryptionPS = "XtsAes128"; }
                // encryption = selectedEncryption.ToString();
            }
            catch { encryption = "aes128"; encryptionPS = "Aes128"; }

            string protector = "";
            try
            {
                selectedProtector = comboBox_Protectors.SelectedItem;
                if (selectedProtector.ToString() == "Password") { protector = "-password"; protectorPS = "-PasswordProtector"; }
                if (selectedProtector.ToString() == "Recovery Password") { protector = "-recoverypassword"; protectorPS = "-RecoveryPasswordProtector"; }
                if (selectedProtector.ToString() == "Recovery Key") { protector = "-recoverykey"; protectorPS = "-RecoveryKeyProtector"; }
            }
            catch { protector = "-recoverypassword"; protectorPS = "-RecoveryPasswordProtector"; }

            // manage-bde –on D: -EncryptionMethod aes256 -recoverypassword 
            textBox_cmdResult.Text = "manage-bde –on " + unit + " " + "-EncryptionMethod " + encryption + " " +
                protector;
                
            // Enable-BitLocker -MountPoint "D:" -EncryptionMethod Aes256 -RecoveryPasswordProtector -UsedSpaceOnly:$true
            textBox_pshellResult.Text = "Enable-BitLocker -MountPoint " + "\"" + unit + "\"" + 
                " -EncryptionMethod " + encryptionPS + " " + protectorPS;

            if (protectorPS == "-RecoveryKeyProtector")
            {
                string path = "";
                try { path = textBox_path.Text; } catch { path = @"H:\Data"; }
                // manage-bde –on D: -EncryptionMethod aes256 -RecoveryKey H:\Data
                textBox_cmdResult.Text = "manage-bde –on " + unit + " " + "-EncryptionMethod " + encryption + " " +
                protector + " " + "\"" + path + "\"";

                // Enable-BitLocker -MountPoint "D:" -EncryptionMethod Aes256 -RecoveryKeyProtector -RecoveryKeyPath "E:\Recovery\"
                textBox_pshellResult.Text = "Enable-BitLocker -MountPoint " + "\"" + unit + "\"" +
                " -EncryptionMethod " + encryptionPS + " " + protectorPS + " -RecoveryKeyPath " + "\"" + path + "\\\"";
            }

            if (protectorPS == "-PasswordProtector")
            {
                /*
                 $pass = ConvertTo-SecureString "myPASSWORD999HERE" -AsPlainText -Force
                 Enable-BitLocker -MountPoint "D:" -EncryptionMethod Aes128 -PasswordProtector -Password $pass 
                */
                textBox_pshellResult.Text = "$pass = Read-Host \"Password\" -AsSecureString" + "\r\n";
                textBox_pshellResult.Text += "Enable-BitLocker -MountPoint " + "\"" + unit + "\"" +
                " -EncryptionMethod " + encryptionPS + " " + protectorPS + " -Password $pass";
                textBox_pshellResult.Text += "\r\n\r\n" +
                                                        "# Note: Other usage.- USE ` to escape special characters like $, for example: secret$123" + "\r\n" +
                                                        "# $pass = ConvertTo-SecureString \"secret`$123\" -AsPlainText -Force";
            }

            if (checkBox_usedSpace.Checked)
            {
                textBox_cmdResult.Text += @" -UsedSpaceOnly";
                textBox_pshellResult.Text += @" -UsedSpaceOnly:$true";
            }

        }

        private void Button_removeProtector_Click(object sender, EventArgs e)
        {
            string protectorID;
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            try { protectorID = textBox_protectorID.Text; } catch { protectorID = @"{Protector ID HERE}"; }
            textBox_cmdResult.Text = @"manage-bde -protectors -delete " + unit + " -id " + protectorID;
            textBox_pshellResult.Text = @"Remove-BitLockerKeyProtector -MountPoint " + unit + " -KeyProtectorId " + protectorID;
        }

        private void Button_addProtector_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            string protectorPS = "";
            object selectedProtector = null;

            string protector = "";
            try
            {
                selectedProtector = comboBox_Protectors.SelectedItem;
                if (selectedProtector.ToString() == "Password") { protector = "-password"; protectorPS = "-PasswordProtector"; }
                if (selectedProtector.ToString() == "Recovery Password") { protector = "-recoverypassword"; protectorPS = "-RecoveryPasswordProtector"; }
                if (selectedProtector.ToString() == "Recovery Key") { protector = "-recoverykey"; protectorPS = "-RecoveryKeyProtector"; }
            }
            catch { protector = "-recoverypassword"; protectorPS = "-RecoveryPasswordProtector"; }

            // manage-bde -protectors -add D: -recoverypassword
            textBox_cmdResult.Text = "manage-bde -protectors -add " + unit + " " + protector;

            // Add-BitLockerKeyProtector -MountPoint "D:" -RecoveryPasswordProtector
            textBox_pshellResult.Text = "Add-BitLockerKeyProtector -MountPoint " + unit + " " + protectorPS;

            if (protectorPS == "-RecoveryKeyProtector")
            {
                string path = "";
                try { path = textBox_path.Text; } catch { path = @"H:\Data"; }
                // manage-bde -protectors -add D: -RecoveryKey H:\Data
                textBox_cmdResult.Text = "manage-bde -protectors -add " + unit + " " + protector + " " + "\"" + path + "\"";

                // Add-BitLockerKeyProtector -MountPoint "D:" -RecoveryKeyProtector -RecoveryKeyPath "E:\Recovery\"
                textBox_pshellResult.Text = "Add-BitLockerKeyProtector -MountPoint " + "\"" + unit + "\"" +
                " " + protectorPS + " -RecoveryKeyPath " + "\"" + path + "\\\"";
            }

            if (protectorPS == "-PasswordProtector")
            {
                /*
                 $pass = ConvertTo-SecureString "myPASSWORD999HERE" -AsPlainText -Force
                 Add-BitLockerKeyProtector -MountPoint "D:" -PasswordProtector -Password $pass 
                */
                textBox_pshellResult.Text = "$pass = Read-Host \"Password\" -AsSecureString" + "\r\n";
                textBox_pshellResult.Text += "Add-BitLockerKeyProtector -MountPoint " + "\"" + unit + "\"" +
                " " + protectorPS + " -Password $pass";
                textBox_pshellResult.Text += "\r\n\r\n" +
                    "# Note: Other usage.- USE ` to escape special characters like $, for example: secret$123" + "\r\n" +
                    "# $pass = ConvertTo-SecureString \"secret`$123\" -AsPlainText -Force";
            }
        }

        private void Button_turnOff_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            textBox_cmdResult.Text = @"manage-bde –off " + unit;
            textBox_pshellResult.Text = @"Disable-Bitlocker -MountPoint " + unit;
        }

        private void Button_repair_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            textBox_cmdResult.Text = @"repair-bde " + unit + " X: " + "-Password";
            textBox_pshellResult.Text = "Not available, for now...";
        }

        private void Button_withoutTPMinfo_Click(object sender, EventArgs e)
        {
            if (form2.IsAccessible)
                return;

            if (form2.IsDisposed)
                form2 = new withoutTPM();

            form2.Show();
        }

        private void Button_ForceSoftwareOnly_Click(object sender, EventArgs e)
        {
            if (form3.IsAccessible)
                return;

            if (form3.IsDisposed)
                form3 = new ForceSoftwareOnly();

            form3.Show();
        }

        private void Button_enableAutoUnlock_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            textBox_cmdResult.Text = "manage-bde –autounlock -enable " + unit;
            textBox_pshellResult.Text = "Enable-BitLockerAutoUnlock -MountPoint " + unit;
        }

        private void Button_disableAutoUnlock_Click(object sender, EventArgs e)
        {
            string unit;
            try { unit = textBox_Unit.Text; } catch { unit = "C:"; }
            textBox_cmdResult.Text = "manage-bde –autounlock -disable " + unit;
            textBox_pshellResult.Text = "Disable-AutoUnlock -MountPoint " + unit;
        }

        private void Button_ClearAutoKeys_Click(object sender, EventArgs e)
        {
            textBox_cmdResult.Text = "manage-bde -autounlock -clearallkeys";
            textBox_pshellResult.Text = "Clear-BitLockerAutoUnlock";
        }
    }
}
