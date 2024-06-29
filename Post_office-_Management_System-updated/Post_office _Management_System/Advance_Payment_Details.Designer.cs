namespace Post_office__Management_System
{
    partial class Advance_Payment_Details
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
            this.btnadvcrt = new System.Windows.Forms.Button();
            this.btnadvsrh = new System.Windows.Forms.Button();
            this.lbladvrec = new System.Windows.Forms.Label();
            this.txtadvrec = new System.Windows.Forms.TextBox();
            this.btnadvpayhm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtadvdes = new System.Windows.Forms.RichTextBox();
            this.cmbadvsts = new System.Windows.Forms.ComboBox();
            this.dtpadvsdt = new System.Windows.Forms.DateTimePicker();
            this.txtadvvlu = new System.Windows.Forms.TextBox();
            this.txtadvno = new System.Windows.Forms.TextBox();
            this.lbladvdes = new System.Windows.Forms.Label();
            this.lbladvsts = new System.Windows.Forms.Label();
            this.lbladvsdt = new System.Windows.Forms.Label();
            this.lbladvvlu = new System.Windows.Forms.Label();
            this.lbladvno = new System.Windows.Forms.Label();
            this.btnadvdlt = new System.Windows.Forms.Button();
            this.btnadvedt = new System.Windows.Forms.Button();
            this.btnadvbck = new System.Windows.Forms.Button();
            this.btnadvudt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadvcrt
            // 
            this.btnadvcrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadvcrt.Location = new System.Drawing.Point(1048, 521);
            this.btnadvcrt.Name = "btnadvcrt";
            this.btnadvcrt.Size = new System.Drawing.Size(80, 25);
            this.btnadvcrt.TabIndex = 5;
            this.btnadvcrt.Text = "Create";
            this.btnadvcrt.UseVisualStyleBackColor = true;
            this.btnadvcrt.Click += new System.EventHandler(this.btnadvcrt_Click_1);
            // 
            // btnadvsrh
            // 
            this.btnadvsrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadvsrh.Location = new System.Drawing.Point(825, 520);
            this.btnadvsrh.Name = "btnadvsrh";
            this.btnadvsrh.Size = new System.Drawing.Size(80, 25);
            this.btnadvsrh.TabIndex = 6;
            this.btnadvsrh.Text = "Search";
            this.btnadvsrh.UseVisualStyleBackColor = true;
            this.btnadvsrh.Click += new System.EventHandler(this.btnadvsrh_Click);
            // 
            // lbladvrec
            // 
            this.lbladvrec.AutoSize = true;
            this.lbladvrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvrec.Location = new System.Drawing.Point(1236, 15);
            this.lbladvrec.Name = "lbladvrec";
            this.lbladvrec.Size = new System.Drawing.Size(59, 18);
            this.lbladvrec.TabIndex = 15;
            this.lbladvrec.Text = "Bill  No ";
            // 
            // txtadvrec
            // 
            this.txtadvrec.Enabled = false;
            this.txtadvrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvrec.Location = new System.Drawing.Point(1293, 12);
            this.txtadvrec.Name = "txtadvrec";
            this.txtadvrec.Size = new System.Drawing.Size(60, 24);
            this.txtadvrec.TabIndex = 14;
            // 
            // btnadvpayhm
            // 
            this.btnadvpayhm.Location = new System.Drawing.Point(12, 657);
            this.btnadvpayhm.Name = "btnadvpayhm";
            this.btnadvpayhm.Size = new System.Drawing.Size(75, 23);
            this.btnadvpayhm.TabIndex = 7;
            this.btnadvpayhm.Text = "Home";
            this.btnadvpayhm.UseVisualStyleBackColor = true;
            this.btnadvpayhm.Click += new System.EventHandler(this.btnadvpayhm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtadvdes);
            this.groupBox1.Controls.Add(this.cmbadvsts);
            this.groupBox1.Controls.Add(this.dtpadvsdt);
            this.groupBox1.Controls.Add(this.txtadvvlu);
            this.groupBox1.Controls.Add(this.txtadvno);
            this.groupBox1.Controls.Add(this.lbladvdes);
            this.groupBox1.Controls.Add(this.lbladvsts);
            this.groupBox1.Controls.Add(this.lbladvsdt);
            this.groupBox1.Controls.Add(this.lbladvvlu);
            this.groupBox1.Controls.Add(this.lbladvno);
            this.groupBox1.Location = new System.Drawing.Point(315, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 290);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // txtadvdes
            // 
            this.txtadvdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvdes.Location = new System.Drawing.Point(163, 170);
            this.txtadvdes.Name = "txtadvdes";
            this.txtadvdes.Size = new System.Drawing.Size(498, 70);
            this.txtadvdes.TabIndex = 25;
            this.txtadvdes.Text = "";
            // 
            // cmbadvsts
            // 
            this.cmbadvsts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbadvsts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbadvsts.FormattingEnabled = true;
            this.cmbadvsts.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbadvsts.Location = new System.Drawing.Point(163, 141);
            this.cmbadvsts.Name = "cmbadvsts";
            this.cmbadvsts.Size = new System.Drawing.Size(121, 26);
            this.cmbadvsts.TabIndex = 24;
            // 
            // dtpadvsdt
            // 
            this.dtpadvsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpadvsdt.Location = new System.Drawing.Point(163, 114);
            this.dtpadvsdt.Name = "dtpadvsdt";
            this.dtpadvsdt.Size = new System.Drawing.Size(220, 24);
            this.dtpadvsdt.TabIndex = 23;
            // 
            // txtadvvlu
            // 
            this.txtadvvlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvvlu.Location = new System.Drawing.Point(163, 87);
            this.txtadvvlu.Name = "txtadvvlu";
            this.txtadvvlu.Size = new System.Drawing.Size(121, 24);
            this.txtadvvlu.TabIndex = 22;
            this.txtadvvlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadvvlu_KeyPress);
            // 
            // txtadvno
            // 
            this.txtadvno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvno.Location = new System.Drawing.Point(163, 60);
            this.txtadvno.Name = "txtadvno";
            this.txtadvno.Size = new System.Drawing.Size(55, 24);
            this.txtadvno.TabIndex = 21;
            // 
            // lbladvdes
            // 
            this.lbladvdes.AutoSize = true;
            this.lbladvdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvdes.Location = new System.Drawing.Point(56, 173);
            this.lbladvdes.Name = "lbladvdes";
            this.lbladvdes.Size = new System.Drawing.Size(83, 18);
            this.lbladvdes.TabIndex = 30;
            this.lbladvdes.Text = "Description";
            // 
            // lbladvsts
            // 
            this.lbladvsts.AutoSize = true;
            this.lbladvsts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvsts.Location = new System.Drawing.Point(56, 144);
            this.lbladvsts.Name = "lbladvsts";
            this.lbladvsts.Size = new System.Drawing.Size(50, 18);
            this.lbladvsts.TabIndex = 29;
            this.lbladvsts.Text = "Status";
            // 
            // lbladvsdt
            // 
            this.lbladvsdt.AutoSize = true;
            this.lbladvsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvsdt.Location = new System.Drawing.Point(56, 119);
            this.lbladvsdt.Name = "lbladvsdt";
            this.lbladvsdt.Size = new System.Drawing.Size(74, 18);
            this.lbladvsdt.TabIndex = 28;
            this.lbladvsdt.Text = "Start Date";
            // 
            // lbladvvlu
            // 
            this.lbladvvlu.AutoSize = true;
            this.lbladvvlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvvlu.Location = new System.Drawing.Point(56, 90);
            this.lbladvvlu.Name = "lbladvvlu";
            this.lbladvvlu.Size = new System.Drawing.Size(81, 18);
            this.lbladvvlu.TabIndex = 27;
            this.lbladvvlu.Text = "Value (Rs.)";
            // 
            // lbladvno
            // 
            this.lbladvno.AutoSize = true;
            this.lbladvno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvno.Location = new System.Drawing.Point(56, 63);
            this.lbladvno.Name = "lbladvno";
            this.lbladvno.Size = new System.Drawing.Size(59, 18);
            this.lbladvno.TabIndex = 26;
            this.lbladvno.Text = "Reg No";
            // 
            // btnadvdlt
            // 
            this.btnadvdlt.Location = new System.Drawing.Point(1160, 520);
            this.btnadvdlt.Name = "btnadvdlt";
            this.btnadvdlt.Size = new System.Drawing.Size(80, 25);
            this.btnadvdlt.TabIndex = 62;
            this.btnadvdlt.Text = "Delete";
            this.btnadvdlt.UseVisualStyleBackColor = true;
            this.btnadvdlt.Click += new System.EventHandler(this.btnadvdlt_Click);
            // 
            // btnadvedt
            // 
            this.btnadvedt.Location = new System.Drawing.Point(936, 520);
            this.btnadvedt.Name = "btnadvedt";
            this.btnadvedt.Size = new System.Drawing.Size(80, 25);
            this.btnadvedt.TabIndex = 63;
            this.btnadvedt.Text = "Edit";
            this.btnadvedt.UseVisualStyleBackColor = true;
            this.btnadvedt.Click += new System.EventHandler(this.btnadvedt_Click_1);
            // 
            // btnadvbck
            // 
            this.btnadvbck.Location = new System.Drawing.Point(936, 568);
            this.btnadvbck.Name = "btnadvbck";
            this.btnadvbck.Size = new System.Drawing.Size(75, 23);
            this.btnadvbck.TabIndex = 64;
            this.btnadvbck.Text = "Back";
            this.btnadvbck.UseVisualStyleBackColor = true;
            // 
            // btnadvudt
            // 
            this.btnadvudt.Location = new System.Drawing.Point(1053, 568);
            this.btnadvudt.Name = "btnadvudt";
            this.btnadvudt.Size = new System.Drawing.Size(75, 23);
            this.btnadvudt.TabIndex = 65;
            this.btnadvudt.Text = "Update";
            this.btnadvudt.UseVisualStyleBackColor = true;
            // 
            // Advance_Payment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 692);
            this.Controls.Add(this.btnadvudt);
            this.Controls.Add(this.btnadvbck);
            this.Controls.Add(this.btnadvdlt);
            this.Controls.Add(this.btnadvedt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnadvpayhm);
            this.Controls.Add(this.btnadvcrt);
            this.Controls.Add(this.btnadvsrh);
            this.Controls.Add(this.lbladvrec);
            this.Controls.Add(this.txtadvrec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Advance_Payment_Details";
            this.Text = "Advance Payment Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Advance_Payment_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadvcrt;
        private System.Windows.Forms.Button btnadvsrh;
        private System.Windows.Forms.Label lbladvrec;
        private System.Windows.Forms.TextBox txtadvrec;
        private System.Windows.Forms.Button btnadvpayhm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtadvdes;
        private System.Windows.Forms.ComboBox cmbadvsts;
        private System.Windows.Forms.DateTimePicker dtpadvsdt;
        private System.Windows.Forms.TextBox txtadvvlu;
        private System.Windows.Forms.TextBox txtadvno;
        private System.Windows.Forms.Label lbladvdes;
        private System.Windows.Forms.Label lbladvsts;
        private System.Windows.Forms.Label lbladvsdt;
        private System.Windows.Forms.Label lbladvvlu;
        private System.Windows.Forms.Label lbladvno;
        private System.Windows.Forms.Button btnadvdlt;
        private System.Windows.Forms.Button btnadvedt;
        private System.Windows.Forms.Button btnadvbck;
        private System.Windows.Forms.Button btnadvudt;
    }
}