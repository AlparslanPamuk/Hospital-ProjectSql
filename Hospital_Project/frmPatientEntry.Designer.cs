namespace Hospital_Project
{
    partial class frmPatientEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnksignup = new System.Windows.Forms.LinkLabel();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.Pictureboxpatient = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxpatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Entry Pannel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identity Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // lnksignup
            // 
            this.lnksignup.AutoSize = true;
            this.lnksignup.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnksignup.Location = new System.Drawing.Point(175, 212);
            this.lnksignup.Name = "lnksignup";
            this.lnksignup.Size = new System.Drawing.Size(112, 35);
            this.lnksignup.TabIndex = 4;
            this.lnksignup.TabStop = true;
            this.lnksignup.Text = "Sign Up ";
            this.lnksignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnksignup_LinkClicked);
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(181, 112);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(231, 32);
            this.msktc.TabIndex = 1;
            this.msktc.ValidatingType = typeof(int);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(181, 159);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(231, 32);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(308, 211);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(104, 40);
            this.btnenter.TabIndex = 3;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // Pictureboxpatient
            // 
            this.Pictureboxpatient.Location = new System.Drawing.Point(444, 9);
            this.Pictureboxpatient.Name = "Pictureboxpatient";
            this.Pictureboxpatient.Size = new System.Drawing.Size(384, 275);
            this.Pictureboxpatient.TabIndex = 7;
            this.Pictureboxpatient.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPatientEntry
            // 
            this.AcceptButton = this.btnenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(840, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pictureboxpatient);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.lnksignup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatientEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientEntry";
            this.Load += new System.EventHandler(this.PatientEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxpatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnksignup;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.PictureBox Pictureboxpatient;
        private System.Windows.Forms.Button button1;
    }
}