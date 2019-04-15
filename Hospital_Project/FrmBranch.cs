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
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
        }

        Sqlconn connection = new Sqlconn();

        private void FrmBranch_Load(object sender, EventArgs e)
        {
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from  Tbl_branch", connection.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand command41 = new SqlCommand("insert into Tbl_branch (branchname) values (@b1)", connection.connection());
            command41.Parameters.AddWithValue("@b1", txtbranchname.Text);
            command41.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Branch has been Added!", "Mustafa Alparslan Pamuk Hospital Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtbranchid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtbranchname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("delete from tbl_branch where branchid=@b1 ", connection.connection());
            delete.Parameters.AddWithValue("@b1", txtbranchid.Text);
            delete.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Branch have been deleted!");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update tbl_branch set branchname=@n1 where branchid=@n2", connection.connection());
            update.Parameters.AddWithValue(@"n1", txtbranchname.Text);
            update.Parameters.AddWithValue("@n2", txtbranchid.Text);
            update.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Branch have been updated!");
        }
    }
}
