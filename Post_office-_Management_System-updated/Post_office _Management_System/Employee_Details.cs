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
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        string emppsnnm1, emppsnnm2, emppsnfnm, emppsnnic, emppsnpsn, emppsncmu, emppsneml, empeduol1, empedual1, empeduaql, empedudes, empwrkdes,
           empoffepf, empoffbrnno, empoffdep, empdesig, empoffsts, empoffdes, emprec, empeduol2, empedual2, empoffbrnnm;
        int emppsncon1, emppsncon2, empwrkdrt;


        DateTime emppsnbd, empoffapp;

        private void grpbxempwrk_Enter(object sender, EventArgs e)
        {

        }

        //home button
        private void btbemphm_Click(object sender, EventArgs e)
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
                string genaretemprec = "Select max(Rec_No) from Employee";

                cmd1.CommandText = genaretemprec;
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
        private void Employee_Details_Load(object sender, EventArgs e)
        {
            this.txtemprec.Text = Convert.ToString(GetNextNo());

            this.txtemprec.Enabled = false;
            this.txtempoffbrnno.Enabled = false;

            this.btnempbck.Visible = false;
            this.btnempdlt.Visible = false;
            this.btnempedt.Visible = false;
            this.btnempudt.Visible = false;

            desig();
            dep();
            brnchnm();

        }

        //create button
        private void btnempcrt_Click(object sender, EventArgs e)
        {
            String pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            String nic = @"^([0-9]{9})[vV]$|^([0-9]{12})$";

            if (String.IsNullOrEmpty(cmbemppsnnm.Text) || String.IsNullOrEmpty(txtemppsnnm.Text) || String.IsNullOrEmpty(txtemppsnfnm.Text) || String.IsNullOrEmpty(txtemppsnnic.Text) || String.IsNullOrEmpty(txtemppsnpsn.Text) || String.IsNullOrEmpty(txtemppsncmu.Text) || String.IsNullOrEmpty(txtemppsneml.Text) || String.IsNullOrEmpty(cmbempeduol.Text) || String.IsNullOrEmpty(cmbempedual.Text) || String.IsNullOrEmpty(cmbempeduaql.Text) || String.IsNullOrEmpty(txtempedudes.Text) || String.IsNullOrEmpty(txtempoffepf.Text) || String.IsNullOrEmpty(txtempoffbrnno.Text) || String.IsNullOrEmpty(cmbempoffdep.Text) || String.IsNullOrEmpty(cmbempdesig.Text) || String.IsNullOrEmpty(cmbempoffsts.Text) || String.IsNullOrEmpty(dtpempoffapp.Text) || String.IsNullOrEmpty(txtempoffdes.Text) || String.IsNullOrEmpty(dtpemppsnbd.Text) || String.IsNullOrEmpty(txtemppsncon1.Text) || String.IsNullOrEmpty(txtemppsncon2.Text) || String.IsNullOrEmpty(txtempwrkdrt.Text))
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check All Fields And submit again", "Message");
            }
            else if (!Regex.IsMatch(this.txtemppsnnic.Text.Trim(), nic))
            {
                MessageBox.Show("Invalid NIC No","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(this.txtemppsneml.Text.Trim(), pattern))
            {
                MessageBox.Show("Invalid Email Email");
            }
            else
            {

                try
                {
                    emppsnnm1 = this.cmbemppsnnm.Text.Trim();
                    emppsnnm2 = this.txtemppsnnm.Text.Trim();
                    emppsnfnm = this.txtemppsnfnm.Text.Trim();
                    emppsnnic = this.txtemppsnnic.Text.Trim();
                    emppsnbd = Convert.ToDateTime(this.dtpemppsnbd.Text.Trim());
                    emppsnpsn = this.txtemppsnpsn.Text.Trim();
                    emppsncmu = this.txtemppsncmu.Text.Trim();
                    emppsneml = this.txtemppsneml.Text.Trim();
                    emppsncon1 = Convert.ToInt32(this.txtemppsncon1.Text.Trim());
                    emppsncon2 = Convert.ToInt32(this.txtemppsncon2.Text.Trim());

                    empeduol1 = this.cmbempeduol.Text.Trim();
                    empeduol2 = this.txtempeduol.Text.Trim();
                    empedual1 = this.cmbempedual.Text.Trim();
                    empedual2 = this.txtempedual.Text.Trim();
                    empeduaql = this.cmbempeduaql.Text.Trim();
                    empedudes = this.txtempedudes.Text.Trim();

                    empwrkdrt = Convert.ToInt32(this.txtempwrkdrt.Text.Trim());
                    empwrkdes = this.txtempwrkdes.Text.Trim();

                    empoffepf = this.txtempoffepf.Text.Trim();
                    empoffbrnno = this.txtempoffbrnno.Text.Trim();
                    empoffbrnnm = this.cmbempoffbrnnm.Text.Trim();
                    empoffdep = this.cmbempoffdep.Text.Trim();
                    empdesig = this.cmbempdesig.Text.Trim();
                    empoffapp = Convert.ToDateTime(this.dtpempoffapp.Text.Trim());
                    empoffsts = this.cmbempoffsts.Text.Trim();
                    empoffdes = this.txtempoffdes.Text.Trim();
                    emprec = this.txtemprec.Text.Trim();

                    //String inisialName = emppsnnm1 + " " + emppsnnm2;

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String addD = "insert into Employee  values('" + emppsnnm2 + "','" + emppsnfnm + "','" + emppsnnic + "','" + emppsnbd + "','" + emppsnpsn + "', '" + emppsncmu + "', '" + emppsneml + "','" + emppsncon1 + "','" + emppsncon2 + "','" + empeduol1 + "','" + empedual1 + "','" + empeduaql + "','" + empwrkdrt + "','" + empwrkdes + "','" + empoffepf + "','" + empoffbrnno + "', '" + empoffdep + "','" + empdesig + "','" + empoffapp + "','" + empoffsts + "','" + empoffdes + "','" + emprec + "','" + empeduol2 + "','" + empedual2 + "','" + empedudes + "','" + empoffbrnnm + "','" + emppsnnm1 + "')";

                    cmd1.CommandText = addD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    this.txtemprec.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");
                    Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("        Data Can't Insert", "Message");
                }

            }
        }

        //search button
        private void btnempsrh_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtemppsnnic.Text))
            {
                MessageBox.Show("        Please Enter A Valid Employee NIC Number", "Message");
            }
            else
            {
                String emppsnnic = this.txtemppsnnic.Text.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String dtsrch = "select * from Employee where (NIC_No ='" + emppsnnic + "')";

                cmd1.CommandText = dtsrch;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {


                    this.txtemppsnnm.Text = dr[0].ToString();
                    this.txtemppsnfnm.Text = dr[1].ToString();
                    this.dtpemppsnbd.Text = dr[3].ToString();
                    this.txtemppsnpsn.Text = dr[4].ToString();
                    this.txtemppsncmu.Text = dr[5].ToString();
                    this.txtemppsneml.Text = dr[6].ToString();
                    this.txtemppsncon1.Text = dr[7].ToString();
                    this.txtemppsncon2.Text = dr[8].ToString();

                    this.cmbempeduol.SelectedItem = dr[9].ToString();
                    this.txtempeduol.Text = dr[22].ToString();
                    this.cmbempedual.SelectedItem = dr[10].ToString();
                    this.txtempedual.Text = dr[23].ToString();
                    this.cmbempeduaql.SelectedItem = dr[11].ToString();
                    this.txtempedudes.Text = dr[24].ToString();

                    this.txtempwrkdrt.Text = dr[12].ToString();
                    this.txtempwrkdes.Text = dr[13].ToString();

                    this.txtempoffepf.Text = dr[14].ToString();
                    this.txtempoffbrnno.Text = dr[15].ToString();
                    this.cmbempoffdep.SelectedItem = dr[16].ToString();
                    this.cmbempdesig.SelectedItem = dr[17].ToString();
                    this.dtpempoffapp.Text = dr[18].ToString();
                    this.cmbempoffsts.SelectedItem = dr[19].ToString();
                    this.txtempoffdes.Text = dr[20].ToString();

                    this.txtemprec.Text = dr[21].ToString();
                    this.cmbempoffbrnnm.Text = dr[25].ToString();
                    this.cmbemppsnnm.SelectedItem = dr[26].ToString();

                }

                conn.Close();
                conn.Dispose();

                this.btnempedt.Visible = true;
                this.btnempcrt.Visible = false;
                this.btnempdlt.Visible = true;

                Disable();

            }

        }

        //edit btn
        private void btnempedt_Click_1(object sender, EventArgs e)
        {
            this.btnempsrh.Visible = false;
            this.btnempbck.Visible = true;
            this.btnempudt.Visible = true;
            this.btnempedt.Visible = false;

            Enable();
            this.txtempoffbrnno.Enabled = false;
            this.txtemprec.Enabled = false;
            this.txtemppsnnic.Enabled = false;

        }

        //update button
        private void btnempudt_Click(object sender, EventArgs e)
        {
            try
            {
                emppsnnm1 = this.cmbemppsnnm.Text.Trim();
                emppsnnm2 = this.txtemppsnnm.Text.Trim();
                emppsnfnm = this.txtemppsnfnm.Text.Trim();
                emppsnnic = this.txtemppsnnic.Text.Trim();
                emppsnbd = Convert.ToDateTime(this.dtpemppsnbd.Text.Trim());
                emppsnpsn = this.txtemppsnpsn.Text.Trim();
                emppsncmu = this.txtemppsncmu.Text.Trim();
                emppsneml = this.txtemppsneml.Text.Trim();
                emppsncon1 = Convert.ToInt32(this.txtemppsncon1.Text.Trim());
                emppsncon2 = Convert.ToInt32(this.txtemppsncon2.Text.Trim());

                empeduol1 = this.cmbempeduol.Text.Trim();
                empeduol2 = this.txtempeduol.Text.Trim();
                empedual1 = this.cmbempedual.Text.Trim();
                empedual2 = this.txtempedual.Text.Trim();
                empeduaql = this.cmbempeduaql.Text.Trim();
                empedudes = this.txtempedudes.Text.Trim();

                empwrkdrt = Convert.ToInt32(this.txtempwrkdrt.Text.Trim());
                empwrkdes = this.txtempwrkdes.Text.Trim();

                empoffepf = this.txtempoffepf.Text.Trim();
                empoffbrnno = this.txtempoffbrnno.Text.Trim();
                empoffbrnnm = this.cmbempoffbrnnm.Text.Trim();
                empoffdep = this.cmbempoffdep.Text.Trim();
                empdesig = this.cmbempdesig.Text.Trim();
                empoffapp = Convert.ToDateTime(this.dtpempoffapp.Text.Trim());
                empoffsts = this.cmbempoffsts.Text.Trim();
                empoffdes = this.txtempoffdes.Text.Trim();
                emprec = this.txtemprec.Text.Trim();



                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String empedt = "UPDATE Employee SET Name_with_Initials  = '" + emppsnnm2 + "', Full_Name = '" + emppsnfnm + "', DOB = '" + emppsnbd + "', Prsnl_Add = '" + emppsnpsn + "', Cmnction_Add = '" + emppsncmu + "', Email = '" + emppsneml + "', Con_No1 = '" + emppsncon1 + "', Con_No2 = '" + emppsncon2 + "', [O/L] = '" + empeduol1 + "', [A/L] ='" + empedual1 + "', Other_Qualification = '" + empeduaql + "', WEDuration = '" + empwrkdrt + "', WEDescription = '" + empwrkdes + "', EPF_ETF_No = '" + empoffepf + "', Branch_No = '" + empoffbrnno + "', Department = '" + empoffdep + "', Designation = '" + empdesig + "', Appointment_Date = '" + empoffapp + "', Status = '" + empoffsts + "', Description = '" + empoffdes + "', Rec_No = '" + emprec + "', OL_Des = '" + empeduol2 + "', AL_Des = '" + empedual2 + "', OQ_Des = '" + empedudes + "', Branch_Name = '" + empoffbrnnm + "', MR_Mrs = '" + emppsnnm1 + "' WHERE NIC_No = '" + emppsnnic + "'";

                cmd1.CommandText = empedt;
                cmd1.Connection = conn;
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();


                MessageBox.Show("        Succesfully Updated", "Message");
                this.txtemprec.Text = Convert.ToString(GetNextNo());
                Rfresh();
            }

            catch (Exception)
            {
                MessageBox.Show("           Data can't Insert", "Message");
            }
        }

        //back button
        private void btnempbck_Click(object sender, EventArgs e)
        {
            this.btnempsrh.Visible = true;
            this.btnempbck.Visible = false;
            this.btnempudt.Visible = false;
            this.btnempedt.Visible = true;

            Disable();
            this.txtempoffbrnno.Enabled = false;
            this.txtemprec.Enabled = false;
            this.txtemppsnnic.Enabled = true;
        }

        //delete button
        private void btnempdlt_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String empdlt = "delete from Employee where NIC_No ='" + emppsnnic + "'";

            cmd1.CommandText = empdlt;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();


            MessageBox.Show("        Succesfully Deleted", "Message");
            this.txtemprec.Text = Convert.ToString(GetNextNo());
            Rfresh();
        }

        //All Filed Clear Method
        private void Clear()
        {
            this.cmbemppsnnm.SelectedIndex = -1;
            this.txtemppsnnm.Text = "";
            this.txtemppsnfnm.Text = "";
            this.txtemppsnnic.Text = "";
            this.dtpemppsnbd.Text = "";
            this.txtemppsnpsn.Text = "";
            this.txtemppsncmu.Text = "";
            this.txtemppsneml.Text = "";
            this.txtemppsncon1.Text = "";
            this.txtemppsncon2.Text = "";
            this.cmbempeduol.SelectedIndex = -1;
            this.cmbempedual.SelectedIndex = -1;
            this.cmbempeduaql.SelectedIndex = -1;
            this.txtempedudes.Text = "";
            this.txtempwrkdrt.Text = "";
            this.txtempwrkdes.Text = "";
            this.txtempoffepf.Text = "";
            this.txtempoffbrnno.Text = "";
            this.cmbempoffdep.SelectedIndex = -1;
            this.cmbempdesig.SelectedIndex = -1;
            this.dtpempoffapp.Text = "";
            this.cmbempoffsts.SelectedIndex = -1;
            this.txtempoffdes.Text = "";
            this.txtempeduol.Text = "";
            this.txtempedual.Text = "";
            this.txtempedudes.Text = "";
            this.cmbempoffbrnnm.SelectedIndex = -1;
        }

        //branch name load
        private void brnchnm()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String brnch = "select Name from Branch";
            cmd1.CommandText = brnch;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                this.cmbempoffbrnnm.Items.Add(dr["Name"]);
            }
        }

        //branch-no load
        private void cmbempoffbrnnm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String Brnchno = this.cmbempoffbrnnm.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String branchno = "select No from Branch where (Name='" + Brnchno + "')";
                cmd1.CommandText = branchno;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    this.txtempoffbrnno.Text = dr["No"].ToString();

                }
            }
            catch
            {

            }
            
        }

        //deparments load to combobox
        private void dep()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String Desig = "select Dep_Name from Branch";
            cmd1.CommandText = Desig;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                this.cmbempoffdep.Items.Add(dr["Dep_Name"]);
            }
        }

        //designations load to combobox
        private void desig()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String Desig = "select Name from Designation";
            cmd1.CommandText = Desig;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                this.cmbempdesig.Items.Add(dr["Name"]);
            }
        }

        //input enable
        private void Enable()
        {
            this.txtemppsnnm.Enabled = true;
            this.txtemppsnfnm.Enabled = true;
            this.dtpemppsnbd.Enabled = true;
            this.txtemppsnpsn.Enabled = true;
            this.txtemppsncmu.Enabled = true;
            this.txtemppsneml.Enabled = true;
            this.txtemppsncon1.Enabled = true;
            this.txtemppsncon2.Enabled = true;

            this.cmbempeduol.Enabled = true;
            this.txtempeduol.Enabled = true;
            this.cmbempedual.Enabled = true;
            this.txtempedual.Enabled = true;
            this.cmbempeduaql.Enabled = true;
            this.txtempedudes.Enabled = true;

            this.txtempwrkdrt.Enabled = true;
            this.txtempwrkdes.Enabled = true;

            this.txtempoffepf.Enabled = true;
            this.txtempoffbrnno.Enabled = true;
            this.cmbempoffdep.Enabled = true;
            this.cmbempdesig.Enabled = true;
            this.dtpempoffapp.Enabled = true;
            this.cmbempoffsts.Enabled = true;
            this.txtempoffdes.Enabled = true;

            this.txtemprec.Enabled = true;
            this.cmbempoffbrnnm.Enabled = true;
            this.cmbemppsnnm.Enabled = true;
        }

        //input disable 
        private void Disable()
        {
            this.cmbemppsnnm.Enabled = false;
            this.txtemppsnnm.Enabled = false;
            this.txtemppsnfnm.Enabled = false;
            this.dtpemppsnbd.Enabled = false;
            this.txtemppsnpsn.Enabled = false;
            this.txtemppsncmu.Enabled = false;
            this.txtemppsneml.Enabled = false;
            this.txtemppsncon1.Enabled = false;
            this.txtemppsncon2.Enabled = false;

            this.cmbempeduol.Enabled = false;
            this.txtempeduol.Enabled = false;
            this.cmbempedual.Enabled = false;
            this.txtempedual.Enabled = false;
            this.cmbempeduaql.Enabled = false;
            this.txtempedudes.Enabled = false;

            this.txtempwrkdrt.Enabled = false;
            this.txtempwrkdes.Enabled = false;

            this.txtempoffepf.Enabled = false;
            this.txtempoffbrnno.Enabled = false;
            this.cmbempoffdep.Enabled = false;
            this.cmbempdesig.Enabled = false;
            this.dtpempoffapp.Enabled = false;
            this.cmbempoffsts.Enabled = false;
            this.txtempoffdes.Enabled = false;

            this.txtemprec.Enabled = false;
            this.cmbempoffbrnnm.Enabled = false;
            this.cmbemppsnnm.Enabled = false;
        }

        //refresh
        private void Rfresh()
        {
            Clear();
            this.txtemprec.Text = Convert.ToString(GetNextNo());

            this.txtemppsnnic.Enabled = true;
            this.txtemprec.Enabled = false;
            this.txtempoffbrnno.Enabled = false;

            this.btnempbck.Visible = false;
            this.btnempdlt.Visible = false;
            this.btnempedt.Visible = false;
            this.btnempudt.Visible = false;
            this.btnempsrh.Visible = true;
            this.btnempcrt.Visible = true;

            desig();
            dep();
            brnchnm();
        }

        //contact no1
        private void txtemppsncon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //contact no2
        private void txtemppsncon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //duration 
        private void txtempwrkdrt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //birth date
        private void dtpemppsnbd_ValueChanged(object sender, EventArgs e)
        {
            DateTime emppsnbd = Convert.ToDateTime(this.dtpemppsnbd.Text.Trim());

            if (emppsnbd > DateTime.Now.AddDays(0))
            {
                dtpemppsnbd.Text = DateTime.Now.AddDays(0).ToString();
                MessageBox.Show("Enter Correct Birthdate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //appointment date
        private void dtpempoffapp_ValueChanged(object sender, EventArgs e)
        {
            DateTime empoffapp = Convert.ToDateTime(this.dtpempoffapp.Text.Trim());

            if (empoffapp > DateTime.Now.AddDays(0))
            {
                dtpempoffapp.Text = DateTime.Now.AddDays(0).ToString();
                MessageBox.Show("Can't Enter Future Date");
            }
        }

        //nic
        private void txtemppsnnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
