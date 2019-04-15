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
    public partial class FrmDoctorInformationEdit : Form
    {
        public FrmDoctorInformationEdit()
        {
            InitializeComponent();
        }

        Sqlconn MustafaAlparslanPamukConnection = new Sqlconn();
        public string IDno;

        private void FrmDoctorInformationEdit_Load(object sender, EventArgs e)
        {


            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            btnupdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnupdate.Image = Image.FromFile(Application.StartupPath + "\\update1.gif");

            mskidentitynumber.Text = IDno;

            SqlCommand command = new SqlCommand("select * from Tbl_Doctors where doctc=@p1", MustafaAlparslanPamukConnection.connection());
            command.Parameters.AddWithValue("@p1", mskidentitynumber.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read()) 
            {
                txtname.Text = dr[1].ToString();
                txtsurname.Text = dr[2].ToString();
                cmbbranch.Text = dr[3].ToString();
                txtpassword.Text = dr[5].ToString();
            }
            MustafaAlparslanPamukConnection.connection().Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandMustafa = new SqlCommand("Update Tbl_Doctors set docname=@a1,docsurname=@a2,docbranch=@a3, docpassword=@a4 where doctc=@a5", MustafaAlparslanPamukConnection.connection());
            commandMustafa.Parameters.AddWithValue("@a1", txtname.Text);
            commandMustafa.Parameters.AddWithValue("@a2", txtsurname.Text);
            commandMustafa.Parameters.AddWithValue("@a3", cmbbranch.Text);
            commandMustafa.Parameters.AddWithValue("@a4", txtpassword.Text);
            commandMustafa.Parameters.AddWithValue("@a5", mskidentitynumber.Text);
            commandMustafa.ExecuteNonQuery();
            MustafaAlparslanPamukConnection.connection().Close();
            MessageBox.Show("Updated!");    

        }
    }
}
