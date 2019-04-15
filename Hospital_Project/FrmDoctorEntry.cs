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
    public partial class FrmDoctorEntry : Form
    {
        public FrmDoctorEntry()
        {
            InitializeComponent();
        }

        Sqlconn alpalpalp = new Sqlconn();

        private void FrmDoctorEntry_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            btnenter.BackgroundImageLayout = ImageLayout.Stretch;
           btnenter.Image = Image.FromFile(Application.StartupPath+ "\\doc3.gif");

            //So much tests occurs so id and pass will be given here. ((0)) ((0)) ((0)) ((0)) ((0)) ((0)) ((0)) ((0)) ((0)) ((0))
            txtpassword.Text = "123";
            msktc.Text = "33333333333";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntries frmfrmfrm = new FrmEntries();
            frmfrmfrm.Show();
            this.Hide();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Doctors  where  doctc=@f1 and docpassword=@f2 ", alpalpalp.connection());
            command.Parameters.AddWithValue("@f1", msktc.Text);
            command.Parameters.AddWithValue("@f2", txtpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetails fr = new FrmDoctorDetails();
                fr.ID = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect Entry!");

            alpalpalp.connection().Close();
        }
    }
}
