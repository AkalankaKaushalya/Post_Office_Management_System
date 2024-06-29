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
    public partial class Advance_Payment_Details : Form
    {
        public Advance_Payment_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        string advno, advsts, advdes;
        int advvlu, advrec;
        DateTime advsdt;

        //home button
        private void btnadvpayhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        //create button
        private void btnadvcrt_Click_1(object sender, EventArgs e)
        {
            //txtadvno,txtadvvlu,dtpadvsdt,cmbadvsts,txtadvdes
            if (String.IsNullOrEmpty(txtadvno.Text) || String.IsNullOrEmpty(txtadvvlu.Text) || String.IsNullOrEmpty(dtpadvsdt.Text) || String.IsNullOrEmpty(cmbadvsts.Text) || String.IsNullOrEmpty(txtadvdes.Text))
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check All Fields And submit again", "Message");
            }
            else
            {
                try
                {
                    advno = this.txtadvno.Text.Trim();
                    advvlu = Convert.ToInt32(this.txtadvvlu.Text.Trim());
                    advsdt = Convert.ToDateTime(this.dtpadvsdt.Text.Trim());
                    advsts = this.cmbadvsts.Text.Trim();
                    advdes = this.txtadvdes.Text.Trim();
                    advrec = Convert.ToInt32(this.txtadvrec.Text.Trim());

                    //db connection
                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String addD = "insert into Advance_Payment  values('" + advno + "','" + advvlu + "','" + advsdt + "','" + advsts + "','" + advdes + "','" + advrec + "')";

                    cmd1.CommandText = addD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    //successful msg
                    this.txtadvrec.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");
                    Clear();

                }
                catch (Exception)

                {
                    MessageBox.Show("        Data can't Insert", "Message");
                }
            }

        }


        //All Filed Clear Method
        private void Clear()
        {
            this.txtadvno.Text="";
            this.txtadvvlu.Text="";
            this.dtpadvsdt.Text="";
            this.cmbadvsts.SelectedIndex=-1;
            this.txtadvdes.Text="";
        }

        //Record Number auto Increment Method
        public int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                string genaretadvrec = "Select max(Rec_No) from Advance_Payment";

                cmd1.CommandText = genaretadvrec;
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

        //Interface Load Mathod
        private void Advance_Payment_Details_Load(object sender, EventArgs e)
        {
            this.txtadvrec.Enabled = false;

            this.txtadvrec.Text = Convert.ToString(GetNextNo());

            this.btnadvbck.Visible = false;
            this.btnadvdlt.Visible = false;
            this.btnadvedt.Visible = false;
            this.btnadvudt.Visible = false;
        }


        //data search
        private void btnadvsrh_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtadvrec.Text))
            {
                MessageBox.Show("        Insert the Bill Number", "Message");
            }
            else
            {
                string advno = this.txtadvno.Text.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String dtsrch = "select * from Advance_Payment where (No ='" + advno + "')";

                cmd1.CommandText = dtsrch;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.txtadvvlu.Text = dr[1].ToString();
                    this.dtpadvsdt.Text = dr[2].ToString();
                    this.cmbadvsts.SelectedItem = dr[3].ToString();
                    this.txtadvdes.Text = dr[4].ToString();
                    this.txtadvrec.Text = dr[5].ToString();

                }

                conn.Close();
                conn.Dispose();

                //Disable();
            }

        }

        //input fields disable
        private void Disable()
        {
     
            this.txtadvvlu.Enabled = false;
            this.dtpadvsdt.Enabled = false;
            this.cmbadvsts.Enabled = false;
            this.txtadvdes.Enabled = false;
        }


        //edit btn
        private void btnadvedt_Click_1(object sender, EventArgs e)
        {
            try
            {
                advno = this.txtadvno.Text.Trim();
                advvlu = Convert.ToInt32(this.txtadvvlu.Text.Trim());
                advsdt = Convert.ToDateTime(this.dtpadvsdt.Text.Trim());
                advsts = this.cmbadvsts.Text.Trim();
                advdes = this.txtadvdes.Text.Trim();
                advrec = Convert.ToInt32(this.txtadvrec.Text.Trim());

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String avdedt = "update Advance_Payment set Value = '" + advvlu + "', Start_Date = '" + advsdt + "', Status = '" + advsts + "', Description = '" + advdes + "', Rec_No = '" + advrec + "' where No = '" + advno + "'";

                cmd1.CommandText = avdedt;
                cmd1.Connection = conn;
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();


                this.txtadvrec.Text = Convert.ToString(GetNextNo());
                MessageBox.Show("        Succesfully Updated", "Message");
                Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("        Data can't Insert", "Message");
            }
        }


        //delete btn
        private void btnadvdlt_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String avddlt = "delete from Advance_Payment where No ='" + advno + "'";

            cmd1.CommandText = avddlt;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();

            this.txtadvrec.Text = Convert.ToString(GetNextNo());
            MessageBox.Show("        Succesfully Deleted", "Message");
            Clear();
        }


        //supplier reg no load
        private void SupReg()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String reg = "select Reg_No from Supplier_Detail";
            cmd1.CommandText = reg;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                this.txtadvno.Text = dr["Reg_No"].ToString();
            }
        }


        //only number
        private void txtadvvlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
