using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GooglePlayGamesMover
{
    public partial class Form1 : Form
    {

        private Options options;
        private bool wentToOptions;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wentToOptions = true;
            options = new Options();
            options.ShowDialog();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            if (wentToOptions)
            {
                Console.WriteLine("Starting");
            }
            else
            {
                MessageBox.Show("Please visit options before starting.");
            }
        }
    }
}
