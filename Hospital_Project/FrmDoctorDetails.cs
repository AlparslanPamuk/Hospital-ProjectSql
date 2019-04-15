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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }

        Sqlconn AlparslanPamuk = new Sqlconn();
        public string ID;


        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;

            lblidentity.Text = ID;

            //////////////////////////// Doctor Name-Surname ////////////////////////

            SqlCommand PamukAlparslan = new SqlCommand("select docname,docsurname from Tbl_Doctors where  doctc=@p1", AlparslanPamuk.connection());
            PamukAlparslan.Parameters.AddWithValue("@p1", lblidentity.Text);
            SqlDataReader dr = PamukAlparslan.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[0] + " " + dr[1];
            }
            AlparslanPamuk.connection().Close();

            ///////////////////////////////////////////////Appointments//////////////////////////////////////////////////////////////
            ///
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments where appointmentdoctor='" + lblnamesurname.Text + "'", AlparslanPamuk.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctorEntry frs = new FrmDoctorEntry();
            
            frs.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            FrmDoctorInformationEdit frksks = new FrmDoctorInformationEdit();
            frksks.IDno = lblidentity.Text;
            frksks.Show();
        }

        private void btnannouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements anc = new FrmAnnouncements();
            anc.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            rchcomplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
