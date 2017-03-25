namespace ShipCaddieApp
{
    partial class Form1
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
            this.lblCarrierName = new System.Windows.Forms.Label();
            this.ddlCarrierName = new System.Windows.Forms.ComboBox();
            this.lblServiceLabel = new System.Windows.Forms.Label();
            this.ddlServiceLabel = new System.Windows.Forms.ComboBox();
            this.lblShipFrom = new System.Windows.Forms.Label();
            this.txtShipFrom = new System.Windows.Forms.TextBox();
            this.lblShipTo = new System.Windows.Forms.Label();
            this.txtShipTo = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtlbs = new System.Windows.Forms.TextBox();
            this.txtOz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblPrintLabel = new System.Windows.Forms.Button();
            this.lnlblRate = new System.Windows.Forms.LinkLabel();
            this.lbShipFrom = new System.Windows.Forms.LinkLabel();
            this.lbShipTo = new System.Windows.Forms.LinkLabel();
            this.lblErrorFrom = new System.Windows.Forms.Label();
            this.lblErrorTo = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblAccessories = new System.Windows.Forms.Label();
            this.chkCOD = new System.Windows.Forms.CheckBox();
            this.chkSign = new System.Windows.Forms.CheckBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.ddlCOD = new System.Windows.Forms.ComboBox();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.ddlSign = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.lbl_LabelMessage = new System.Windows.Forms.Label();
            this.lblVoidLabel = new System.Windows.Forms.Label();
            this.txtVoidLabel = new System.Windows.Forms.TextBox();
            this.btnVoidLabel = new System.Windows.Forms.Button();
            this.lblPrintFormat = new System.Windows.Forms.Label();
            this.txt_Labelkey = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ddlSwitchAPI = new System.Windows.Forms.ComboBox();
            this.lblSwitchAPI = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTokenMsg = new System.Windows.Forms.Label();
            this.btnGToken = new System.Windows.Forms.Button();
            this.btnRefreshToken = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.btnShipmentId = new System.Windows.Forms.Button();
            this.txtShipId = new System.Windows.Forms.TextBox();
            this.lblShipmentId = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarrierName
            // 
            this.lblCarrierName.AutoSize = true;
            this.lblCarrierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrierName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCarrierName.Location = new System.Drawing.Point(9, 482);
            this.lblCarrierName.Name = "lblCarrierName";
            this.lblCarrierName.Size = new System.Drawing.Size(94, 16);
            this.lblCarrierName.TabIndex = 0;
            this.lblCarrierName.Text = "Carrier Name :";
            // 
            // ddlCarrierName
            // 
            this.ddlCarrierName.FormattingEnabled = true;
            this.ddlCarrierName.Items.AddRange(new object[] {
            "--Select--"});
            this.ddlCarrierName.Location = new System.Drawing.Point(126, 483);
            this.ddlCarrierName.Name = "ddlCarrierName";
            this.ddlCarrierName.Size = new System.Drawing.Size(200, 21);
            this.ddlCarrierName.TabIndex = 1;
            this.ddlCarrierName.Text = "--Select--";
            this.ddlCarrierName.SelectedIndexChanged += new System.EventHandler(this.ddlCarrierName_SelectedIndexChanged);
            // 
            // lblServiceLabel
            // 
            this.lblServiceLabel.AutoSize = true;
            this.lblServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblServiceLabel.Location = new System.Drawing.Point(9, 522);
            this.lblServiceLabel.Name = "lblServiceLabel";
            this.lblServiceLabel.Size = new System.Drawing.Size(96, 16);
            this.lblServiceLabel.TabIndex = 2;
            this.lblServiceLabel.Text = "Service Level :";
            // 
            // ddlServiceLabel
            // 
            this.ddlServiceLabel.FormattingEnabled = true;
            this.ddlServiceLabel.Location = new System.Drawing.Point(126, 522);
            this.ddlServiceLabel.Name = "ddlServiceLabel";
            this.ddlServiceLabel.Size = new System.Drawing.Size(200, 21);
            this.ddlServiceLabel.TabIndex = 3;
            this.ddlServiceLabel.Text = "--Select--";
            this.ddlServiceLabel.SelectedIndexChanged += new System.EventHandler(this.ddlServiceLabel_SelectedIndexChanged);
            // 
            // lblShipFrom
            // 
            this.lblShipFrom.AutoSize = true;
            this.lblShipFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipFrom.ForeColor = System.Drawing.Color.Firebrick;
            this.lblShipFrom.Location = new System.Drawing.Point(10, 139);
            this.lblShipFrom.Name = "lblShipFrom";
            this.lblShipFrom.Size = new System.Drawing.Size(75, 16);
            this.lblShipFrom.TabIndex = 4;
            this.lblShipFrom.Text = "Ship From :";
            // 
            // txtShipFrom
            // 
            this.txtShipFrom.Location = new System.Drawing.Point(128, 139);
            this.txtShipFrom.Multiline = true;
            this.txtShipFrom.Name = "txtShipFrom";
            this.txtShipFrom.ReadOnly = true;
            this.txtShipFrom.Size = new System.Drawing.Size(200, 129);
            this.txtShipFrom.TabIndex = 5;
            this.txtShipFrom.Text = "Name\r\nOrganization\r\nAddress1\r\nAddress 2\r\nCity\r\nState\r\nZipCode\r\nCountry\r\nPhone\r\nEm" +
    "ail";
            // 
            // lblShipTo
            // 
            this.lblShipTo.AutoSize = true;
            this.lblShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipTo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblShipTo.Location = new System.Drawing.Point(9, 314);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(61, 16);
            this.lblShipTo.TabIndex = 6;
            this.lblShipTo.Text = "Ship To :";
            // 
            // txtShipTo
            // 
            this.txtShipTo.Location = new System.Drawing.Point(128, 314);
            this.txtShipTo.Multiline = true;
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.ReadOnly = true;
            this.txtShipTo.Size = new System.Drawing.Size(200, 124);
            this.txtShipTo.TabIndex = 7;
            this.txtShipTo.Text = "Name\r\nOrganization\r\nAddress1\r\nAddress 2\r\nCity\r\nState\r\nZipCode\r\nCountry\r\nPhone\r\nEm" +
    "ail";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWeight.Location = new System.Drawing.Point(12, 562);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 16);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight :";
            // 
            // txtlbs
            // 
            this.txtlbs.Location = new System.Drawing.Point(126, 562);
            this.txtlbs.Name = "txtlbs";
            this.txtlbs.Size = new System.Drawing.Size(90, 20);
            this.txtlbs.TabIndex = 10;
            this.txtlbs.Enter += new System.EventHandler(this.txtlbs_Enter);
            this.txtlbs.Leave += new System.EventHandler(this.txtlbs_Leave);
            // 
            // txtOz
            // 
            this.txtOz.Location = new System.Drawing.Point(222, 562);
            this.txtOz.Name = "txtOz";
            this.txtOz.Size = new System.Drawing.Size(104, 20);
            this.txtOz.TabIndex = 11;
            this.txtOz.Enter += new System.EventHandler(this.txtOz_Enter);
            this.txtOz.Leave += new System.EventHandler(this.txtOz_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(9, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Size (inches) :";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(264, 600);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(63, 20);
            this.txtHeight.TabIndex = 15;
            this.txtHeight.Enter += new System.EventHandler(this.txtHeight_Enter);
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(191, 600);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(67, 20);
            this.txtWidth.TabIndex = 16;
            this.txtWidth.Enter += new System.EventHandler(this.txtWidth_Enter);
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(126, 600);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(60, 20);
            this.txtLength.TabIndex = 17;
            this.txtLength.Enter += new System.EventHandler(this.txtLength_Enter);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // lblPrintLabel
            // 
            this.lblPrintLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintLabel.ForeColor = System.Drawing.Color.White;
            this.lblPrintLabel.Location = new System.Drawing.Point(640, 546);
            this.lblPrintLabel.Name = "lblPrintLabel";
            this.lblPrintLabel.Size = new System.Drawing.Size(90, 29);
            this.lblPrintLabel.TabIndex = 20;
            this.lblPrintLabel.Text = "Print Label";
            this.lblPrintLabel.UseVisualStyleBackColor = false;
            this.lblPrintLabel.Click += new System.EventHandler(this.lblPrintLabel_Click);
            // 
            // lnlblRate
            // 
            this.lnlblRate.AutoSize = true;
            this.lnlblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlblRate.LinkColor = System.Drawing.Color.Blue;
            this.lnlblRate.Location = new System.Drawing.Point(740, 471);
            this.lnlblRate.Name = "lnlblRate";
            this.lnlblRate.Size = new System.Drawing.Size(55, 15);
            this.lnlblRate.TabIndex = 21;
            this.lnlblRate.TabStop = true;
            this.lnlblRate.Text = "Get Rate";
            this.lnlblRate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlblRate_LinkClicked);
            // 
            // lbShipFrom
            // 
            this.lbShipFrom.AutoSize = true;
            this.lbShipFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipFrom.ForeColor = System.Drawing.Color.Coral;
            this.lbShipFrom.LinkColor = System.Drawing.Color.Blue;
            this.lbShipFrom.Location = new System.Drawing.Point(127, 270);
            this.lbShipFrom.Name = "lbShipFrom";
            this.lbShipFrom.Size = new System.Drawing.Size(132, 15);
            this.lbShipFrom.TabIndex = 22;
            this.lbShipFrom.TabStop = true;
            this.lbShipFrom.Text = "Add ShipFrom Address";
            this.lbShipFrom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShipFrom_LinkClicked);
            // 
            // lbShipTo
            // 
            this.lbShipTo.AutoSize = true;
            this.lbShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipTo.LinkColor = System.Drawing.Color.Blue;
            this.lbShipTo.Location = new System.Drawing.Point(127, 440);
            this.lbShipTo.Name = "lbShipTo";
            this.lbShipTo.Size = new System.Drawing.Size(117, 15);
            this.lbShipTo.TabIndex = 23;
            this.lbShipTo.TabStop = true;
            this.lbShipTo.Text = "Add ShipTo Address";
            this.lbShipTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShipTo_LinkClicked);
            // 
            // lblErrorFrom
            // 
            this.lblErrorFrom.AutoSize = true;
            this.lblErrorFrom.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblErrorFrom.Location = new System.Drawing.Point(127, 291);
            this.lblErrorFrom.Name = "lblErrorFrom";
            this.lblErrorFrom.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFrom.TabIndex = 24;
            // 
            // lblErrorTo
            // 
            this.lblErrorTo.AutoSize = true;
            this.lblErrorTo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblErrorTo.Location = new System.Drawing.Point(127, 460);
            this.lblErrorTo.Name = "lblErrorTo";
            this.lblErrorTo.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTo.TabIndex = 25;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFormat.Location = new System.Drawing.Point(10, 636);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(85, 16);
            this.lblFormat.TabIndex = 26;
            this.lblFormat.Text = "Print Format :";
            // 
            // lblAccessories
            // 
            this.lblAccessories.AutoSize = true;
            this.lblAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessories.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAccessories.Location = new System.Drawing.Point(369, 140);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(124, 16);
            this.lblAccessories.TabIndex = 28;
            this.lblAccessories.Text = "Accessorial Types:";
            // 
            // chkCOD
            // 
            this.chkCOD.AutoSize = true;
            this.chkCOD.Location = new System.Drawing.Point(507, 141);
            this.chkCOD.Name = "chkCOD";
            this.chkCOD.Size = new System.Drawing.Size(49, 17);
            this.chkCOD.TabIndex = 29;
            this.chkCOD.Text = "COD";
            this.chkCOD.UseVisualStyleBackColor = true;
            // 
            // chkSign
            // 
            this.chkSign.AutoSize = true;
            this.chkSign.Location = new System.Drawing.Point(507, 256);
            this.chkSign.Name = "chkSign";
            this.chkSign.Size = new System.Drawing.Size(89, 17);
            this.chkSign.TabIndex = 30;
            this.chkSign.Text = "SIGNATURE";
            this.chkSign.UseVisualStyleBackColor = true;
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(506, 199);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(89, 17);
            this.chkInsurance.TabIndex = 31;
            this.chkInsurance.Text = "INSURANCE";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // ddlCOD
            // 
            this.ddlCOD.FormattingEnabled = true;
            this.ddlCOD.Items.AddRange(new object[] {
            "COD_SECURED_FUNDS",
            "COD_CASH",
            "COD_CHECK",
            "COD_ANY"});
            this.ddlCOD.Location = new System.Drawing.Point(506, 164);
            this.ddlCOD.Name = "ddlCOD";
            this.ddlCOD.Size = new System.Drawing.Size(218, 21);
            this.ddlCOD.TabIndex = 32;
            this.ddlCOD.Text = "-- Select --";
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(506, 221);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.Size = new System.Drawing.Size(218, 20);
            this.txtChargeAmount.TabIndex = 36;
            // 
            // ddlSign
            // 
            this.ddlSign.FormattingEnabled = true;
            this.ddlSign.Items.AddRange(new object[] {
            "SIGNATURE_ADULT",
            "SIGNATURE_ADULT_RESTRICTED",
            "SIGNATURE_REQUIRED",
            "SIGNATURE_NO_REQUIRED",
            "SIGNATURE_DIRECT",
            "SIGNATURE_INDIRECT"});
            this.ddlSign.Location = new System.Drawing.Point(507, 277);
            this.ddlSign.Name = "ddlSign";
            this.ddlSign.Size = new System.Drawing.Size(218, 21);
            this.ddlSign.TabIndex = 38;
            this.ddlSign.Text = "--Select--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(370, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Rate List :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(507, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(223, 171);
            this.dataGridView1.TabIndex = 43;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorLabel.Location = new System.Drawing.Point(124, 12);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.ErrorLabel.TabIndex = 45;
            // 
            // lbl_LabelMessage
            // 
            this.lbl_LabelMessage.AutoSize = true;
            this.lbl_LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LabelMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_LabelMessage.Location = new System.Drawing.Point(9, 9);
            this.lbl_LabelMessage.Name = "lbl_LabelMessage";
            this.lbl_LabelMessage.Size = new System.Drawing.Size(0, 20);
            this.lbl_LabelMessage.TabIndex = 46;
            // 
            // lblVoidLabel
            // 
            this.lblVoidLabel.AutoSize = true;
            this.lblVoidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoidLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVoidLabel.Location = new System.Drawing.Point(370, 639);
            this.lblVoidLabel.Name = "lblVoidLabel";
            this.lblVoidLabel.Size = new System.Drawing.Size(79, 16);
            this.lblVoidLabel.TabIndex = 47;
            this.lblVoidLabel.Text = "Void Label :";
            // 
            // txtVoidLabel
            // 
            this.txtVoidLabel.Location = new System.Drawing.Point(507, 633);
            this.txtVoidLabel.Name = "txtVoidLabel";
            this.txtVoidLabel.Size = new System.Drawing.Size(223, 20);
            this.txtVoidLabel.TabIndex = 48;
            this.txtVoidLabel.Enter += new System.EventHandler(this.txtVoidLabel_Enter);
            this.txtVoidLabel.Leave += new System.EventHandler(this.txtVoidLabel_Leave);
            // 
            // btnVoidLabel
            // 
            this.btnVoidLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoidLabel.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnVoidLabel.FlatAppearance.BorderSize = 0;
            this.btnVoidLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoidLabel.Location = new System.Drawing.Point(743, 630);
            this.btnVoidLabel.Name = "btnVoidLabel";
            this.btnVoidLabel.Size = new System.Drawing.Size(75, 25);
            this.btnVoidLabel.TabIndex = 49;
            this.btnVoidLabel.Text = "Void Label";
            this.btnVoidLabel.UseVisualStyleBackColor = false;
            this.btnVoidLabel.Click += new System.EventHandler(this.btnVoidLabel_Click);
            // 
            // lblPrintFormat
            // 
            this.lblPrintFormat.AutoSize = true;
            this.lblPrintFormat.Location = new System.Drawing.Point(123, 640);
            this.lblPrintFormat.Name = "lblPrintFormat";
            this.lblPrintFormat.Size = new System.Drawing.Size(53, 13);
            this.lblPrintFormat.TabIndex = 51;
            this.lblPrintFormat.Text = "PNG_4x6";
            // 
            // txt_Labelkey
            // 
            this.txt_Labelkey.Location = new System.Drawing.Point(507, 590);
            this.txt_Labelkey.Name = "txt_Labelkey";
            this.txt_Labelkey.Size = new System.Drawing.Size(223, 20);
            this.txt_Labelkey.TabIndex = 52;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_info.Location = new System.Drawing.Point(509, 613);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = global::ShipCaddieApp.Properties.Resources.noimage4;
            this.pictureBox1.Location = new System.Drawing.Point(837, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 634);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // ddlSwitchAPI
            // 
            this.ddlSwitchAPI.FormattingEnabled = true;
            this.ddlSwitchAPI.Location = new System.Drawing.Point(1070, 15);
            this.ddlSwitchAPI.Name = "ddlSwitchAPI";
            this.ddlSwitchAPI.Size = new System.Drawing.Size(146, 21);
            this.ddlSwitchAPI.TabIndex = 55;
            this.ddlSwitchAPI.SelectedIndexChanged += new System.EventHandler(this.ddlSwitchAPI_SelectedIndexChanged);
            // 
            // lblSwitchAPI
            // 
            this.lblSwitchAPI.AutoSize = true;
            this.lblSwitchAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchAPI.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSwitchAPI.Location = new System.Drawing.Point(939, 16);
            this.lblSwitchAPI.Name = "lblSwitchAPI";
            this.lblSwitchAPI.Size = new System.Drawing.Size(106, 16);
            this.lblSwitchAPI.TabIndex = 56;
            this.lblSwitchAPI.Text = "Switch Request :";
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUN.Location = new System.Drawing.Point(9, 21);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(88, 16);
            this.lblUN.TabIndex = 60;
            this.lblUN.Text = "UserName * :";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPwd.Location = new System.Drawing.Point(276, 21);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 16);
            this.lblPwd.TabIndex = 61;
            this.lblPwd.Text = "Password * :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTokenMsg);
            this.groupBox1.Controls.Add(this.btnGToken);
            this.groupBox1.Controls.Add(this.btnRefreshToken);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtUN);
            this.groupBox1.Controls.Add(this.lblUN);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 75);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ShipCaddie Login";
            // 
            // lblTokenMsg
            // 
            this.lblTokenMsg.AutoSize = true;
            this.lblTokenMsg.Location = new System.Drawing.Point(19, 53);
            this.lblTokenMsg.Name = "lblTokenMsg";
            this.lblTokenMsg.Size = new System.Drawing.Size(297, 13);
            this.lblTokenMsg.TabIndex = 63;
            this.lblTokenMsg.Text = "* Enter your ShipCaddie credentials first to test this application";
            // 
            // btnGToken
            // 
            this.btnGToken.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGToken.ForeColor = System.Drawing.Color.White;
            this.btnGToken.Location = new System.Drawing.Point(534, 16);
            this.btnGToken.Name = "btnGToken";
            this.btnGToken.Size = new System.Drawing.Size(106, 29);
            this.btnGToken.TabIndex = 65;
            this.btnGToken.Text = "Generate Token";
            this.btnGToken.UseVisualStyleBackColor = false;
            this.btnGToken.Click += new System.EventHandler(this.btnGToken_Click);
            // 
            // btnRefreshToken
            // 
            this.btnRefreshToken.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefreshToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshToken.ForeColor = System.Drawing.Color.White;
            this.btnRefreshToken.Location = new System.Drawing.Point(650, 16);
            this.btnRefreshToken.Name = "btnRefreshToken";
            this.btnRefreshToken.Size = new System.Drawing.Size(102, 29);
            this.btnRefreshToken.TabIndex = 64;
            this.btnRefreshToken.Text = "Refresh Token";
            this.btnRefreshToken.UseVisualStyleBackColor = false;
            this.btnRefreshToken.Click += new System.EventHandler(this.btnRefreshToken_Click_1);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(356, 21);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(148, 20);
            this.txtPwd.TabIndex = 63;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(96, 21);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(147, 20);
            this.txtUN.TabIndex = 62;
            // 
            // btnShipmentId
            // 
            this.btnShipmentId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShipmentId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShipmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipmentId.ForeColor = System.Drawing.Color.White;
            this.btnShipmentId.Location = new System.Drawing.Point(508, 546);
            this.btnShipmentId.Name = "btnShipmentId";
            this.btnShipmentId.Size = new System.Drawing.Size(114, 29);
            this.btnShipmentId.TabIndex = 63;
            this.btnShipmentId.Text = "Get Shipment Id";
            this.btnShipmentId.UseVisualStyleBackColor = false;
            this.btnShipmentId.Click += new System.EventHandler(this.btnShipmentId_Click);
            // 
            // txtShipId
            // 
            this.txtShipId.Location = new System.Drawing.Point(507, 502);
            this.txtShipId.Name = "txtShipId";
            this.txtShipId.Size = new System.Drawing.Size(88, 20);
            this.txtShipId.TabIndex = 67;
            // 
            // lblShipmentId
            // 
            this.lblShipmentId.AutoSize = true;
            this.lblShipmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentId.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblShipmentId.Location = new System.Drawing.Point(509, 524);
            this.lblShipmentId.Name = "lblShipmentId";
            this.lblShipmentId.Size = new System.Drawing.Size(0, 13);
            this.lblShipmentId.TabIndex = 68;
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTrackingNumber.Location = new System.Drawing.Point(436, 670);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(0, 13);
            this.lblTrackingNumber.TabIndex = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 695);
            this.Controls.Add(this.lblTrackingNumber);
            this.Controls.Add(this.lblShipmentId);
            this.Controls.Add(this.txtShipId);
            this.Controls.Add(this.btnShipmentId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSwitchAPI);
            this.Controls.Add(this.ddlSwitchAPI);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.txt_Labelkey);
            this.Controls.Add(this.lblPrintFormat);
            this.Controls.Add(this.btnVoidLabel);
            this.Controls.Add(this.txtVoidLabel);
            this.Controls.Add(this.lblVoidLabel);
            this.Controls.Add(this.lbl_LabelMessage);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlSign);
            this.Controls.Add(this.txtChargeAmount);
            this.Controls.Add(this.ddlCOD);
            this.Controls.Add(this.chkInsurance);
            this.Controls.Add(this.chkSign);
            this.Controls.Add(this.chkCOD);
            this.Controls.Add(this.lblAccessories);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblErrorTo);
            this.Controls.Add(this.lblErrorFrom);
            this.Controls.Add(this.lbShipTo);
            this.Controls.Add(this.lbShipFrom);
            this.Controls.Add(this.lnlblRate);
            this.Controls.Add(this.lblPrintLabel);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOz);
            this.Controls.Add(this.txtlbs);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtShipTo);
            this.Controls.Add(this.lblShipTo);
            this.Controls.Add(this.txtShipFrom);
            this.Controls.Add(this.lblShipFrom);
            this.Controls.Add(this.ddlServiceLabel);
            this.Controls.Add(this.lblServiceLabel);
            this.Controls.Add(this.ddlCarrierName);
            this.Controls.Add(this.lblCarrierName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Shipment Label Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrierName;
        private System.Windows.Forms.ComboBox ddlCarrierName;
        private System.Windows.Forms.Label lblServiceLabel;
        private System.Windows.Forms.ComboBox ddlServiceLabel;
        private System.Windows.Forms.Label lblShipFrom;
        private System.Windows.Forms.TextBox txtShipFrom;
        private System.Windows.Forms.Label lblShipTo;
        private System.Windows.Forms.TextBox txtShipTo;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtlbs;
        private System.Windows.Forms.TextBox txtOz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button lblPrintLabel;
        private System.Windows.Forms.LinkLabel lnlblRate;
        public System.Windows.Forms.LinkLabel lbShipFrom;
        private System.Windows.Forms.LinkLabel lbShipTo;
        private System.Windows.Forms.Label lblErrorFrom;
        private System.Windows.Forms.Label lblErrorTo;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblAccessories;
        private System.Windows.Forms.CheckBox chkCOD;
        private System.Windows.Forms.CheckBox chkSign;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.ComboBox ddlCOD;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.ComboBox ddlSign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label lbl_LabelMessage;
        private System.Windows.Forms.Label lblVoidLabel;
        private System.Windows.Forms.TextBox txtVoidLabel;
        private System.Windows.Forms.Button btnVoidLabel;
        private System.Windows.Forms.Label lblPrintFormat;
        private System.Windows.Forms.TextBox txt_Labelkey;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ComboBox ddlSwitchAPI;
        private System.Windows.Forms.Label lblSwitchAPI;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTokenMsg;
        private System.Windows.Forms.Button btnGToken;
        private System.Windows.Forms.Button btnRefreshToken;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Button btnShipmentId;
        private System.Windows.Forms.TextBox txtShipId;
        private System.Windows.Forms.Label lblShipmentId;
        private System.Windows.Forms.Label lblTrackingNumber;
    }
}

