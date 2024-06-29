namespace Post_office__Management_System
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblhelp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimelblPoMS = new System.Windows.Forms.Label();
            this.lblPoMS = new System.Windows.Forms.Label();
            this.btnpaydtl = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btncus = new System.Windows.Forms.Button();
            this.btnpkg = new System.Windows.Forms.Button();
            this.btnvehi = new System.Windows.Forms.Button();
            this.btnpkgdel = new System.Windows.Forms.Button();
            this.btnitmdtl = new System.Windows.Forms.Button();
            this.btnsupdtl = new System.Windows.Forms.Button();
            this.btnadvpay = new System.Windows.Forms.Button();
            this.btnslspri = new System.Windows.Forms.Button();
            this.btnpsttyp = new System.Windows.Forms.Button();
            this.btndesig = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.btnbrn = new System.Windows.Forms.Button();
            this.sqlCeCommand1 = new System.Data.SqlServerCe.SqlCeCommand();
            this.sqlCeConnection1 = new System.Data.SqlServerCe.SqlCeConnection();
            this.SuspendLayout();
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.BackColor = System.Drawing.Color.Transparent;
            this.lblhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhelp.ForeColor = System.Drawing.Color.White;
            this.lblhelp.Location = new System.Drawing.Point(14, 69);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(42, 20);
            this.lblhelp.TabIndex = 57;
            this.lblhelp.Text = "Help";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimelblPoMS
            // 
            this.TimelblPoMS.AutoSize = true;
            this.TimelblPoMS.BackColor = System.Drawing.Color.Transparent;
            this.TimelblPoMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimelblPoMS.ForeColor = System.Drawing.Color.White;
            this.TimelblPoMS.Location = new System.Drawing.Point(572, 140);
            this.TimelblPoMS.Name = "TimelblPoMS";
            this.TimelblPoMS.Size = new System.Drawing.Size(157, 39);
            this.TimelblPoMS.TabIndex = 45;
            this.TimelblPoMS.Text = "00:00:00";
            // 
            // lblPoMS
            // 
            this.lblPoMS.AutoSize = true;
            this.lblPoMS.BackColor = System.Drawing.Color.Transparent;
            this.lblPoMS.Font = new System.Drawing.Font("Calisto MT", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoMS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPoMS.Location = new System.Drawing.Point(298, 43);
            this.lblPoMS.Name = "lblPoMS";
            this.lblPoMS.Size = new System.Drawing.Size(781, 59);
            this.lblPoMS.TabIndex = 30;
            this.lblPoMS.Text = "Post office Management System";
            // 
            // btnpaydtl
            // 
            this.btnpaydtl.BackgroundImage = global::Post_office__Management_System.Properties.Resources.payment_details;
            this.btnpaydtl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpaydtl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpaydtl.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaydtl.Location = new System.Drawing.Point(845, 603);
            this.btnpaydtl.Name = "btnpaydtl";
            this.btnpaydtl.Size = new System.Drawing.Size(265, 67);
            this.btnpaydtl.TabIndex = 58;
            this.btnpaydtl.Text = "             Payment Details";
            this.btnpaydtl.UseVisualStyleBackColor = true;
            this.btnpaydtl.Click += new System.EventHandler(this.btnpaydtl_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Location = new System.Drawing.Point(1325, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(30, 30);
            this.btnexit.TabIndex = 59;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.Transparent;
            this.btnhelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhelp.BackgroundImage")));
            this.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhelp.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhelp.Location = new System.Drawing.Point(12, 15);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(45, 45);
            this.btnhelp.TabIndex = 12;
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btncus
            // 
            this.btncus.BackgroundImage = global::Post_office__Management_System.Properties.Resources.customer_details;
            this.btncus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncus.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btncus.FlatAppearance.BorderSize = 10;
            this.btncus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncus.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncus.Location = new System.Drawing.Point(547, 603);
            this.btncus.Name = "btncus";
            this.btncus.Size = new System.Drawing.Size(265, 67);
            this.btncus.TabIndex = 6;
            this.btncus.Text = "             Customer Details";
            this.btncus.UseVisualStyleBackColor = true;
            this.btncus.Click += new System.EventHandler(this.btncus_Click);
            // 
            // btnpkg
            // 
            this.btnpkg.BackgroundImage = global::Post_office__Management_System.Properties.Resources.package_details;
            this.btnpkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpkg.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnpkg.FlatAppearance.BorderSize = 10;
            this.btnpkg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpkg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpkg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpkg.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpkg.Location = new System.Drawing.Point(61, 516);
            this.btnpkg.Name = "btnpkg";
            this.btnpkg.Size = new System.Drawing.Size(265, 67);
            this.btnpkg.TabIndex = 4;
            this.btnpkg.Text = "             Package Details";
            this.btnpkg.UseVisualStyleBackColor = true;
            this.btnpkg.Click += new System.EventHandler(this.btnpkg_Click);
            // 
            // btnvehi
            // 
            this.btnvehi.BackgroundImage = global::Post_office__Management_System.Properties.Resources.vehical;
            this.btnvehi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvehi.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnvehi.FlatAppearance.BorderSize = 10;
            this.btnvehi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnvehi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnvehi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvehi.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvehi.Location = new System.Drawing.Point(1037, 184);
            this.btnvehi.Name = "btnvehi";
            this.btnvehi.Size = new System.Drawing.Size(265, 67);
            this.btnvehi.TabIndex = 7;
            this.btnvehi.Text = "             Vehicle Details";
            this.btnvehi.UseVisualStyleBackColor = true;
            this.btnvehi.Click += new System.EventHandler(this.btnvehi_Click);
            // 
            // btnpkgdel
            // 
            this.btnpkgdel.BackgroundImage = global::Post_office__Management_System.Properties.Resources.package_delivery;
            this.btnpkgdel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpkgdel.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnpkgdel.FlatAppearance.BorderSize = 10;
            this.btnpkgdel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpkgdel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpkgdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpkgdel.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpkgdel.Location = new System.Drawing.Point(1037, 267);
            this.btnpkgdel.Name = "btnpkgdel";
            this.btnpkgdel.Size = new System.Drawing.Size(265, 67);
            this.btnpkgdel.TabIndex = 8;
            this.btnpkgdel.Text = "             Package Delivery              Details";
            this.btnpkgdel.UseVisualStyleBackColor = true;
            this.btnpkgdel.Click += new System.EventHandler(this.btnpkgdel_Click);
            // 
            // btnitmdtl
            // 
            this.btnitmdtl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnitmdtl.BackgroundImage")));
            this.btnitmdtl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnitmdtl.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnitmdtl.FlatAppearance.BorderSize = 10;
            this.btnitmdtl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnitmdtl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnitmdtl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnitmdtl.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitmdtl.Location = new System.Drawing.Point(1037, 350);
            this.btnitmdtl.Name = "btnitmdtl";
            this.btnitmdtl.Size = new System.Drawing.Size(265, 67);
            this.btnitmdtl.TabIndex = 9;
            this.btnitmdtl.Text = "             Item Details";
            this.btnitmdtl.UseVisualStyleBackColor = true;
            this.btnitmdtl.Click += new System.EventHandler(this.btnitmdtl_Click);
            // 
            // btnsupdtl
            // 
            this.btnsupdtl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsupdtl.BackgroundImage")));
            this.btnsupdtl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsupdtl.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnsupdtl.FlatAppearance.BorderSize = 10;
            this.btnsupdtl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsupdtl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsupdtl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsupdtl.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupdtl.Location = new System.Drawing.Point(1037, 433);
            this.btnsupdtl.Name = "btnsupdtl";
            this.btnsupdtl.Size = new System.Drawing.Size(265, 67);
            this.btnsupdtl.TabIndex = 10;
            this.btnsupdtl.Text = "             Supplier Details";
            this.btnsupdtl.UseVisualStyleBackColor = true;
            this.btnsupdtl.Click += new System.EventHandler(this.btnsupdtl_Click);
            // 
            // btnadvpay
            // 
            this.btnadvpay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadvpay.BackgroundImage")));
            this.btnadvpay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadvpay.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnadvpay.FlatAppearance.BorderSize = 10;
            this.btnadvpay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnadvpay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnadvpay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadvpay.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadvpay.Location = new System.Drawing.Point(1037, 516);
            this.btnadvpay.Name = "btnadvpay";
            this.btnadvpay.Size = new System.Drawing.Size(265, 67);
            this.btnadvpay.TabIndex = 11;
            this.btnadvpay.Text = "             Advance Payment              Details";
            this.btnadvpay.UseVisualStyleBackColor = true;
            this.btnadvpay.Click += new System.EventHandler(this.btnadvpay_Click);
            // 
            // btnslspri
            // 
            this.btnslspri.BackgroundImage = global::Post_office__Management_System.Properties.Resources.Sales_price;
            this.btnslspri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnslspri.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnslspri.FlatAppearance.BorderSize = 10;
            this.btnslspri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnslspri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnslspri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnslspri.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnslspri.Location = new System.Drawing.Point(249, 603);
            this.btnslspri.Name = "btnslspri";
            this.btnslspri.Size = new System.Drawing.Size(265, 67);
            this.btnslspri.TabIndex = 5;
            this.btnslspri.Text = "             Sales Price Details";
            this.btnslspri.UseVisualStyleBackColor = true;
            this.btnslspri.Click += new System.EventHandler(this.btnslspri_Click);
            // 
            // btnpsttyp
            // 
            this.btnpsttyp.BackgroundImage = global::Post_office__Management_System.Properties.Resources.post_type;
            this.btnpsttyp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpsttyp.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnpsttyp.FlatAppearance.BorderSize = 10;
            this.btnpsttyp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpsttyp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpsttyp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpsttyp.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpsttyp.Location = new System.Drawing.Point(61, 433);
            this.btnpsttyp.Name = "btnpsttyp";
            this.btnpsttyp.Size = new System.Drawing.Size(265, 67);
            this.btnpsttyp.TabIndex = 3;
            this.btnpsttyp.Text = "             Post Type Details";
            this.btnpsttyp.UseVisualStyleBackColor = true;
            this.btnpsttyp.Click += new System.EventHandler(this.btnpsttyp_Click);
            // 
            // btndesig
            // 
            this.btndesig.BackgroundImage = global::Post_office__Management_System.Properties.Resources.designation_details;
            this.btndesig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndesig.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btndesig.FlatAppearance.BorderSize = 10;
            this.btndesig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndesig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndesig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndesig.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesig.Location = new System.Drawing.Point(61, 267);
            this.btndesig.Name = "btndesig";
            this.btndesig.Size = new System.Drawing.Size(265, 67);
            this.btndesig.TabIndex = 1;
            this.btndesig.Text = "             Designation Details";
            this.btndesig.UseVisualStyleBackColor = true;
            this.btndesig.Click += new System.EventHandler(this.btndesig_Click);
            // 
            // btnemp
            // 
            this.btnemp.BackgroundImage = global::Post_office__Management_System.Properties.Resources.employee_details;
            this.btnemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnemp.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnemp.FlatAppearance.BorderSize = 10;
            this.btnemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnemp.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.Location = new System.Drawing.Point(61, 184);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(265, 67);
            this.btnemp.TabIndex = 0;
            this.btnemp.Text = "             Employee Details";
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnbrn
            // 
            this.btnbrn.BackgroundImage = global::Post_office__Management_System.Properties.Resources.branch_details;
            this.btnbrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbrn.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnbrn.FlatAppearance.BorderSize = 10;
            this.btnbrn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbrn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbrn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbrn.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrn.Location = new System.Drawing.Point(61, 350);
            this.btnbrn.Name = "btnbrn";
            this.btnbrn.Size = new System.Drawing.Size(265, 67);
            this.btnbrn.TabIndex = 2;
            this.btnbrn.Text = "             Branch Details";
            this.btnbrn.UseVisualStyleBackColor = true;
            this.btnbrn.Click += new System.EventHandler(this.btnbrn_Click);
            // 
            // sqlCeCommand1
            // 
            this.sqlCeCommand1.CommandTimeout = 0;
            this.sqlCeCommand1.Connection = null;
            this.sqlCeCommand1.IndexName = null;
            this.sqlCeCommand1.Transaction = null;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Post_office__Management_System.Properties.Resources.dashboard_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 740);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnpaydtl);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btncus);
            this.Controls.Add(this.btnpkg);
            this.Controls.Add(this.btnvehi);
            this.Controls.Add(this.btnpkgdel);
            this.Controls.Add(this.btnitmdtl);
            this.Controls.Add(this.btnsupdtl);
            this.Controls.Add(this.btnadvpay);
            this.Controls.Add(this.btnslspri);
            this.Controls.Add(this.btnpsttyp);
            this.Controls.Add(this.btndesig);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.lblhelp);
            this.Controls.Add(this.TimelblPoMS);
            this.Controls.Add(this.lblPoMS);
            this.Controls.Add(this.btnbrn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhelp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimelblPoMS;
        private System.Windows.Forms.Label lblPoMS;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btndesig;
        private System.Windows.Forms.Button btnbrn;
        private System.Windows.Forms.Button btnpsttyp;
        private System.Windows.Forms.Button btnslspri;
        private System.Windows.Forms.Button btnpkg;
        private System.Windows.Forms.Button btnadvpay;
        private System.Windows.Forms.Button btncus;
        private System.Windows.Forms.Button btnsupdtl;
        private System.Windows.Forms.Button btnitmdtl;
        private System.Windows.Forms.Button btnpkgdel;
        private System.Windows.Forms.Button btnvehi;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btnpaydtl;
        private System.Windows.Forms.Button btnexit;
        private System.Data.SqlServerCe.SqlCeCommand sqlCeCommand1;
        private System.Data.SqlServerCe.SqlCeConnection sqlCeConnection1;
    }
}