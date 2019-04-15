namespace Hospital_Project
{
    partial class frmpatientDetails
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
            this.lblnamesurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidentity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lnkedit = new System.Windows.Forms.LinkLabel();
            this.btnappointment = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbdoctors = new System.Windows.Forms.ComboBox();
            this.cmbbranch = new System.Windows.Forms.ComboBox();
            this.rchappointment = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lblnamesurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblidentity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblnamesurname
            // 
            this.lblnamesurname.AutoSize = true;
            this.lblnamesurname.Location = new System.Drawing.Point(156, 82);
            this.lblnamesurname.Name = "lblnamesurname";
            this.lblnamesurname.Size = new System.Drawing.Size(82, 24);
            this.lblnamesurname.TabIndex = 3;
            this.lblnamesurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Surname";
            // 
            // lblidentity
            // 
            this.lblidentity.AutoSize = true;
            this.lblidentity.Location = new System.Drawing.Point(156, 39);
            this.lblidentity.Name = "lblidentity";
            this.lblidentity.Size = new System.Drawing.Size(120, 24);
            this.lblidentity.TabIndex = 2;
            this.lblidentity.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identity No";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lnkedit);
            this.groupBox2.Controls.Add(this.btnappointment);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbdoctors);
            this.groupBox2.Controls.Add(this.cmbbranch);
            this.groupBox2.Controls.Add(this.rchappointment);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(103, 34);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(221, 32);
            this.txtid.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 24);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID -->";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkedit
            // 
            this.lnkedit.AutoSize = true;
            this.lnkedit.Location = new System.Drawing.Point(11, 355);
            this.lnkedit.Name = "lnkedit";
            this.lnkedit.Size = new System.Drawing.Size(86, 24);
            this.lnkedit.TabIndex = 5;
            this.lnkedit.TabStop = true;
            this.lnkedit.Text = "Edit Info.";
            this.lnkedit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkedit_LinkClicked);
            // 
            // btnappointment
            // 
            this.btnappointment.Location = new System.Drawing.Point(103, 290);
            this.btnappointment.Name = "btnappointment";
            this.btnappointment.Size = new System.Drawing.Size(221, 124);
            this.btnappointment.TabIndex = 4;
            this.btnappointment.UseVisualStyleBackColor = true;
            this.btnappointment.Click += new System.EventHandler(this.btnappointment_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Complaint:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Patient ";
            // 
            // cmbdoctors
            // 
            this.cmbdoctors.FormattingEnabled = true;
            this.cmbdoctors.Location = new System.Drawing.Point(103, 111);
            this.cmbdoctors.Name = "cmbdoctors";
            this.cmbdoctors.Size = new System.Drawing.Size(221, 32);
            this.cmbdoctors.TabIndex = 2;
            this.cmbdoctors.SelectedIndexChanged += new System.EventHandler(this.cmbdoctors_SelectedIndexChanged);
            // 
            // cmbbranch
            // 
            this.cmbbranch.FormattingEnabled = true;
            this.cmbbranch.Location = new System.Drawing.Point(103, 72);
            this.cmbbranch.Name = "cmbbranch";
            this.cmbbranch.Size = new System.Drawing.Size(221, 32);
            this.cmbbranch.TabIndex = 1;
            this.cmbbranch.SelectedIndexChanged += new System.EventHandler(this.cmbbranch_SelectedIndexChanged);
            // 
            // rchappointment
            // 
            this.rchappointment.Location = new System.Drawing.Point(103, 148);
            this.rchappointment.Name = "rchappointment";
            this.rchappointment.Size = new System.Drawing.Size(221, 136);
            this.rchappointment.TabIndex = 3;
            this.rchappointment.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doctor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Branch";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(349, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(751, 277);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 246);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(349, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 304);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointment";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(748, 273);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(352, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 23);
            this.panel1.TabIndex = 5;
            // 
            // frmpatientDetails
            // 
            this.AcceptButton = this.btnappointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1099, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmpatientdetails";
            this.Load += new System.EventHandler(this.frmpatientdetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnamesurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblidentity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnappointment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbdoctors;
        private System.Windows.Forms.ComboBox cmbbranch;
        private System.Windows.Forms.RichTextBox rchappointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkedit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblId;
    }
}