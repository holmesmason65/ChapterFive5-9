
namespace ChapterFive5_9
{
    partial class frmPublishers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.txtPubComments = new System.Windows.Forms.TextBox();
            this.txtPubFax = new System.Windows.Forms.TextBox();
            this.txtPubTelephone = new System.Windows.Forms.TextBox();
            this.txtPubZip = new System.Windows.Forms.TextBox();
            this.txtPubState = new System.Windows.Forms.TextBox();
            this.txtPubCity = new System.Windows.Forms.TextBox();
            this.txtPubAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpPublishers = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher ID\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "FAX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Comments";
            // 
            // txtPubID
            // 
            this.txtPubID.Location = new System.Drawing.Point(198, 30);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.Size = new System.Drawing.Size(100, 23);
            this.txtPubID.TabIndex = 10;
            this.txtPubID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubComments
            // 
            this.txtPubComments.Location = new System.Drawing.Point(198, 289);
            this.txtPubComments.Name = "txtPubComments";
            this.txtPubComments.Size = new System.Drawing.Size(283, 23);
            this.txtPubComments.TabIndex = 11;
            this.txtPubComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubFax
            // 
            this.txtPubFax.Location = new System.Drawing.Point(198, 260);
            this.txtPubFax.Name = "txtPubFax";
            this.txtPubFax.Size = new System.Drawing.Size(100, 23);
            this.txtPubFax.TabIndex = 12;
            this.txtPubFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubTelephone
            // 
            this.txtPubTelephone.Location = new System.Drawing.Point(198, 225);
            this.txtPubTelephone.Name = "txtPubTelephone";
            this.txtPubTelephone.Size = new System.Drawing.Size(100, 23);
            this.txtPubTelephone.TabIndex = 13;
            this.txtPubTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubZip
            // 
            this.txtPubZip.Location = new System.Drawing.Point(198, 200);
            this.txtPubZip.Name = "txtPubZip";
            this.txtPubZip.Size = new System.Drawing.Size(100, 23);
            this.txtPubZip.TabIndex = 14;
            this.txtPubZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubState
            // 
            this.txtPubState.Location = new System.Drawing.Point(198, 178);
            this.txtPubState.Name = "txtPubState";
            this.txtPubState.Size = new System.Drawing.Size(100, 23);
            this.txtPubState.TabIndex = 15;
            this.txtPubState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubCity
            // 
            this.txtPubCity.Location = new System.Drawing.Point(198, 149);
            this.txtPubCity.Name = "txtPubCity";
            this.txtPubCity.Size = new System.Drawing.Size(283, 23);
            this.txtPubCity.TabIndex = 16;
            this.txtPubCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubAddress
            // 
            this.txtPubAddress.Location = new System.Drawing.Point(198, 120);
            this.txtPubAddress.Name = "txtPubAddress";
            this.txtPubAddress.Size = new System.Drawing.Size(283, 23);
            this.txtPubAddress.TabIndex = 17;
            this.txtPubAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(198, 89);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(283, 23);
            this.txtCompanyName.TabIndex = 18;
            this.txtCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // txtPubName
            // 
            this.txtPubName.Location = new System.Drawing.Point(198, 59);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.Size = new System.Drawing.Size(283, 23);
            this.txtPubName.TabIndex = 19;
            this.txtPubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPubName_KeyPress);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(167, 344);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(248, 344);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(117, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Edit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(117, 405);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 25;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(279, 402);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(279, 431);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 28;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 476);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtPubAddress);
            this.Controls.Add(this.txtPubCity);
            this.Controls.Add(this.txtPubState);
            this.Controls.Add(this.txtPubZip);
            this.Controls.Add(this.txtPubTelephone);
            this.Controls.Add(this.txtPubFax);
            this.Controls.Add(this.txtPubComments);
            this.Controls.Add(this.txtPubID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPublishers";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPublishers_FormClosing);
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.TextBox txtPubComments;
        private System.Windows.Forms.TextBox txtPubFax;
        private System.Windows.Forms.TextBox txtPubTelephone;
        private System.Windows.Forms.TextBox txtPubZip;
        private System.Windows.Forms.TextBox txtPubState;
        private System.Windows.Forms.TextBox txtPubCity;
        private System.Windows.Forms.TextBox txtPubAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpPublishers;
    }
}

