using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Post_office__Management_System
{
    public partial class Payment_Details : Form
    {
        public Payment_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        string pmtbll, pmtrec, pmtreg, pmtnm, pmtadvsts, pmtfnlsts, pmtsts;
        float pmttot, pmtadvprc, pmtfnlprc, pmtblc;
        DateTime pmtcdt, pmtrdt, pmtadvdt, pmtfnldt;
        
        //home button
        private void btnpayhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        //Interface Load Mathod
        private void Payment_Details_Load(object sender, EventArgs e)
        {
            //this.txtpmtbll.Enabled = false;

            this.txtpmtbll.Text = Convert.ToString(GetNextNo());

            this.lnklblcus.Visible = false;
            this.lstvwcus.Visible = false;
            this.lnklblsup.Visible = false;
            this.lstvwsup.Visible = false;

            //this.btnpaycrt.Visible = false;
            this.btnpaydlt.Visible = false;
            this.btnpayedt.Visible = false;
            this.btnpaybck.Visible = false;
            this.btnpayudt.Visible = false;
        }

        //Bill Number auto Increment Method
        public int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                string genaretpmtrec = "Select max(Bill_No) from Payment";

                cmd1.CommandText = genaretpmtrec;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        //create button
        private void btnpaycrt_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpmtbll.Text) || String.IsNullOrEmpty(txtpmtreg.Text) || String.IsNullOrEmpty(txtpmtnm.Text) || String.IsNullOrEmpty(txtpmttot.Text))
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check All Fields And submit again", "Message");
            }
            else if (rbtnpmtsup.Checked &&  (String.IsNullOrEmpty(txtpmtadvprc.Text) || String.IsNullOrEmpty(cmbpmtadvsts.Text)))
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check Advance Payment Details", "Message");
            }
            else if ( String.IsNullOrEmpty(txtpmtfnlprc.Text) || String.IsNullOrEmpty(cmbpmtfnlsts.Text) || String.IsNullOrEmpty(txtpmtblc.Text) || String.IsNullOrEmpty(cmbpmtsts.Text))
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check All Fields And submit again", "Message");
            }
            else
            {
                this.txtpmtbll.Text = Convert.ToString(GetNextNo());
                try
                {
                    pmtbll = this.txtpmtbll.Text.Trim();
                    pmtreg = this.txtpmtreg.Text.Trim();
                    pmtnm = this.txtpmtnm.Text.Trim();
                    pmttot = Convert.ToInt32(this.txtpmttot.Text.Trim());
                    pmtcdt = Convert.ToDateTime(this.dtppmtcdt.Text.Trim());
                    pmtrdt = Convert.ToDateTime(this.dtppmtrdt.Text.Trim());

                    pmtadvprc = Convert.ToInt32(this.txtpmtadvprc.Text.Trim());
                    pmtadvdt = Convert.ToDateTime(this.dtppmtadvdt.Text.Trim());
                    pmtadvsts = this.cmbpmtadvsts.Text.Trim();

                    pmtfnlprc = Convert.ToInt32(this.txtpmtfnlprc.Text.Trim());
                    pmtfnldt = Convert.ToDateTime(this.dtppmtfnldt.Text.Trim());
                    pmtfnlsts = this.cmbpmtfnlsts.Text.Trim();

                    pmtblc = Convert.ToInt32(this.txtpmtblc.Text.Trim());
                    pmtsts = this.cmbpmtsts.Text.Trim();



                    //db connection
                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String addD = "insert into Payment  values('" + pmtbll + "','" + pmtreg + "','" + pmtnm + "','" + pmttot + "','" + pmtcdt + "', '" + pmtrdt + "', '" + pmtadvprc + "','" + pmtadvdt + "','" + pmtadvsts + "','" + pmtfnlprc + "','" + pmtfnldt + "','" + pmtfnlsts + "','" + pmtblc + "','" + pmtsts + "')";

                    cmd1.CommandText = addD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    //successful msg
                    this.txtpmtbll.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");
                    clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("        Data cant Insert", "Message");
                }
            }
        }

        //data search
        private void btnpmtsch_Click(object sender, EventArgs e)
        {
            string pmtbll = this.txtpmtbll.Text.ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String dtsrch = "select * from Payment where (Bill_No ='" + pmtbll + "')";

            cmd1.CommandText = dtsrch;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                //this.txtpmtbll.Text = dr[0].ToString();
                this.txtpmtreg.Text = dr[1].ToString();
                this.txtpmtnm.Text = dr[2].ToString();
                this.txtpmttot.Text = dr[3].ToString();
                this.dtppmtcdt.Text = dr[4].ToString();
                this.dtppmtrdt.Text = dr[5].ToString();

                this.txtpmtadvprc.Text = dr[6].ToString();
                this.dtppmtadvdt.Text = dr[7].ToString();
                this.cmbpmtadvsts.SelectedItem = dr[8].ToString();

                this.txtpmtfnlprc.Text = dr[9].ToString();
                this.dtppmtfnldt.Text = dr[10].ToString();
                this.cmbpmtfnlsts.SelectedItem = dr[11].ToString();

                this.txtpmtblc.Text = dr[12].ToString();
                this.cmbpmtsts.SelectedItem = dr[13].ToString();



            }

            conn.Close();
            conn.Dispose();

            Disable();
            this.txtpmtbll.Enabled = true;

            this.btnpaycrt.Visible = false;
            this.btnpayedt.Visible = true;
            this.btnpaydlt.Visible = true;
        }

        //edit btn
        private void btnpayedt_Click_1(object sender, EventArgs e)
        {
            Enable();
            this.txtpmtbll.Enabled = false;

            this.rbtnpmtcus.Enabled = false;
            this.rbtnpmtsup.Enabled = false;

            this.btnpmtsch.Visible = false;
            this.btnpaydlt.Visible = false;
            this.btnpaybck.Visible = true;
            this.btnpayudt.Visible = true;

            
        }

        //back button
        private void btnpaybck_Click_1(object sender, EventArgs e)
        {
            Disable();
            this.txtpmtbll.Enabled = true;

            this.btnpayudt.Visible = false;
            this.btnpaybck.Visible = false;
            this.btnpmtsch.Visible = true;
            this.btnpayedt.Visible = true;
            this.btnpaydlt.Visible = true;
        }

        //updaate button
        private void btnpayudt_Click(object sender, EventArgs e)
        {
            try
            {
                pmtbll = this.txtpmtbll.Text.Trim();

                pmtreg = this.txtpmtreg.Text.Trim();
                pmtnm = this.txtpmtnm.Text.Trim();
                pmttot = Convert.ToInt32(this.txtpmttot.Text.Trim());
                pmtcdt = Convert.ToDateTime(this.dtppmtcdt.Text.Trim());
                pmtrdt = Convert.ToDateTime(this.dtppmtrdt.Text.Trim());

                pmtadvprc = Convert.ToInt32(this.txtpmtadvprc.Text.Trim());
                pmtadvdt = Convert.ToDateTime(this.dtppmtadvdt.Text.Trim());
                pmtadvsts = this.cmbpmtadvsts.Text.Trim();

                pmtfnlprc = Convert.ToInt32(this.txtpmtfnlprc.Text.Trim());
                pmtfnldt = Convert.ToDateTime(this.dtppmtfnldt.Text.Trim());
                pmtfnlsts = this.cmbpmtfnlsts.Text.Trim();

                pmtblc = Convert.ToInt32(this.txtpmtblc.Text.Trim());
                pmtsts = this.cmbpmtsts.Text.Trim();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String pmtedt = "update Payment set Bill_No = '" + pmtbll + "', Name = '" + pmtnm + "', Total_Price = '" + pmttot + "', Create_Date = '" + pmtcdt + "', [Receive-Date] = '" + pmtrdt + "', AP_Price = '" + pmtadvprc + "', AP_Date = '" + pmtadvdt + "', AP_Status = '" + pmtadvsts + "', FP_Price = '" + pmtfnlprc + "', FP_Date = '" + pmtfnldt + "', FP_Status = '" + pmtfnlsts + "', Balance = '" + pmtblc + "', Status = '" + pmtsts + "' where RegNo_NICNo = '" + pmtreg + "'";

                cmd1.CommandText = pmtedt;
                cmd1.Connection = conn;
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();

                this.txtpmtbll.Text = Convert.ToString(GetNextNo());
                clear();
                this.rbtnpmtcus.Enabled = true;
                this.rbtnpmtsup.Enabled = true;
                MessageBox.Show("        Succesfully Updated", "Message");
                
            }
            catch (Exception)
            {
                MessageBox.Show("        Data cant Insert", "Message");
            }
        }

        //delete btn
        private void btnpaydlt_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String pmtdlt = "delete from Payment where Bill_No ='" + pmtbll + "'";

            cmd1.CommandText = pmtdlt;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();


            MessageBox.Show("        Succesfully Deleted", "Message");
            this.txtpmtbll.Text = Convert.ToString(GetNextNo());
            clear();
        }

        //All Filed Clear Method
        private void clear()
        {
            this.txtpmtbll.Text = Convert.ToString(GetNextNo());

            this.txtpmtreg.Text = "";
            this.txtpmtnm.Text = "";
            this.txtpmttot.Text = "";
            this.dtppmtcdt.Text = "";
            this.dtppmtrdt.Text = "";

            this.txtpmtadvprc.Text = "";
            this.dtppmtadvdt.Text = "";
            this.cmbpmtadvsts.SelectedIndex = -1;

            this.txtpmtfnlprc.Text = "";
            this.dtppmtfnldt.Text = "";
            this.cmbpmtfnlsts.SelectedIndex = -1;

            this.txtpmtblc.Text = "";
            this.cmbpmtsts.SelectedIndex = -1;
        }

        //input fields disable
        private void Disable()
        {
            this.txtpmtbll.Enabled = false;
            this.txtpmtreg.Enabled = false;
            this.txtpmtnm.Enabled = false;
            this.txtpmttot.Enabled = false;
            this.dtppmtcdt.Enabled = false;
            this.dtppmtrdt.Enabled = false;

            this.txtpmtadvprc.Enabled = false;
            this.dtppmtadvdt.Enabled = false;
            this.cmbpmtadvsts.Enabled = false;

            this.txtpmtfnlprc.Enabled = false;
            this.dtppmtfnldt.Enabled = false;
            this.cmbpmtfnlsts.Enabled = false;

            this.txtpmtblc.Enabled = false;
            this.cmbpmtsts.Enabled = false;
        }

        //input fields enable
        private void Enable()
        {
            this.txtpmtbll.Enabled = true;
            this.txtpmtreg.Enabled = true;
            this.txtpmtnm.Enabled = true;
            this.txtpmttot.Enabled = true;
            this.dtppmtcdt.Enabled = true;
            this.dtppmtrdt.Enabled = true;

            this.txtpmtadvprc.Enabled = true;
            this.dtppmtadvdt.Enabled = true;
            this.cmbpmtadvsts.Enabled = true;

            this.txtpmtfnlprc.Enabled = true;
            this.dtppmtfnldt.Enabled = true;
            this.cmbpmtfnlsts.Enabled = true;

            this.txtpmtblc.Enabled = true;
            this.cmbpmtsts.Enabled = true;
        }

        // customer radio buttons
        private void rbtnpmtcus_CheckedChanged(object sender, EventArgs e)
        {     
            /*this.lnklblcus.Visible = true;
            this.lstvwcus.Visible = true;*/
            this.lnklblsup.Visible=false;
            this.lstvwsup.Visible = false;
            this.grpbxpmtadv.Enabled = false;
            clear();
            this.txtpmtadvprc.Text = "0";
        }

        //supplier radio button
        private void rbtnpmtsup_CheckedChanged(object sender, EventArgs e)
        {
            this.lnklblcus.Visible = false;
            this.lstvwcus.Visible = false;
            this.lnklblsup.Visible = true;
            this.lstvwsup.Visible = true;
            this.grpbxpmtadv.Enabled = true;
            clear();
        }

        //calculate button
        private void btnpmtcal_Click(object sender, EventArgs e)
        {
            if (rbtnpmtcus.Checked == true)
            {
                float tot1 = Convert.ToInt32(this.txtpmttot.Text.Trim());
                float fnl = Convert.ToInt32(this.txtpmtfnlprc.Text.Trim());
                float blc1 = tot1 - fnl;
                this.txtpmtblc.Text = Convert.ToString(blc1);
            }

            if (rbtnpmtsup.Checked == true)
            {
                float tot2 = Convert.ToInt32(this.txtpmttot.Text.Trim());
                float adv = Convert.ToInt32(this.txtpmtadvprc.Text.Trim());
                float blc2 = tot2 - adv;
                this.txtpmtblc.Text = Convert.ToString(blc2);
            }
        }

        //customer nic view
        private void lnklblcus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstvwcus.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter nic = new SqlCeDataAdapter("select NIC_No,Name_with_Initials from Customer", conn);
            DataTable dt = new DataTable();
            nic.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["NIC_No"].ToString());
                listview.SubItems.Add(dr["Name_with_Initials"].ToString());
                lstvwcus.Items.Add(listview);
                lstvwcus.Show();
            }
        }

        //supplier reg no view
        private void lnklblsup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstvwsup.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter reg = new SqlCeDataAdapter("select Reg_No,Name from Supplier_Detail", conn);
            DataTable dt = new DataTable();
            reg.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["Reg_No"].ToString());
                listview.SubItems.Add(dr["Name"].ToString());
                lstvwsup.Items.Add(listview);
                lstvwsup.Show();
            }
        }

        //only number
        private void txtpmttot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //only number
        private void txtpmtadvprc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //only number
        private void txtpmtfnlprc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //only number
        private void txtpmtblc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } 

    }
}
