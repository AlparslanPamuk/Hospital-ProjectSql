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
    public partial class FrmSecretaryDetails : Form
    {
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }

        public string identitysecretary;

        Sqlconn sqlconnectionMustafa = new Sqlconn();

        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            lblidentitynumber.Text = identitysecretary;

            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;

            // // // // // // // // // // // // //  name surname // // // // // // // // // // // // //  

            SqlCommand command1 = new SqlCommand("select secnamesurname from Tbl_Secretary where sectc=@p1", sqlconnectionMustafa.connection());
            command1.Parameters.AddWithValue("@p1", lblidentitynumber.Text);
            SqlDataReader drAlparslan = command1.ExecuteReader();
            while (drAlparslan.Read())
            {
                lblnamesurname.Text = drAlparslan[0].ToString();
            }
            sqlconnectionMustafa.connection().Close();

            // // // // // // // // // // // // //  Branch fetch datagridview // // // // // // // // // // // // //  

            DataTable dtAlparslan = new DataTable();
            SqlDataAdapter daPamuk = new SqlDataAdapter("select * from Tbl_Branch", sqlconnectionMustafa.connection());
            daPamuk.Fill(dtAlparslan);
            Dvbranches.DataSource = dtAlparslan;
            Dvbranches.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dvbranches.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Dvbranches.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // // // // // // // // // // // // //  Doctor fetch Datagridview // // // // // // // // // // // // //

            DataTable dtPamuk = new DataTable();
            SqlDataAdapter daAlparslan = new SqlDataAdapter("select (docname + ' ' + docsurname) as 'Doctor', docbranch as ' Doctor Branch',doctc as 'ID', docpassword as 'Password' from Tbl_Doctors", sqlconnectionMustafa.connection());
            daAlparslan.Fill(dtPamuk);
            DvDoctors.DataSource = dtPamuk;
            DvDoctors.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DvDoctors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DvDoctors.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DvDoctors.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // // // // // // // // // // // // //  Fetch Branch to Combobox // // // // // // // // // // // // //

            SqlCommand MustafaAlparslanPamuk = new SqlCommand("select branchname from Tbl_branch", sqlconnectionMustafa.connection());
            SqlDataReader drPamuk = MustafaAlparslanPamuk.ExecuteReader();
            while (drPamuk.Read())
            {
                cmbranch.Items.Add(drPamuk[0]);
            }
            sqlconnectionMustafa.connection().Close();

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Announcements (announcement) values (@a1)", sqlconnectionMustafa.connection());
            command.Parameters.AddWithValue("@a1", rchannouncements.Text);
            command.ExecuteNonQuery();
            sqlconnectionMustafa.connection().Close();
            MessageBox.Show("Announcement have been created!","Created by Mustafa Turan Alparslan Pamuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand Savecommand = new SqlCommand("insert into Tbl_Appointments (appointmentdate,appointmenttime,appointmentbranch,appointmentdoctor) values (@r1,@r2,@r3,@r4)", sqlconnectionMustafa.connection());
            Savecommand.Parameters.AddWithValue("@r1", mskdate.Text);
            Savecommand.Parameters.AddWithValue("@r2", mskclock.Text);
            Savecommand.Parameters.AddWithValue("@r3", cmbranch.Text);
            Savecommand.Parameters.AddWithValue("@r4", cmbdoctor.Text);
            Savecommand.ExecuteNonQuery();
            sqlconnectionMustafa.connection().Close();
            MessageBox.Show("Appointment have been created!", "Mustafa Alparslan Pamuk Hospital Project", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void cmbdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();

            SqlCommand command321 = new SqlCommand("select docname,docsurname from Tbl_Doctors where docbranch=@d1", sqlconnectionMustafa.connection());
            command321.Parameters.AddWithValue("@d1", cmbranch.Text);
            SqlDataReader drPamuk12 = command321.ExecuteReader();
            while (drPamuk12.Read())
            {
                cmbdoctor.Items.Add(drPamuk12[0] + " " + drPamuk12[1]);
            }
            sqlconnectionMustafa.connection().Close();
        }

        private void btndoctorpanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frsks = new FrmDoctorPanel();
            frsks.Show();
            
        }

        private void btnbranchpanel_Click(object sender, EventArgs e)
        {
            FrmBranch frb = new FrmBranch();
            frb.Show();
        }

        private void btnappointmentlist_Click(object sender, EventArgs e)
        {
            FrmAppointmentList MustafaAlparslanPamuk = new FrmAppointmentList();
            MustafaAlparslanPamuk.Show();
        }
    }
}
