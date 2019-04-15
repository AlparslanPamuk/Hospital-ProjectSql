namespace Hospital_Project
{
    partial class FrmSecretaryDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblidentitynumber = new System.Windows.Forms.Label();
            this.lblnamesurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.rchannouncements = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chkstate = new System.Windows.Forms.CheckBox();
            this.mskidentityno = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.cmbranch = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.mskclock = new System.Windows.Forms.MaskedTextBox();
            this.mskdate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Dvbranches = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DvDoctors = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnappointmentlist = new System.Windows.Forms.Button();
            this.btnbranchpanel = new System.Windows.Forms.Button();
            this.btndoctorpanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvbranches)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvDoctors)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblidentitynumber);
            this.groupBox1.Controls.Add(this.lblnamesurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Information";
            // 
            // lblidentitynumber
            // 
            this.lblidentitynumber.AutoSize = true;
            this.lblidentitynumber.Location = new System.Drawing.Point(165, 32);
            this.lblidentitynumber.Name = "lblidentitynumber";
            this.lblidentitynumber.Size = new System.Drawing.Size(120, 24);
            this.lblidentitynumber.TabIndex = 1;
            this.lblidentitynumber.Text = "00000000000";
            // 
            // lblnamesurname
            // 
            this.lblnamesurname.AutoSize = true;
            this.lblnamesurname.Location = new System.Drawing.Point(165, 67);
            this.lblnamesurname.Name = "lblnamesurname";
            this.lblnamesurname.Size = new System.Drawing.Size(82, 24);
            this.lblnamesurname.TabIndex = 2;
            this.lblnamesurname.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identity Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncreate);
            this.groupBox2.Controls.Add(this.rchannouncements);
            this.groupBox2.Location = new System.Drawing.Point(13, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create An Announcement";
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(11, 228);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(274, 58);
            this.btncreate.TabIndex = 10;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // rchannouncements
            // 
            this.rchannouncements.Location = new System.Drawing.Point(11, 32);
            this.rchannouncements.Name = "rchannouncements";
            this.rchannouncements.Size = new System.Drawing.Size(274, 189);
            this.rchannouncements.TabIndex = 0;
            this.rchannouncements.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.chkstate);
            this.groupBox3.Controls.Add(this.mskidentityno);
            this.groupBox3.Controls.Add(this.cmbdoctor);
            this.groupBox3.Controls.Add(this.cmbranch);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.mskclock);
            this.groupBox3.Controls.Add(this.mskdate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(317, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 422);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment State";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(20, 381);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(277, 35);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Identity NO";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(20, 340);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(277, 35);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Doctor";
            // 
            // chkstate
            // 
            this.chkstate.AutoSize = true;
            this.chkstate.Location = new System.Drawing.Point(162, 306);
            this.chkstate.Name = "chkstate";
            this.chkstate.Size = new System.Drawing.Size(77, 28);
            this.chkstate.TabIndex = 7;
            this.chkstate.Text = "State";
            this.chkstate.UseVisualStyleBackColor = true;
            // 
            // mskidentityno
            // 
            this.mskidentityno.Location = new System.Drawing.Point(162, 262);
            this.mskidentityno.Mask = "00000000000";
            this.mskidentityno.Name = "mskidentityno";
            this.mskidentityno.Size = new System.Drawing.Size(130, 32);
            this.mskidentityno.TabIndex = 6;
            this.mskidentityno.ValidatingType = typeof(int);
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(162, 215);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(130, 32);
            this.cmbdoctor.TabIndex = 5;
            this.cmbdoctor.SelectedIndexChanged += new System.EventHandler(this.cmbdoctor_SelectedIndexChanged);
            // 
            // cmbranch
            // 
            this.cmbranch.FormattingEnabled = true;
            this.cmbranch.Location = new System.Drawing.Point(162, 168);
            this.cmbranch.Name = "cmbranch";
            this.cmbranch.Size = new System.Drawing.Size(130, 32);
            this.cmbranch.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(162, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 32);
            this.txtid.TabIndex = 1;
            // 
            // mskclock
            // 
            this.mskclock.Location = new System.Drawing.Point(162, 121);
            this.mskclock.Mask = "00:00";
            this.mskclock.Name = "mskclock";
            this.mskclock.Size = new System.Drawing.Size(130, 32);
            this.mskclock.TabIndex = 3;
            this.mskclock.ValidatingType = typeof(System.DateTime);
            // 
            // mskdate
            // 
            this.mskdate.Location = new System.Drawing.Point(162, 74);
            this.mskdate.Mask = "00/00/0000";
            this.mskdate.Name = "mskdate";
            this.mskdate.Size = new System.Drawing.Size(130, 32);
            this.mskdate.TabIndex = 2;
            this.mskdate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Dvbranches);
            this.groupBox4.Location = new System.Drawing.Point(621, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 276);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branches";
            // 
            // Dvbranches
            // 
            this.Dvbranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvbranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dvbranches.Location = new System.Drawing.Point(3, 28);
            this.Dvbranches.Name = "Dvbranches";
            this.Dvbranches.RowTemplate.Height = 24;
            this.Dvbranches.Size = new System.Drawing.Size(561, 245);
            this.Dvbranches.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DvDoctors);
            this.groupBox5.Location = new System.Drawing.Point(624, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(567, 254);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // DvDoctors
            // 
            this.DvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DvDoctors.Location = new System.Drawing.Point(3, 28);
            this.DvDoctors.Name = "DvDoctors";
            this.DvDoctors.RowTemplate.Height = 24;
            this.DvDoctors.Size = new System.Drawing.Size(561, 223);
            this.DvDoctors.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnappointmentlist);
            this.groupBox6.Controls.Add(this.btnbranchpanel);
            this.groupBox6.Controls.Add(this.btndoctorpanel);
            this.groupBox6.Location = new System.Drawing.Point(13, 442);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(601, 107);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Easy Access";
            // 
            // btnappointmentlist
            // 
            this.btnappointmentlist.Location = new System.Drawing.Point(324, 36);
            this.btnappointmentlist.Name = "btnappointmentlist";
            this.btnappointmentlist.Size = new System.Drawing.Size(271, 65);
            this.btnappointmentlist.TabIndex = 13;
            this.btnappointmentlist.Text = "Appointment List";
            this.btnappointmentlist.UseVisualStyleBackColor = true;
            this.btnappointmentlist.Click += new System.EventHandler(this.btnappointmentlist_Click);
            // 
            // btnbranchpanel
            // 
            this.btnbranchpanel.Location = new System.Drawing.Point(171, 36);
            this.btnbranchpanel.Name = "btnbranchpanel";
            this.btnbranchpanel.Size = new System.Drawing.Size(147, 65);
            this.btnbranchpanel.TabIndex = 12;
            this.btnbranchpanel.Text = "Branch Panel";
            this.btnbranchpanel.UseVisualStyleBackColor = true;
            this.btnbranchpanel.Click += new System.EventHandler(this.btnbranchpanel_Click);
            // 
            // btndoctorpanel
            // 
            this.btndoctorpanel.Location = new System.Drawing.Point(11, 36);
            this.btndoctorpanel.Name = "btndoctorpanel";
            this.btndoctorpanel.Size = new System.Drawing.Size(154, 65);
            this.btndoctorpanel.TabIndex = 11;
            this.btndoctorpanel.Text = "Doctor Panel";
            this.btndoctorpanel.UseVisualStyleBackColor = true;
            this.btndoctorpanel.Click += new System.EventHandler(this.btndoctorpanel_Click);
            // 
            // FrmSecretaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1203, 555);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSecretaryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSecretaryDetails";
            this.Load += new System.EventHandler(this.FrmSecretaryDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dvbranches)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvDoctors)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblidentitynumber;
        private System.Windows.Forms.Label lblnamesurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.RichTextBox rchannouncements;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkstate;
        private System.Windows.Forms.MaskedTextBox mskidentityno;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.ComboBox cmbranch;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MaskedTextBox mskclock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView Dvbranches;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DvDoctors;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnappointmentlist;
        private System.Windows.Forms.Button btnbranchpanel;
        private System.Windows.Forms.Button btndoctorpanel;
    }
}