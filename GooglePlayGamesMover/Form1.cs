using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Drawing;
using MaterialSkin.Controls;
using MaterialSkin;
using Microsoft.Win32;
using System.Runtime.Versioning;

namespace GooglePlayGamesMover
{
    public partial class Form1 : MaterialForm
    {

        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        RegistryKey key;

        bool isElevated;
        bool darkMode;

        [SupportedOSPlatform("windows")]
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            if (isElevated == false)
            {
                DialogResult dialogResult = MaterialMessageBox.Show("Not running as administrator do you want to continue anyway?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.No)
                {
                    this.Close();
                    return;
                }
            }
            try
            {
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\raiden\GooglePlayGamesMover");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.StackTrace);
                MaterialMessageBox.Show(ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.StackTrace, "Could not create Registry value (Application data will not be saved).", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            versionText.Text = "v" + ProductVersion;
            Console.WriteLine("" + isElevated);
            try
            {
                if (key.GetValue("LaunchedApp").ToString() == null)
                {
                    // do nothing since this is just a detector of if it exists
                }
            }
            catch
            {
                // create the key because it doesn't exist
                Console.WriteLine("First time launching app");
                key.SetValue("LaunchedApp", null);
            }
            try
            {
                if (key.GetValue("LaunchedApp").ToString() == null)
                {
                    key.SetValue("LaunchedApp", 1);
                    key.SetValue("DarkMode", 1);
                    toTB.Text = "D:\\Play Games\\";
                }
                else
                {
                    toTB.Text = key.GetValue("toTB").ToString();
                    if (key.GetValue("DarkMode").ToString() == "True")
                    {
                        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                    }
                    else
                    {
                        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    }
                }
                if (key.GetValue("LastLaunchedVersion").ToString() != ProductVersion)
                {
                    WhatsNew whatsNew = new WhatsNew();
                    whatsNew.Show();
                    key.SetValue("LastLaunchedVersion", ProductVersion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.StackTrace);
                MaterialMessageBox.Show(ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.StackTrace, "Could not create Registry value (Application data will not be saved).", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void StartMove(bool moveUD, bool createLI)
        {
            if (createLI)
            {
                Console.WriteLine("Moving directory from " + fromTB.Text + " to " + toTB.Text);
                //Directory.Move(fromTB.Text, toTB.Text);
                try
                {
                    statusText.Text = "Creating local install...";
                    Move(fromTB.Text, toTB.Text);
                }
                catch (IOException ex)
                {
                    statusText.Text = "Error!";
                    MaterialMessageBox.Show(ex.Message + " " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!createLI)
            {
                Console.WriteLine("Moving directory from " + fromTB.Text + " to " + toTB.Text);
                try
                {
                    statusText.Text = "Moving directory...";
                    Move(fromTB.Text, toTB.Text);
                    statusText.Text = "Creating symlinks...";
                    CreateSymbolicLink(fromTB.Text, toTB.Text, 1);
                }
                catch (Exception ex)
                {
                    statusText.Text = "Error!";
                    MaterialMessageBox.Show(ex.Message + " " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (moveUD)
            {
                Console.Write("Moving UserData...");
                statusText.Text = "Moving UserData...";
                
                try
                {
                    //Directory.CreateDirectory(toTB.Text + "UserData");
                    Move(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Google\\Play Games\\", toTB.Text + "UserData");
                    //MessageBox.Show("Now Deleting UserData", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Google\\Play Games\\");
                    CreateSymbolicLink(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Google\\Play Games\\", toTB.Text + "UserData", 1);
                }
                catch (Exception ex)
                {
                    statusText.Text = "Error!";
                    MaterialMessageBox.Show(ex.Message + " " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MaterialMessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public new void Move(string source, string target)
        {

            if (!Directory.Exists(source))
            {
                throw new System.IO.DirectoryNotFoundException("Source directory couldn't be found.");
            }

            if (Directory.Exists(target))
            {
                throw new System.IO.IOException("Target directory already exists.");
            }

            DirectoryInfo sourceInfo = Directory.CreateDirectory(source);
            DirectoryInfo targetInfo = Directory.CreateDirectory(target);

            if (sourceInfo.FullName == targetInfo.FullName)
            {
                throw new System.IO.IOException("Source and target directories are the same.");
            }

            Stack<DirectoryInfo> sourceDirectories = new Stack<DirectoryInfo>();
            sourceDirectories.Push(sourceInfo);

            Stack<DirectoryInfo> targetDirectories = new Stack<DirectoryInfo>();
            targetDirectories.Push(targetInfo);

            while (sourceDirectories.Count > 0)
            {
                DirectoryInfo sourceDirectory = sourceDirectories.Pop();
                DirectoryInfo targetDirectory = targetDirectories.Pop();

                foreach (FileInfo file in sourceDirectory.GetFiles())
                {
                    file.CopyTo(Path.Combine(targetDirectory.FullName, file.Name), overwrite: true);
                    Console.WriteLine("Copying file " + sourceDirectory.FullName + file.Name + " to " + targetDirectory.FullName + "\\ " + file.Name);
                    statusText.Text = "Copying file " + sourceDirectory.FullName + file.Name + " to " + targetDirectory.FullName + "\\ " + file.Name;
                }

                foreach (DirectoryInfo subDirectory in sourceDirectory.GetDirectories())
                {
                    sourceDirectories.Push(subDirectory);
                    targetDirectories.Push(targetDirectory.CreateSubdirectory(subDirectory.Name));
                }
            }

            sourceInfo.Delete(true);
        }

        private void startBTN_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Starting! \nMove User Data: " + moveUDt.Checked + "\nCreate Local Install: " + createLIt.Checked);
            Console.WriteLine("\"" + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Google\\Play Games\\\" " + "\"" + toTB.Text + "UserData\\\"");
            Console.WriteLine(Application.StartupPath + "\\Junction64.exe");
            if (isElevated)
            {
                StartMove(moveUDt.Checked, createLIt.Checked);
            }
            else
            {
                MaterialMessageBox.Show("Please run as administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moveUDt_CheckedChanged_1(object sender, EventArgs e)
        {
            if (moveUDt.Checked)
            {
                MaterialMessageBox.Show("WARNING! Enabling this option may DELETE all Android user data.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void browseBTN_Click_1(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                toTB.Text = Path.GetFullPath(openFD.SelectedPath + "\\");
            }
        }

        [SupportedOSPlatform("windows")]
        private void darkmodeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            darkMode = !darkMode;
            if (darkMode)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            try
            {
                key.SetValue("DarkMode", darkMode);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.StackTrace, "Could not create Registry value (Application data will not be saved).", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        [SupportedOSPlatform("windows")]
        private void toTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                key.SetValue("toTB", toTB.Text);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.StackTrace, "Could not create Registry value (Application data will not be saved).", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
