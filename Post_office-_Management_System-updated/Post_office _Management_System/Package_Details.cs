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
    public partial class Package_Details : Form
    {
        public Package_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        int pkgno, pkgrec;
        String pkgnm, pkgfrmt, pkgtot,
               pkgidpt1, pkgidpt2, pkgidpt3, pkgidpt4, pkgidpt5, pkgidpt6,
               pkgidcat1, pkgidcat2, pkgidcat3, pkgidcat4, pkgidcat5, pkgidcat6,
               pkgidit1, pkgidit2, pkgidit3, pkgidit4, pkgidit5, pkgidit6,
               pkgidcno1, pkgidcno2, pkgidcno3, pkgidcno4, pkgidcno5, pkgidcno6,
               pkgidqu1, pkgidqu2, pkgidqu3, pkgidqu4, pkgidqu5, pkgidqu6,
               pkgidw1, pkgidw2, pkgidw3, pkgidw4, pkgidw5, pkgidw6,
               pkgtotqu, pkgtotwe, pkgsts;
        DateTime pkgfrmd, pkgtod, pkgcrdt, pkgdudt;

        private void btnpkgitmhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        private void Package_Details_Load(object sender, EventArgs e)
        {
            this.txtpkgrec.Enabled = false;
            PackageDtDB obj1 = new PackageDtDB();
            this.txtpkgrec.Text = Convert.ToString(obj1.GetNextNo());
            GetBranchName1();

            this.txtpkgidqu1.Enabled = false;
            this.txtpkgidqu2.Enabled = false;
            this.txtpkgidqu3.Enabled = false;
            this.txtpkgidqu4.Enabled = false;
            this.txtpkgidqu5.Enabled = false;
            this.txtpkgidqu6.Enabled = false;
            this.txtpkgidw1.Enabled = false;
            this.txtpkgidw2.Enabled = false;
            this.txtpkgidw3.Enabled = false;
            this.txtpkgidw4.Enabled = false;
            this.txtpkgidw5.Enabled = false;
            this.txtpkgidw6.Enabled = false;

            this.txtpkgidqu1.Text = "0";
            this.txtpkgidqu2.Text = "0";
            this.txtpkgidqu3.Text = "0";
            this.txtpkgidqu4.Text = "0";
            this.txtpkgidqu5.Text = "0";
            this.txtpkgidqu6.Text = "0";
            this.txtpkgidw1.Text = "0";
            this.txtpkgidw2.Text = "0";
            this.txtpkgidw3.Text = "0";
            this.txtpkgidw4.Text = "0";
            this.txtpkgidw5.Text = "0";
            this.txtpkgidw6.Text = "0";

        }

        private void GetBranchName1()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "Select Name from Branch";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbpkgfrmt.Items.Add(dr["Name"].ToString());
            }
        }

        //Create Pkg_dt
        private void btnpkgitmcrt_Click(object sender, EventArgs e)
        {
            pkgrec = Convert.ToInt32(this.txtpkgrec.Text.Trim());
            pkgno = Convert.ToInt32(this.txtpkgno.Text.Trim());
            pkgnm = this.txtpkgnm.Text.Trim();
            pkgfrmd = Convert.ToDateTime(this.dtppkgfrmd.Text.Trim());
            pkgtod = Convert.ToDateTime(this.dtppkgtod.Text.Trim());
            pkgfrmt = this.cmbpkgfrmt.Text.Trim();
            pkgtot = this.cmbpkgtot.Text.Trim();
            pkgidpt1 = this.cmbpkgidpt1.Text.Trim();
            pkgidpt2 = this.cmbpkgidpt2.Text.Trim();
            pkgidpt3 = this.cmbpkgidpt3.Text.Trim();
            pkgidpt4 = this.cmbpkgidpt4.Text.Trim();
            pkgidpt5 = this.cmbpkgidpt5.Text.Trim();
            pkgidpt6 = this.cmbpkgidpt6.Text.Trim();
            pkgidcat1 = this.cmbpkgidcat1.Text.Trim();
            pkgidcat2 = this.cmbpkgidcat2.Text.Trim();
            pkgidcat3 = this.cmbpkgidcat3.Text.Trim();
            pkgidcat4 = this.cmbpkgidcat4.Text.Trim();
            pkgidcat5 = this.cmbpkgidcat5.Text.Trim();
            pkgidcat6 = this.cmbpkgidcat6.Text.Trim();
            pkgidit1 = this.cmbpkgidit1.Text.Trim();
            pkgidit2 = this.cmbpkgidit2.Text.Trim();
            pkgidit3 = this.cmbpkgidit3.Text.Trim();
            pkgidit4 = this.cmbpkgidit4.Text.Trim();
            pkgidit5 = this.cmbpkgidit5.Text.Trim();
            pkgidit6 = this.cmbpkgidit6.Text.Trim();
            pkgidcno1 = this.cmbpkgidcno1.Text.Trim();
            pkgidcno2 = this.cmbpkgidcno2.Text.Trim();
            pkgidcno3 = this.cmbpkgidcno3.Text.Trim();
            pkgidcno4 = this.cmbpkgidcno4.Text.Trim();
            pkgidcno5 = this.cmbpkgidcno5.Text.Trim();
            pkgidcno6 = this.cmbpkgidcno6.Text.Trim();
            pkgidqu1 = this.txtpkgidqu1.Text.Trim();
            pkgidqu2 = this.txtpkgidqu2.Text.Trim();
            pkgidqu3 = this.txtpkgidqu3.Text.Trim();
            pkgidqu4 = this.txtpkgidqu4.Text.Trim();
            pkgidqu5 = this.txtpkgidqu5.Text.Trim();
            pkgidqu6 = this.txtpkgidqu6.Text.Trim();
            pkgidw1 = this.txtpkgidw1.Text.Trim();
            pkgidw2 = this.txtpkgidw2.Text.Trim();
            pkgidw3 = this.txtpkgidw3.Text.Trim();
            pkgidw4 = this.txtpkgidw4.Text.Trim();
            pkgidw5 = this.txtpkgidw5.Text.Trim();
            pkgidw6 = this.txtpkgidw6.Text.Trim();
            pkgtotqu = this.txtpkgtotqu.Text.Trim();
            pkgtotwe = this.txtpkgtotwe.Text.Trim();
            pkgcrdt = Convert.ToDateTime(this.dtppkgcrdt.Text.Trim());
            pkgdudt = Convert.ToDateTime(this.dtppkgdudt.Text.Trim());
            pkgsts = this.cmbpkgsts.Text.Trim();

            PackageDtDB Crtpack = new PackageDtDB();
            Crtpack.AddData(pkgno, pkgrec, pkgnm, pkgfrmt, pkgtot,
               pkgidpt1, pkgidpt2, pkgidpt3, pkgidpt4, pkgidpt5, pkgidpt6,
               pkgidcat1, pkgidcat2, pkgidcat3, pkgidcat4, pkgidcat5, pkgidcat6,
               pkgidit1, pkgidit2, pkgidit3, pkgidit4, pkgidit5, pkgidit6,
               pkgidcno1, pkgidcno2, pkgidcno3, pkgidcno4, pkgidcno5, pkgidcno6,
               pkgidqu1, pkgidqu2, pkgidqu3, pkgidqu4, pkgidqu5, pkgidqu6,
               pkgidw1, pkgidw2, pkgidw3, pkgidw4, pkgidw5, pkgidw6,
               pkgtotqu, pkgtotwe, pkgsts, pkgfrmd, pkgtod, pkgcrdt, pkgdudt);

            clear();

            this.txtpkgrec.Text = Convert.ToString(Crtpack.GetNextNo());
            MessageBox.Show("Succesfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clear()
        {
            this.txtpkgrec.Text = "";
            this.txtpkgno.Text = "";
            this.txtpkgnm.Text = "";
            this.dtppkgfrmd.Value = System.DateTime.Now;
            this.dtppkgtod.Value = System.DateTime.Now;
            this.cmbpkgfrmt.SelectedIndex = -1;
            this.cmbpkgtot.SelectedIndex = -1;
            this.cmbpkgidpt1.SelectedIndex = -1;
            this.cmbpkgidpt2.SelectedIndex = -1;
            this.cmbpkgidpt3.SelectedIndex = -1;
            this.cmbpkgidpt4.SelectedIndex = -1;
            this.cmbpkgidpt5.SelectedIndex = -1;
            this.cmbpkgidpt6.SelectedIndex = -1;
            this.cmbpkgidcat1.SelectedIndex = -1;
            this.cmbpkgidcat2.SelectedIndex = -1;
            this.cmbpkgidcat3.SelectedIndex = -1;
            this.cmbpkgidcat4.SelectedIndex = -1;
            this.cmbpkgidcat5.SelectedIndex = -1;
            this.cmbpkgidcat6.SelectedIndex = -1;
            this.cmbpkgidit1.SelectedIndex = -1;
            this.cmbpkgidit2.SelectedIndex = -1;
            this.cmbpkgidit3.SelectedIndex = -1;
            this.cmbpkgidit4.SelectedIndex = -1;
            this.cmbpkgidit5.SelectedIndex = -1;
            this.cmbpkgidit6.SelectedIndex = -1;
            this.cmbpkgidcno1.SelectedIndex = -1;
            this.cmbpkgidcno2.SelectedIndex = -1;
            this.cmbpkgidcno3.SelectedIndex = -1;
            this.cmbpkgidcno4.SelectedIndex = -1;
            this.cmbpkgidcno5.SelectedIndex = -1;
            this.cmbpkgidcno6.SelectedIndex = -1;
            this.txtpkgidqu1.Text = "";
            this.txtpkgidqu2.Text = "";
            this.txtpkgidqu3.Text = "";
            this.txtpkgidqu4.Text = "";
            this.txtpkgidqu5.Text = "";
            this.txtpkgidqu6.Text = "";
            this.txtpkgidw1.Text = "";
            this.txtpkgidw2.Text = "";
            this.txtpkgidw3.Text = "";
            this.txtpkgidw4.Text = "";
            this.txtpkgidw5.Text = "";
            this.txtpkgidw6.Text = "";
            this.txtpkgtotqu.Text = "";
            this.txtpkgtotwe.Text = "";
            this.dtppkgcrdt.Text = "";
            this.dtppkgdudt.Text = "";
            this.cmbpkgsts.SelectedIndex = -1;
        }

        private void btnpkgitmsrh_Click(object sender, EventArgs e)
        {
            int pkgno = Convert.ToInt32(this.txtpkgno.Text.ToString());

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String SrhDt = "select * from Package where (No ='" + pkgno + "')";

            cmd1.CommandText = SrhDt;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtpkgrec.Text = dr[47].ToString();
                this.txtpkgnm.Text = dr[1].ToString();
                this.dtppkgfrmd.Text = dr[2].ToString();
                this.dtppkgtod.Text = dr[3].ToString();
                this.cmbpkgfrmt.SelectedItem = dr[4].ToString();
                this.cmbpkgtot.SelectedItem = dr[5].ToString();
                this.cmbpkgidpt1.SelectedItem = dr[6].ToString();
                this.cmbpkgidpt2.SelectedItem = dr[7].ToString();
                this.cmbpkgidpt3.SelectedItem = dr[8].ToString();
                this.cmbpkgidpt4.SelectedItem = dr[9].ToString();
                this.cmbpkgidpt5.SelectedItem = dr[10].ToString();
                this.cmbpkgidpt6.SelectedItem = dr[11].ToString();
                this.cmbpkgidcat1.SelectedItem = dr[12].ToString();
                this.cmbpkgidcat2.SelectedItem = dr[13].ToString();
                this.cmbpkgidcat3.SelectedItem = dr[14].ToString();
                this.cmbpkgidcat4.SelectedItem = dr[15].ToString();
                this.cmbpkgidcat5.SelectedItem = dr[16].ToString();
                this.cmbpkgidcat6.SelectedItem = dr[17].ToString();
                this.cmbpkgidit1.SelectedItem = dr[18].ToString();
                this.cmbpkgidit2.SelectedItem = dr[19].ToString();
                this.cmbpkgidit3.SelectedItem = dr[20].ToString();
                this.cmbpkgidit4.SelectedItem = dr[21].ToString();
                this.cmbpkgidit5.SelectedItem = dr[22].ToString();
                this.cmbpkgidit6.SelectedItem = dr[23].ToString();
                this.cmbpkgidcno1.SelectedItem = dr[24].ToString();
                this.cmbpkgidcno2.SelectedItem = dr[25].ToString();
                this.cmbpkgidcno3.SelectedItem = dr[26].ToString();
                this.cmbpkgidcno4.SelectedItem = dr[27].ToString();
                this.cmbpkgidcno5.SelectedItem = dr[28].ToString();
                this.cmbpkgidcno6.SelectedItem = dr[29].ToString();
                this.txtpkgidqu1.Text = dr[30].ToString();
                this.txtpkgidqu2.Text = dr[31].ToString();
                this.txtpkgidqu3.Text = dr[32].ToString();
                this.txtpkgidqu4.Text = dr[33].ToString();
                this.txtpkgidqu5.Text = dr[34].ToString();
                this.txtpkgidqu6.Text = dr[35].ToString();
                this.txtpkgidw1.Text = dr[36].ToString();
                this.txtpkgidw2.Text = dr[37].ToString();
                this.txtpkgidw3.Text = dr[38].ToString();
                this.txtpkgidw4.Text = dr[39].ToString();
                this.txtpkgidw5.Text = dr[40].ToString();
                this.txtpkgidw6.Text =dr[41].ToString();
                this.txtpkgtotqu.Text =dr[42].ToString();
                this.txtpkgtotwe.Text = dr[43].ToString();
                this.dtppkgcrdt.Text = dr[44].ToString();
                this.dtppkgdudt.Text = dr[45].ToString();
                this.cmbpkgsts.SelectedItem = dr[46].ToString();
            }

            conn.Close();
            conn.Dispose();

            Disable();
        }

        private void Disable()
        {
            this.txtpkgno.Enabled = false;
            this.txtpkgnm.Enabled = false;
            this.dtppkgfrmd.Enabled = false;
            this.dtppkgtod.Enabled = false;
            this.cmbpkgfrmt.Enabled = false;
            this.cmbpkgtot.Enabled = false;
            this.cmbpkgidpt1.Enabled = false;
            this.cmbpkgidpt2.Enabled = false;
            this.cmbpkgidpt3.Enabled = false;
            this.cmbpkgidpt4.Enabled = false;
            this.cmbpkgidpt5.Enabled = false;
            this.cmbpkgidpt6.Enabled = false;
            this.cmbpkgidcat1.Enabled = false;
            this.cmbpkgidcat2.Enabled = false;
            this.cmbpkgidcat3.Enabled = false;
            this.cmbpkgidcat4.Enabled = false;
            this.cmbpkgidcat5.Enabled = false;
            this.cmbpkgidcat6.Enabled = false;
            this.cmbpkgidit1.Enabled = false;
            this.cmbpkgidit2.Enabled = false;
            this.cmbpkgidit3.Enabled = false;
            this.cmbpkgidit4.Enabled = false;
            this.cmbpkgidit5.Enabled = false;
            this.cmbpkgidit6.Enabled = false;
            this.cmbpkgidcno1.Enabled = false;
            this.cmbpkgidcno2.Enabled = false;
            this.cmbpkgidcno3.Enabled = false;
            this.cmbpkgidcno4.Enabled = false;
            this.cmbpkgidcno5.Enabled = false;
            this.cmbpkgidcno6.Enabled = false;
            this.txtpkgidqu1.Enabled = false;
            this.txtpkgidqu2.Enabled = false;
            this.txtpkgidqu3.Enabled = false;
            this.txtpkgidqu4.Enabled = false;
            this.txtpkgidqu5.Enabled = false;
            this.txtpkgidqu6.Enabled = false;
            this.txtpkgidw1.Enabled = false;
            this.txtpkgidw2.Enabled = false;
            this.txtpkgidw3.Enabled = false;
            this.txtpkgidw4.Enabled = false;
            this.txtpkgidw5.Enabled = false;
            this.txtpkgidw6.Enabled = false;
            this.txtpkgtotqu.Enabled = false;
            this.txtpkgtotwe.Enabled = false;
            this.dtppkgcrdt.Enabled = false;
            this.dtppkgdudt.Enabled = false;
            this.cmbpkgsts.Enabled = false;
        }

        private void Enable()
        {
            this.txtpkgno.Enabled = true;
            this.txtpkgnm.Enabled = true;
            this.dtppkgfrmd.Enabled = true;
            this.dtppkgtod.Enabled = true;
            this.cmbpkgfrmt.Enabled = true;
            this.cmbpkgtot.Enabled = true;
            this.cmbpkgidpt1.Enabled = true;
            this.cmbpkgidpt2.Enabled = true;
            this.cmbpkgidpt3.Enabled = true;
            this.cmbpkgidpt4.Enabled = true;
            this.cmbpkgidpt5.Enabled = true;
            this.cmbpkgidpt6.Enabled = true;
            this.cmbpkgidcat1.Enabled = true;
            this.cmbpkgidcat2.Enabled = true;
            this.cmbpkgidcat3.Enabled = true;
            this.cmbpkgidcat4.Enabled = true;
            this.cmbpkgidcat5.Enabled = true;
            this.cmbpkgidcat6.Enabled = true;
            this.cmbpkgidit1.Enabled = true;
            this.cmbpkgidit2.Enabled = true;
            this.cmbpkgidit3.Enabled = true;
            this.cmbpkgidit4.Enabled = true;
            this.cmbpkgidit5.Enabled = true;
            this.cmbpkgidit6.Enabled = true;
            this.cmbpkgidcno1.Enabled = true;
            this.cmbpkgidcno2.Enabled = true;
            this.cmbpkgidcno3.Enabled = true;
            this.cmbpkgidcno4.Enabled = true;
            this.cmbpkgidcno5.Enabled = true;
            this.cmbpkgidcno6.Enabled = true;
            this.txtpkgidqu1.Enabled = true;
            this.txtpkgidqu2.Enabled = true;
            this.txtpkgidqu3.Enabled = true;
            this.txtpkgidqu4.Enabled = true;
            this.txtpkgidqu5.Enabled = true;
            this.txtpkgidqu6.Enabled = true;
            this.txtpkgidw1.Enabled = true;
            this.txtpkgidw2.Enabled = true;
            this.txtpkgidw3.Enabled = true;
            this.txtpkgidw4.Enabled = true;
            this.txtpkgidw5.Enabled = true;
            this.txtpkgidw6.Enabled = true;
            this.txtpkgtotqu.Enabled = true;
            this.txtpkgtotwe.Enabled = true;
            this.dtppkgcrdt.Enabled = true;
            this.dtppkgdudt.Enabled = true;
            this.cmbpkgsts.Enabled = true;
        }

        private void cmbpkgfrmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbpkgtot.Items.Clear();
            String branch_1 = cmbpkgfrmt.SelectedItem.ToString();
            select1(branch_1);
        }

        private void select1(string branch_1)
        {
            SqlCeConnection conn12 = new SqlCeConnection(db.path);
            SqlCeCommand cmd13 = new SqlCeCommand();

            string addDt = "Select * from Branch where(Name NOT IN ('" + branch_1 + "'))";

            cmd13.CommandText = addDt;
            cmd13.Connection = conn12;
            conn12.Open();
            
            SqlCeDataReader dr1 = cmd13.ExecuteReader();
            while (dr1.Read())
            {
                this.cmbpkgtot.Items.Add(dr1["Name"].ToString());
            }
          
        }

        private void btnpkgitmupd_Click(object sender, EventArgs e)
        {
            pkgrec = Convert.ToInt32(this.txtpkgrec.Text.Trim());
            pkgno = Convert.ToInt32(this.txtpkgno.Text.Trim());
            pkgnm = this.txtpkgnm.Text.Trim();
            pkgfrmd = Convert.ToDateTime(this.dtppkgfrmd.Text.Trim());
            pkgtod = Convert.ToDateTime(this.dtppkgtod.Text.Trim());
            pkgfrmt = this.cmbpkgfrmt.Text.Trim();
            pkgtot = this.cmbpkgtot.Text.Trim();
            pkgidpt1 = this.cmbpkgidpt1.Text.Trim();
            pkgidpt2 = this.cmbpkgidpt2.Text.Trim();
            pkgidpt3 = this.cmbpkgidpt3.Text.Trim();
            pkgidpt4 = this.cmbpkgidpt4.Text.Trim();
            pkgidpt5 = this.cmbpkgidpt5.Text.Trim();
            pkgidpt6 = this.cmbpkgidpt6.Text.Trim();
            pkgidcat1 = this.cmbpkgidcat1.Text.Trim();
            pkgidcat2 = this.cmbpkgidcat2.Text.Trim();
            pkgidcat3 = this.cmbpkgidcat3.Text.Trim();
            pkgidcat4 = this.cmbpkgidcat4.Text.Trim();
            pkgidcat5 = this.cmbpkgidcat5.Text.Trim();
            pkgidcat6 = this.cmbpkgidcat6.Text.Trim();
            pkgidit1 = this.cmbpkgidit1.Text.Trim();
            pkgidit2 = this.cmbpkgidit2.Text.Trim();
            pkgidit3 = this.cmbpkgidit3.Text.Trim();
            pkgidit4 = this.cmbpkgidit4.Text.Trim();
            pkgidit5 = this.cmbpkgidit5.Text.Trim();
            pkgidit6 = this.cmbpkgidit6.Text.Trim();
            pkgidcno1 = this.cmbpkgidcno1.Text.Trim();
            pkgidcno2 = this.cmbpkgidcno2.Text.Trim();
            pkgidcno3 = this.cmbpkgidcno3.Text.Trim();
            pkgidcno4 = this.cmbpkgidcno4.Text.Trim();
            pkgidcno5 = this.cmbpkgidcno5.Text.Trim();
            pkgidcno6 = this.cmbpkgidcno6.Text.Trim();
            pkgidqu1 = this.txtpkgidqu1.Text.Trim();
            pkgidqu2 = this.txtpkgidqu2.Text.Trim();
            pkgidqu3 = this.txtpkgidqu3.Text.Trim();
            pkgidqu4 = this.txtpkgidqu4.Text.Trim();
            pkgidqu5 = this.txtpkgidqu5.Text.Trim();
            pkgidqu6 = this.txtpkgidqu6.Text.Trim();
            pkgidw1 = this.txtpkgidw1.Text.Trim();
            pkgidw2 = this.txtpkgidw2.Text.Trim();
            pkgidw3 = this.txtpkgidw3.Text.Trim();
            pkgidw4 = this.txtpkgidw4.Text.Trim();
            pkgidw5 = this.txtpkgidw5.Text.Trim();
            pkgidw6 = this.txtpkgidw6.Text.Trim();
            pkgtotqu = this.txtpkgtotqu.Text.Trim();
            pkgtotwe = this.txtpkgtotwe.Text.Trim();
            pkgcrdt = Convert.ToDateTime(this.dtppkgcrdt.Text.Trim());
            pkgdudt = Convert.ToDateTime(this.dtppkgdudt.Text.Trim());
            pkgsts = this.cmbpkgsts.Text.Trim();

            PackageDtDB Updpack = new PackageDtDB();
            Updpack.UpdData(pkgno, pkgrec, pkgnm, pkgfrmt, pkgtot,
               pkgidpt1, pkgidpt2, pkgidpt3, pkgidpt4, pkgidpt5, pkgidpt6,
               pkgidcat1, pkgidcat2, pkgidcat3, pkgidcat4, pkgidcat5, pkgidcat6,
               pkgidit1, pkgidit2, pkgidit3, pkgidit4, pkgidit5, pkgidit6,
               pkgidcno1, pkgidcno2, pkgidcno3, pkgidcno4, pkgidcno5, pkgidcno6,
               pkgidqu1, pkgidqu2, pkgidqu3, pkgidqu4, pkgidqu5, pkgidqu6,
               pkgidw1, pkgidw2, pkgidw3, pkgidw4, pkgidw5, pkgidw6,
               pkgtotqu, pkgtotwe, pkgsts, pkgfrmd, pkgtod, pkgcrdt, pkgdudt);

            clear();

            this.txtpkgrec.Text = Convert.ToString(Updpack.GetNextNo());
            MessageBox.Show("Succesfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnpkgitmedt_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void btnpkgitmdlt_Click(object sender, EventArgs e)
        {
            PackageDtDB DltPack = new PackageDtDB();
            int pkgrec = Convert.ToInt32(this.txtpkgrec.Text.ToString());
            DltPack.DeleteData(pkgrec);
            clear();

            MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtpkgrec.Text = Convert.ToString(DltPack.GetNextNo());
        }

        private void btnpkgitmcal_Click(object sender, EventArgs e)
        {
            txtpkgtotqu.Text = (float.Parse(txtpkgidqu1.Text) + float.Parse(txtpkgidqu2.Text) + float.Parse(txtpkgidqu3.Text) + float.Parse(txtpkgidqu4.Text) + float.Parse(txtpkgidqu5.Text) + float.Parse(txtpkgidqu6.Text)).ToString();
            txtpkgtotwe.Text = (float.Parse(txtpkgidw1.Text) + float.Parse(txtpkgidw2.Text) + float.Parse(txtpkgidw3.Text) + float.Parse(txtpkgidw4.Text) + float.Parse(txtpkgidw5.Text) + float.Parse(txtpkgidw6.Text)).ToString();
        }

        private void txtpkgidqu1_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotqu.Text = "";
        }

        private void txtpkgidqu2_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotqu.Text = "";
        }

        private void txtpkgidqu3_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotqu.Text = "";
        }

        private void txtpkgidqu4_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotqu.Text = "";
        }

        private void txtpkgidqu5_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotqu.Text = "";
        }

        private void txtpkgidqu6_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotqu.Text = "";
        }

        private void txtpkgidw1_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotwe.Text = "";
        }

        private void txtpkgidw2_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotwe.Text = "";
        }

        private void txtpkgidw3_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotwe.Text = "";
        }

        private void txtpkgidw4_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotwe.Text = "";
        }

        private void txtpkgidw5_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotwe.Text = "";
        }

        private void txtpkgidw6_TextChanged(object sender, EventArgs e)
        {
            this.txtpkgtotwe.Text = "";
        }

        private void cmbpkgidcno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtpkgidqu1.Enabled = true;
            getItemDetails();
        }

        private void getItemDetails()
        {
            String type = cmbpkgidpt1.SelectedItem.ToString();
            String category = cmbpkgidcat1.SelectedItem.ToString();
            String item = cmbpkgidit1.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String cusNo = "select NIC_No from Customer where (No ='" + pkgno + "')";

            cmd1.CommandText = cusNo;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            conn.Close();
            conn.Dispose();
        }

        private void cmbpkgidcno2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtpkgidqu2.Enabled = true;
        }

        private void cmbpkgidcno3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtpkgidqu3.Enabled = true;
        }

        private void cmbpkgidcno4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtpkgidqu4.Enabled = true;
        }

        private void cmbpkgidcno5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtpkgidqu5.Enabled = true;
        }

        private void cmbpkgidcno6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtpkgidqu6.Enabled = true;
        }
    }
}
