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
    public partial class FrmEntries : Form
    {
        public FrmEntries()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmEntries form1 = new FrmEntries();
            form1.StartPosition = FormStartPosition.CenterScreen;
            Icon myIcon = new Icon(Application.StartupPath+ "\\ico1.ico");
            this.Icon = myIcon;
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            btndoctor.BackgroundImageLayout = ImageLayout.Stretch;
            btnpatient.BackgroundImageLayout = ImageLayout.Stretch;
            btnsecretary.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            btndoctor.Image = Image.FromFile(Application.StartupPath + "\\doc1.gif");
            btnpatient.Image = Image.FromFile(Application.StartupPath + "\\pat1.gif");
            btnsecretary.Image = Image.FromFile(Application.StartupPath + "\\sec3.gif");
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\hos1.gif");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\new3.gif");

        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            frmPatientEntry frm1 = new frmPatientEntry();
            frm1.Show();
            this.Hide();
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            FrmDoctorEntry frm2 = new FrmDoctorEntry();
            frm2.Show();
            this.Hide();
        }

        private void btnsecretary_Click(object sender, EventArgs e)
        {
            FrmSecretaryEntry frm3 = new FrmSecretaryEntry();
            frm3.Show();
            this.Hide();
        }
    }
}
