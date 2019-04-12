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
    public partial class FrmSecretaryEntry : Form
    {
        public FrmSecretaryEntry()
        {
            InitializeComponent();
        }

        Sqlconn sqlconnectiON = new Sqlconn();

        private void FrmSecretaryEntry_Load(object sender, EventArgs e)
        {
            msktc.Text = "77777777777";
            txtpassword.Text = "123";
            
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            btnenter.BackgroundImageLayout = ImageLayout.Stretch;
            btnenter.Image = Image.FromFile(Application.StartupPath + "\\sec4.gif");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntries frm1 = new FrmEntries();
            frm1.Show();
            this.Hide();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("select * from Tbl_Secretary where sectc=@p1 and secpassword=@p2", sqlconnectiON.connection());
            update.Parameters.AddWithValue("@p1", msktc.Text);
            update.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = update.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryDetails frsec = new FrmSecretaryDetails();
                frsec.identitysecretary = msktc.Text;
                frsec.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Check Entered Values.", "Mustafa Alparslan Pamuk's Hospital", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
