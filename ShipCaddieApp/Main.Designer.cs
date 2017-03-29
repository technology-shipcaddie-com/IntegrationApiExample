namespace ShipCaddieApp
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGetToken = new System.Windows.Forms.TabPage();
            this.lblRefreshToken = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtRefToken = new System.Windows.Forms.TextBox();
            this.txtGToken = new System.Windows.Forms.TextBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.btnRefreshToken = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tabAddShipment = new System.Windows.Forms.TabPage();
            this.lnlblRate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblShipmentId = new System.Windows.Forms.Label();
            this.txtShipId = new System.Windows.Forms.TextBox();
            this.btnShipmentId = new System.Windows.Forms.Button();
            this.lblPrintFormat = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnPrintLabel = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOz = new System.Windows.Forms.TextBox();
            this.txtlbs = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.ddlServiceLabel = new System.Windows.Forms.ComboBox();
            this.lblServiceLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlSign = new System.Windows.Forms.ComboBox();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.ddlCOD = new System.Windows.Forms.ComboBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.chkSign = new System.Windows.Forms.CheckBox();
            this.chkCOD = new System.Windows.Forms.CheckBox();
            this.lblAccessories = new System.Windows.Forms.Label();
            this.lblErrorTo = new System.Windows.Forms.Label();
            this.lblErrorFrom = new System.Windows.Forms.Label();
            this.lbShipTo = new System.Windows.Forms.LinkLabel();
            this.lbShipFrom = new System.Windows.Forms.LinkLabel();
            this.txtShipTo = new System.Windows.Forms.TextBox();
            this.lblShipTo = new System.Windows.Forms.Label();
            this.txtShipFrom = new System.Windows.Forms.TextBox();
            this.lblShipFrom = new System.Windows.Forms.Label();
            this.ddlCarrierName = new System.Windows.Forms.ComboBox();
            this.lblCarrierName = new System.Windows.Forms.Label();
            this.tabVoidLabel = new System.Windows.Forms.TabPage();
            this.lblTrackingNo = new System.Windows.Forms.Label();
            this.txtTrackingNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGVoidLabel = new System.Windows.Forms.TextBox();
            this.btnVoidLabel = new System.Windows.Forms.Button();
            this.lblVoidLabel = new System.Windows.Forms.Label();
            this.tabShipInfo = new System.Windows.Forms.TabPage();
            this.lbl2TrackNo = new System.Windows.Forms.Label();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTracking = new System.Windows.Forms.Label();
            this.btnGetShipment = new System.Windows.Forms.Button();
            this.txtTrackingBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSwitchAPI = new System.Windows.Forms.Label();
            this.ddlSwitchAPI = new System.Windows.Forms.ComboBox();
            this.lblBaseUrl = new System.Windows.Forms.Label();
            this.lblTokenMsg = new System.Windows.Forms.Label();
            this.txtAPIUrl = new System.Windows.Forms.TextBox();
            this.lbl_LabelMessage = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGetToken.SuspendLayout();
            this.tabAddShipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabVoidLabel.SuspendLayout();
            this.tabShipInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGetToken);
            this.tabControl1.Controls.Add(this.tabAddShipment);
            this.tabControl1.Controls.Add(this.tabVoidLabel);
            this.tabControl1.Controls.Add(this.tabShipInfo);
            this.tabControl1.Location = new System.Drawing.Point(19, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 577);
            this.tabControl1.TabIndex = 1;
            // 
            // tabGetToken
            // 
            this.tabGetToken.Controls.Add(this.lblRefreshToken);
            this.tabGetToken.Controls.Add(this.lblToken);
            this.tabGetToken.Controls.Add(this.txtRefToken);
            this.tabGetToken.Controls.Add(this.txtGToken);
            this.tabGetToken.Controls.Add(this.btnGetToken);
            this.tabGetToken.Controls.Add(this.btnRefreshToken);
            this.tabGetToken.Controls.Add(this.txtPwd);
            this.tabGetToken.Controls.Add(this.txtUN);
            this.tabGetToken.Controls.Add(this.lblUN);
            this.tabGetToken.Controls.Add(this.lblPwd);
            this.tabGetToken.Location = new System.Drawing.Point(4, 22);
            this.tabGetToken.Name = "tabGetToken";
            this.tabGetToken.Padding = new System.Windows.Forms.Padding(3);
            this.tabGetToken.Size = new System.Drawing.Size(1185, 551);
            this.tabGetToken.TabIndex = 0;
            this.tabGetToken.Text = "Get Token";
            this.tabGetToken.UseVisualStyleBackColor = true;
            // 
            // lblRefreshToken
            // 
            this.lblRefreshToken.AutoSize = true;
            this.lblRefreshToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshToken.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRefreshToken.Location = new System.Drawing.Point(56, 397);
            this.lblRefreshToken.Name = "lblRefreshToken";
            this.lblRefreshToken.Size = new System.Drawing.Size(103, 16);
            this.lblRefreshToken.TabIndex = 77;
            this.lblRefreshToken.Text = "Refresh Token :";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.ForeColor = System.Drawing.Color.Firebrick;
            this.lblToken.Location = new System.Drawing.Point(56, 248);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(53, 16);
            this.lblToken.TabIndex = 76;
            this.lblToken.Text = "Token :";
            // 
            // txtRefToken
            // 
            this.txtRefToken.Location = new System.Drawing.Point(180, 397);
            this.txtRefToken.Multiline = true;
            this.txtRefToken.Name = "txtRefToken";
            this.txtRefToken.Size = new System.Drawing.Size(955, 122);
            this.txtRefToken.TabIndex = 74;
            // 
            // txtGToken
            // 
            this.txtGToken.Location = new System.Drawing.Point(180, 244);
            this.txtGToken.Multiline = true;
            this.txtGToken.Name = "txtGToken";
            this.txtGToken.Size = new System.Drawing.Size(955, 122);
            this.txtGToken.TabIndex = 73;
            // 
            // btnGetToken
            // 
            this.btnGetToken.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetToken.ForeColor = System.Drawing.Color.White;
            this.btnGetToken.Location = new System.Drawing.Point(180, 144);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(106, 27);
            this.btnGetToken.TabIndex = 72;
            this.btnGetToken.Text = "Get Token";
            this.btnGetToken.UseVisualStyleBackColor = false;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // btnRefreshToken
            // 
            this.btnRefreshToken.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefreshToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshToken.ForeColor = System.Drawing.Color.White;
            this.btnRefreshToken.Location = new System.Drawing.Point(1027, 199);
            this.btnRefreshToken.Name = "btnRefreshToken";
            this.btnRefreshToken.Size = new System.Drawing.Size(108, 28);
            this.btnRefreshToken.TabIndex = 71;
            this.btnRefreshToken.Text = "Refresh Token";
            this.btnRefreshToken.UseVisualStyleBackColor = false;
            this.btnRefreshToken.Click += new System.EventHandler(this.btnRefreshToken_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(180, 94);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(183, 20);
            this.txtPwd.TabIndex = 70;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(180, 50);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(183, 20);
            this.txtUN.TabIndex = 68;
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUN.Location = new System.Drawing.Point(56, 50);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(91, 16);
            this.lblUN.TabIndex = 66;
            this.lblUN.Text = "User Name * :";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPwd.Location = new System.Drawing.Point(56, 95);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 16);
            this.lblPwd.TabIndex = 67;
            this.lblPwd.Text = "Password * :";
            // 
            // tabAddShipment
            // 
            this.tabAddShipment.Controls.Add(this.lnlblRate);
            this.tabAddShipment.Controls.Add(this.pictureBox1);
            this.tabAddShipment.Controls.Add(this.lblShipmentId);
            this.tabAddShipment.Controls.Add(this.txtShipId);
            this.tabAddShipment.Controls.Add(this.btnShipmentId);
            this.tabAddShipment.Controls.Add(this.lblPrintFormat);
            this.tabAddShipment.Controls.Add(this.lblFormat);
            this.tabAddShipment.Controls.Add(this.btnPrintLabel);
            this.tabAddShipment.Controls.Add(this.txtLength);
            this.tabAddShipment.Controls.Add(this.txtWidth);
            this.tabAddShipment.Controls.Add(this.txtHeight);
            this.tabAddShipment.Controls.Add(this.label1);
            this.tabAddShipment.Controls.Add(this.txtOz);
            this.tabAddShipment.Controls.Add(this.txtlbs);
            this.tabAddShipment.Controls.Add(this.lblWeight);
            this.tabAddShipment.Controls.Add(this.ddlServiceLabel);
            this.tabAddShipment.Controls.Add(this.lblServiceLabel);
            this.tabAddShipment.Controls.Add(this.dataGridView1);
            this.tabAddShipment.Controls.Add(this.label2);
            this.tabAddShipment.Controls.Add(this.ddlSign);
            this.tabAddShipment.Controls.Add(this.txtChargeAmount);
            this.tabAddShipment.Controls.Add(this.ddlCOD);
            this.tabAddShipment.Controls.Add(this.chkInsurance);
            this.tabAddShipment.Controls.Add(this.chkSign);
            this.tabAddShipment.Controls.Add(this.chkCOD);
            this.tabAddShipment.Controls.Add(this.lblAccessories);
            this.tabAddShipment.Controls.Add(this.lblErrorTo);
            this.tabAddShipment.Controls.Add(this.lblErrorFrom);
            this.tabAddShipment.Controls.Add(this.lbShipTo);
            this.tabAddShipment.Controls.Add(this.lbShipFrom);
            this.tabAddShipment.Controls.Add(this.txtShipTo);
            this.tabAddShipment.Controls.Add(this.lblShipTo);
            this.tabAddShipment.Controls.Add(this.txtShipFrom);
            this.tabAddShipment.Controls.Add(this.lblShipFrom);
            this.tabAddShipment.Controls.Add(this.ddlCarrierName);
            this.tabAddShipment.Controls.Add(this.lblCarrierName);
            this.tabAddShipment.Location = new System.Drawing.Point(4, 22);
            this.tabAddShipment.Name = "tabAddShipment";
            this.tabAddShipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddShipment.Size = new System.Drawing.Size(1185, 551);
            this.tabAddShipment.TabIndex = 1;
            this.tabAddShipment.Text = "Add Shipment";
            this.tabAddShipment.UseVisualStyleBackColor = true;
            // 
            // lnlblRate
            // 
            this.lnlblRate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnlblRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lnlblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlblRate.ForeColor = System.Drawing.Color.White;
            this.lnlblRate.Location = new System.Drawing.Point(520, 454);
            this.lnlblRate.Name = "lnlblRate";
            this.lnlblRate.Size = new System.Drawing.Size(106, 29);
            this.lnlblRate.TabIndex = 90;
            this.lnlblRate.Text = "Get Rate";
            this.lnlblRate.UseVisualStyleBackColor = false;
            this.lnlblRate.Click += new System.EventHandler(this.lnlblRate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = global::ShipCaddieApp.Properties.Resources.noimage4;
            this.pictureBox1.Location = new System.Drawing.Point(770, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // lblShipmentId
            // 
            this.lblShipmentId.AutoSize = true;
            this.lblShipmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentId.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblShipmentId.Location = new System.Drawing.Point(489, 527);
            this.lblShipmentId.Name = "lblShipmentId";
            this.lblShipmentId.Size = new System.Drawing.Size(0, 13);
            this.lblShipmentId.TabIndex = 88;
            // 
            // txtShipId
            // 
            this.txtShipId.Location = new System.Drawing.Point(646, 497);
            this.txtShipId.Name = "txtShipId";
            this.txtShipId.Size = new System.Drawing.Size(98, 20);
            this.txtShipId.TabIndex = 87;
            // 
            // btnShipmentId
            // 
            this.btnShipmentId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShipmentId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShipmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipmentId.ForeColor = System.Drawing.Color.White;
            this.btnShipmentId.Location = new System.Drawing.Point(520, 492);
            this.btnShipmentId.Name = "btnShipmentId";
            this.btnShipmentId.Size = new System.Drawing.Size(106, 25);
            this.btnShipmentId.TabIndex = 86;
            this.btnShipmentId.Text = "Add Shipment";
            this.btnShipmentId.UseVisualStyleBackColor = false;
            this.btnShipmentId.Click += new System.EventHandler(this.btnShipmentId_Click);
            // 
            // lblPrintFormat
            // 
            this.lblPrintFormat.AutoSize = true;
            this.lblPrintFormat.Location = new System.Drawing.Point(517, 221);
            this.lblPrintFormat.Name = "lblPrintFormat";
            this.lblPrintFormat.Size = new System.Drawing.Size(53, 13);
            this.lblPrintFormat.TabIndex = 83;
            this.lblPrintFormat.Text = "PNG_4x6";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFormat.Location = new System.Drawing.Point(383, 218);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(85, 16);
            this.lblFormat.TabIndex = 79;
            this.lblFormat.Text = "Print Format :";
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintLabel.ForeColor = System.Drawing.Color.White;
            this.btnPrintLabel.Location = new System.Drawing.Point(646, 454);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Size = new System.Drawing.Size(98, 29);
            this.btnPrintLabel.TabIndex = 78;
            this.btnPrintLabel.Text = "Print Label";
            this.btnPrintLabel.UseVisualStyleBackColor = false;
            this.btnPrintLabel.Click += new System.EventHandler(this.btnPrintLabel_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(140, 505);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(60, 20);
            this.txtLength.TabIndex = 77;
            this.txtLength.Enter += new System.EventHandler(this.txtLength_Enter);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(205, 505);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(67, 20);
            this.txtWidth.TabIndex = 76;
            this.txtWidth.Enter += new System.EventHandler(this.txtWidth_Enter);
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(278, 505);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(63, 20);
            this.txtHeight.TabIndex = 75;
            this.txtHeight.Enter += new System.EventHandler(this.txtHeight_Enter);
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(23, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Size (inches) :";
            // 
            // txtOz
            // 
            this.txtOz.Location = new System.Drawing.Point(236, 467);
            this.txtOz.Name = "txtOz";
            this.txtOz.Size = new System.Drawing.Size(104, 20);
            this.txtOz.TabIndex = 73;
            this.txtOz.Enter += new System.EventHandler(this.txtOz_Enter);
            this.txtOz.Leave += new System.EventHandler(this.txtOz_Leave);
            // 
            // txtlbs
            // 
            this.txtlbs.Location = new System.Drawing.Point(140, 467);
            this.txtlbs.Name = "txtlbs";
            this.txtlbs.Size = new System.Drawing.Size(90, 20);
            this.txtlbs.TabIndex = 72;
            this.txtlbs.Enter += new System.EventHandler(this.txtlbs_Enter);
            this.txtlbs.Leave += new System.EventHandler(this.txtlbs_Leave);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWeight.Location = new System.Drawing.Point(26, 467);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 16);
            this.lblWeight.TabIndex = 71;
            this.lblWeight.Text = "Weight :";
            // 
            // ddlServiceLabel
            // 
            this.ddlServiceLabel.FormattingEnabled = true;
            this.ddlServiceLabel.Location = new System.Drawing.Point(140, 427);
            this.ddlServiceLabel.Name = "ddlServiceLabel";
            this.ddlServiceLabel.Size = new System.Drawing.Size(200, 21);
            this.ddlServiceLabel.TabIndex = 70;
            this.ddlServiceLabel.Text = "--Select--";
            this.ddlServiceLabel.SelectedIndexChanged += new System.EventHandler(this.ddlServiceLabel_SelectedIndexChanged);
            // 
            // lblServiceLabel
            // 
            this.lblServiceLabel.AutoSize = true;
            this.lblServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblServiceLabel.Location = new System.Drawing.Point(23, 427);
            this.lblServiceLabel.Name = "lblServiceLabel";
            this.lblServiceLabel.Size = new System.Drawing.Size(96, 16);
            this.lblServiceLabel.TabIndex = 69;
            this.lblServiceLabel.Text = "Service Level :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(223, 180);
            this.dataGridView1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(384, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Rate List :";
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
            this.ddlSign.Location = new System.Drawing.Point(521, 180);
            this.ddlSign.Name = "ddlSign";
            this.ddlSign.Size = new System.Drawing.Size(218, 21);
            this.ddlSign.TabIndex = 61;
            this.ddlSign.Text = "--Select--";
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(520, 122);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.Size = new System.Drawing.Size(218, 20);
            this.txtChargeAmount.TabIndex = 60;
            // 
            // ddlCOD
            // 
            this.ddlCOD.FormattingEnabled = true;
            this.ddlCOD.Items.AddRange(new object[] {
            "COD_SECURED_FUNDS",
            "COD_CASH",
            "COD_CHECK",
            "COD_ANY"});
            this.ddlCOD.Location = new System.Drawing.Point(520, 64);
            this.ddlCOD.Name = "ddlCOD";
            this.ddlCOD.Size = new System.Drawing.Size(218, 21);
            this.ddlCOD.TabIndex = 59;
            this.ddlCOD.Text = "-- Select --";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(520, 99);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(89, 17);
            this.chkInsurance.TabIndex = 58;
            this.chkInsurance.Text = "INSURANCE";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // chkSign
            // 
            this.chkSign.AutoSize = true;
            this.chkSign.Location = new System.Drawing.Point(521, 157);
            this.chkSign.Name = "chkSign";
            this.chkSign.Size = new System.Drawing.Size(89, 17);
            this.chkSign.TabIndex = 57;
            this.chkSign.Text = "SIGNATURE";
            this.chkSign.UseVisualStyleBackColor = true;
            // 
            // chkCOD
            // 
            this.chkCOD.AutoSize = true;
            this.chkCOD.Location = new System.Drawing.Point(521, 40);
            this.chkCOD.Name = "chkCOD";
            this.chkCOD.Size = new System.Drawing.Size(49, 17);
            this.chkCOD.TabIndex = 56;
            this.chkCOD.Text = "COD";
            this.chkCOD.UseVisualStyleBackColor = true;
            // 
            // lblAccessories
            // 
            this.lblAccessories.AutoSize = true;
            this.lblAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessories.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAccessories.Location = new System.Drawing.Point(383, 39);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(124, 16);
            this.lblAccessories.TabIndex = 55;
            this.lblAccessories.Text = "Accessorial Types:";
            // 
            // lblErrorTo
            // 
            this.lblErrorTo.AutoSize = true;
            this.lblErrorTo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblErrorTo.Location = new System.Drawing.Point(141, 360);
            this.lblErrorTo.Name = "lblErrorTo";
            this.lblErrorTo.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTo.TabIndex = 54;
            // 
            // lblErrorFrom
            // 
            this.lblErrorFrom.AutoSize = true;
            this.lblErrorFrom.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblErrorFrom.Location = new System.Drawing.Point(141, 191);
            this.lblErrorFrom.Name = "lblErrorFrom";
            this.lblErrorFrom.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFrom.TabIndex = 53;
            // 
            // lbShipTo
            // 
            this.lbShipTo.AutoSize = true;
            this.lbShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipTo.LinkColor = System.Drawing.Color.Blue;
            this.lbShipTo.Location = new System.Drawing.Point(141, 340);
            this.lbShipTo.Name = "lbShipTo";
            this.lbShipTo.Size = new System.Drawing.Size(117, 15);
            this.lbShipTo.TabIndex = 52;
            this.lbShipTo.TabStop = true;
            this.lbShipTo.Text = "Add ShipTo Address";
            this.lbShipTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShipTo_LinkClicked);
            // 
            // lbShipFrom
            // 
            this.lbShipFrom.AutoSize = true;
            this.lbShipFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipFrom.ForeColor = System.Drawing.Color.Coral;
            this.lbShipFrom.LinkColor = System.Drawing.Color.Blue;
            this.lbShipFrom.Location = new System.Drawing.Point(141, 170);
            this.lbShipFrom.Name = "lbShipFrom";
            this.lbShipFrom.Size = new System.Drawing.Size(132, 15);
            this.lbShipFrom.TabIndex = 51;
            this.lbShipFrom.TabStop = true;
            this.lbShipFrom.Text = "Add ShipFrom Address";
            this.lbShipFrom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShipFrom_LinkClicked);
            // 
            // txtShipTo
            // 
            this.txtShipTo.Location = new System.Drawing.Point(142, 214);
            this.txtShipTo.Multiline = true;
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.ReadOnly = true;
            this.txtShipTo.Size = new System.Drawing.Size(200, 124);
            this.txtShipTo.TabIndex = 49;
            this.txtShipTo.Text = "Name\r\nOrganization\r\nAddress1\r\nAddress 2\r\nCity\r\nState\r\nZipCode\r\nCountry\r\nPhone\r\nEm" +
    "ail";
            // 
            // lblShipTo
            // 
            this.lblShipTo.AutoSize = true;
            this.lblShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipTo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblShipTo.Location = new System.Drawing.Point(23, 214);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(61, 16);
            this.lblShipTo.TabIndex = 48;
            this.lblShipTo.Text = "Ship To :";
            // 
            // txtShipFrom
            // 
            this.txtShipFrom.Location = new System.Drawing.Point(142, 39);
            this.txtShipFrom.Multiline = true;
            this.txtShipFrom.Name = "txtShipFrom";
            this.txtShipFrom.ReadOnly = true;
            this.txtShipFrom.Size = new System.Drawing.Size(200, 129);
            this.txtShipFrom.TabIndex = 47;
            this.txtShipFrom.Text = "Name\r\nOrganization\r\nAddress1\r\nAddress 2\r\nCity\r\nState\r\nZipCode\r\nCountry\r\nPhone\r\nEm" +
    "ail";
            // 
            // lblShipFrom
            // 
            this.lblShipFrom.AutoSize = true;
            this.lblShipFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipFrom.ForeColor = System.Drawing.Color.Firebrick;
            this.lblShipFrom.Location = new System.Drawing.Point(24, 39);
            this.lblShipFrom.Name = "lblShipFrom";
            this.lblShipFrom.Size = new System.Drawing.Size(75, 16);
            this.lblShipFrom.TabIndex = 46;
            this.lblShipFrom.Text = "Ship From :";
            // 
            // ddlCarrierName
            // 
            this.ddlCarrierName.FormattingEnabled = true;
            this.ddlCarrierName.Items.AddRange(new object[] {
            "--Select--"});
            this.ddlCarrierName.Location = new System.Drawing.Point(140, 383);
            this.ddlCarrierName.Name = "ddlCarrierName";
            this.ddlCarrierName.Size = new System.Drawing.Size(200, 21);
            this.ddlCarrierName.TabIndex = 45;
            this.ddlCarrierName.Text = "--Select--";
            this.ddlCarrierName.SelectedIndexChanged += new System.EventHandler(this.ddlCarrierName_SelectedIndexChanged);
            // 
            // lblCarrierName
            // 
            this.lblCarrierName.AutoSize = true;
            this.lblCarrierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrierName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCarrierName.Location = new System.Drawing.Point(23, 382);
            this.lblCarrierName.Name = "lblCarrierName";
            this.lblCarrierName.Size = new System.Drawing.Size(94, 16);
            this.lblCarrierName.TabIndex = 44;
            this.lblCarrierName.Text = "Carrier Name :";
            // 
            // tabVoidLabel
            // 
            this.tabVoidLabel.Controls.Add(this.lblTrackingNo);
            this.tabVoidLabel.Controls.Add(this.txtTrackingNo);
            this.tabVoidLabel.Controls.Add(this.label5);
            this.tabVoidLabel.Controls.Add(this.txtGVoidLabel);
            this.tabVoidLabel.Controls.Add(this.btnVoidLabel);
            this.tabVoidLabel.Controls.Add(this.lblVoidLabel);
            this.tabVoidLabel.Location = new System.Drawing.Point(4, 22);
            this.tabVoidLabel.Name = "tabVoidLabel";
            this.tabVoidLabel.Size = new System.Drawing.Size(1185, 551);
            this.tabVoidLabel.TabIndex = 2;
            this.tabVoidLabel.Text = "Void Label";
            this.tabVoidLabel.UseVisualStyleBackColor = true;
            // 
            // lblTrackingNo
            // 
            this.lblTrackingNo.AutoSize = true;
            this.lblTrackingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTrackingNo.Location = new System.Drawing.Point(266, 284);
            this.lblTrackingNo.Name = "lblTrackingNo";
            this.lblTrackingNo.Size = new System.Drawing.Size(0, 13);
            this.lblTrackingNo.TabIndex = 79;
            // 
            // txtTrackingNo
            // 
            this.txtTrackingNo.Location = new System.Drawing.Point(263, 258);
            this.txtTrackingNo.Name = "txtTrackingNo";
            this.txtTrackingNo.Size = new System.Drawing.Size(223, 20);
            this.txtTrackingNo.TabIndex = 78;
            this.txtTrackingNo.Enter += new System.EventHandler(this.txtTrackingNo_Enter);
            this.txtTrackingNo.Leave += new System.EventHandler(this.txtTrackingNo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(101, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tracking Number :";
            // 
            // txtGVoidLabel
            // 
            this.txtGVoidLabel.Location = new System.Drawing.Point(263, 99);
            this.txtGVoidLabel.Name = "txtGVoidLabel";
            this.txtGVoidLabel.Size = new System.Drawing.Size(223, 20);
            this.txtGVoidLabel.TabIndex = 75;
            this.txtGVoidLabel.Enter += new System.EventHandler(this.txtGVoidLabel_Enter);
            this.txtGVoidLabel.Leave += new System.EventHandler(this.txtGVoidLabel_Leave);
            // 
            // btnVoidLabel
            // 
            this.btnVoidLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoidLabel.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnVoidLabel.FlatAppearance.BorderSize = 0;
            this.btnVoidLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoidLabel.Location = new System.Drawing.Point(411, 160);
            this.btnVoidLabel.Name = "btnVoidLabel";
            this.btnVoidLabel.Size = new System.Drawing.Size(75, 25);
            this.btnVoidLabel.TabIndex = 72;
            this.btnVoidLabel.Text = "Void Label";
            this.btnVoidLabel.UseVisualStyleBackColor = false;
            this.btnVoidLabel.Click += new System.EventHandler(this.btnVoidLabel_Click);
            // 
            // lblVoidLabel
            // 
            this.lblVoidLabel.AutoSize = true;
            this.lblVoidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoidLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVoidLabel.Location = new System.Drawing.Point(101, 103);
            this.lblVoidLabel.Name = "lblVoidLabel";
            this.lblVoidLabel.Size = new System.Drawing.Size(79, 16);
            this.lblVoidLabel.TabIndex = 70;
            this.lblVoidLabel.Text = "Void Label :";
            // 
            // tabShipInfo
            // 
            this.tabShipInfo.Controls.Add(this.lbl2TrackNo);
            this.tabShipInfo.Controls.Add(this.txtTrack);
            this.tabShipInfo.Controls.Add(this.label3);
            this.tabShipInfo.Controls.Add(this.pictureBox2);
            this.tabShipInfo.Controls.Add(this.lblTracking);
            this.tabShipInfo.Controls.Add(this.btnGetShipment);
            this.tabShipInfo.Controls.Add(this.txtTrackingBox);
            this.tabShipInfo.Controls.Add(this.label8);
            this.tabShipInfo.Location = new System.Drawing.Point(4, 22);
            this.tabShipInfo.Name = "tabShipInfo";
            this.tabShipInfo.Size = new System.Drawing.Size(1185, 551);
            this.tabShipInfo.TabIndex = 3;
            this.tabShipInfo.Text = "Get Shipment Information";
            this.tabShipInfo.UseVisualStyleBackColor = true;
            this.tabShipInfo.Click += new System.EventHandler(this.tabShipInfo_Click);
            // 
            // lbl2TrackNo
            // 
            this.lbl2TrackNo.AutoSize = true;
            this.lbl2TrackNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2TrackNo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl2TrackNo.Location = new System.Drawing.Point(224, 276);
            this.lbl2TrackNo.Name = "lbl2TrackNo";
            this.lbl2TrackNo.Size = new System.Drawing.Size(0, 13);
            this.lbl2TrackNo.TabIndex = 93;
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point(226, 253);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size(246, 20);
            this.txtTrack.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(88, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tracking Number :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = global::ShipCaddieApp.Properties.Resources.noimage4;
            this.pictureBox2.Location = new System.Drawing.Point(722, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 529);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracking.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTracking.Location = new System.Drawing.Point(220, 114);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(0, 13);
            this.lblTracking.TabIndex = 77;
            // 
            // btnGetShipment
            // 
            this.btnGetShipment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetShipment.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnGetShipment.FlatAppearance.BorderSize = 0;
            this.btnGetShipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetShipment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetShipment.Location = new System.Drawing.Point(226, 147);
            this.btnGetShipment.Name = "btnGetShipment";
            this.btnGetShipment.Size = new System.Drawing.Size(129, 33);
            this.btnGetShipment.TabIndex = 76;
            this.btnGetShipment.Text = "Get Shipment Info";
            this.btnGetShipment.UseVisualStyleBackColor = false;
            this.btnGetShipment.Click += new System.EventHandler(this.btnGetShipment_Click);
            // 
            // txtTrackingBox
            // 
            this.txtTrackingBox.Location = new System.Drawing.Point(223, 93);
            this.txtTrackingBox.Name = "txtTrackingBox";
            this.txtTrackingBox.Size = new System.Drawing.Size(175, 20);
            this.txtTrackingBox.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(88, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Shipment Id :";
            // 
            // lblSwitchAPI
            // 
            this.lblSwitchAPI.AutoSize = true;
            this.lblSwitchAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchAPI.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSwitchAPI.Location = new System.Drawing.Point(891, 19);
            this.lblSwitchAPI.Name = "lblSwitchAPI";
            this.lblSwitchAPI.Size = new System.Drawing.Size(106, 16);
            this.lblSwitchAPI.TabIndex = 91;
            this.lblSwitchAPI.Text = "Switch Request :";
            // 
            // ddlSwitchAPI
            // 
            this.ddlSwitchAPI.FormattingEnabled = true;
            this.ddlSwitchAPI.Location = new System.Drawing.Point(1034, 18);
            this.ddlSwitchAPI.Name = "ddlSwitchAPI";
            this.ddlSwitchAPI.Size = new System.Drawing.Size(170, 21);
            this.ddlSwitchAPI.TabIndex = 90;
            this.ddlSwitchAPI.SelectedIndexChanged += new System.EventHandler(this.ddlSwitchAPI_SelectedIndexChanged);
            // 
            // lblBaseUrl
            // 
            this.lblBaseUrl.AutoSize = true;
            this.lblBaseUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseUrl.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBaseUrl.Location = new System.Drawing.Point(20, 20);
            this.lblBaseUrl.Name = "lblBaseUrl";
            this.lblBaseUrl.Size = new System.Drawing.Size(137, 16);
            this.lblBaseUrl.TabIndex = 68;
            this.lblBaseUrl.Text = "Base WebAPI URL * :";
            // 
            // lblTokenMsg
            // 
            this.lblTokenMsg.AutoSize = true;
            this.lblTokenMsg.Location = new System.Drawing.Point(1155, 660);
            this.lblTokenMsg.Name = "lblTokenMsg";
            this.lblTokenMsg.Size = new System.Drawing.Size(57, 13);
            this.lblTokenMsg.TabIndex = 70;
            this.lblTokenMsg.Text = "* Required";
            // 
            // txtAPIUrl
            // 
            this.txtAPIUrl.Location = new System.Drawing.Point(163, 19);
            this.txtAPIUrl.Name = "txtAPIUrl";
            this.txtAPIUrl.Size = new System.Drawing.Size(202, 20);
            this.txtAPIUrl.TabIndex = 71;
            // 
            // lbl_LabelMessage
            // 
            this.lbl_LabelMessage.AutoSize = true;
            this.lbl_LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LabelMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_LabelMessage.Location = new System.Drawing.Point(25, 646);
            this.lbl_LabelMessage.Name = "lbl_LabelMessage";
            this.lbl_LabelMessage.Size = new System.Drawing.Size(0, 20);
            this.lbl_LabelMessage.TabIndex = 93;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorLabel.Location = new System.Drawing.Point(134, 649);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.ErrorLabel.TabIndex = 92;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 684);
            this.Controls.Add(this.lbl_LabelMessage);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.lblSwitchAPI);
            this.Controls.Add(this.txtAPIUrl);
            this.Controls.Add(this.ddlSwitchAPI);
            this.Controls.Add(this.lblTokenMsg);
            this.Controls.Add(this.lblBaseUrl);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabGetToken.ResumeLayout(false);
            this.tabGetToken.PerformLayout();
            this.tabAddShipment.ResumeLayout(false);
            this.tabAddShipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabVoidLabel.ResumeLayout(false);
            this.tabVoidLabel.PerformLayout();
            this.tabShipInfo.ResumeLayout(false);
            this.tabShipInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGetToken;
        private System.Windows.Forms.Label lblRefreshToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtRefToken;
        private System.Windows.Forms.TextBox txtGToken;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnRefreshToken;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TabPage tabAddShipment;
        private System.Windows.Forms.TabPage tabVoidLabel;
        private System.Windows.Forms.TabPage tabShipInfo;
        private System.Windows.Forms.Label lblBaseUrl;
        private System.Windows.Forms.Label lblTokenMsg;
        private System.Windows.Forms.TextBox txtAPIUrl;
        private System.Windows.Forms.Label lblSwitchAPI;
        private System.Windows.Forms.ComboBox ddlSwitchAPI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblShipmentId;
        private System.Windows.Forms.TextBox txtShipId;
        private System.Windows.Forms.Button btnShipmentId;
        private System.Windows.Forms.Label lblPrintFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOz;
        private System.Windows.Forms.TextBox txtlbs;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ComboBox ddlServiceLabel;
        private System.Windows.Forms.Label lblServiceLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSign;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.ComboBox ddlCOD;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.CheckBox chkSign;
        private System.Windows.Forms.CheckBox chkCOD;
        private System.Windows.Forms.Label lblAccessories;
        private System.Windows.Forms.Label lblErrorTo;
        private System.Windows.Forms.Label lblErrorFrom;
        private System.Windows.Forms.LinkLabel lbShipTo;
        public System.Windows.Forms.LinkLabel lbShipFrom;
        private System.Windows.Forms.TextBox txtShipTo;
        private System.Windows.Forms.Label lblShipTo;
        private System.Windows.Forms.TextBox txtShipFrom;
        private System.Windows.Forms.Label lblShipFrom;
        private System.Windows.Forms.ComboBox ddlCarrierName;
        private System.Windows.Forms.Label lblCarrierName;
        private System.Windows.Forms.TextBox txtGVoidLabel;
        private System.Windows.Forms.Button btnVoidLabel;
        private System.Windows.Forms.Label lblVoidLabel;
        private System.Windows.Forms.Label lblTrackingNo;
        private System.Windows.Forms.TextBox txtTrackingNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_LabelMessage;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.Button btnGetShipment;
        private System.Windows.Forms.TextBox txtTrackingBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button lnlblRate;
        private System.Windows.Forms.TextBox txtTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl2TrackNo;
    }
}