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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        Sqlconn connection = new Sqlconn();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {

            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;

            DataTable dtPamuk = new DataTable();
            SqlDataAdapter daAlparslan = new SqlDataAdapter("select * from Tbl_Doctors", connection.connection());
            daAlparslan.Fill(dtPamuk);
            dataGridView1.DataSource = dtPamuk;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ////////////// fetch branches to combobox ///////////////////////
            ///
            SqlCommand command5 = new SqlCommand("select branchname from Tbl_branch", connection.connection());
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                cmbbranch.Items.Add(dr5[0]);
            }
            connection.connection().Close();


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand commmand = new SqlCommand("insert into Tbl_Doctors (docname,docsurname,docbranch,doctc,docpassword) values (@d1,@d2,@d3,@d4,@d5)", connection.connection());
            commmand.Parameters.AddWithValue("@d1", txtname.Text);
            commmand.Parameters.AddWithValue("@d2", txtsurname.Text);
            commmand.Parameters.AddWithValue("@d3", cmbbranch.Text);
            commmand.Parameters.AddWithValue("@d4", mskidentitynumber.Text);
            commmand.Parameters.AddWithValue("@d5", txtpassword.Text);
            commmand.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Doctor has been Added!", "Mustafa Alparslan Pamuk Hospital Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbbranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            mskidentitynumber.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandALP = new SqlCommand("delete  from Tbl_Doctors where doctc=@p1", connection.connection());
            commandALP.Parameters.AddWithValue("@p1", mskidentitynumber.Text);
            commandALP.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Doctor has been Deleted!", "Mustafa Alparslan Pamuk Hospital Project", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandPamuk = new SqlCommand("update Tbl_Doctors set docname=@z1,docsurname=@z2,docbranch=@z3,docpassword=@z5 where doctc=@z4", connection.connection());
            commandPamuk.Parameters.AddWithValue("@z1", txtname.Text);
            commandPamuk.Parameters.AddWithValue("@z2", txtsurname.Text);
            commandPamuk.Parameters.AddWithValue("@z3", cmbbranch.Text);
            commandPamuk.Parameters.AddWithValue("@z4", mskidentitynumber.Text);
            commandPamuk.Parameters.AddWithValue("@z5", txtpassword.Text);
            commandPamuk.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Doctor has been Updated!", "Mustafa Alparslan Pamuk Hospital Project", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
