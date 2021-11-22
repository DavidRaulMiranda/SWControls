using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connSql;
//add referer


namespace SC_CustomControls
{
    public partial class SWCodi : UserControl
    {
        private bool unknownData;
        public SWCodi()
        {
            InitializeComponent();
            unknownData = false;
        }
        /// <summary>
        /// metodes
        /// </summary>
        /// 
        private void txtIntro_Enter(object sender, EventArgs e)
        {
            if (!unknownData)
            {
                txtIntro.BackColor = SystemColors.Info;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void ValidaCodi(CancelEventArgs e)
        {

            //consulta bbdd
            connSql.SQLConnect sql = new connSql.SQLConnect();
            DataSet dts = new DataSet();
            string f = String.Format("select {0},{1},{2} from {3} where {3}.{1}='{4}';", _NomId,_Nomcodi, _NomDesc ,_NomTaula, txtIntro.Text);
            //string f = String.Format("select idAgency,CodeAgency,DescAgency from Agencies where Agencies.CodeAgency='40A'");
            dts = sql.PortarPerConsulta(f);
            //select idAgency,CodeAgency,DescAgency from Agencies where Agencies.CodeAgency='40A';
            if (dts.Tables[0].Rows.Count == 1)
            {
                txtData.Text = dts.Tables[0].Rows[0][_NomDesc].ToString();
                // valor de id a tbx externa


                Form frmt = (Form)this.Parent;
                foreach (Control item in frmt.Controls)
                {
                    if (item.Name.Equals(this.controlID))
                    {
                        item.Text = dts.Tables[0].Rows[0][_NomId].ToString(); ;
                    }
                }
                //
                //UpdateKey(dts);
                unknownData = false;
                txtIntro.BackColor = Color.White;
            }
            else
            {
                txtData.Text = "Unknown data";
                incorrecData(e);
                unknownData = true;
            }
        }
        /// <summary>
        /// rep el nom d’un formulari i una classe i l’obre per reflection en mode modal.
        ///Aquest formulari mostrarà la taula associada a la FK i permetrà escollir un sol registre i portar
        ///les dades al custom control
        /// </summary>
        private void ObreCS()
        {
            //obre form pasa dades obte string


            txtIntro.Text = "bbdd_result";
            //exit(valida_codi)

        }
     
        private void incorrecData(CancelEventArgs e)
        {
            txtIntro.BackColor = Color.Red;
            txtIntro.Text = "";
            e.Cancel = true;
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
                ValidaCodi(e);

            }




        }

 
        ////
        /// MACROS
        ///
        private void txtIntro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                ObreCS();
            }
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
