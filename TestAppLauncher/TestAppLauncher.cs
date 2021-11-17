using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppLauncher
{
    public partial class TestAppLauncher : Form
    {
        public bool size = true;
        public TestAppLauncher()
        {
            InitializeComponent();
        }

        private void appLauncher1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appLauncher1.Description = "aaaaaaaaaaa";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appLauncher1.Width = appLauncher1.Width + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appLauncher1.Width = appLauncher1.Width - 10;
        }
    }
}
