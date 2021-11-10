using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //5
using System.Windows.Forms;  //1-add
using System.Text.RegularExpressions;

namespace SC_CustomControls
{
    
    public class SWTextbox : TextBox  //2-inherit 
    {

        public SWTextbox()
        {
            
            InitializeComponent();
        }
        /// <summary>
        /// initizacio de component
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_Validating);
            this.ResumeLayout(false);

        }
        /// <summary>
        /// Sw validate  data in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rgx;

            //check if empty
            if (this.Text.Equals(string.Empty))
            {
                if (_AlowEmpty == false)
                {
                    e.Cancel = true; //inverted
                }
                //do i need both? no
            }
            else
            {
                //validate regex
                switch (this.TipoDato)
                {
                    case tbxCont.text:

                        e.Cancel = true;

                        break;

                    case tbxCont.codi:
                        rgx = new Regex("^[A-Z]{4}-[0-9]{3}/[1,3,5,7,9]{1}[AEIOU]{1}$");
                        if (!rgx.IsMatch(this.Text))
                        {
                            e.Cancel = true;
                        }
                        break;
                    case tbxCont.nombre:
                        rgx = new Regex("^[0-9]+$");
                        if (!rgx.IsMatch(this.Text))
                        {
                            e.Cancel = true;
                        }

                        break;
                    default:
                        break;
                }
            }


        }
        /// <summary>
        /// SwTextbox gain focus event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            //6- s+use system color or SystemColor
            this.BackColor = SystemColors.Info;
        }
        /// <summary>
        /// Sw manage lost focus event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            //on estic
            Form frmt = (Form)this.Parent;
            foreach (Control item in frmt.Controls)
            {
                if (item.Name.Equals(this._ControlAssociat))
                {
                    item.Text = this.Text;
                }
            }
        }

        /// <summary>
        /// SWcodi properties:
        /// </summary>
        public enum tbxCont { text, codi, nombre };
        //propietats propfull
        private tbxCont _TipoDato;

        public tbxCont TipoDato
        {
            get { return _TipoDato; }
            set { _TipoDato = value; }
        }

        private bool _AlowEmpty;

        public bool AlowEmpty
        {
            get { return _AlowEmpty; }
            set { _AlowEmpty = value; }
        }

        private bool _IsForeignKey;

        public bool IsForeignKey
        {
            get { return _IsForeignKey; }
            set { _IsForeignKey = value; }
        }

        private string _ControlAssociat;

        public string ControlAssociat
        {
            get { return _ControlAssociat; }
            set { _ControlAssociat = value; }
        }

        private string _CampBBDD;

        public string CampBBDD
        {
            get { return _CampBBDD; }
            set { _CampBBDD = value; }
        }
    }
}
