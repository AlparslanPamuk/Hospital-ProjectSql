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
    public partial class FrmPatientRegister : Form
    {
        public FrmPatientRegister()
        {
            InitializeComponent();
        }

        Sqlconn connectionup = new Sqlconn();

        private void FrmPatientRegister_Load(object sender, EventArgs e)
        {
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            this.StartPosition = FormStartPosition.CenterScreen;

            btnsignup.Image = Image.FromFile(Application.StartupPath + "\\signup1.gif");
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Patients (patientname,patientsurname,patienttc,patienttel,patientpassword,patientgender) values(@p1,@p2,@p3,@p4,@p5,@p6)", connectionup.connection());
            command.Parameters.AddWithValue("@p1", txtsurname.Text);
            command.Parameters.AddWithValue("@p2", txtsurname.Text);
            command.Parameters.AddWithValue("@p3", mskident.Text);
            command.Parameters.AddWithValue("@p4", mskphone.Text);
            command.Parameters.AddWithValue("@p5", txtpassword.Text);
            command.Parameters.AddWithValue("@p6", cmbgender.Text);
            command.ExecuteNonQuery();
            connectionup.connection().Close();
            MessageBox.Show("Yout Registery Have been Created, Your Password:" + txtpassword.Text ,"Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPatientEntry frfrfk = new frmPatientEntry();
            frfrfk.Show();
            this.Hide();
                
        }
    }
}
