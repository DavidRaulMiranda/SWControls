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
            string appClass;
            string appForm;

            connSql.SQLConnect sql = new connSql.SQLConnect();

            //sql.Connectar();

            //sql.PortarTaule() importa 1 taula
            DataSet dts = new DataSet();
            string f = String.Format("select  class,form from UserOptions where  UserOptions.Alias='{0}';", _NomApp);
            //dts =sql.PortarPerConsulta(String.Format("select  class,form from UserOptions where  UserOptions.Alias='{0}';", _NomApp));
           // dts = sql.PortarPerConsulta("select * from UserOptions");
            dts = sql.PortarPerConsulta("select  class,form from UserOptions where Alias='test1'");
            ///*
            // string query = "INSERT INTO AGENCIES VALUES ('a','a')";
            // sql.Executar(query);


            if ( dts.Tables[0].Rows.Count==1)
            {
                appClass = dts.Tables[0].Rows[0]["class"].ToString();
                appForm = dts.Tables[0].Rows[0]["form"].ToString();
                if (!String.IsNullOrEmpty(appClass) && !String.IsNullOrEmpty(appForm))
                {
                    StartApp(appClass, appForm);
                }



            }
           

            

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
