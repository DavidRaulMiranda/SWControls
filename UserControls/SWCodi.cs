using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_CustomControls
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Form frmt = (Form)this.Parent;
            foreach (Control item in frmt.Controls)
            {
                if (item.Name.Equals(this.controlID))
                {
                    item.Text = txtIntro.Text;
                }
            }
        }
        
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (this.txtIntro.Equals(string.Empty))
            {
                if(_Requerit == true)
                {
                    incorrecData(e);
                }
                else
                {
                    txtIntro.BackColor = Color.White;
                }

            }
            else
            {
                ConsultaBBDDD();
            }




        }
        private void txtIntro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConsultaBBDDD();
        }
        private void ConsultaBBDDD()
        {

        }
        private void incorrecData(CancelEventArgs e)
        {
            txtIntro.BackColor = Color.Red;
            txtIntro.Text = "";
            e.Cancel = true;
        }
        
        /// <summary>
        ///  Control property
        /// </summary>
        private bool _Requerit;

        public bool Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }

        private string _NomTaula;

        public string NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }

        private string _Nomcodi;
        public string Nomcodi
        {
            get { return _Nomcodi; }
            set { _Nomcodi = value; }
        }

        private string _NomDesc;
        public string NomDesc
        {
            get { return _NomDesc; }
            set { _NomDesc = value; }
        }

        private string _NomId;
        public string NomId
        {
            get { return _NomId; }
            set { _NomId = value; }
        }
        private string _FormCS;
        public string FormCS
        {
            get { return _FormCS; }
            set { _FormCS = value; }
        }
        private string _ClaseCS;
        public string ClaseCS
        {
            get { return _ClaseCS; }
            set { _ClaseCS = value; }
        }



        private string _ControlID;

        public string controlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }


    }
}
