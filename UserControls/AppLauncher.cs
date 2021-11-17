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
using connSql;


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
            this.Height = this.Width / 3;
            pictureBox1.Width = this.Width / 2;
            pictureBox1.Height = this.Height - 4;


        }
        
        //
        /// <summary>
        /// IF icon is clicked request names from sql if valid trigger option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppLauncher_Click(object sender, EventArgs e)
        {

            ///if app not open then launch


            //this.BackColor = Color.Goldenrod;
            //debe ser un dll => que sea biblio de calses

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

            dllBD = Activator.CreateInstance(tipus);
            //frmchild.MDIParent=this;
            ((Form)dllBD).Show();
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

        private void AppLauncher_SizeChanged(object sender, EventArgs e)
        {

            lblDesc.Text = this.Width.ToString();
            if (this.Width > 100)
            {
                this.Height = this.Width / 3;
                pictureBox1.Width = this.Width / 2;
                pictureBox1.Height = this.Height - 4;
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
