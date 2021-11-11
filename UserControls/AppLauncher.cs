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
using SC_SQL;


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
            

        }
        
        //
        /// <summary>
        /// IF icon is clicked request names from sql if valid trigger option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppLauncher_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
            //debe ser un dll => que sea biblio de calses
            if(!string.IsNullOrEmpty(_NomApp))
            {
                RequestFromServer(_NomApp);

                


            }
            else
            {
                this.BackColor = Color.DimGray;
            }
 
        }
        
       

        /// <summary>
        /// reguest sql??
        /// </summary>
        /// <param name="NomApp"></param>
        private void RequestFromServer(string NomApp)
        {
            /*
           SQL a = new SQL();
            SC_SQL.SQL a = new SC_SQL.SQL();
            */
            //sql.Connectar();

            // DataSet data= sql.PortarPerConsulta("select * from dbo.users");
            ///



            StartApp("HelloWorldForm", "Form1");

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

            ((Form)dllBD).Show();
        }

        private string _NomApp;

        public string NomApp
        {
            get { return _NomApp; }
            set { _NomApp = value; }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value;
                lblDesc.Text = _Description;
            }
        }
        private string _Title;

        public string title
        {
            get { return _Title; }
            set { _Title = value;
               lblTitle.Text = _Title;
            }
        }
    }
}
