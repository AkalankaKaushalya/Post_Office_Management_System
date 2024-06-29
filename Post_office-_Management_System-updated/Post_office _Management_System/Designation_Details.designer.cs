namespace Post_office__Management_System
{
    partial class Designation_Details
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
            this.txtdsgrecno = new System.Windows.Forms.TextBox();
            this.lblpkgrec = new System.Windows.Forms.Label();
            this.btndsgdlt = new System.Windows.Forms.Button();
            this.btndsgedt = new System.Windows.Forms.Button();
            this.btndsgcrt = new System.Windows.Forms.Button();
            this.btndsgsrh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndsgrst = new System.Windows.Forms.Button();
            this.lbldsgdes = new System.Windows.Forms.Label();
            this.cmbdsgsts = new System.Windows.Forms.ComboBox();
            this.lbldsgsts = new System.Windows.Forms.Label();
            this.lbldsgnm = new System.Windows.Forms.Label();
            this.lbldsgno = new System.Windows.Forms.Label();
            this.txtdsgdes = new System.Windows.Forms.RichTextBox();
            this.txtdsgnm = new System.Windows.Forms.TextBox();
            this.txtdsgno = new System.Windows.Forms.TextBox();
            this.btndsgupd = new System.Windows.Forms.Button();
            this.lstvDESG = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnklblDetails = new System.Windows.Forms.LinkLabel();
            this.btndsgcncl = new System.Windows.Forms.Button();
            this.btbdsghm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdsgrecno
            // 
            this.txtdsgrecno.Enabled = false;
            this.txtdsgrecno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdsgrecno.Location = new System.Drawing.Point(1295, 12);
            this.txtdsgrecno.Name = "txtdsgrecno";
            this.txtdsgrecno.Size = new System.Drawing.Size(60, 24);
            this.txtdsgrecno.TabIndex = 29;
            // 
            // lblpkgrec
            // 
            this.lblpkgrec.AutoSize = true;
            this.lblpkgrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpkgrec.Location = new System.Drawing.Point(1241, 15);
            this.lblpkgrec.Name = "lblpkgrec";
            this.lblpkgrec.Size = new System.Drawing.Size(59, 18);
            this.lblpkgrec.TabIndex = 28;
            this.lblpkgrec.Text = "Rec No";
            // 
            // btndsgdlt
            // 
            this.btndsgdlt.Location = new System.Drawing.Point(1120, 502);
            this.btndsgdlt.Name = "btndsgdlt";
            this.btndsgdlt.Size = new System.Drawing.Size(90, 30);
            this.btndsgdlt.TabIndex = 5;
            this.btndsgdlt.Text = "Delete";
            this.btndsgdlt.UseVisualStyleBackColor = true;
            this.btndsgdlt.Click += new System.EventHandler(this.btndsgdlt_Click);
            // 
            // btndsgedt
            // 
            this.btndsgedt.Location = new System.Drawing.Point(928, 502);
            this.btndsgedt.Name = "btndsgedt";
            this.btndsgedt.Size = new System.Drawing.Size(90, 30);
            this.btndsgedt.TabIndex = 3;
            this.btndsgedt.Text = "Edit";
            this.btndsgedt.UseVisualStyleBackColor = true;
            this.btndsgedt.Click += new System.EventHandler(this.btndsgedt_Click);
            // 
            // btndsgcrt
            // 
            this.btndsgcrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndsgcrt.Location = new System.Drawing.Point(1024, 502);
            this.btndsgcrt.Name = "btndsgcrt";
            this.btndsgcrt.Size = new System.Drawing.Size(90, 30);
            this.btndsgcrt.TabIndex = 1;
            this.btndsgcrt.Text = "Create";
            this.btndsgcrt.UseVisualStyleBackColor = true;
            this.btndsgcrt.Click += new System.EventHandler(this.btndsgcrt_Click);
            // 
            // btndsgsrh
            // 
            this.btndsgsrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndsgsrh.Location = new System.Drawing.Point(928, 502);
            this.btndsgsrh.Name = "btndsgsrh";
            this.btndsgsrh.Size = new System.Drawing.Size(90, 30);
            this.btndsgsrh.TabIndex = 2;
            this.btndsgsrh.Text = "Search";
            this.btndsgsrh.UseVisualStyleBackColor = true;
            this.btndsgsrh.Click += new System.EventHandler(this.btndsgsrh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btndsgrst);
            this.groupBox1.Controls.Add(this.lbldsgdes);
            this.groupBox1.Controls.Add(this.cmbdsgsts);
            this.groupBox1.Controls.Add(this.lbldsgsts);
            this.groupBox1.Controls.Add(this.lbldsgnm);
            this.groupBox1.Controls.Add(this.lbldsgno);
            this.groupBox1.Controls.Add(this.txtdsgdes);
            this.groupBox1.Controls.Add(this.txtdsgnm);
            this.groupBox1.Controls.Add(this.txtdsgno);
            this.groupBox1.Location = new System.Drawing.Point(245, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btndsgrst
            // 
            this.btndsgrst.BackgroundImage = global::Post_office__Management_System.Properties.Resources.recycle;
            this.btndsgrst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndsgrst.Location = new System.Drawing.Point(631, 195);
            this.btndsgrst.Name = "btndsgrst";
            this.btndsgrst.Size = new System.Drawing.Size(35, 35);
            this.btndsgrst.TabIndex = 73;
            this.btndsgrst.UseVisualStyleBackColor = true;
            this.btndsgrst.Click += new System.EventHandler(this.btndsgrst_Click);
            // 
            // lbldsgdes
            // 
            this.lbldsgdes.AutoSize = true;
            this.lbldsgdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsgdes.Location = new System.Drawing.Point(71, 143);
            this.lbldsgdes.Name = "lbldsgdes";
            this.lbldsgdes.Size = new System.Drawing.Size(83, 18);
            this.lbldsgdes.TabIndex = 41;
            this.lbldsgdes.Text = "Description";
            // 
            // cmbdsgsts
            // 
            this.cmbdsgsts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdsgsts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdsgsts.FormattingEnabled = true;
            this.cmbdsgsts.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbdsgsts.Location = new System.Drawing.Point(183, 112);
            this.cmbdsgsts.Name = "cmbdsgsts";
            this.cmbdsgsts.Size = new System.Drawing.Size(140, 26);
            this.cmbdsgsts.TabIndex = 2;
            // 
            // lbldsgsts
            // 
            this.lbldsgsts.AutoSize = true;
            this.lbldsgsts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsgsts.Location = new System.Drawing.Point(71, 113);
            this.lbldsgsts.Name = "lbldsgsts";
            this.lbldsgsts.Size = new System.Drawing.Size(50, 18);
            this.lbldsgsts.TabIndex = 40;
            this.lbldsgsts.Text = "Status";
            // 
            // lbldsgnm
            // 
            this.lbldsgnm.AutoSize = true;
            this.lbldsgnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsgnm.Location = new System.Drawing.Point(71, 84);
            this.lbldsgnm.Name = "lbldsgnm";
            this.lbldsgnm.Size = new System.Drawing.Size(48, 18);
            this.lbldsgnm.TabIndex = 39;
            this.lbldsgnm.Text = "Name";
            // 
            // lbldsgno
            // 
            this.lbldsgno.AutoSize = true;
            this.lbldsgno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsgno.Location = new System.Drawing.Point(71, 53);
            this.lbldsgno.Name = "lbldsgno";
            this.lbldsgno.Size = new System.Drawing.Size(28, 18);
            this.lbldsgno.TabIndex = 38;
            this.lbldsgno.Text = "No";
            // 
            // txtdsgdes
            // 
            this.txtdsgdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdsgdes.Location = new System.Drawing.Point(183, 145);
            this.txtdsgdes.Name = "txtdsgdes";
            this.txtdsgdes.Size = new System.Drawing.Size(440, 84);
            this.txtdsgdes.TabIndex = 3;
            this.txtdsgdes.Text = "";
            // 
            // txtdsgnm
            // 
            this.txtdsgnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdsgnm.Location = new System.Drawing.Point(183, 81);
            this.txtdsgnm.Name = "txtdsgnm";
            this.txtdsgnm.Size = new System.Drawing.Size(440, 24);
            this.txtdsgnm.TabIndex = 1;
            // 
            // txtdsgno
            // 
            this.txtdsgno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdsgno.Location = new System.Drawing.Point(183, 50);
            this.txtdsgno.Name = "txtdsgno";
            this.txtdsgno.Size = new System.Drawing.Size(116, 24);
            this.txtdsgno.TabIndex = 0;
            this.txtdsgno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdsgno_KeyPress);
            // 
            // btndsgupd
            // 
            this.btndsgupd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndsgupd.Location = new System.Drawing.Point(1024, 502);
            this.btndsgupd.Name = "btndsgupd";
            this.btndsgupd.Size = new System.Drawing.Size(90, 30);
            this.btndsgupd.TabIndex = 4;
            this.btndsgupd.Text = "Update";
            this.btndsgupd.UseVisualStyleBackColor = true;
            this.btndsgupd.Click += new System.EventHandler(this.btndsgupd_Click);
            // 
            // lstvDESG
            // 
            this.lstvDESG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvDESG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDESG.GridLines = true;
            this.lstvDESG.Location = new System.Drawing.Point(245, 441);
            this.lstvDESG.Name = "lstvDESG";
            this.lstvDESG.Size = new System.Drawing.Size(559, 244);
            this.lstvDESG.TabIndex = 2;
            this.lstvDESG.UseCompatibleStateImageBehavior = false;
            this.lstvDESG.View = System.Windows.Forms.View.Details;
            this.lstvDESG.DoubleClick += new System.EventHandler(this.lstvDESG_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rec No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 152;
            // 
            // lnklblDetails
            // 
            this.lnklblDetails.AutoSize = true;
            this.lnklblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblDetails.Location = new System.Drawing.Point(242, 423);
            this.lnklblDetails.Name = "lnklblDetails";
            this.lnklblDetails.Size = new System.Drawing.Size(103, 18);
            this.lnklblDetails.TabIndex = 1;
            this.lnklblDetails.TabStop = true;
            this.lnklblDetails.Text = "View all details";
            this.lnklblDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblDetails_LinkClicked);
            // 
            // btndsgcncl
            // 
            this.btndsgcncl.Location = new System.Drawing.Point(832, 502);
            this.btndsgcncl.Name = "btndsgcncl";
            this.btndsgcncl.Size = new System.Drawing.Size(90, 30);
            this.btndsgcncl.TabIndex = 6;
            this.btndsgcncl.Text = "Cancel";
            this.btndsgcncl.UseVisualStyleBackColor = true;
            this.btndsgcncl.Click += new System.EventHandler(this.btndsgcncl_Click);
            // 
            // btbdsghm
            // 
            this.btbdsghm.FlatAppearance.BorderSize = 0;
            this.btbdsghm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btbdsghm.Location = new System.Drawing.Point(12, 12);
            this.btbdsghm.Name = "btbdsghm";
            this.btbdsghm.Size = new System.Drawing.Size(65, 40);
            this.btbdsghm.TabIndex = 7;
            this.btbdsghm.Text = "Home";
            this.btbdsghm.UseVisualStyleBackColor = false;
            this.btbdsghm.Click += new System.EventHandler(this.btbdsghm_Click);
            // 
            // Designation_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Post_office__Management_System.Properties.Resources.designation_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.btndsgcrt);
            this.Controls.Add(this.btndsgdlt);
            this.Controls.Add(this.btndsgcncl);
            this.Controls.Add(this.lnklblDetails);
            this.Controls.Add(this.lstvDESG);
            this.Controls.Add(this.btndsgupd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndsgedt);
            this.Controls.Add(this.btndsgsrh);
            this.Controls.Add(this.btbdsghm);
            this.Controls.Add(this.txtdsgrecno);
            this.Controls.Add(this.lblpkgrec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Designation_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Designation Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Designation_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdsgrecno;
        private System.Windows.Forms.Label lblpkgrec;
        private System.Windows.Forms.Button btbdsghm;
        private System.Windows.Forms.Button btndsgdlt;
        private System.Windows.Forms.Button btndsgedt;
        private System.Windows.Forms.Button btndsgcrt;
        private System.Windows.Forms.Button btndsgsrh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldsgdes;
        private System.Windows.Forms.Label lbldsgsts;
        private System.Windows.Forms.Label lbldsgnm;
        private System.Windows.Forms.Label lbldsgno;
        private System.Windows.Forms.RichTextBox txtdsgdes;
        private System.Windows.Forms.TextBox txtdsgnm;
        private System.Windows.Forms.TextBox txtdsgno;
        private System.Windows.Forms.Button btndsgupd;
        private System.Windows.Forms.ListView lstvDESG;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.LinkLabel lnklblDetails;
        private System.Windows.Forms.ComboBox cmbdsgsts;
        private System.Windows.Forms.Button btndsgrst;
        private System.Windows.Forms.Button btndsgcncl;
    }
}