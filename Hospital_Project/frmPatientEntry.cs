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
    public partial class frmPatientEntry : Form
    {
        public frmPatientEntry()
        {
            InitializeComponent();
        }

        Sqlconn connectionON = new Sqlconn();

        private void PatientEntry_Load(object sender, EventArgs e)
        {
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            frmPatientEntry formabc = new frmPatientEntry();
            formabc.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hospital By: Mustafa Alparslan Pamuk";
            Pictureboxpatient.BackgroundImageLayout = ImageLayout.Stretch;
            Pictureboxpatient.Image = Image.FromFile(Application.StartupPath + "\\pat2.gif");
        }

        private void lnksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientRegister frmd1 = new FrmPatientRegister();
            frmd1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntries frmfrm = new FrmEntries();
            frmfrm.Show();
            this.Hide();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Patients where patienttc=@p1 and patientpassword=@p2", connectionON.connection());
            command.Parameters.AddWithValue("@p1", msktc.Text);
            command.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                frmpatientDetails fr = new frmpatientDetails();
                fr.ID = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID & Password are not matched");
            }
            connectionON.connection().Close();
        }   

    }
}
