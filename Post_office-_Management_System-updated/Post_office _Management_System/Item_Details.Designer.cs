namespace Post_office__Management_System
{
    partial class Item_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Details));
            this.txtitmrec = new System.Windows.Forms.TextBox();
            this.lblitmrec = new System.Windows.Forms.Label();
            this.btnitmhm = new System.Windows.Forms.Button();
            this.btnempdlt = new System.Windows.Forms.Button();
            this.btnitmedt = new System.Windows.Forms.Button();
            this.btnitmcrt = new System.Windows.Forms.Button();
            this.btnimtsrh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbitmsts = new System.Windows.Forms.ComboBox();
            this.txtitmdes = new System.Windows.Forms.TextBox();
            this.txtitmtyp = new System.Windows.Forms.TextBox();
            this.txtitmnm = new System.Windows.Forms.TextBox();
            this.txtitmno = new System.Windows.Forms.TextBox();
            this.lblitmsts = new System.Windows.Forms.Label();
            this.lblitmdes = new System.Windows.Forms.Label();
            this.lblitmtyp = new System.Windows.Forms.Label();
            this.lblitmno = new System.Windows.Forms.Label();
            this.lblitmnm = new System.Windows.Forms.Label();
            this.ItemTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtitmrec
            // 
            this.txtitmrec.Enabled = false;
            this.txtitmrec.Location = new System.Drawing.Point(1294, 12);
            this.txtitmrec.Name = "txtitmrec";
            this.txtitmrec.Size = new System.Drawing.Size(60, 21);
            this.txtitmrec.TabIndex = 18;
            // 
            // lblitmrec
            // 
            this.lblitmrec.AutoSize = true;
            this.lblitmrec.Location = new System.Drawing.Point(1240, 15);
            this.lblitmrec.Name = "lblitmrec";
            this.lblitmrec.Size = new System.Drawing.Size(48, 15);
            this.lblitmrec.TabIndex = 12;
            this.lblitmrec.Text = "Rec No";
            // 
            // btnitmhm
            // 
            this.btnitmhm.Location = new System.Drawing.Point(12, 655);
            this.btnitmhm.Name = "btnitmhm";
            this.btnitmhm.Size = new System.Drawing.Size(80, 25);
            this.btnitmhm.TabIndex = 59;
            this.btnitmhm.Text = "Home";
            this.btnitmhm.UseVisualStyleBackColor = true;
            this.btnitmhm.Click += new System.EventHandler(this.btnitmhm_Click);
            // 
            // btnempdlt
            // 
            this.btnempdlt.Location = new System.Drawing.Point(556, 434);
            this.btnempdlt.Name = "btnempdlt";
            this.btnempdlt.Size = new System.Drawing.Size(80, 25);
            this.btnempdlt.TabIndex = 74;
            this.btnempdlt.Text = "Delete";
            this.btnempdlt.UseVisualStyleBackColor = true;
            this.btnempdlt.Click += new System.EventHandler(this.btnempdlt_Click);
            // 
            // btnitmedt
            // 
            this.btnitmedt.Location = new System.Drawing.Point(332, 435);
            this.btnitmedt.Name = "btnitmedt";
            this.btnitmedt.Size = new System.Drawing.Size(80, 25);
            this.btnitmedt.TabIndex = 75;
            this.btnitmedt.Text = "Edit";
            this.btnitmedt.UseVisualStyleBackColor = true;
            this.btnitmedt.Click += new System.EventHandler(this.btnitmedt_Click);
            // 
            // btnitmcrt
            // 
            this.btnitmcrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitmcrt.Location = new System.Drawing.Point(442, 434);
            this.btnitmcrt.Name = "btnitmcrt";
            this.btnitmcrt.Size = new System.Drawing.Size(80, 25);
            this.btnitmcrt.TabIndex = 72;
            this.btnitmcrt.Text = "Create";
            this.btnitmcrt.UseVisualStyleBackColor = true;
            this.btnitmcrt.Click += new System.EventHandler(this.btnitmcrt_Click);
            // 
            // btnimtsrh
            // 
            this.btnimtsrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimtsrh.Location = new System.Drawing.Point(221, 435);
            this.btnimtsrh.Name = "btnimtsrh";
            this.btnimtsrh.Size = new System.Drawing.Size(80, 25);
            this.btnimtsrh.TabIndex = 73;
            this.btnimtsrh.Text = "Search";
            this.btnimtsrh.UseVisualStyleBackColor = true;
            this.btnimtsrh.Click += new System.EventHandler(this.btnimtsrh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbitmsts);
            this.groupBox1.Controls.Add(this.txtitmdes);
            this.groupBox1.Controls.Add(this.txtitmtyp);
            this.groupBox1.Controls.Add(this.txtitmnm);
            this.groupBox1.Controls.Add(this.txtitmno);
            this.groupBox1.Controls.Add(this.lblitmsts);
            this.groupBox1.Controls.Add(this.lblitmdes);
            this.groupBox1.Controls.Add(this.lblitmtyp);
            this.groupBox1.Controls.Add(this.lblitmno);
            this.groupBox1.Controls.Add(this.lblitmnm);
            this.groupBox1.Location = new System.Drawing.Point(118, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 233);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbitmsts
            // 
            this.cmbitmsts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbitmsts.FormattingEnabled = true;
            this.cmbitmsts.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbitmsts.Location = new System.Drawing.Point(235, 123);
            this.cmbitmsts.Name = "cmbitmsts";
            this.cmbitmsts.Size = new System.Drawing.Size(121, 23);
            this.cmbitmsts.TabIndex = 22;
            // 
            // txtitmdes
            // 
            this.txtitmdes.Location = new System.Drawing.Point(235, 152);
            this.txtitmdes.Multiline = true;
            this.txtitmdes.Name = "txtitmdes";
            this.txtitmdes.Size = new System.Drawing.Size(257, 62);
            this.txtitmdes.TabIndex = 21;
            // 
            // txtitmtyp
            // 
            this.txtitmtyp.Location = new System.Drawing.Point(235, 96);
            this.txtitmtyp.Name = "txtitmtyp";
            this.txtitmtyp.Size = new System.Drawing.Size(257, 21);
            this.txtitmtyp.TabIndex = 20;
            // 
            // txtitmnm
            // 
            this.txtitmnm.Location = new System.Drawing.Point(235, 69);
            this.txtitmnm.Name = "txtitmnm";
            this.txtitmnm.Size = new System.Drawing.Size(257, 21);
            this.txtitmnm.TabIndex = 19;
            // 
            // txtitmno
            // 
            this.txtitmno.Location = new System.Drawing.Point(235, 42);
            this.txtitmno.Name = "txtitmno";
            this.txtitmno.Size = new System.Drawing.Size(66, 21);
            this.txtitmno.TabIndex = 18;
            this.txtitmno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtitmno_KeyPress);
            // 
            // lblitmsts
            // 
            this.lblitmsts.AutoSize = true;
            this.lblitmsts.Location = new System.Drawing.Point(110, 126);
            this.lblitmsts.Name = "lblitmsts";
            this.lblitmsts.Size = new System.Drawing.Size(41, 15);
            this.lblitmsts.TabIndex = 27;
            this.lblitmsts.Text = "Status";
            // 
            // lblitmdes
            // 
            this.lblitmdes.AutoSize = true;
            this.lblitmdes.Location = new System.Drawing.Point(110, 155);
            this.lblitmdes.Name = "lblitmdes";
            this.lblitmdes.Size = new System.Drawing.Size(69, 15);
            this.lblitmdes.TabIndex = 26;
            this.lblitmdes.Text = "Description";
            // 
            // lblitmtyp
            // 
            this.lblitmtyp.AutoSize = true;
            this.lblitmtyp.Location = new System.Drawing.Point(110, 99);
            this.lblitmtyp.Name = "lblitmtyp";
            this.lblitmtyp.Size = new System.Drawing.Size(33, 15);
            this.lblitmtyp.TabIndex = 25;
            this.lblitmtyp.Text = "Type";
            // 
            // lblitmno
            // 
            this.lblitmno.AutoSize = true;
            this.lblitmno.Location = new System.Drawing.Point(110, 45);
            this.lblitmno.Name = "lblitmno";
            this.lblitmno.Size = new System.Drawing.Size(23, 15);
            this.lblitmno.TabIndex = 24;
            this.lblitmno.Text = "No";
            // 
            // lblitmnm
            // 
            this.lblitmnm.AutoSize = true;
            this.lblitmnm.Location = new System.Drawing.Point(110, 72);
            this.lblitmnm.Name = "lblitmnm";
            this.lblitmnm.Size = new System.Drawing.Size(41, 15);
            this.lblitmnm.TabIndex = 23;
            this.lblitmnm.Text = "Name";
            // 
            // ItemTable
            // 
            this.ItemTable.BackColor = System.Drawing.Color.LightSlateGray;
            this.ItemTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ItemTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemTable.GridLines = true;
            this.ItemTable.Location = new System.Drawing.Point(791, 169);
            this.ItemTable.Name = "ItemTable";
            this.ItemTable.Size = new System.Drawing.Size(405, 310);
            this.ItemTable.TabIndex = 110;
            this.ItemTable.UseCompatibleStateImageBehavior = false;
            this.ItemTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item No";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;
            // 
            // Item_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.ItemTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnempdlt);
            this.Controls.Add(this.btnitmedt);
            this.Controls.Add(this.btnitmcrt);
            this.Controls.Add(this.btnimtsrh);
            this.Controls.Add(this.btnitmhm);
            this.Controls.Add(this.txtitmrec);
            this.Controls.Add(this.lblitmrec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.Item_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtitmrec;
        private System.Windows.Forms.Label lblitmrec;
        private System.Windows.Forms.Button btnitmhm;
        private System.Windows.Forms.Button btnempdlt;
        private System.Windows.Forms.Button btnitmedt;
        private System.Windows.Forms.Button btnitmcrt;
        private System.Windows.Forms.Button btnimtsrh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbitmsts;
        private System.Windows.Forms.TextBox txtitmdes;
        private System.Windows.Forms.TextBox txtitmtyp;
        private System.Windows.Forms.TextBox txtitmnm;
        private System.Windows.Forms.TextBox txtitmno;
        private System.Windows.Forms.Label lblitmsts;
        private System.Windows.Forms.Label lblitmdes;
        private System.Windows.Forms.Label lblitmtyp;
        private System.Windows.Forms.Label lblitmno;
        private System.Windows.Forms.Label lblitmnm;
        private System.Windows.Forms.ListView ItemTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}