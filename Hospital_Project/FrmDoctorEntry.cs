using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmDoctorEntry : Form
    {
        public FrmDoctorEntry()
        {
            InitializeComponent();
        }

        

        private void FrmDoctorEntry_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            btnenter.BackgroundImageLayout = ImageLayout.Stretch;
           btnenter.Image = Image.FromFile(Application.StartupPath+ "\\doc3.gif");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntries frmfrmfrm = new FrmEntries();
            frmfrmfrm.Show();
            this.Hide();
        }
    }
}
