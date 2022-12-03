using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Drawing;

namespace GooglePlayGamesMover
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);

        bool isElevated;

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
        }

        private void startBTN_Click(object sender, EventArgs e)
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
                MessageBox.Show("Please run as administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(ex.Message + " " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(ex.Message + " " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(ex.Message + " " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void moveUDt_CheckedChanged(object sender, EventArgs e)
        {
            if (moveUDt.Checked)
            {
                MessageBox.Show("WARNING! Enabling this option may DELETE all Android user data.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void browseBTN_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                toTB.Text = Path.GetFullPath(openFD.SelectedPath + "\\");
            }

        }
    }
}
