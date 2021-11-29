using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //5
using System.Windows.Forms;  //1-add
using System.Text.RegularExpressions;


namespace SWControls
{
    class SWButton: Button
    {
        public SWButton()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
            this.ForeColor = Color.Yellow;
           
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWButton
            // 
            this.MouseHover += new System.EventHandler(this.SWButton_MouseHover);
            this.ResumeLayout(false);

        }

        private void SWButton_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
            this.BackColor = Color.Black;
        }
    }
}
