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
    public partial class FrmAnnouncements : Form
    {
        public FrmAnnouncements()
        {
            InitializeComponent();
        }

        Sqlconn cnct = new Sqlconn();

        private void FrmAnnouncements_Load(object sender, EventArgs e)
        {
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Announcements", cnct.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
