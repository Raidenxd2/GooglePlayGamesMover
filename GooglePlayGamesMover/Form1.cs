using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Drawing;
using MaterialSkin.Controls;
using MaterialSkin;

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

        bool isElevated;
        bool darkMode;

        public Form1()
        {
            InitializeComponent();
            versionText.Text = "v" + ProductVersion;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            Console.WriteLine("" + isElevated);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        public void Move(string source, string target)
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
        }
    }
}
