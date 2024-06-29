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
    public partial class Supplier_Details : Form
    {

        public Supplier_Details()
        {
            InitializeComponent();
            AllZiero();
            TableLoad();
            
        }

        DBConnect db = new DBConnect();

        int regNo, recNo, TelNo, ContacNo, Up1, Up2, Up3, Q1, Q2, Q3, Sp1, Sp2, Sp3, Tp1, Tp2, Tp3, AllTp;
        String CompName, CompLocation, CompEmaile, PersonName, PersonDesignation, UName1, UName2, UName3, UType1, UType2, UType3, Status;
        DateTime CreateDate, RecivedDate;
        String value;

        private void loadsalepricelastvalue()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string getvalus = "SELECT * FROM Sales_Price WHERE Status = 'Active' ORDER BY Rec_No ASC";
            cmd1.CommandText = getvalus;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                value = dr["Value"].ToString();
            }
        }

        private void btnsuphm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }


        //-----------Insert Data -----------------------------//
        private void btnsupcrt_Click(object sender, EventArgs e)
        {
            
            String pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            if (String.IsNullOrEmpty(txtsupcomreg.Text) || String.IsNullOrEmpty(txtsupcomnm.Text) || String.IsNullOrEmpty(txtsupcomloc.Text) || String.IsNullOrEmpty(txtsupcomeml.Text) || String.IsNullOrEmpty(txtsupcomdsg.Text) || String.IsNullOrEmpty(txtsupcomtel.Text) || String.IsNullOrEmpty(txtsupcomdsg.Text) || String.IsNullOrEmpty(txtsupcomnmi.Text) || String.IsNullOrEmpty(txtsupcomcon.Text))
            {
                MessageBox.Show("Some field remain vacant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtsupodrTotTtlPrc.Text) || Convert.ToInt32(this.txtsupodrTotTtlPrc.Text.Trim()) == 0)
            {
                MessageBox.Show("Please Calculate Totle Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(this.txtsupcomeml.Text.Trim(), pattern))
            {
                MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {

               try
               {
                    regNo = Convert.ToInt32(this.txtsupcomreg.Text.Trim());
                    recNo = Convert.ToInt32(this.txtrecno.Text.Trim());
                    TelNo = Convert.ToInt32(this.txtsupcomtel.Text.Trim());
                    ContacNo = Convert.ToInt32(this.txtsupcomcon.Text.Trim());
                    Up1 = Convert.ToInt32(this.txtsupodrUntPrc1.Text.Trim());
                    Up2 = Convert.ToInt32(this.txtsupodrUntPrc2.Text.Trim());
                    Up3 = Convert.ToInt32(this.txtsupodrUntPrc3.Text.Trim());
                    Q1 = Convert.ToInt32(this.txtsupodrqty1.Text.Trim());
                    Q2 = Convert.ToInt32(this.txtsupodrqty2.Text.Trim());
                    Q3 = Convert.ToInt32(this.txtsupodrqty3.Text.Trim());
                    Sp1 = Convert.ToInt32(this.txtsupodrTtlPrc1.Text.Trim());
                    Sp2 = Convert.ToInt32(this.txtsupodrTtlPrc2.Text.Trim());
                    Sp3 = Convert.ToInt32(this.txtsupodrTtlPrc3.Text.Trim());
                    Tp1 = Convert.ToInt32(this.txtsupodrSlPrc1.Text.Trim());
                    Tp2 = Convert.ToInt32(this.txtsupodrSlPrc2.Text.Trim());
                    Tp3 = Convert.ToInt32(this.txtsupodrSlPrc3.Text.Trim());
                    AllTp = Convert.ToInt32(this.txtsupodrTotTtlPrc.Text.Trim());

                    CompName = this.txtsupcomnm.Text.Trim();
                    CompLocation = this.txtsupcomloc.Text.Trim();
                    CompEmaile = this.txtsupcomeml.Text.Trim();
                    PersonName = this.txtsupcomnmi.Text.Trim();
                    PersonDesignation = this.txtsupcomdsg.Text.Trim();
                    UName1 = this.cmbsuptimnm1.Text.Trim();
                    UName2 = this.cmbsupitmnm2.Text.Trim();
                    UName3 = this.cmbsupitmnm3.Text.Trim();
                    UType1 = this.cmbsupitmtyp1.Text.Trim();
                    UType2 = this.cmbsupitmtyp2.Text.Trim();
                    UType3 = this.cmbsupitmtyp3.Text.Trim();
                    CreateDate = Convert.ToDateTime(this.dtpsupcdt.Text.Trim());
                    RecivedDate = Convert.ToDateTime(this.dtpsuprdt.Text.Trim());
                    Status = this.cmbsupsts.Text.Trim();

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();
                    String addSPD = "INSERT INTO Supplier_Detail (Reg_No, Rec_No, Name, Address, Email, TellNo, Name_with_Initials, Contact_No, Designation, I_Name1, I_Name2, I_Name3, I_Type1, I_Type2, I_Type3, I_UnitPrice1, I_UnitPrice2, I_UnitPrice3, SalesPrise1, SalesPrise2, SalesPrise3, Quantity1, Quantity2, Quantity3, Create_Date, Receive_Date, Status) VALUES (" +
                            "'" + regNo + "', " +
                            "'" + recNo + "', " +
                            "'" + CompName + "', " +
                            "'" + CompLocation + "', " +
                            "'" + CompEmaile + "', " +
                            "'" + TelNo + "', " +
                            "'" + PersonName + "', " +
                            "'" + ContacNo + "', " +
                            "'" + PersonDesignation + "', " +
                            "'" + UName1 + "', " +
                            "'" + UName2 + "', " +
                            "'" + UName3 + "', " +
                            "'" + UType1 + "', " +
                            "'" + UType2 + "', " +
                            "'" + UType3 + "', " +
                            "'" + Up1 + "', " +
                            "'" + Up2 + "', " +
                            "'" + Up3 + "', " +
                            "'" + Sp1 + "', " +
                            "'" + Sp2 + "', " +
                            "'" + Sp3 + "', " +
                            "'" + Q1 + "', " +
                            "'" + Q2 + "', " +
                            "'" + Q3 + "', " +
                            "'" + CreateDate.ToString("yyyy-MM-dd") + "', " +
                            "'" + RecivedDate.ToString("yyyy-MM-dd") + "', " +
                            "'" + Status + "')";
                    cmd1.CommandText = addSPD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    this.txtrecno.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");
                    Clear();
                    TableLoad();
                }
               catch (Exception ex)
               {
                   MessageBox.Show("Error Creating Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }

        }


        private void Supplier_Details_Load(object sender, EventArgs e)
        {
            this.txtrecno.Text = Convert.ToString(GetNextNo());
            getItemName1();
            getItemName2();
            getItemName3();
            getItemType1();
            getItemType2();
            getItemType3();
            loadsalepricelastvalue();

        }


       

        //Record Number auto Increment Method
        public int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                //SqlCeConnection conn = new SqlCeConnection("Data Source=C:/Users/Anuradha/Documents/Visual Studio vProject/Post_office _Management_System updated/Post_office_Management_System.sdf;Password='POMS@2022'");
                SqlCeCommand cmd1 = new SqlCeCommand();
                string genaretrecNo = "Select max(Rec_No) from Supplier_Detail";
               
                cmd1.CommandText = genaretrecNo;
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

        //Clear Data 
        public void Clear()
        {
            this.txtsupcomreg.Text = "";
            this.txtsupcomnm.Text = "";
            this.txtsupcomloc.Text = "";
            this.txtsupcomeml.Text = "";
            this.txtsupcomtel.Text = "";
            this.txtsupcomnmi.Text = "";
            this.txtsupcomcon.Text = "";
            this.txtsupcomdsg.Text = "";

            AllZiero();
        }


        //All Number Files 0 in satart
        public void AllZiero()
        {
            this.txtsupodrUntPrc1.Text = Convert.ToString(0);
            this.txtsupodrUntPrc2.Text = Convert.ToString(0);
            this.txtsupodrUntPrc3.Text = Convert.ToString(0);

            this.txtsupodrqty1.Text = Convert.ToString(0);
            this.txtsupodrqty2.Text = Convert.ToString(0);
            this.txtsupodrqty3.Text = Convert.ToString(0);

            this.txtsupodrTtlPrc1.Text = Convert.ToString(0);
            this.txtsupodrTtlPrc2.Text = Convert.ToString(0);
            this.txtsupodrTtlPrc3.Text = Convert.ToString(0);


            this.txtsupodrSlPrc1.Text = Convert.ToString(0);
            this.txtsupodrSlPrc2.Text = Convert.ToString(0);
            this.txtsupodrSlPrc3.Text = Convert.ToString(0);

            this.txtsupodrTotTtlPrc.Text = Convert.ToString(0);
        }
   

        private void getItemName1()
        {


            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "Select Name from Item";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbsuptimnm1.Items.Add(dr["Name"].ToString());
            }
        }
        private void getItemName2()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "Select Name from Item";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbsupitmnm2.Items.Add(dr["Name"].ToString());
            }
        }
        private void getItemName3()
        {

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "Select Name from Item";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbsupitmnm3.Items.Add(dr["Name"].ToString());
            }
        }


        private void getItemType1()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "Select Type from Item";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbsupitmtyp1.Items.Add(dr["Type"].ToString());
            }
        }
        private void getItemType2()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "Select Type from Item";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbsupitmtyp2.Items.Add(dr["Type"].ToString());
            }
        }
        private void getItemType3()
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string addD = "Select Type from Item";
            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbsupitmtyp3.Items.Add(dr["Type"].ToString());
            }
        }

        
        //--------Number filed validation---------//
        private void txtsupcomreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsupcomtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsupcomcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrUntPrc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrUntPrc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrUntPrc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrqty1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtsupodrqty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrqty3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrTtlPrc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrTtlPrc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrTtlPrc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrSlPrc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrSlPrc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrSlPrc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsupodrTotTtlPrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void txtsupodrqty1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int up1 = Convert.ToInt32(this.txtsupodrUntPrc1.Text.Trim());
                int q1g = Convert.ToInt32(this.txtsupodrqty1.Text.Trim());

                int tp1s = up1 * q1g;

                this.txtsupodrSlPrc1.Text = Convert.ToString(tp1s);
            }
            catch (Exception)
            {
                this.txtsupodrqty1.Text = Convert.ToString(0);
            }

            
        }

        private void txtsupodrqty2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int up2 = Convert.ToInt32(this.txtsupodrUntPrc2.Text.Trim());
                int q2g = Convert.ToInt32(this.txtsupodrqty2.Text.Trim());

                int tp1s = up2 * q2g;

                this.txtsupodrSlPrc2.Text = Convert.ToString(tp1s);
            }
            catch (Exception)
            {
                this.txtsupodrqty2.Text = Convert.ToString(0);
            }
        }

        private void txtsupodrqty3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int up3 = Convert.ToInt32(this.txtsupodrUntPrc3.Text.Trim());
                int q3g = Convert.ToInt32(this.txtsupodrqty3.Text.Trim());

                int tp1s = up3 * q3g;

                this.txtsupodrSlPrc3.Text = Convert.ToString(tp1s);
            }
            catch (Exception)
            {
                this.txtsupodrqty3.Text = Convert.ToString(0);
            }
        }

        private void btnsupodrcal_Click(object sender, EventArgs e)
        {
            try
            {
                int tp1 = Convert.ToInt32(this.txtsupodrSlPrc1.Text.Trim());
                int tp2 = Convert.ToInt32(this.txtsupodrSlPrc2.Text.Trim());
                int tp3 = Convert.ToInt32(this.txtsupodrSlPrc3.Text.Trim());

                int alltp = tp1 + tp2 + tp3;

                this.txtsupodrTotTtlPrc.Text = Convert.ToString(alltp);
            }
            catch (Exception)
            {
                //this.txtsupodrqty3.Text = Convert.ToString(0);
            }
        }




        //------------Search Data ----------------------------------//
        private void btnsupsrh_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsupcomreg.Text))
            {
                MessageBox.Show("Plice Enter Supplie Reg Number.");
            }
            else
            {
                int spdNo = Convert.ToInt32(this.txtsupcomreg.Text.ToString());

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String SrhDt = "select * from Supplier_Detail where (Reg_No='" + spdNo + "')";

                cmd1.CommandText = SrhDt;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {


                    this.txtsupcomnm.Text = dr[1].ToString();  //recno
                    this.txtsupcomloc.Text = dr[2].ToString(); //address
                    this.txtsupcomeml.Text = dr[3].ToString(); //email
                    this.txtsupcomtel.Text = dr[4].ToString(); //tell no
                    this.txtsupcomnmi.Text = dr[5].ToString(); //name winth insial
                    this.txtsupcomcon.Text = dr[6].ToString(); //contacno
                    this.txtsupcomdsg.Text = dr[7].ToString(); //designation

                    this.cmbsuptimnm1.SelectedItem = dr[8].ToString();
                    this.cmbsupitmnm2.SelectedItem = dr[9].ToString();
                    this.cmbsupitmnm3.SelectedItem = dr[10].ToString();

                    this.cmbsupitmtyp1.SelectedItem = dr[11].ToString();
                    this.cmbsupitmtyp2.SelectedItem = dr[12].ToString();
                    this.cmbsupitmtyp3.SelectedItem = dr[13].ToString();

                    this.txtsupodrUntPrc1.Text = dr[14].ToString();
                    this.txtsupodrUntPrc2.Text = dr[15].ToString();
                    this.txtsupodrUntPrc3.Text = dr[16].ToString();

                    this.txtsupodrSlPrc1.Text = dr[17].ToString();
                    this.txtsupodrSlPrc2.Text = dr[18].ToString();
                    this.txtsupodrSlPrc3.Text = dr[19].ToString();

                    this.txtsupodrqty1.Text = dr[20].ToString();
                    this.txtsupodrqty2.Text = dr[21].ToString();
                    this.txtsupodrqty3.Text = dr[22].ToString();




                    //this.txtsupodrTtlPrc1.Text = dr[1].ToString();
                    //this.txtsupodrTtlPrc2.Text = dr[1].ToString();
                    //this.txtsupodrTtlPrc3.Text = dr[1].ToString();



                    //this.txtsupodrTotTtlPrc.Text = dr[1].ToString();


                    this.dtpsupcdt.Text = dr[23].ToString();
                    this.dtpsuprdt.Text = dr[24].ToString();

                    this.cmbsupsts.SelectedItem = dr[25].ToString();
                    this.txtrecno.Text = dr[26].ToString();

                }

                conn.Close();
                conn.Dispose();
            }
        }

        
        //---------------Update Data  ----------------------------//
        private void btnsupedt_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtsupcomreg.Text))
            {
                MessageBox.Show("Pless enter Register Number");
            }
            else
            {
                try
                {
                    regNo = Convert.ToInt32(this.txtsupcomreg.Text.Trim());
                    //regNo = Convert.ToInt32(this.txtsupcomreg.Text.Trim());
                    recNo = Convert.ToInt32(this.txtrecno.Text.Trim());
                    TelNo = Convert.ToInt32(this.txtsupcomtel.Text.Trim());
                    ContacNo = Convert.ToInt32(this.txtsupcomcon.Text.Trim());
                    Up1 = Convert.ToInt32(this.txtsupodrUntPrc1.Text.Trim());
                    Up2 = Convert.ToInt32(this.txtsupodrUntPrc2.Text.Trim());
                    Up3 = Convert.ToInt32(this.txtsupodrUntPrc3.Text.Trim());
                    Q1 = Convert.ToInt32(this.txtsupodrqty1.Text.Trim());
                    Q2 = Convert.ToInt32(this.txtsupodrqty2.Text.Trim());
                    Q3 = Convert.ToInt32(this.txtsupodrqty3.Text.Trim());
                    Sp1 = Convert.ToInt32(this.txtsupodrTtlPrc1.Text.Trim());
                    Sp2 = Convert.ToInt32(this.txtsupodrTtlPrc2.Text.Trim());
                    Sp3 = Convert.ToInt32(this.txtsupodrTtlPrc3.Text.Trim());
                    Tp1 = Convert.ToInt32(this.txtsupodrSlPrc1.Text.Trim());
                    Tp2 = Convert.ToInt32(this.txtsupodrSlPrc2.Text.Trim());
                    Tp3 = Convert.ToInt32(this.txtsupodrSlPrc3.Text.Trim());
                    AllTp = Convert.ToInt32(this.txtsupodrTotTtlPrc.Text.Trim());

                    CompName = this.txtsupcomnm.Text.Trim();
                    CompLocation = this.txtsupcomloc.Text.Trim();
                    CompEmaile = this.txtsupcomeml.Text.Trim();
                    PersonName = this.txtsupcomnmi.Text.Trim();
                    PersonDesignation = this.txtsupcomdsg.Text.Trim();
                    UName1 = this.cmbsuptimnm1.Text.Trim();
                    UName2 = this.cmbsupitmnm2.Text.Trim();
                    UName3 = this.cmbsupitmnm3.Text.Trim();
                    UType1 = this.cmbsupitmtyp1.Text.Trim();
                    UType2 = this.cmbsupitmtyp2.Text.Trim();
                    UType3 = this.cmbsupitmtyp3.Text.Trim();
                    CreateDate = Convert.ToDateTime(this.dtpsupcdt.Text.Trim());
                    RecivedDate = Convert.ToDateTime(this.dtpsuprdt.Text.Trim());
                    Status = this.cmbsupsts.Text.Trim();

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String addD = "UPDATE Supplier_Detail SET Rec_No = '" + recNo + "', Name = '" + CompName + "', Address = '" + CompLocation + "', Email = '" + CompEmaile + "', TellNo = '" + TelNo + "', Name_with_Initials = '" + PersonName + "', Contact_No = '" + ContacNo + "', Designation = '" + PersonDesignation + "', I_Name1 = '" + UName1 + "', I_Name2 = '" + UName2 + "', I_Name3 = '" + UName3 + "', I_Type1 = '" + UType1 + "', I_Type2 = '" + UType2 + "', I_Type3 = '" + UType3 + "',  I_UnitPrice1 = '" + Up1 + "', I_UnitPrice2 = '" + Up2 + "', I_UnitPrice3 = '" + Up3 + "' , SalesPrise1 = '" + Sp1 + "', SalesPrise2 = '" + Sp2 + "', SalesPrise3 = '" + Sp3 + "', Quantity1 = '" + Q1 + "', Quantity2 = '" + Q2 + "', Quantity3 = '" + Q3 + "', Create_Date = '" + CreateDate + "', Receive_Date = '" + RecivedDate + "', Status = '" + Status + "'   where Reg_No ='" + regNo + "'";
                    cmd1.CommandText = addD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Update Successful..");
                    conn.Close();
                    conn.Dispose();
                    Clear();
                    TableLoad();
                }
                catch(Exception)
                {
                    MessageBox.Show("Update Faild..!");
                }

            }
        }



        private void txtsupodrUntPrc1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int up1 = Convert.ToInt32(this.txtsupodrUntPrc1.Text.Trim());

                int slp = up1 * Convert.ToInt32(value) / 100;

                this.txtsupodrTtlPrc1.Text = Convert.ToString(slp);
            }
            catch (Exception)
            {
                this.txtsupodrTtlPrc1.Text = Convert.ToString(0);
            }
        }

        private void txtsupodrUntPrc2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int up2 = Convert.ToInt32(this.txtsupodrUntPrc2.Text.Trim());
              
                int slp = up2 * Convert.ToInt32(value) / 100;

                this.txtsupodrTtlPrc2.Text = Convert.ToString(slp);
            }
            catch (Exception)
            {
                this.txtsupodrTtlPrc2.Text = Convert.ToString(0);
            }
        }

        private void txtsupodrUntPrc3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int up3 = Convert.ToInt32(this.txtsupodrUntPrc3.Text.Trim());
               
                int slp = up3 * Convert.ToInt32(value) / 100;

                this.txtsupodrTtlPrc3.Text = Convert.ToString(slp);
            }
            catch (Exception)
            {
                this.txtsupodrTtlPrc3.Text = Convert.ToString(0);
            }
        }


        //------------------Delete Data-----------------------//
        private void btnsupdlt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsupcomreg.Text))
            {
                MessageBox.Show("Plice Enter Supplie Reg Number.");
            }
            else
            {

                try
                {
                    int spdNo = Convert.ToInt32(this.txtsupcomreg.Text.ToString());
                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String dataDelete = "DELETE FROM Supplier_Detail WHERE Reg_No='" + spdNo + "' ";

                    cmd1.CommandText = dataDelete;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Delete Successful..");
                    conn.Close();
                    conn.Dispose();
                    Clear();
                    TableLoad();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Delete Faile.." + es);
                }
            }
        }

        //-------------------Loan Suppler data to tabale------------//
        private void TableLoad()
        {
            ItemTable.Items.Clear();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter data = new SqlCeDataAdapter("SELECT * FROM Supplier_Detail", conn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["Reg_No"].ToString());
                listview.SubItems.Add(dr["Name"].ToString());
                listview.SubItems.Add(dr["Name_with_Initials"].ToString());
                listview.SubItems.Add(dr["Contact_No"].ToString());
                listview.SubItems.Add(dr["Status"].ToString());



                ItemTable.Items.Add(listview);
                ItemTable.Show();
            }
        }
    }
}
