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
    public partial class FrmDoctorInformationEdit : Form
    {
        public FrmDoctorInformationEdit()
        {
            InitializeComponent();
        }

        private void FrmDoctorInformationEdit_Load(object sender, EventArgs e)
        {
            this.Text = "Hospital Project By: Mustafa Alparslan Pamuk";
            Icon myIcon = new Icon(Application.StartupPath + "\\ico1.ico");
            this.Icon = myIcon;
            btnupdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnupdate.Image = Image.FromFile(Application.StartupPath + "\\update1.gif");
        }
    }
}
