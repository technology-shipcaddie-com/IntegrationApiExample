namespace ShipCaddieApp
{
    partial class AddressForm
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ddlAddCountry = new System.Windows.Forms.ComboBox();
            this.chkResident = new System.Windows.Forms.CheckBox();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.btnCancelAddd = new System.Windows.Forms.Button();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_Zip = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddress.Location = new System.Drawing.Point(166, 18);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(118, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "ADD ADDRESS";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCustomerId.Location = new System.Drawing.Point(21, 55);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(59, 16);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "* Name :";
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganization.ForeColor = System.Drawing.Color.Firebrick;
            this.lblOrganization.Location = new System.Drawing.Point(20, 95);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(97, 16);
            this.lblOrganization.TabIndex = 2;
            this.lblOrganization.Text = "* Organization :";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddress1.Location = new System.Drawing.Point(20, 139);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(83, 16);
            this.lblAddress1.TabIndex = 3;
            this.lblAddress1.Text = "* Address 1 :";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(127, 54);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(277, 20);
            this.txtCID.TabIndex = 5;
            // 
            // txtOrganization
            // 
            this.txtOrganization.Location = new System.Drawing.Point(127, 98);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(277, 20);
            this.txtOrganization.TabIndex = 6;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(127, 138);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(277, 20);
            this.txtAdd1.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCountry.Location = new System.Drawing.Point(21, 276);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(67, 16);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "* Country :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPhone.Location = new System.Drawing.Point(21, 315);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 16);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "* Phone :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmail.Location = new System.Drawing.Point(21, 350);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "* Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(127, 318);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(277, 20);
            this.txtPhone.TabIndex = 15;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged_1);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 349);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // ddlAddCountry
            // 
            this.ddlAddCountry.FormattingEnabled = true;
            this.ddlAddCountry.Location = new System.Drawing.Point(127, 279);
            this.ddlAddCountry.Name = "ddlAddCountry";
            this.ddlAddCountry.Size = new System.Drawing.Size(277, 21);
            this.ddlAddCountry.TabIndex = 17;
            // 
            // chkResident
            // 
            this.chkResident.AutoSize = true;
            this.chkResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResident.ForeColor = System.Drawing.Color.Firebrick;
            this.chkResident.Location = new System.Drawing.Point(125, 387);
            this.chkResident.Name = "chkResident";
            this.chkResident.Size = new System.Drawing.Size(135, 19);
            this.chkResident.TabIndex = 18;
            this.chkResident.Text = "Residential Address";
            this.chkResident.UseVisualStyleBackColor = true;
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAdd.ForeColor = System.Drawing.Color.White;
            this.btnSaveAdd.Location = new System.Drawing.Point(127, 423);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(75, 28);
            this.btnSaveAdd.TabIndex = 19;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = false;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // btnCancelAddd
            // 
            this.btnCancelAddd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelAddd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelAddd.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddd.Location = new System.Drawing.Point(219, 423);
            this.btnCancelAddd.Name = "btnCancelAddd";
            this.btnCancelAddd.Size = new System.Drawing.Size(75, 28);
            this.btnCancelAddd.TabIndex = 19;
            this.btnCancelAddd.Text = "Cancel";
            this.btnCancelAddd.UseVisualStyleBackColor = false;
            this.btnCancelAddd.Click += new System.EventHandler(this.btnCancelAddd_Click);
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_State.Location = new System.Drawing.Point(221, 217);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(43, 15);
            this.lbl_State.TabIndex = 22;
            this.lbl_State.Text = "* State";
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zip.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Zip.Location = new System.Drawing.Point(317, 216);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(32, 15);
            this.lbl_Zip.TabIndex = 23;
            this.lbl_Zip.Text = "* Zip";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(127, 182);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(277, 20);
            this.txtAdd2.TabIndex = 8;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(319, 236);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(85, 20);
            this.txtZip.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(127, 237);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(85, 20);
            this.txtCity.TabIndex = 9;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddress2.Location = new System.Drawing.Point(26, 186);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(83, 16);
            this.lblAddress2.TabIndex = 4;
            this.lblAddress2.Text = "* Address 2 :";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(220, 236);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(85, 20);
            this.txtState.TabIndex = 10;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_City.Location = new System.Drawing.Point(124, 217);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(34, 15);
            this.lbl_City.TabIndex = 21;
            this.lbl_City.Text = "* City";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 478);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnCancelAddd);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.chkResident);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.ddlAddCountry);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.lbl_Zip);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.txtOrganization);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblAddress);
            this.Name = "AddressForm";
            this.Text = "Address Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtOrganization;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox ddlAddCountry;
        private System.Windows.Forms.CheckBox chkResident;
        private System.Windows.Forms.Button btnCancelAddd;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_Zip;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Button btnSaveAdd;
    }
}