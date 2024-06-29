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
    public partial class Package_Delivery_Details : Form
    {
        public Package_Delivery_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        string  Branch_Name, V_Type, V_Driver_Name, Status;
        DateTime Create_Date, Delivery_Date;
        int Rec_No, No, Branch_No, Package_No_1, Package_No_2, Package_No_3, V_No, Quantity_1, Weight_1, Quantity_2, Weight_2, Quantity_3, Weight_3, V_Capacity, Total_Weight;
       
        private void btnpkgdlvhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        private void btnpkgdlvcrt_Click(object sender, EventArgs e)
        {
            String no = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            if (String.IsNullOrEmpty(txtpkgdlvno.Text) || String.IsNullOrEmpty(cmbpkgdlvbrn.Text) || String.IsNullOrEmpty(txtpkgdlvcd.Text) || String.IsNullOrEmpty(cmbpkgdvlPDno1.Text) || String.IsNullOrEmpty(txtpkgdlvttl.Text) || String.IsNullOrEmpty(cmbpkgdlvvcltyp.Text) || String.IsNullOrEmpty(cmbpkgdlvvclno.Text) || String.IsNullOrEmpty(txtpkgdlvttl.Text) || String.IsNullOrEmpty(cmbpkgdlvsts.Text))
            {
                MessageBox.Show("Please Fill All the Field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(this.txtpkgdlvno.Text.Trim(), no))
            {
                MessageBox.Show("Invalid No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else if (String.IsNullOrEmpty(txtpkgdlvttl.Text) || Convert.ToInt32(this.txtpkgdlvttl.Text.Trim()) == 0)
            {
                MessageBox.Show("Please Calculate Totle Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                try
                {
                    Rec_No = Convert.ToInt32(this.txtpkgdlvrec.Text.Trim());
                    No = Convert.ToInt32(this.txtpkgdlvno.Text.Trim());
                    Branch_Name = this.cmbpkgdlvbrn.Text.Trim();
                    Branch_No = Convert.ToInt32(this.txtpkgdlvcd.Text.Trim());

                    Package_No_1 = Convert.ToInt32(this.cmbpkgdvlPDno1.Text.Trim());
                    Quantity_1 = Convert.ToInt32(this.txtpkgdvlPDqua1.Text.Trim());
                    Weight_1 = Convert.ToInt32(this.txtpkgdvlPDwght1.Text.Trim());

                    Package_No_2 = Convert.ToInt32(this.cmbpkgdvlPDno2.Text.Trim());
                    Quantity_2 = Convert.ToInt32(this.txtpkgdvlPDqua2.Text.Trim());
                    Weight_2 = Convert.ToInt32(this.txtpkgdvlPDwght2.Text.Trim());

                    Package_No_3 = Convert.ToInt32(this.cmbpkgdvlPDno3.Text.Trim());
                    Quantity_3 = Convert.ToInt32(this.txtpkgdvlPDqua3.Text.Trim());
                    Weight_3 = Convert.ToInt32(this.txtpkgdvlPDwght3.Text.Trim());

                    Total_Weight = Convert.ToInt32(this.txtpkgdlvttl.Text.Trim());

                    V_Type = this.cmbpkgdlvvcltyp.Text.Trim();
                    V_No = Convert.ToInt32(this.cmbpkgdlvvclno.Text.Trim());
                    V_Capacity = Convert.ToInt32(this.txtpkgdlvvclcap.Text.Trim());
                    V_Driver_Name = this.txtpkgdlvvcldrv.Text.Trim();

                    Create_Date = Convert.ToDateTime(this.dtppkgdlvcdt.Text.Trim());
                    Delivery_Date = Convert.ToDateTime(this.dtppkgdlvdlvdt.Text.Trim());
                    Status = this.cmbpkgdlvsts.Text.Trim();


                    Package_Delivery_DB CD = new Package_Delivery_DB();
                    CD.AddData(Branch_Name, V_Type, V_Driver_Name, Status, Rec_No, No, Branch_No, Package_No_1, Package_No_2, Package_No_3, V_No, Quantity_1, Weight_1, Quantity_2, Weight_2, Quantity_3, Weight_3, V_Capacity, Total_Weight, Create_Date, Delivery_Date);


                    
                    MessageBox.Show("     Succesfully Created", "Message");

                    clear();
                    this.txtpkgdlvrec.Text = Convert.ToString((GetNextNo()));
                   
                    getBranchName();
                    getPkgPackageNo1();
                    getPkgPackageNo2();
                    getPkgPackageNo3();
                    AllZero();

                    LVPkgdlvPkgdtl.Items.Clear();
                    LVPkgdlvdtVhcl.Items.Clear();
                    LVPckdlv.Items.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show(" Created Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Record Number auto Increment Method
        private int GetNextNo()
        {
            try
            {
                int newNo = 0;

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd = new SqlCeCommand();
                string GenerateNo = "Select max(Rec_No) from Package_Delivary";

                cmd.CommandText = GenerateNo;
                cmd.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
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

        
        //clear data

        public void clear()
        {
            this.txtpkgdlvrec.Text = "";
            this.txtpkgdlvno.Text = "";
            this.cmbpkgdlvbrn.Items.Clear();
            this.txtpkgdlvcd.Text = "";
            this.cmbpkgdvlPDno1.Items.Clear();
            this.txtpkgdvlPDqua1.Text = "";
            this.txtpkgdvlPDwght1.Text = "";
            this.cmbpkgdvlPDno2.Items.Clear();
            this.txtpkgdvlPDqua2.Text = "";
            this.txtpkgdvlPDwght2.Text = "";
            this.cmbpkgdvlPDno3.Items.Clear();
            this.txtpkgdvlPDqua3.Text= "";
            this.txtpkgdvlPDwght3.Text = "";
            this.txtpkgdlvttl.Text = "";
            this.cmbpkgdlvvcltyp.Items.Clear();
            this.cmbpkgdlvvclno.Items.Clear();
            this.txtpkgdlvvclcap.Text = "";
            this.txtpkgdlvvcldrv.Text = "";
            this.dtppkgdlvcdt.Value = System.DateTime.Now;
            this.dtppkgdlvdlvdt.Value = System.DateTime.Now;
            this.cmbpkgdlvsts.Items.Clear(); 

           
        }

        //all zero
        private void AllZero()
         {
             this.txtpkgdvlPDqua1.Text = Convert.ToString(0);
             this.txtpkgdvlPDqua2.Text = Convert.ToString(0);
             this.txtpkgdvlPDqua3.Text = Convert.ToString(0);

             this.txtpkgdvlPDwght1.Text = Convert.ToString(0);
             this.txtpkgdvlPDwght2.Text = Convert.ToString(0);
             this.txtpkgdvlPDwght3.Text = Convert.ToString(0);

             this.txtpkgdlvttl.Text = Convert.ToString(0);

         }

        //Form load
        private void Package_Delivery_Details_Load(object sender, EventArgs e)
         {
             //this.txtpkgdlvrec.Enabled = false;

             this.btnpkgdlvupd.Visible = false;
             this.btnpkgdlvedt.Visible = false;
             this.btnpkgdlvdlt.Visible = false;
             this.btnpkgdlvbk.Visible = false;
            
             this.txtpkgdlvrec.Text = Convert.ToString(GetNextNo());
           
             getBranchName();
             getPkgPackageNo1();
             getPkgPackageNo2();
             getPkgPackageNo3();
             AllZero();

             LVPkgdlvPkgdtl.Items.Clear();
             LVPkgdlvdtVhcl.Items.Clear();
             LVPckdlv.Items.Clear();
            

         }

        private void getBranchName()
         {
             SqlCeConnection conn = new SqlCeConnection(db.path);
             SqlCeCommand cmd1 = new SqlCeCommand();
             String addD = "Select Name from Branch";
             cmd1.CommandText = addD;
             cmd1.Connection = conn;
             conn.Open();
             SqlCeDataReader dr = cmd1.ExecuteReader();
             while (dr.Read())
             {
                 cmbpkgdlvbrn.Items.Add(dr["Name"].ToString());
             }
         }

        private void getPkgPackageNo1()
         {
             SqlCeConnection conn = new SqlCeConnection(db.path);
             SqlCeCommand cmd1 = new SqlCeCommand();
             String addD = "Select No from Package";
             cmd1.CommandText = addD;
             cmd1.Connection = conn;
             conn.Open();
             SqlCeDataReader dr = cmd1.ExecuteReader();
             while (dr.Read())
             {
                 cmbpkgdvlPDno1.Items.Add(dr["No"].ToString());
             }
         }

        private void getPkgPackageNo2()
         {

             SqlCeConnection conn = new SqlCeConnection(db.path);
             SqlCeCommand cmd1 = new SqlCeCommand();
             String addD = "Select No from Package";
             cmd1.CommandText = addD;
             cmd1.Connection = conn;
             conn.Open();
             SqlCeDataReader dr = cmd1.ExecuteReader();
             while (dr.Read())
             {
                 cmbpkgdvlPDno2.Items.Add(dr["No"].ToString());
             }
         }

        private void getPkgPackageNo3()
         {

             SqlCeConnection conn = new SqlCeConnection(db.path);
             SqlCeCommand cmd1 = new SqlCeCommand();
             String addD = "Select No from Package";
             cmd1.CommandText = addD;
             cmd1.Connection = conn;
             conn.Open();
             SqlCeDataReader dr = cmd1.ExecuteReader();
             while (dr.Read())
             {
                 cmbpkgdvlPDno3.Items.Add(dr["No"].ToString());
             }
         }

        // Search data

        private void btnpkgdlvsrh_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(txtpkgdlvno.Text))
            {
                MessageBox.Show("Please Enter No...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else
            {

            int No = Convert.ToInt32(this.txtpkgdlvno.Text.ToString());

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd = new SqlCeCommand();

            String SrhDt = "select * from Package_Delivary where (No ='" + No + "')";

            cmd.CommandText = SrhDt;
            cmd.Connection = conn;
            conn.Open();

            SqlCeDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //this.txtpkgdlvno.Text = dr["No"].ToString();
                this.cmbpkgdlvbrn.SelectedItem = dr["Branch_Name"].ToString();
                this.txtpkgdlvcd.Text = dr["Branch_No"].ToString();

                this.cmbpkgdvlPDno1.SelectedItem = dr["Package_No_1"].ToString();
                this.txtpkgdvlPDqua1.Text = dr["Quantity_1"].ToString();
                this.txtpkgdvlPDwght1.Text = dr["Weight_1"].ToString();

                this.cmbpkgdvlPDno2.SelectedItem = dr["Package_No_2"].ToString();
                this.txtpkgdvlPDqua2.Text = dr["Quantity_2"].ToString();
                this.txtpkgdvlPDwght2.Text = dr["Weight_2"].ToString();

                this.cmbpkgdvlPDno3.SelectedItem = dr["Package_No_3"].ToString();
                this.txtpkgdvlPDqua3.Text = dr["Quantity_3"].ToString();
                this.txtpkgdvlPDwght3.Text = dr["Weight_3"].ToString();

                this.txtpkgdlvttl.Text = dr["Total_Weight"].ToString();

                this.cmbpkgdlvsts.SelectedItem = dr["Status"].ToString();
                this.cmbpkgdlvvcltyp.SelectedItem = dr["V_Type"].ToString();
                this.cmbpkgdlvvclno.SelectedItem = dr["V_No"].ToString();
                this.txtpkgdlvvclcap.Text = dr["V_Capacity"].ToString();
                this.txtpkgdlvvcldrv.Text = dr["V_Driver_Name"].ToString();

                this.dtppkgdlvcdt.Text = dr["Create_Date"].ToString();
                this.dtppkgdlvdlvdt.Text = dr["Delivery_Date"].ToString();
                this.cmbpkgdlvsts.SelectedItem = dr["Status"].ToString();
                this.txtpkgdlvrec.Text = dr["Rec_No"].ToString();

                Disable();

                this.btnpkgdlvedt.Visible = true;
                this.btnpkgdlvbk.Visible = true;
                this.btnpkgdlvcrt.Visible = false;
                this.btnpkgdlvsrh.Visible = false;

            }

            else
            {
                MessageBox.Show("Invalid No..!");
                conn.Close();
                clear();
                this.txtpkgdlvrec.Text = Convert.ToString((GetNextNo()));
                addVehicleTypes();
                addStatus();
               
                getBranchName();
                getPkgPackageNo1();
                getPkgPackageNo2();
                getPkgPackageNo3();
                AllZero();

                LVPkgdlvPkgdtl.Items.Clear();
                LVPkgdlvdtVhcl.Items.Clear();
                LVPckdlv.Items.Clear();
            

                this.btnpkgdlvcrt.Visible = true;
                this.btnpkgdlvsrh.Visible = true;
                   
            }
                                                 
                         
            }

            
        }


        private void addStatus()
        {
            this.cmbpkgdlvsts.Items.Add("Pending");
            this.cmbpkgdlvsts.Items.Add("Complete");
            this.cmbpkgdlvsts.Items.Add("Canel");
        }

        private void addVehicleTypes()
        {
            this.cmbpkgdlvvcltyp.Items.Add("Car");
            this.cmbpkgdlvvcltyp.Items.Add("Van");
            this.cmbpkgdlvvcltyp.Items.Add("Motor Bike");
        }


        //Disable code

        public void Disable()
        {

            this.txtpkgdlvrec.Enabled = false;
            this.txtpkgdlvno.Enabled = false;
            this.cmbpkgdlvbrn.Enabled = false;
            this.txtpkgdlvcd.Enabled = false;

            this.cmbpkgdvlPDno1.Enabled = false;
            this.txtpkgdvlPDqua1.Enabled = false;
            this.txtpkgdvlPDwght1.Enabled = false;

            this.cmbpkgdvlPDno2.Enabled = false;
            this.txtpkgdvlPDqua2.Enabled = false;
            this.txtpkgdvlPDwght2.Enabled = false;

            this.cmbpkgdvlPDno3.Enabled = false;
            this.txtpkgdvlPDqua3.Enabled = false;
            this.txtpkgdvlPDwght3.Enabled = false;

            this.txtpkgdlvttl.Enabled = false;

            this.cmbpkgdlvvcltyp.Enabled = false;
            this.cmbpkgdlvvclno.Enabled = false;
            this.txtpkgdlvvclcap.Enabled = false;
            this.txtpkgdlvvcldrv.Enabled = false;

            this.dtppkgdlvcdt.Enabled = false;
            this.dtppkgdlvdlvdt.Enabled = false;
            this.cmbpkgdlvsts.Enabled = false;

        }

        private void cmbpkgdlvbrn_SelectedIndexChanged(object sender, EventArgs e)
        {

            String Name = cmbpkgdlvbrn.SelectedItem.ToString();

            SqlCeConnection conn2 = new SqlCeConnection(db.path);
            SqlCeCommand cmd2 = new SqlCeCommand();

            String addD = "Select * from Branch where( Name = '" + Name + "')";

            cmd2.CommandText = addD;
            cmd2.Connection = conn2;
            conn2.Open();

            SqlCeDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                //cmbpkgdlvvclno.Items.Add(dr["Name"].ToString());
                this.txtpkgdlvcd.Text = dr["No"].ToString();
            }

            this.LlblPkgdlvdtVhcl.Visible = true;
            this.LlblPkgdlvPkgdtl.Visible = true;
            this.LVPkgdlvdtVhcl.Visible = true;
            this.LVPkgdlvPkgdtl.Visible = true;

          

        }

        private void cmbpkgdvlPDno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Package_No1 = cmbpkgdvlPDno1.SelectedItem.ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd12 = new SqlCeCommand();

            String addD = "Select * from Package where( No = '" + Package_No1 + "')";

            cmd12.CommandText = addD;
            cmd12.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd12.ExecuteReader();
            while (dr.Read())
            {
                this.txtpkgdvlPDqua1.Text = dr["Total_Quantity"].ToString();
                this.txtpkgdvlPDwght1.Text = dr["Total_Weight"].ToString();

            }

            select1(Package_No1);

        }

        private void select1(string Package_No1)
        {
            SqlCeConnection conn12 = new SqlCeConnection(db.path);
            SqlCeCommand cmd13 = new SqlCeCommand();

            String addDt = "Select No from Package where(No NOT IN ('" + Package_No1 + "'))";

            cmd13.CommandText = addDt;
            cmd13.Connection = conn12;
            conn12.Open();
            SqlCeDataReader dr1 = cmd13.ExecuteReader();
            while (dr1.Read())
            {
                this.cmbpkgdvlPDno2.Items.Add(dr1["No"].ToString());
            }
        }

        private void cmbpkgdvlPDno2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Package_No1 = cmbpkgdvlPDno1.SelectedItem.ToString();
            string Package_No2 = cmbpkgdvlPDno2.SelectedItem.ToString();

            this.cmbpkgdvlPDno3.Items.Clear();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String addD = "Select * from Package where( No = '" + Package_No2 + "') ";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtpkgdvlPDqua2.Text = dr["Total_Quantity"].ToString();
                this.txtpkgdvlPDwght2.Text = dr["Total_Weight"].ToString();

            }

            select2(Package_No1, Package_No2);

        }

        private void select2(string Package_No1, string Package_No2)
        {
            SqlCeConnection conn12 = new SqlCeConnection(db.path);
            SqlCeCommand cmd13 = new SqlCeCommand();

            string addDt = "Select No from Package where(No NOT IN ('" + Package_No1 + "','" + Package_No2 + "'))";

            cmd13.CommandText = addDt;
            cmd13.Connection = conn12;
            conn12.Open();
            SqlCeDataReader dr1 = cmd13.ExecuteReader();
            while (dr1.Read())
            {
                this.cmbpkgdvlPDno3.Items.Add(dr1["No"].ToString());
            }
        }

        private void cmbpkgdvlPDno3_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Package_No3 = cmbpkgdvlPDno3.SelectedItem.ToString();


            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String addD = "Select * from Package where( No = '" + Package_No3 + "') ";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtpkgdvlPDqua3.Text = dr["Total_Quantity"].ToString();
                this.txtpkgdvlPDwght3.Text = dr["Total_Weight"].ToString();

            }
        }

        private void cmbpkgdlvvcltyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbpkgdlvvclno.Items.Clear();

            string VehType = cmbpkgdlvvcltyp.SelectedItem.ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String addD = "Select * from Vehicle where(Type = '" + VehType + "')";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbpkgdlvvclno.Items.Add(dr["No"].ToString());
            }
        }

        private void cmbpkgdlvvclno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string VehNo = cmbpkgdlvvclno.SelectedItem.ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String addD = "Select * from Vehicle where( No = '" + VehNo + "')";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtpkgdlvvclcap.Text = dr["Capacity"].ToString();
                this.txtpkgdlvvcldrv.Text = dr["Name"].ToString();
            }
        }
        

        //Edit data

        private void btnpkgdlvedt_Click(object sender, EventArgs e)
        {
            Enable();
            this.btnpkgdlvdlt.Visible = true;
            this.btnpkgdlvcrt.Visible = false;
            this.btnpkgdlvupd.Visible = true;
            this.btnpkgdlvbk.Visible = true;
        }

        //Enable Data

        private void Enable()
        {
            this.txtpkgdlvrec.Enabled = true;
            this.txtpkgdlvno.Enabled = true;
            this.cmbpkgdlvbrn.Enabled = true;
            this.txtpkgdlvcd.Enabled = true;

            this.cmbpkgdvlPDno1.Enabled = true;
            this.txtpkgdvlPDqua1.Enabled = true;
            this.txtpkgdvlPDwght1.Enabled = true;

            this.cmbpkgdvlPDno2.Enabled = true;
            this.txtpkgdvlPDqua2.Enabled = true;
            this.txtpkgdvlPDwght2.Enabled = true;

            this.cmbpkgdvlPDno3.Enabled = true;
            this.txtpkgdvlPDqua3.Enabled = true;
            this.txtpkgdvlPDwght3.Enabled = true;
            
            this.txtpkgdlvttl.Enabled = true;

            this.cmbpkgdlvvcltyp.Enabled = true;
            this.cmbpkgdlvvclno.Enabled = true;
            this.txtpkgdlvvclcap.Enabled = true;
            this.txtpkgdlvvcldrv.Enabled = true;

            this.dtppkgdlvcdt.Enabled = true;
            this.dtppkgdlvdlvdt.Enabled = true;
            this.cmbpkgdlvsts.Enabled = true;
        }

        //update data
        private void btnpkgdlvupd_Click(object sender, EventArgs e)
        {


                    int Rec_No = Convert.ToInt32(this.txtpkgdlvrec.Text.Trim());
                    int No = Convert.ToInt32(this.txtpkgdlvno.Text.Trim());
                    string Branch_Name = this.cmbpkgdlvbrn.Text.Trim();
                    int Branch_No = Convert.ToInt32(this.txtpkgdlvcd.Text.Trim());

                    int Package_No_1 = Convert.ToInt32(this.cmbpkgdvlPDno1.Text.Trim());
                    int Quantity_1 = Convert.ToInt32(this.txtpkgdvlPDqua1.Text.Trim());
                    int Weight_1 = Convert.ToInt32(this.txtpkgdvlPDwght1.Text.Trim());

                    int Package_No_2 = Convert.ToInt32(this.cmbpkgdvlPDno2.Text.Trim());
                    int Quantity_2 = Convert.ToInt32(this.txtpkgdvlPDqua2.Text.Trim());
                    int Weight_2 = Convert.ToInt32(this.txtpkgdvlPDwght2.Text.Trim());

                    int Package_No_3 = Convert.ToInt32(this.cmbpkgdvlPDno3.Text.Trim());
                    int Quantity_3 = Convert.ToInt32(this.txtpkgdvlPDqua3.Text.Trim());
                    int Weight_3 = Convert.ToInt32(this.txtpkgdvlPDwght3.Text.Trim());

                    int Total_Weight = Convert.ToInt32(this.txtpkgdlvttl.Text.Trim());

                    string V_Type = this.cmbpkgdlvvcltyp.Text.Trim();
                    int V_No = Convert.ToInt32(this.cmbpkgdlvvclno.Text.Trim());
                    int V_Capacity = Convert.ToInt32(this.txtpkgdlvvclcap.Text.Trim());
                    string V_Driver_Name = this.txtpkgdlvvcldrv.Text.Trim();

                    DateTime Create_Date = Convert.ToDateTime(this.dtppkgdlvcdt.Text.Trim());
                    DateTime Delivery_Date = Convert.ToDateTime(this.dtppkgdlvdlvdt.Text.Trim());
                    string Status = this.cmbpkgdlvsts.Text.Trim();

                    Package_Delivery_DB UD = new Package_Delivery_DB();
                    UD.UpdateData(Rec_No, No, Branch_Name, Branch_No, Package_No_1, Package_No_2, Package_No_3, V_Type, V_No, Quantity_1, Quantity_2, Quantity_3, Weight_1, Weight_2, Weight_3, Total_Weight, V_Capacity, V_Driver_Name, Delivery_Date, Create_Date, Status);

                    clear();

                    this.txtpkgdlvrec.Text = Convert.ToString(UD.GetNextNo());
                    MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    addVehicleTypes();
                    addStatus();

                    getBranchName();
                    getPkgPackageNo1();
                    getPkgPackageNo2();
                    getPkgPackageNo3();
                    AllZero();

                    LVPkgdlvPkgdtl.Items.Clear();
                    LVPkgdlvdtVhcl.Items.Clear();
                    LVPckdlv.Items.Clear();
           
                    this.txtpkgdlvrec.Enabled = false;
                    this.btnpkgdlvsrh.Visible = true;
                    this.btnpkgdlvupd.Visible = false;
                    this.btnpkgdlvedt.Visible = false;
                    this.btnpkgdlvdlt.Visible = false;
                    this.btnpkgdlvcrt.Visible = true;
                    this.btnpkgdlvbk.Visible = false;


       }

        private void btnpkgdlvttl_Click(object sender, EventArgs e)
       {
           try
           {
               int wght1 = Convert.ToInt32(this.txtpkgdvlPDwght1.Text.Trim());
               int wght2 = Convert.ToInt32(this.txtpkgdvlPDwght2.Text.Trim());
               int wght3 = Convert.ToInt32(this.txtpkgdvlPDwght3.Text.Trim());

               int alltp = wght1 + wght2 + wght3;

               int ttlwght = alltp / 1000;

               this.txtpkgdlvttl.Text = Convert.ToString(ttlwght);
           }
           catch (Exception)
           {
               //this.txtcusItmRqDeqty3.Text = Convert.ToString(0);
           }

       }

        private void LlblPkgdlvPkgdtl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           LVPkgdlvPkgdtl.Items.Clear();
           SqlCeConnection conn = new SqlCeConnection(db.path);
           SqlCeDataAdapter data = new SqlCeDataAdapter("select * from Package", conn);
           DataTable dt = new DataTable();
           data.Fill(dt);

           for (int i = 0; i < dt.Rows.Count; i++)
           {
               DataRow dr = dt.Rows[i];
               ListViewItem listview = new ListViewItem(dr["No"].ToString());

               
               listview.SubItems.Add(dr["Total_Quantity"].ToString());
               listview.SubItems.Add(dr["Total_Weight"].ToString());


               LVPkgdlvPkgdtl.Items.Add(listview);
               LVPkgdlvPkgdtl.Show();
           }
       }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           LVPkgdlvdtVhcl.Items.Clear();
           SqlCeConnection conn = new SqlCeConnection(db.path);
           SqlCeDataAdapter data = new SqlCeDataAdapter("select * from Vehicle", conn);
           DataTable dt = new DataTable();
           data.Fill(dt);

           for (int i = 0; i < dt.Rows.Count; i++)
           {
               DataRow dr = dt.Rows[i];
               ListViewItem listview = new ListViewItem(dr["No"].ToString());

               listview.SubItems.Add(dr["Type"].ToString());
               listview.SubItems.Add(dr["Capacity"].ToString());
               listview.SubItems.Add(dr["Name"].ToString());


               LVPkgdlvdtVhcl.Items.Add(listview);
               LVPkgdlvdtVhcl.Show();
           }
       }


        private void Llblpkgdlv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           LVPckdlv.Items.Clear();
           SqlCeConnection conn = new SqlCeConnection(db.path);
           SqlCeDataAdapter data = new SqlCeDataAdapter("select * from Package_Delivary", conn);
           DataTable dt = new DataTable();
           data.Fill(dt);

           for (int i = 0; i < dt.Rows.Count; i++)
           {
               DataRow dr = dt.Rows[i];
               ListViewItem listview = new ListViewItem(dr["No"].ToString());


               listview.SubItems.Add(dr["Branch_Name"].ToString());
               listview.SubItems.Add(dr["Branch_No"].ToString());
               listview.SubItems.Add(dr["Total_Weight"].ToString());
               listview.SubItems.Add(dr["V_Type"].ToString());
               listview.SubItems.Add(dr["V_No"].ToString());
               listview.SubItems.Add(dr["V_Capacity"].ToString());
               listview.SubItems.Add(dr["V_Driver_Name"].ToString());
               listview.SubItems.Add(dr["Create_Date"].ToString());
               listview.SubItems.Add(dr["Delivery_Date"].ToString());
               listview.SubItems.Add(dr["Status"].ToString());



               LVPckdlv.Items.Add(listview);
               LVPckdlv.Show();
           }
       }


        //Delete Data

        private void btnpkgdlvdlt_Click(object sender, EventArgs e)
       {
           if (String.IsNullOrEmpty(txtpkgdlvno.Text))
            {
                MessageBox.Show("Please Enter Your  No...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Package_Delivery_DB DltPDD = new Package_Delivery_DB();
                    int No =Convert.ToInt32(this.txtpkgdlvno.Text.ToString());
                    DltPDD.delete(No);
                    clear();

                    MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtpkgdlvrec.Text = Convert.ToString(GetNextNo());
           
                    LVPckdlv.Items.Clear();
                    clear();
                    Enable();
                    this.txtpkgdlvrec.Text = Convert.ToString((GetNextNo()));

                    addVehicleTypes();
                    addStatus();

                    getBranchName();
                    getPkgPackageNo1();
                    getPkgPackageNo2();
                    getPkgPackageNo3();
                    AllZero();

                    LVPkgdlvPkgdtl.Items.Clear();
                    LVPkgdlvdtVhcl.Items.Clear();
                    LVPckdlv.Items.Clear();
            
                    this.txtpkgdlvrec.Enabled = false;
                    this.btnpkgdlvsrh.Visible = true;
                    this.btnpkgdlvupd.Visible = false;
                    this.btnpkgdlvedt.Visible = false;
                    this.btnpkgdlvdlt.Visible = false;
                    this.btnpkgdlvcrt.Visible = true;
                    this.btnpkgdlvbk.Visible = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Deleted Failed..!");
                }
            }



       }

        private void btnpkgdlvbk_Click(object sender, EventArgs e)
       {
           clear();
           Enable();
           this.txtpkgdlvrec.Text = Convert.ToString((GetNextNo()));
           
           addVehicleTypes();
           addStatus();

           getBranchName();
           getPkgPackageNo1();
           getPkgPackageNo2();
           getPkgPackageNo3();
           AllZero();

           LVPkgdlvPkgdtl.Items.Clear();
           LVPkgdlvdtVhcl.Items.Clear();
           LVPckdlv.Items.Clear();
            
           this.txtpkgdlvrec.Enabled = false;
           this.btnpkgdlvsrh.Visible = true;
           this.btnpkgdlvupd.Visible = false;
           this.btnpkgdlvedt.Visible = false;
           this.btnpkgdlvdlt.Visible = false;
           this.btnpkgdlvcrt.Visible = true;
           this.btnpkgdlvbk.Visible = false;



       }

        private void txtpkgdlvno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }    
}



        
        

