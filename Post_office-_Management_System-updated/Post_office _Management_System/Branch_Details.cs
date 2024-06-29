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
using System.Text.RegularExpressions;

namespace Post_office__Management_System
{
    public partial class Branch_Details : Form
    {
        public Branch_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        int brnrecno,brnno,brndepno;
        String brnname, brnadr1, brnadr2, brneml, brncon, brnfax, brnbcrg, brnbcrgETF, brnsts, brndsc;
        String brndepnm, brndeploc, brndepempno;

        //Form load
        public void Branch_Details_Load(object sender, EventArgs e)
        {
            this.txtbrnrec.Enabled = false;
            BranchDB obj1 = new BranchDB();
            this.txtbrnrec.Text = Convert.ToString(obj1.GetNextNo());
            GetETFno();

            this.btnbrnudt.Visible = false;
            this.btnbrndlt.Visible = false;
        }

        private void GetETFno()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "SELECT EPF_ETF_No FROM Employee";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbbrnETF.Items.Add(dr["EPF_ETF_No"].ToString());
            }
        }

        //Home button
        private void btnbrnhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        //Load name
        private void cmbbrnETF_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ETFno = cmbbrnETF.Text.Trim().ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String SrhDt = "SELECT Full_Name FROM Employee WHERE (EPF_ETF_No ='" + ETFno + "')";

            cmd1.CommandText = SrhDt;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                this.txtbrnbcrg.Text = dr[0].ToString();
            }

            conn.Close();
            conn.Dispose();

        }

        //Data insert
        private void btnbrncrt_Click(object sender, EventArgs e)
        {
            String email = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            String contact = @"^([0-9]{10})$"; 
            //String contact1 = @"^(\+[0-9]{11})$";
            String fax = @"^\+[0-9]{1,3}\([0-9]{3}\)[0-9]{7}$";

            if (String.IsNullOrEmpty(txtbrnno.Text) || String.IsNullOrEmpty(txtbrnnm.Text) || String.IsNullOrEmpty(txtbrnadr1.Text) || String.IsNullOrEmpty(txtbrnadr2.Text) || String.IsNullOrEmpty(txtbrneml.Text) || String.IsNullOrEmpty(txtbrncon.Text) || String.IsNullOrEmpty(txtbrnfax.Text) || String.IsNullOrEmpty(txtbrnbcrg.Text) || String.IsNullOrEmpty(cmbbrnsts.Text) || String.IsNullOrEmpty(txtbrndsc.Text) || String.IsNullOrEmpty(txtbrndeploc.Text) || String.IsNullOrEmpty(txtbrndepno.Text) || String.IsNullOrEmpty(txtbrndepnm.Text) || String.IsNullOrEmpty(txtbrndepempno.Text))
            {
                MessageBox.Show("Some fields remain vacant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(this.txtbrncon.Text.Trim(), contact ))
            {
                MessageBox.Show("Invalid Contact No...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(this.txtbrnfax.Text.Trim(), fax))
            {
                MessageBox.Show("Invalid Fax No...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(this.txtbrneml.Text.Trim(), email))
            {
                MessageBox.Show("Invalid Email Address...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    brnrecno = Convert.ToInt32(this.txtbrnrec.Text.Trim());
                    brnno = Convert.ToInt32(this.txtbrnno.Text.Trim());
                    brnname = this.txtbrnnm.Text.Trim();
                    brnadr1 = this.txtbrnadr1.Text.Trim();
                    brnadr2 = this.txtbrnadr2.Text.Trim();
                    brneml = this.txtbrneml.Text.Trim();
                    brncon = this.txtbrncon.Text.Trim();
                    brnfax = this.txtbrnfax.Text.Trim();
                    brnbcrg = this.txtbrnbcrg.Text.Trim();
                    brnbcrgETF = this.cmbbrnETF.Text.Trim();
                    brnsts = this.cmbbrnsts.Text.Trim();
                    brndsc = this.txtbrndsc.Text.Trim();
                    brndepno = Convert.ToInt32(this.txtbrndepno.Text.Trim());
                    brndepnm = this.txtbrndepnm.Text.Trim();
                    brndeploc = this.txtbrndeploc.Text.Trim();
                    brndepempno = this.txtbrndepempno.Text.Trim();

                    BranchDB brnDB = new BranchDB();
                    brnDB.addData(brnrecno, brnno, brndepno, brnname, brnadr1, brnadr2, brneml, brncon, brnfax, brnbcrg, brnbcrgETF, brnsts, brndsc, brndepnm, brndeploc, brndepempno);

                    clear();

                    this.txtbrnrec.Text = Convert.ToString(brnDB.GetNextNo());
                    MessageBox.Show("Succesfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Clear method
        public void clear()
        {
            this.txtbrnno.Text = "";
            this.txtbrnnm.Text = "";
            this.txtbrnadr1.Text = "";
            this.txtbrnadr2.Text = "";
            this.txtbrneml.Text = "";
            this.txtbrncon.Text = "";
            this.txtbrnfax.Text = "";
            this.txtbrnbcrg.Text = "";
            this.cmbbrnETF.SelectedIndex = -1;
            this.cmbbrnsts.SelectedIndex = -1;
            this.txtbrndsc.Text = "";
            this.txtbrndepno.Text = "";
            this.txtbrndepnm.Text = "";
            this.txtbrndeploc.Text = "";
            this.txtbrndepempno.Text = "";
        }

        //Search data
        private void btnbrnsrh1_Click(object sender, EventArgs e)
        {
            try
            {
                int brnno = Convert.ToInt32(this.txtbrnno.Text.ToString());

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String SrhDt = "select * from Branch where (No ='" + brnno + "')";

                cmd1.CommandText = SrhDt;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.txtbrnnm.Text = dr[1].ToString();
                    this.txtbrnadr1.Text = dr[2].ToString();
                    this.txtbrnadr2.Text = dr[15].ToString();
                    this.txtbrneml.Text = dr[3].ToString();
                    this.txtbrncon.Text = dr[4].ToString();
                    this.txtbrnfax.Text = dr[5].ToString();
                    this.txtbrnbcrg.Text = dr[6].ToString();
                    this.cmbbrnETF.SelectedItem = dr[7].ToString();
                    this.cmbbrnsts.SelectedItem = dr[12].ToString();
                    this.txtbrndsc.Text = dr[13].ToString();
                    this.txtbrndepno.Text = dr[8].ToString();
                    this.txtbrndepnm.Text = dr[9].ToString();
                    this.txtbrndeploc.Text = dr[10].ToString();
                    this.txtbrndepempno.Text = dr[11].ToString();
                    this.txtbrnrec.Text = dr[14].ToString();
                }

                conn.Close();
                conn.Dispose();

                disable();
                this.btnbrncrt.Visible = false;
            }
            catch
            {
                MessageBox.Show("Please Enter No...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void disable()
        {
            this.txtbrnnm.Enabled = false;
            this.txtbrnadr1.Enabled = false;
            this.txtbrnadr2.Enabled = false;
            this.txtbrneml.Enabled = false;
            this.txtbrncon.Enabled = false;
            this.txtbrnfax.Enabled = false;
            this.txtbrnbcrg.Enabled = false;
            this.cmbbrnETF.Enabled = false;
            this.cmbbrnsts.Enabled = false;
            this.txtbrndsc.Enabled = false;
            this.txtbrndepno.Enabled = false;
            this.txtbrndepnm.Enabled = false;
            this.txtbrndeploc.Enabled = false;
            this.txtbrndepempno.Enabled = false;
        }

        private void btnbrnsrh2_Click(object sender, EventArgs e)
        {
            try
            {
                String brnname = this.txtbrnnm.Text.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String SrhDt = "select * from Branch where (Name ='" + brnname + "')";

                cmd1.CommandText = SrhDt;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.txtbrnno.Text = dr[0].ToString();
                    this.txtbrnnm.Text = dr[1].ToString();
                    this.txtbrnadr1.Text = dr[2].ToString();
                    this.txtbrnadr2.Text = dr[15].ToString();
                    this.txtbrneml.Text = dr[3].ToString();
                    this.txtbrncon.Text = dr[4].ToString();
                    this.txtbrnfax.Text = dr[5].ToString();
                    this.txtbrnbcrg.Text = dr[6].ToString();
                    this.cmbbrnETF.SelectedItem = dr[7].ToString();
                    this.cmbbrnsts.SelectedItem = dr[12].ToString();
                    this.txtbrndsc.Text = dr[13].ToString();
                    this.txtbrndepno.Text = dr[8].ToString();
                    this.txtbrndepnm.Text = dr[9].ToString();
                    this.txtbrndeploc.Text = dr[10].ToString();
                    this.txtbrndepempno.Text = dr[11].ToString();
                    this.txtbrnrec.Text = dr[14].ToString();
                }

                conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Please Enter Name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbrnudt_Click(object sender, EventArgs e)
        {
            brnrecno = Convert.ToInt32(this.txtbrnrec.Text.Trim());
            brnno = Convert.ToInt32(this.txtbrnno.Text.Trim());
            brnname = this.txtbrnnm.Text.Trim();
            brnadr1 = this.txtbrnadr1.Text.Trim();
            brnadr2 = this.txtbrnadr2.Text.Trim();
            brneml = this.txtbrneml.Text.Trim();
            brncon = this.txtbrncon.Text.Trim();
            brnfax = this.txtbrnfax.Text.Trim();
            brnbcrg = this.txtbrnbcrg.Text.Trim();
            brnbcrgETF = this.cmbbrnETF.Text.Trim();
            brnsts = this.cmbbrnsts.Text.Trim();
            brndsc = this.txtbrndsc.Text.Trim();
            brndepno = Convert.ToInt32(this.txtbrndepno.Text.Trim());
            brndepnm = this.txtbrndepnm.Text.Trim();
            brndeploc = this.txtbrndeploc.Text.Trim();
            brndepempno = this.txtbrndepempno.Text.Trim();

            BranchDB UpdBrn = new BranchDB();
            UpdBrn.UpdateData(brnrecno, brnno, brndepno, brnname, brnadr1, brnadr2, brneml, brncon, brnfax, brnbcrg, brnbcrgETF, brnsts, brndsc, brndepnm, brndeploc, brndepempno);

            clear();

            this.txtbrnrec.Text = Convert.ToString(UpdBrn.GetNextNo());
            MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbrndlt_Click(object sender, EventArgs e)
        {
            BranchDB DltBrn = new BranchDB();
            int brnrecno = Convert.ToInt32(this.txtbrnrec.Text.ToString());
            DltBrn.DeleteData(brnrecno);
            clear();

            MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtbrnrec.Text = Convert.ToString(DltBrn.GetNextNo());
            

        }

        private void btnbrnedt_Click(object sender, EventArgs e)
        {
            enable();
            this.btnbrnedt.Visible = false;
            this.btnbrnudt.Visible = true;
            this.btnbrndlt.Visible = true;
        }

        private void enable()
        {
            this.txtbrnnm.Enabled = true;
            this.txtbrnadr1.Enabled = true;
            this.txtbrnadr2.Enabled = true;
            this.txtbrneml.Enabled = true;
            this.txtbrncon.Enabled = true;
            this.txtbrnfax.Enabled = true;
            this.txtbrnbcrg.Enabled = true;
            this.cmbbrnETF.Enabled = true;
            this.cmbbrnsts.Enabled = true;
            this.txtbrndsc.Enabled = true;
            this.txtbrndepno.Enabled = true;
            this.txtbrndepnm.Enabled = true;
            this.txtbrndeploc.Enabled = true;
            this.txtbrndepempno.Enabled = true;
        }

        private void btnbrnrst_Click(object sender, EventArgs e)
        {
            clear();
            BranchDB brnDB = new BranchDB();
            this.txtbrnrec.Text = Convert.ToString(brnDB.GetNextNo());
        }

        private void txtbrnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbrndepno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbrndepempno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
