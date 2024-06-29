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
    public partial class Vehicle_Details : Form
    {
        public Vehicle_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        string vclno, vcltyp, vcldrvepf, vcldrvnmi, vclsts, vclsvsrsn, vclsvssts;
        int vclcap, vcldrvcon1, vcldrvcon2,vclrec;
        DateTime vclsvsfrm, vclsvsto;

        //home button
        private void btnvehhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        //Record Number auto Increment Method
        public int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                string genaretvclrec = "Select max(Rec_No) from Vehicle";

                cmd1.CommandText = genaretvclrec;
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

        //form load
        private void Vehicle_Details_Load(object sender, EventArgs e)
        {
            this.txtvclrec.Enabled = false;
            this.txtvcldrvnmi.Enabled = false;

            this.txtvclrec.Text = Convert.ToString(GetNextNo());

            this.btnvehbck.Visible = false;
            this.btnvehdlt.Visible = false;
            this.btnvehedt.Visible = false;
            this.btnvehudt.Visible = false;

            driver();
        }

        //create button
        private void btnvehcrt_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtvclno.Text) || String.IsNullOrEmpty(cmbvcltyp.Text) || String.IsNullOrEmpty(txtvclcap.Text) || String.IsNullOrEmpty(cmbvcldrvepf.Text) || String.IsNullOrEmpty(txtvcldrvnmi.Text) || String.IsNullOrEmpty(txtvcldrvcon1.Text))
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check All Fields And submit again", "Message");
            }
            else if (String.IsNullOrEmpty(txtvcldrvcon2.Text) || String.IsNullOrEmpty(cmbvclsts.Text) /*|| String.IsNullOrEmpty(txtvclsvsrsn.Text) || String.IsNullOrEmpty(dtpvclsvsfrm.Text) || String.IsNullOrEmpty(dtpvclsvsto.Text) || String.IsNullOrEmpty(cmbvclsvssts.Text)*/)
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check All Fields And submit again", "Message");
            }
            else
            {
                try
                {
                    vclrec = Convert.ToInt32(this.txtvclrec.Text.Trim());
                    vclno = this.txtvclno.Text.Trim();
                    vcltyp = this.cmbvcltyp.Text.Trim();
                    vclcap = Convert.ToInt32(this.txtvclcap.Text.Trim());

                    vcldrvepf = this.cmbvcldrvepf.Text.Trim();
                    vcldrvnmi = this.txtvcldrvnmi.Text.Trim();
                    vcldrvcon1 = Convert.ToInt32(this.txtvcldrvcon1.Text.Trim());
                    vcldrvcon2 = Convert.ToInt32(this.txtvcldrvcon2.Text.Trim());
                    vclsts = this.cmbvclsts.Text.Trim();

                    vclsvsrsn = this.txtvclsvsrsn.Text.Trim();
                    vclsvsfrm = Convert.ToDateTime(this.dtpvclsvsfrm.Text.Trim());
                    vclsvsto = Convert.ToDateTime(this.dtpvclsvsto.Text.Trim());
                    vclsvssts = this.cmbvclsvssts.Text.Trim();


                    //db connection
                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String addD = "insert into Vehicle values('" + vclno + "','" + vcltyp + "','" + vclcap + "','" + vcldrvepf + "','" + vcldrvnmi + "','" + vcldrvcon1 + "', '" + vcldrvcon2 + "', '" + vclsts + "','" + vclsvsrsn + "','" + vclsvsfrm + "','" + vclsvsto + "','" + vclsvssts + "','" + vclrec + "')";

                    cmd1.CommandText = addD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    //successful msg
                    this.txtvclrec.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");
                    Rfresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("       Data Not Insert", "Message");
                }
            }
        }

        //search button
        private void btnvehsrh_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtvclno.Text))
            {
                MessageBox.Show("        Please Enter A Valid Vehicle Number", "Message");
            }
            else
            {
                string vclno = this.txtvclno.Text.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String dtsrch = "select * from Vehicle where (No ='" + vclno + "')";

                cmd1.CommandText = dtsrch;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {

                    this.cmbvcltyp.SelectedItem = dr[1].ToString();
                    this.txtvclcap.Text = dr[2].ToString();

                    this.cmbvcldrvepf.SelectedItem = dr[3].ToString();
                    this.txtvcldrvnmi.Text = dr[4].ToString();
                    this.txtvcldrvcon1.Text = dr[5].ToString();
                    this.txtvcldrvcon2.Text = dr[6].ToString();
                    this.cmbvclsts.SelectedItem = dr[7].ToString();

                    this.txtvclsvsrsn.Text = dr[8].ToString();
                    this.dtpvclsvsfrm.Text = dr[9].ToString();
                    this.dtpvclsvsto.Text = dr[10].ToString();
                    this.cmbvclsvssts.SelectedItem = dr[11].ToString();
                    this.txtvclrec.Text = dr[12].ToString();


                }

                conn.Close();
                conn.Dispose();

                Disable();

                this.btnvehcrt.Visible = false;
                this.btnvehedt.Visible = true;
                this.btnvehdlt.Visible = true;


            }
            
        }

        //edit btn
        private void btnvehedt_Click_1(object sender, EventArgs e)
        {
            Enable();
            this.txtvclno.Enabled = false;

            this.btnvehbck.Visible = true;
            this.btnvehudt.Visible = true;
            this.btnvehsrh.Visible = false;
            this.btnvehdlt.Visible = false;
        }

        //update button
        private void btnvehudt_Click(object sender, EventArgs e)
        {
            try
            {
                vclrec = Convert.ToInt32(this.txtvclrec.Text.Trim());
                vclno = this.txtvclno.Text.Trim();
                vcltyp = this.cmbvcltyp.Text.Trim();
                vclcap = Convert.ToInt32(this.txtvclcap.Text.Trim());

                vcldrvepf = this.cmbvcldrvepf.Text.Trim();
                vcldrvnmi = this.txtvcldrvnmi.Text.Trim();
                vcldrvcon1 = Convert.ToInt32(this.txtvcldrvcon1.Text.Trim());
                vcldrvcon2 = Convert.ToInt32(this.txtvcldrvcon2.Text.Trim());
                vclsts = this.cmbvclsts.Text.Trim();

                vclsvsrsn = this.txtvclsvsrsn.Text.Trim();
                vclsvsfrm = Convert.ToDateTime(this.dtpvclsvsfrm.Text.Trim());
                vclsvsto = Convert.ToDateTime(this.dtpvclsvsto.Text.Trim());
                vclsvssts = this.cmbvclsvssts.Text.Trim();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String vcledt = "update Vehicle set Type = '" + vcltyp + "', Capacity = '" + vclcap + "', EPFETF_No = '" + vcldrvepf + "', Name = '" + vcldrvnmi + "',Con_No1 = '" + vcldrvcon1 + "', Con_No2 = '" + vcldrvcon2 + "', Status = '" + vclsts + "', SRReason = '" + vclsvsrsn + "', SRDate_From = '" + vclsvsfrm + "', SRDate_To = '" + vclsvsto + "', SRStatus = '" + vclsvssts + "', Rec_No = '" + vclrec + "' where No = '" + vclno + "'";

                cmd1.CommandText = vcledt;
                cmd1.Connection = conn;
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();

                
                MessageBox.Show("        Succesfully Updated", "Message");
                this.txtvclrec.Text = Convert.ToString(GetNextNo());
                Rfresh();
            }
            catch (Exception)
            {
                MessageBox.Show("       Data Not Insert", "Message");
            }
        }

        //back button
        private void btnvehbck_Click(object sender, EventArgs e)
        {
            Disable();
            this.txtvclno.Enabled = true;

            this.btnvehbck.Visible = false;
            this.btnvehudt.Visible = false;
            this.btnvehsrh.Visible = true;
            this.btnvehdlt.Visible = true;
        }

        //delete button
        private void btnvehdlt_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String vcldlt = "delete from Vehicle where No ='" + vclno + "'";

            cmd1.CommandText = vcldlt;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();

            MessageBox.Show("        Succesfully Deleted", "Message");
            this.txtvclrec.Text = Convert.ToString(GetNextNo());
            Rfresh();
        }

        //All Filed Clear Method
        private void Clear()
        {
            this.txtvclno.Text = "";
            this.cmbvcltyp.SelectedIndex = -1;
            this.txtvclcap.Text = "";

            this.cmbvcldrvepf.SelectedIndex = -1;
            this.txtvcldrvnmi.Text = "";
            this.txtvcldrvcon1.Text = "";
            this.txtvcldrvcon2.Text = "";
            this.cmbvclsts.SelectedIndex = -1;

            this.txtvclsvsrsn.Text = "";
            this.dtpvclsvsfrm.Text = "";
            this.dtpvclsvsto.Text = "";
            this.cmbvclsvssts.SelectedIndex = -1;
            
        }

        //driver epf-no load
        private void driver()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String driver = "select EPF_ETF_No from Employee where (Designation='Driver')";
            cmd1.CommandText = driver;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                this.cmbvcldrvepf.Items.Add(dr["EPF_ETF_No"]);

            }
            
        }

        //refresh
        private void Rfresh()
        {
            Clear();
            Enable();

            this.txtvclrec.Enabled = false;
            this.txtvcldrvnmi.Enabled = false;

            this.txtvclrec.Text = Convert.ToString(GetNextNo());

            this.btnvehbck.Visible = false;
            this.btnvehdlt.Visible = false;
            this.btnvehedt.Visible = false;
            this.btnvehudt.Visible = false;
            this.btnvehcrt.Visible = true;

            driver();
        }
        
        //input fielda disable
        private void Disable()
        {
            this.txtvclno.Enabled = false;
            this.cmbvcltyp.Enabled = false;
            this.txtvclcap.Enabled = false;

            this.cmbvcldrvepf.Enabled = false;
            //this.txtvcldrvnmi.Enabled = false;
            this.txtvcldrvcon1.Enabled = false;
            this.txtvcldrvcon2.Enabled = false;
            this.cmbvclsts.Enabled = false;

            /*this.txtvclsvsrsn.Enabled = false;
            this.dtpvclsvsfrm.Enabled = false;
            this.dtpvclsvsto.Enabled = false;
            this.cmbvclsvssts.Enabled = false;*/
        }

        //input field enable
        private void Enable()
        {
            this.txtvclno.Enabled = true;
            this.cmbvcltyp.Enabled = true;
            this.txtvclcap.Enabled = true;

            this.cmbvcldrvepf.Enabled = true;
            //this.txtvcldrvnmi.Enabled = true;
            this.txtvcldrvcon1.Enabled = true;
            this.txtvcldrvcon2.Enabled = true;
            this.cmbvclsts.Enabled = true;

            /*this.txtvclsvsrsn.Enabled = true;
            this.dtpvclsvsfrm.Enabled = true;
            this.dtpvclsvsto.Enabled = true;
            this.cmbvclsvssts.Enabled = true;*/
        }

        //driver name load
        private void cmbvcldrvepf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String DrvNm = this.cmbvcldrvepf.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String drivernmi = "select Name_with_Initials from Employee where (EPF_ETF_No='" + DrvNm + "')";
                cmd1.CommandText = drivernmi;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    this.txtvcldrvnmi.Text = dr["Name_with_Initials"].ToString();

                }
            }
            catch
            {

            }
            
        }

        //service & repair group box active/innactive
        private void cmbvclsts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbvclsts.SelectedItem == "Available")
            {
                this.grpbxvclsvs.Enabled = false;
            }
            else
            {
                this.grpbxvclsvs.Enabled = true;
            }
        }

        //only number
        private void txtvclcap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //only number
        private void txtvcldrvcon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //only number
        private void txtvcldrvcon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
