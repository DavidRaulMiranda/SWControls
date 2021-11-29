using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;



namespace SC_CustomControls
{
    /// <summary>
    /// TESTCODE PATH: C:\Users\pirio\source\repos\HelloWorldForm\HelloWorldForm\
    /// </summary>
    public partial class AppLauncher : UserControl
    {
        public AppLauncher()
        {
     
            
            InitializeComponent();

            
            pnlPicture.Width = this.Width/2;
            pnlText.Width= this.Width /2;


        }
      

        //
        /// <summary>
        /// IF icon is clicked request names from sql if valid trigger option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppLauncher_Click(object sender, EventArgs e)
        {

            StartApp(_Clase, _Form);
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartApp(_Clase, _Form);

        }
        private void pnlText_Click(object sender, EventArgs e)
        {
            StartApp(_Clase, _Form);
        }
        private void pnlPicture_MouseClick(object sender, MouseEventArgs e)
        {
            StartApp(_Clase, _Form);
        }

        /// <summary>
        ///  this function is tirggered  if the response from sql is valid and tries to open the form
        /// </summary>
        /// <param name="appClass"> pases the name of the dll</param>
        /// <param name="appForm"> pases the name of the form</param>
        private void StartApp(string appClass, string appForm)
        {
            Assembly ensamblat = Assembly.LoadFrom(@"" + appClass + ".dll");//@"CustomControls.dll"

            Object dllBD;

            Type tipus;

            tipus = ensamblat.GetType(appClass + "." + appForm);
            Object[] args = { _NomTaula };
            dllBD = Activator.CreateInstance(tipus,args);
            
            //old((Form)dllBD).Show();
            /*
            Form form = ((Form)dllBD);
            form.MdiParent = this.Parent;
            form.MdiParent = _ParentForm;*/

            //v3
            Form form = ((Form)dllBD);
            // form.TopLevel = false;    //<----- = para meter
            /*
            form.AutoScroll = true;
            Panel childPanel = this.Controls[_PosPanel];
            this.childPanel.Controls.Add(form);
            form.Show();
            */

            // pasar pane2 como string y buscarlo en el padre
            
            Form frmt = (Form)this.FindForm();
            foreach (Control item in frmt.Controls)
            {
                if (item.Name.Equals(this._PosPanel))
                {
                    form.AutoScroll = true;
                    form.TopLevel = false;    //<----- = para meter en contenedor
                    item.Controls.Add(form);


                    // form.Anchor = AnchorStyles.Bottom | AnchorStyles.Right| AnchorStyles.Left| AnchorStyles.Right;//nope
                    form.Dock = DockStyle.Fill;
                    form.Show();
                }
            }
            
            //frmchild.MDIParent=this;




        }

        private string _Form;

        public string Form
        {
            get { return _Form; }
            set { _Form = value; }
        }

        private string _Clase;
        public string Clase
        {
            get { return _Clase; }
            set { _Clase = value; }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value;
                
                if (string.IsNullOrEmpty(_Description))
                {
                    lblDesc.Text = "[...]";
                }
                else
                {
                    lblDesc.Text = _Description;
                }
            }
        }
        private string _Title;

        public string title
        {
            get { return _Title; }
            set { _Title = value;
               
                if (string.IsNullOrEmpty(_Title))
                {
                    lblTitle.Text = "-NO TITLE-";
                }
                else
                {
                    lblTitle.Text = _Title;
                }
            }
        }



        private string _PosPanel;

        public string PosPanel
        {
            get { return _PosPanel; }
            set { _PosPanel = value; }
        }


        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                _ImagePath = value;
                pictureBox1.ImageLocation = _ImagePath;
            }
        }
        private  Color _ButtonColor;
         
        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set
            {
                _ButtonColor = value;
                if (_ButtonColor.IsEmpty)
                {
                    this.BackColor = Color.Yellow;
                }
                else
                {
                    this.BackColor = _ButtonColor;
                }

            }
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////addddddddd pasar taula a form
        /// </summary>
        private string _NomTaula;

        public string NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }


        private void AppLauncher_SizeChanged(object sender, EventArgs e)
        {
            
            if (this.Width < 100)
            {
               pnlText.Width = this.Width - this.MinimumSize.Width;
                //pnlText.Hide();
            }
            else
            {
                this.Height = this.Width / 3;
                pnlText.Width = this.Width / 2;
                pnlPicture.Width= this.Width / 2;

                lblDesc.Text = this.Width.ToString();

            }
        }



        ///ADDONS:
        //parent to launch

        //SHIFT SIZE
        /*
        public enum CardSize {card,logo};

        private CardSize _ButtonType;

        public CardSize ButtonType
        {
            get { return _ButtonType; }
            set
            {
                _ButtonType = value;
               

            }
        }
        */
    }
}
