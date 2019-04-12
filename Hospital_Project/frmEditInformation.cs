using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Project
{
    public partial class frmEditInformation : Form
    {
        public frmEditInformation()
        {
            InitializeComponent();
        }

        public string IDno;
        Sqlconn connectionONNN = new Sqlconn();


        private void frmEditInformation_Load(object sender, EventArgs e)
        {
            mskident.Enabled = false;
            mskident.Text = IDno;
            SqlCommand alparslanpamuk = new SqlCommand("select * from Tbl_Patients where patienttc=@p1", connectionONNN.connection());
            alparslanpamuk.Parameters.AddWithValue("@p1", mskident.Text);
            SqlDataReader dr5 = alparslanpamuk.ExecuteReader();
            while (dr5.Read())
            {
                txtname.Text = dr5[1].ToString();
                txtsurname.Text = dr5[2].ToString();
                mskphone.Text = dr5[4].ToString();
                txtpassword.Text = dr5[5].ToString();
                cmbgender.Text = dr5[6].ToString();

            }
            connectionONNN.connection().Close();

            
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmpatientDetails asdasd = new frmpatientDetails();
            asdasd.Show();
            this.Hide();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            SqlCommand commandAlparslanPamuk = new SqlCommand("update Tbl_Patients set patientname=@p1,patientsurname=@p2,patienttel=@p3,patientpassword=@p4,patientgender=@p5 where patienttc=@p6", connectionONNN.connection());
            commandAlparslanPamuk.Parameters.AddWithValue("@p1",txtname.Text);
            commandAlparslanPamuk.Parameters.AddWithValue("@p2",txtsurname.Text);
            commandAlparslanPamuk.Parameters.AddWithValue("@p3",mskphone.Text);
            commandAlparslanPamuk.Parameters.AddWithValue("@p4",txtpassword.Text);
            commandAlparslanPamuk.Parameters.AddWithValue("@p5", cmbgender.Text);
            commandAlparslanPamuk.Parameters.AddWithValue("@p6", mskident.Text);
            commandAlparslanPamuk.ExecuteNonQuery();
            connectionONNN.connection().Close();
            MessageBox.Show("Your informations Have been Updated!", "Mustafa Alparslan Pamuk's Hospital Program", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

        }
    }
}
