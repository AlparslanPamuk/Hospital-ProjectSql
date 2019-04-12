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
    public partial class frmpatientDetails : Form
    {
        public frmpatientDetails()
        {
            InitializeComponent();
        }

        public string ID;

        Sqlconn connectionON = new Sqlconn();

        private void frmpatientdetails_Load(object sender, EventArgs e)
        {
            lblidentity.Text = ID;
            

            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            btnappointment.BackgroundImageLayout = ImageLayout.Stretch;
            btnappointment.Image = Image.FromFile(Application.StartupPath + "\\appointment1.gif");
            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
            
            
            //Fetch Name - Surname
            SqlCommand command = new SqlCommand("select patientname,patientsurname from Tbl_Patients where patienttc=@p1", connectionON.connection());
            command.Parameters.AddWithValue("@p1", lblidentity.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[0] + " " + dr[1];
            }
            connectionON.connection().Close();

            //Appointment History
            DataTable dt = new DataTable();             // Veri tablosu
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments where patienttc='" + ID +"'", connectionON.connection());
            da.Fill(dt); // Sanal tablo oluşturma
            dataGridView1.DataSource = dt;

            //Fetching Branches 

            SqlCommand command2 = new SqlCommand("select branchname from Tbl_branch", connectionON.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }
            connectionON.connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPatientEntry frsk = new frmPatientEntry();
            frsk.Show();
            this.Hide();
        }

        private void cmbbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctors.Items.Clear();
            SqlCommand commandmd = new SqlCommand("Select docname,docsurname from Tbl_Doctors where docbranch=@p1", connectionON.connection());
            commandmd.Parameters.AddWithValue("@p1", cmbbranch.Text);
            SqlDataReader dr3 = commandmd.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoctors.Items.Add(dr3[0]+ " " + dr3[1]);

            }
            connectionON.connection().Close();
        }

        private void cmbdoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtAlparslan = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments  where appointmentbranch='" + cmbbranch.Text+ "'", connectionON.connection());
            da.Fill(dtAlparslan);
            dataGridView2.DataSource = dtAlparslan;
        }

        private void lnkedit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditInformation frmakc = new frmEditInformation();
            frmakc.IDno = lblidentity.Text;
            frmakc.Show();
            this.Hide();
        }
    }
    
}
