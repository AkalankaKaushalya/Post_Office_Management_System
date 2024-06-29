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
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        string NIC_No, Name_with_Initials, Address, I_Name_1, I_Type_1, P_Type_1, P_Category_1, P_Item_1, Country_1, I_Name_2, I_Type_2, P_Type_2, P_Category_2, P_Item_2, Weight_1, Weight_2, Weight_3, Country_2, I_Name_3, I_Type_3, P_Type_3, P_Category_3, P_Item_3, Country_3, Status, I_Unit_Price_1, I_Unit_Price_2, I_Unit_Price_3, I_Total_Price_1, I_Total_Price_2, I_Total_Price_3, P_I_Total_Price, I_R_Total_Price, P_Total_Price_1, P_Total_Price_2, P_Total_Price_3, Gross_Price;
        int Rec_No, I_Quantity_1, I_Quantity_2, I_Quantity_3;
        DateTime Create_Date, Delivery_Date;


        private void btnbrnhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();

        }

        //Create Data

        private void btncuscrt_Click(object sender, EventArgs e)
        {
 
            String nic = @"^([0-9]{12})$|^([0-9]{10})[v]$";

            if (String.IsNullOrEmpty(txtcusnic.Text) || String.IsNullOrEmpty(txtcusnmi.Text) || String.IsNullOrEmpty(txtcusadr.Text))
            {
                MessageBox.Show("        Some fields are not complete" + "\n" + "Check All Fields And submit again", "Message");
            }
            else if (!Regex.IsMatch(this.txtcusnic.Text.Trim(), nic))
            {
                MessageBox.Show("Invalid NIC No","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            else
            {
                try
                {
                    Rec_No = Convert.ToInt32(this.txtcusrec.Text.Trim());
                    NIC_No = this.txtcusnic.Text.Trim();
                    Name_with_Initials = this.txtcusnmi.Text.Trim();
                    Address = this.txtcusadr.Text.Trim();
                    I_Name_1 = this.cmbcusItmRqDenm1.Text.Trim();
                    I_Type_1 = this.cmbcusItmRqDetyp1.Text.Trim();
                    I_Unit_Price_1 = this.txtcusItmRqDeUnPrc1.Text.Trim();
                    I_Quantity_1 = Convert.ToInt32(this.txtcusItmRqDeqty1.Text.Trim());
                    I_Total_Price_1 = this.txtcusItmRqDeTtlPrc1.Text.Trim();

                    P_Type_1 = this.cmbcusPstItmDetyp1.Text.Trim();
                    P_Category_1 = this.cmbcusPstItmDeCtgry1.Text.Trim();
                    P_Item_1 = this.cmbcusPstItmDeItm1.Text.Trim();
                    Weight_1 = this.cmbcusPstItmDeWgt1.Text.Trim();
                    Country_1 = this.cmbcusPstItmDeCntry1.Text.Trim();
                    P_Total_Price_1 = this.txtcusPstItmDeTtlPrc1.Text.Trim();


                    I_Name_2 = this.cmbcusItmRqDenm2.Text.Trim();
                    I_Type_2 = this.cmbcusItmRqDetyp2.Text.Trim();
                    I_Unit_Price_2 = this.txtcusItmRqDeUnPrc2.Text.Trim();
                    I_Quantity_2 = Convert.ToInt32(this.txtcusItmRqDeqty2.Text.Trim());
                    I_Total_Price_2 = this.txtcusItmRqDeTtlPrc2.Text.Trim();

                    P_Type_2 = this.cmbcusPstItmDetyp2.Text.Trim();
                    P_Category_2 = this.cmbcusPstItmDeCtgry2.Text.Trim();
                    P_Item_2 = this.cmbcusPstItmDeItm2.Text.Trim();
                    Weight_2 = this.cmbcusPstItmDeWgt2.Text.Trim();
                    Country_2 = this.cmbcusPstItmDeCntry2.Text.Trim();
                    P_Total_Price_2 = this.txtcusPstItmDeTtlPrc2.Text.Trim();


                    I_Name_3 = this.cmbcusItmRqDenm3.Text.Trim();
                    I_Type_3 = this.cmbcusItmRqDetyp3.Text.Trim();
                    I_Unit_Price_3 = this.txtcusItmRqDeUnPrc3.Text.Trim();
                    I_Quantity_3 = Convert.ToInt32(this.txtcusItmRqDeqty3.Text.Trim());
                    I_Total_Price_3 = this.txtcusItmRqDeTtlPrc3.Text.Trim();

                    P_Type_3 = this.cmbcusPstItmDetyp3.Text.Trim();
                    P_Category_3 = this.cmbcusPstItmDeCtgry3.Text.Trim();
                    P_Item_3 = this.cmbcusPstItmDeItm3.Text.Trim();
                    Weight_3 = this.cmbcusPstItmDeWgt3.Text.Trim();
                    Country_3 = this.cmbcusPstItmDeCntry3.Text.Trim();
                    P_Total_Price_3 = this.txtcusPstItmDeTtlPrc3.Text.Trim();

                    I_R_Total_Price = this.txtcusItmRqDeTtlPrcRs.Text.Trim();
                    P_I_Total_Price = this.txtcusPstItmDeTtlPrcRs.Text.Trim();
                    Gross_Price = this.txtcusttl.Text.Trim();

                    Create_Date = Convert.ToDateTime(this.dtpcuscdt.Text.Trim());
                    Delivery_Date = Convert.ToDateTime(this.dtpcusddt.Text.Trim());
                    Status = this.cmbcussts.Text.Trim();


                    Customer_DB Customer_DB1 = new Customer_DB();
                    Customer_DB1.addData(Rec_No, NIC_No, Name_with_Initials, I_R_Total_Price, P_I_Total_Price, Address, I_Name_1, I_Type_1, P_Type_1, P_Category_1, P_Item_1, Country_1, I_Name_2, I_Type_2, P_Type_2, P_Category_2, P_Item_2, Country_2, I_Name_3, I_Type_3, P_Type_3, P_Category_3, P_Item_3, Country_3, Status, I_Unit_Price_1, I_Quantity_1, Weight_1, I_Unit_Price_2, I_Quantity_2, Weight_2, I_Unit_Price_3, I_Quantity_3, Weight_3, I_Total_Price_1, I_Total_Price_2, I_Total_Price_3, P_Total_Price_1, P_Total_Price_2, P_Total_Price_3, Gross_Price, Create_Date, Delivery_Date);

                    clear();

                    this.txtcusrec.Text = Convert.ToString(Customer_DB1.GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");


                    addstatus();
                    addPostType1();
                    addPostType2();
                    addPostType3();

                    addCategory1();
                    addCategory2();
                    addCategory3();

                    addWeight1();
                    addWeight2();
                    addWeight3();

                    addItem1();
                    addItem2();
                    addItem3();

                    addCountry1();
                    addCountry2();
                    addCountry3();

                    getItemName1();
                    getItemName2();
                    getItemName3();
                    getItemType1();
                    getItemType2();
                    getItemType3();
                    Allzero();

                    this.grpbxcusItmRqDe.Enabled = false;
                    this.grpbxcuspstitm.Enabled = false;

                    LVcusdtl.Items.Clear();
                    LVcusItmDe.Items.Clear();
                    LVcusPstItmDe1.Items.Clear();

                  
                }


                catch (Exception)
                {
                    MessageBox.Show("Created Failed!");
                }
        
            }

        }

        //Form Load
        private void Customer_Details_Load(object sender, EventArgs e)
        {
            this.btncusedt.Visible = false;
            this.btncusdlt.Visible = false;
            this.btncusupd.Visible = false;
            this.txtcusrec.Enabled = false;
            this.btncusbk.Visible = false;
            this.grpbxcusItmRqDe.Enabled = false;
            this.grpbxcuspstitm.Enabled = false;
            this.btncusgprc.Enabled = false;
            this.lblcusttl.Enabled = false;
            Customer_DB obj1 = new Customer_DB();
            this.txtcusrec.Text = Convert.ToString(obj1.GetNextNo());

            LVcusdtl.Items.Clear();
            LVcusItmDe.Items.Clear();
            LVcusPstItmDe1.Items.Clear();


            //addstatus();
            //addPostType1();
            //addPostType2();
            //addPostType3();

            //addCategory1();
            //addCategory2();
            //addCategory3();

            //addWeight1();
            //addWeight2();
            //addWeight3();

            //addItem1();
            //addItem2();
            //addItem3();

            //addCountry1();
            //addCountry2();
            //addCountry3();

            getItemName1();
            getItemName2();
            getItemName3();
            getItemType1();
            getItemType2();
            getItemType3();
            Allzero();
                       
        }

        private void addCountry3()
        {
            this.cmbcusPstItmDeCntry3.Items.Add("Australia");
            this.cmbcusPstItmDeCntry3.Items.Add("Bangaladesh");
            this.cmbcusPstItmDeCntry3.Items.Add("Canada");
            this.cmbcusPstItmDeCntry3.Items.Add("China");
            this.cmbcusPstItmDeCntry3.Items.Add("France");
            this.cmbcusPstItmDeCntry3.Items.Add("Germany");
            this.cmbcusPstItmDeCntry3.Items.Add("Iceland");
            this.cmbcusPstItmDeCntry3.Items.Add("India");
            this.cmbcusPstItmDeCntry3.Items.Add("Indonesia");
            this.cmbcusPstItmDeCntry3.Items.Add("Iran");
            this.cmbcusPstItmDeCntry3.Items.Add("Iraq");
            this.cmbcusPstItmDeCntry3.Items.Add("Ireland");
            this.cmbcusPstItmDeCntry3.Items.Add("Italy");
            this.cmbcusPstItmDeCntry3.Items.Add("Japan");
            this.cmbcusPstItmDeCntry3.Items.Add("Malaysia");
            this.cmbcusPstItmDeCntry3.Items.Add("Maldives");
            this.cmbcusPstItmDeCntry3.Items.Add("Nepal");
            this.cmbcusPstItmDeCntry3.Items.Add("Netherlands");
            this.cmbcusPstItmDeCntry3.Items.Add("New Zealand");
            this.cmbcusPstItmDeCntry3.Items.Add("North Korea");
            this.cmbcusPstItmDeCntry3.Items.Add("Philippines");
            this.cmbcusPstItmDeCntry3.Items.Add("Russia");
            this.cmbcusPstItmDeCntry3.Items.Add("Saudi Arabia");
            this.cmbcusPstItmDeCntry3.Items.Add("Singapore");
            this.cmbcusPstItmDeCntry3.Items.Add("United Kingdom");
            this.cmbcusPstItmDeCntry3.Items.Add("United States of America");
        }

        private void addCountry2()
        {
            this.cmbcusPstItmDeCntry2.Items.Add("Australia");
            this.cmbcusPstItmDeCntry2.Items.Add("Bangaladesh");
            this.cmbcusPstItmDeCntry2.Items.Add("Canada");
            this.cmbcusPstItmDeCntry2.Items.Add("China");
            this.cmbcusPstItmDeCntry2.Items.Add("France");
            this.cmbcusPstItmDeCntry2.Items.Add("Germany");
            this.cmbcusPstItmDeCntry2.Items.Add("Iceland");
            this.cmbcusPstItmDeCntry2.Items.Add("India");
            this.cmbcusPstItmDeCntry2.Items.Add("Indonesia");
            this.cmbcusPstItmDeCntry2.Items.Add("Iran");
            this.cmbcusPstItmDeCntry2.Items.Add("Iraq");
            this.cmbcusPstItmDeCntry2.Items.Add("Ireland");
            this.cmbcusPstItmDeCntry2.Items.Add("Italy");
            this.cmbcusPstItmDeCntry2.Items.Add("Japan");
            this.cmbcusPstItmDeCntry2.Items.Add("Malaysia");
            this.cmbcusPstItmDeCntry2.Items.Add("Maldives");
            this.cmbcusPstItmDeCntry2.Items.Add("Nepal");
            this.cmbcusPstItmDeCntry2.Items.Add("Netherlands");
            this.cmbcusPstItmDeCntry2.Items.Add("New Zealand");
            this.cmbcusPstItmDeCntry2.Items.Add("North Korea");
            this.cmbcusPstItmDeCntry2.Items.Add("Philippines");
            this.cmbcusPstItmDeCntry2.Items.Add("Russia");
            this.cmbcusPstItmDeCntry2.Items.Add("Saudi Arabia");
            this.cmbcusPstItmDeCntry2.Items.Add("Singapore");
            this.cmbcusPstItmDeCntry2.Items.Add("United Kingdom");
            this.cmbcusPstItmDeCntry2.Items.Add("United States of America");
        }

        private void addCountry1()
        {
            this.cmbcusPstItmDeCntry1.Items.Add("Australia");
            this.cmbcusPstItmDeCntry1.Items.Add("Bangaladesh");
            this.cmbcusPstItmDeCntry1.Items.Add("Canada");
            this.cmbcusPstItmDeCntry1.Items.Add("China");
            this.cmbcusPstItmDeCntry1.Items.Add("France");
            this.cmbcusPstItmDeCntry1.Items.Add("Germany");
            this.cmbcusPstItmDeCntry1.Items.Add("Iceland");
            this.cmbcusPstItmDeCntry1.Items.Add("India");
            this.cmbcusPstItmDeCntry1.Items.Add("Indonesia");
            this.cmbcusPstItmDeCntry1.Items.Add("Iran");
            this.cmbcusPstItmDeCntry1.Items.Add("Iraq");
            this.cmbcusPstItmDeCntry1.Items.Add("Ireland");
            this.cmbcusPstItmDeCntry1.Items.Add("Italy");
            this.cmbcusPstItmDeCntry1.Items.Add("Japan");
            this.cmbcusPstItmDeCntry1.Items.Add("Malaysia");
            this.cmbcusPstItmDeCntry1.Items.Add("Maldives");
            this.cmbcusPstItmDeCntry1.Items.Add("Nepal");
            this.cmbcusPstItmDeCntry1.Items.Add("Netherlands");
            this.cmbcusPstItmDeCntry1.Items.Add("New Zealand");
            this.cmbcusPstItmDeCntry1.Items.Add("North Korea");
            this.cmbcusPstItmDeCntry1.Items.Add("Philippines");
            this.cmbcusPstItmDeCntry1.Items.Add("Russia");
            this.cmbcusPstItmDeCntry1.Items.Add("Saudi Arabia");
            this.cmbcusPstItmDeCntry1.Items.Add("Singapore");
            this.cmbcusPstItmDeCntry1.Items.Add("United Kingdom");
            this.cmbcusPstItmDeCntry1.Items.Add("United States of America");
        }


        private void addItem3()
        {
            this.cmbcusPstItmDeItm3.Items.Add("Letter");
            this.cmbcusPstItmDeItm3.Items.Add("Parcel");
        }

        private void addItem2()
        {
            this.cmbcusPstItmDeItm2.Items.Add("Letter");
            this.cmbcusPstItmDeItm2.Items.Add("Parcel");
        }


        private void addItem1()
        {
            this.cmbcusPstItmDeItm1.Items.Add("Letter");
            this.cmbcusPstItmDeItm1.Items.Add("Parcel");
        }


        private void addWeight3()
        {
            this.cmbcusPstItmDeWgt3.Items.Add("5kg");
            this.cmbcusPstItmDeWgt3.Items.Add("10kg");
            this.cmbcusPstItmDeWgt3.Items.Add("15kg");
            this.cmbcusPstItmDeWgt3.Items.Add("20kg");
            this.cmbcusPstItmDeWgt3.Items.Add("25kg");
            this.cmbcusPstItmDeWgt3.Items.Add("30kg");
        }

        private void addWeight1()
        {
            this.cmbcusPstItmDeWgt1.Items.Add("5kg");
            this.cmbcusPstItmDeWgt1.Items.Add("10kg");
            this.cmbcusPstItmDeWgt1.Items.Add("15kg");
            this.cmbcusPstItmDeWgt1.Items.Add("20kg");
            this.cmbcusPstItmDeWgt1.Items.Add("25kg");
            this.cmbcusPstItmDeWgt1.Items.Add("30kg");

        }


        private void addWeight2()
        {
            this.cmbcusPstItmDeWgt2.Items.Add("5kg");
            this.cmbcusPstItmDeWgt2.Items.Add("10kg");
            this.cmbcusPstItmDeWgt2.Items.Add("15kg");
            this.cmbcusPstItmDeWgt2.Items.Add("20kg");
            this.cmbcusPstItmDeWgt2.Items.Add("25kg");
            this.cmbcusPstItmDeWgt2.Items.Add("30kg");
        }


        private void addCategory1()
        {
            this.cmbcusPstItmDeCtgry1.Items.Add("Resgistered");
            this.cmbcusPstItmDeCtgry1.Items.Add("Unegistered"); 
        }

        private void addCategory2()
        {
            this.cmbcusPstItmDeCtgry2.Items.Add("Resgistered");
            this.cmbcusPstItmDeCtgry2.Items.Add("Unegistered");
        }

        private void addCategory3()
        {
            this.cmbcusPstItmDeCtgry3.Items.Add("Resgistered");
            this.cmbcusPstItmDeCtgry3.Items.Add("Unegistered");
        }

        private void addPostType3()
        {
            this.cmbcusPstItmDetyp3.Items.Add("Local");
            this.cmbcusPstItmDetyp3.Items.Add("Foreign");    
        }

        private void addPostType2()
        {
            this.cmbcusPstItmDetyp2.Items.Add("Local");
            this.cmbcusPstItmDetyp2.Items.Add("Foreign");    
        }



        private void addPostType1()
        {
            this.cmbcusPstItmDetyp1.Items.Add("Local");
            this.cmbcusPstItmDetyp1.Items.Add("Foreign");         
        }

        private void addstatus()
        {
            this.cmbcussts.Items.Add("Pending");
            this.cmbcussts.Items.Add("Complete");
            this.cmbcussts.Items.Add("Canel");
      
        }


        private void Allzero()
        {
            this.txtcusItmRqDeUnPrc1.Text = Convert.ToString(0);
            this.txtcusItmRqDeUnPrc2.Text = Convert.ToString(0);
            this.txtcusItmRqDeUnPrc3.Text = Convert.ToString(0);
            this.txtcusItmRqDeqty1.Text = Convert.ToString(0);
            this.txtcusItmRqDeqty2.Text = Convert.ToString(0);
            this.txtcusItmRqDeqty3.Text = Convert.ToString(0);
            this.txtcusItmRqDeTtlPrc1.Text = Convert.ToString(0);
            this.txtcusItmRqDeTtlPrc2.Text = Convert.ToString(0);
            this.txtcusItmRqDeTtlPrc3.Text = Convert.ToString(0);
            this.txtcusPstItmDeTtlPrc1.Text = Convert.ToString(0);
            this.txtcusPstItmDeTtlPrc2.Text = Convert.ToString(0);
            this.txtcusPstItmDeTtlPrc3.Text = Convert.ToString(0);
            this.txtcusItmRqDeTtlPrcRs.Text = Convert.ToString(0);
            this.txtcusPstItmDeTtlPrcRs.Text = Convert.ToString(0);
            this.txtcusttl.Text = Convert.ToString(0);






        }


        public void clear()
        {
            this.txtcusrec.Text = "";
            this.txtcusnic.Text = "";
            this.txtcusnmi.Text = "";
            this.txtcusadr.Text = "";
            this.cmbcusItmRqDenm1.Items.Clear();
            this.cmbcusItmRqDetyp1.Items.Clear();
            //this.txtcusItmRqDeUnPrc1.Text = "";
            //this.txtcusItmRqDeqty1.Text = "";
            //this.txtcusItmRqDeTtlPrc1.Text = "";


            this.cmbcusPstItmDetyp1.Items.Clear();
            this.cmbcusPstItmDeCtgry1.Items.Clear();
            this.cmbcusPstItmDeItm1.Items.Clear();
            this.cmbcusPstItmDeWgt1.Items.Clear();
            this.cmbcusPstItmDeCntry1.Items.Clear(); 
           // this.txtcusPstItmDeTtlPrc1.Text = "";


            this.cmbcusItmRqDenm2.Items.Clear();
            this.cmbcusItmRqDetyp2.Items.Clear();
            //this.txtcusItmRqDeUnPrc2.Text = "";
            //this.txtcusItmRqDeqty2.Text = "";
            //this.txtcusItmRqDeTtlPrc2.Text = "";


            this.cmbcusPstItmDetyp2.Items.Clear();
            this.cmbcusPstItmDeCtgry2.Items.Clear();
            this.cmbcusPstItmDeItm2.Items.Clear();
            this.cmbcusPstItmDeWgt2.Items.Clear();
            this.cmbcusPstItmDeCntry2.Items.Clear();
            //this.txtcusPstItmDeTtlPrc2.Text = "";


            this.cmbcusItmRqDenm3.Items.Clear();
            this.cmbcusItmRqDetyp3.Items.Clear();
            //this.txtcusItmRqDeUnPrc3.Text = "";
            //this.txtcusItmRqDeqty3.Text = "";
            //this.txtcusItmRqDeTtlPrc3.Text = "";


            this.cmbcusPstItmDetyp3.Items.Clear();
            this.cmbcusPstItmDeCtgry3.Items.Clear();
            this.cmbcusPstItmDeItm3.Items.Clear();
            this.cmbcusPstItmDeWgt3.Items.Clear();
            this.cmbcusPstItmDeCntry3.Items.Clear();
           // this.txtcusPstItmDeTtlPrc3.Text = "";
           

            //this.txtcusItmRqDeTtlPrcRs.Text = "";
            //this.txtcusPstItmDeTtlPrcRs.Text = "";
            //this.txtcusttl.Text = "";


            this.dtpcuscdt.Value = System.DateTime.Now;
            this.dtpcusddt.Value = System.DateTime.Now;
            this.cmbcussts.Items.Clear();
            Allzero();


        }

        // Search data

        private void btncussrh_Click(object sender, EventArgs e)
        {

             if (String.IsNullOrEmpty(txtcusnic.Text))
            {
                MessageBox.Show("Please Enter Your NIC No...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {

                     string NIC_No = this.txtcusnic.Text.Trim();

                     SqlCeConnection conn = new SqlCeConnection(db.path);
                     SqlCeCommand cmd = new SqlCeCommand();

                     String SrhDt = "select * from Customer where (NIC_No ='" + NIC_No + "')";

                     cmd.CommandText = SrhDt;
                     cmd.Connection = conn;
                     conn.Open();
                     SqlCeDataReader dr = cmd.ExecuteReader();
                     if (dr.Read())
                     {
                         this.txtcusrec.Text = dr[0].ToString();
                         this.txtcusnic.Text = dr[1].ToString();
                         this.txtcusnmi.Text = dr[2].ToString();
                         this.txtcusadr.Text = dr[3].ToString();

                         this.cmbcusItmRqDenm1.SelectedItem = dr[4].ToString();
                         this.cmbcusItmRqDetyp1.SelectedItem = dr[5].ToString();
                         this.txtcusItmRqDeUnPrc1.Text = dr[6].ToString();
                         this.txtcusItmRqDeqty1.Text = dr[7].ToString();
                         this.txtcusItmRqDeTtlPrc1.Text = dr[8].ToString();

                         this.cmbcusItmRqDenm2.SelectedItem = dr[9].ToString();
                         this.cmbcusItmRqDetyp2.SelectedItem = dr[10].ToString();
                         this.txtcusItmRqDeUnPrc2.Text = dr[11].ToString();
                         this.txtcusItmRqDeqty2.Text = dr[12].ToString();
                         this.txtcusItmRqDeTtlPrc2.Text = dr[13].ToString(); ;

                         this.cmbcusItmRqDenm3.SelectedItem = dr[14].ToString();
                         this.cmbcusItmRqDetyp3.SelectedItem = dr[15].ToString();
                         this.txtcusItmRqDeUnPrc3.Text = dr[16].ToString();
                         this.txtcusItmRqDeqty3.Text = dr[17].ToString();
                         this.txtcusItmRqDeTtlPrc3.Text = dr[18].ToString();

                         this.txtcusItmRqDeTtlPrcRs.Text = dr[19].ToString();


                         this.cmbcusPstItmDetyp1.SelectedItem = dr[20].ToString();
                         this.cmbcusPstItmDeCtgry1.SelectedItem = dr[21].ToString();
                         this.cmbcusPstItmDeItm1.SelectedItem = dr[22].ToString();
                         this.cmbcusPstItmDeWgt1.SelectedItem = dr[23].ToString();
                         this.cmbcusPstItmDeCntry1.SelectedItem = dr[24].ToString();
                         this.txtcusPstItmDeTtlPrc1.Text = dr[25].ToString();


                         this.cmbcusPstItmDetyp2.SelectedItem = dr[26].ToString();
                         this.cmbcusPstItmDeCtgry2.SelectedItem = dr[27].ToString();
                         this.cmbcusPstItmDeItm2.SelectedItem = dr[28].ToString();
                         this.cmbcusPstItmDeWgt2.SelectedItem = dr[29].ToString();
                         this.cmbcusPstItmDeCntry2.SelectedItem = dr[30].ToString();
                         this.txtcusPstItmDeTtlPrc2.Text = dr[31].ToString();


                         this.cmbcusPstItmDetyp3.SelectedItem = dr[32].ToString();
                         this.cmbcusPstItmDeCtgry3.SelectedItem = dr[33].ToString();
                         this.cmbcusPstItmDeItm3.SelectedItem = dr[34].ToString();
                         this.cmbcusPstItmDeWgt3.SelectedItem = dr[35].ToString();
                         this.cmbcusPstItmDeCntry3.SelectedItem = dr[36].ToString();
                         this.txtcusPstItmDeTtlPrc3.Text = dr[37].ToString();


                         this.txtcusPstItmDeTtlPrcRs.Text = dr[38].ToString();
                         this.txtcusttl.Text = dr[39].ToString();


                         this.dtpcuscdt.Text = dr[40].ToString();
                         this.dtpcusddt.Text = dr[41].ToString();
                         this.cmbcussts.SelectedItem = dr[42].ToString();

                         Disable();

                         this.btncusedt.Visible = true;
                         this.btncusbk.Visible = true;
                         this.btncuscrt.Visible = false;
                         this.btncussrh.Visible = false;

                     }
                     else 
                     {
                         MessageBox.Show("Invalid NIC No ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         conn.Close();
                         clear();

                         this.txtcusrec.Text = Convert.ToString(GetNextNo());
                         getItemName1();
                         getItemName2();
                         getItemName3();
                         getItemType1();
                         getItemType2();
                         getItemType3();
                         Allzero();

                         addstatus();
                         addPostType1();
                         addPostType2();
                         addPostType3();

                         addCategory1();
                         addCategory2();
                         addCategory3();

                         addWeight1();
                         addWeight2();
                         addWeight3();

                         addItem1();
                         addItem2();
                         addItem3();

                         addCountry1();
                         addCountry2();
                         addCountry3();

                         this.grpbxcusItmRqDe.Enabled = false;
                         this.grpbxcuspstitm.Enabled = false;

                         LVcusdtl.Items.Clear();
                         LVcusItmDe.Items.Clear();
                         LVcusPstItmDe1.Items.Clear();
                         
                     
                     }

                
             }
             
        }

        //Disable Data 

        private void Disable()
        {
            this.txtcusrec.Enabled = false;
            this.txtcusnic.Enabled = false;
            this.txtcusnmi.Enabled = false;
            this.txtcusadr.Enabled = false;
            this.cmbcusItmRqDenm1.Enabled = false;
            this.cmbcusItmRqDetyp1.Enabled = false;
            this.txtcusItmRqDeUnPrc1.Enabled = false;
            this.txtcusItmRqDeqty1.Enabled = false;
            this.txtcusItmRqDeTtlPrc1.Enabled = false;


            this.cmbcusPstItmDetyp1.Enabled = false;
            this.cmbcusPstItmDeCtgry1.Enabled = false;
            this.cmbcusPstItmDeItm1.Enabled = false;
            this.cmbcusPstItmDeWgt1.Enabled = false;
            this.cmbcusPstItmDeCntry1.Enabled = false;
            this.txtcusPstItmDeTtlPrc1.Enabled = false;


            this.cmbcusItmRqDenm2.Enabled = false;
            this.cmbcusItmRqDetyp2.Enabled = false;
            this.txtcusItmRqDeUnPrc2.Enabled = false;
            this.txtcusItmRqDeqty2.Enabled = false;
            this.txtcusItmRqDeTtlPrc2.Enabled = false;


            this.cmbcusPstItmDetyp2.Enabled = false;
            this.cmbcusPstItmDeCtgry2.Enabled = false;
            this.cmbcusPstItmDeItm2.Enabled = false;
            this.cmbcusPstItmDeWgt2.Enabled = false;
            this.cmbcusPstItmDeCntry2.Enabled = false;
            this.txtcusPstItmDeTtlPrc2.Enabled = false;


            this.cmbcusItmRqDenm3.Enabled = false;
            this.cmbcusItmRqDetyp3.Enabled = false;
            this.txtcusItmRqDeUnPrc3.Enabled = false;
            this.txtcusItmRqDeqty3.Enabled = false;


            this.cmbcusPstItmDetyp3.Enabled = false;
            this.cmbcusPstItmDeCtgry3.Enabled = false;
            this.cmbcusPstItmDeItm3.Enabled = false;
            this.cmbcusPstItmDeWgt3.Enabled = false;
            this.cmbcusPstItmDeCntry3.Enabled = false;
            this.txtcusPstItmDeTtlPrc3.Enabled = false;

            this.txtcusItmRqDeTtlPrcRs.Enabled = false;
            this.txtcusPstItmDeTtlPrcRs.Enabled = false;
            this.txtcusttl.Text = "";


            this.dtpcuscdt.Enabled = false;
            this.dtpcusddt.Enabled = false;
            this.cmbcussts.Enabled = false;
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
                cmbcusItmRqDenm1.Items.Add(dr["Name"].ToString());
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
                cmbcusItmRqDenm2.Items.Add(dr["Name"].ToString());
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
                cmbcusItmRqDenm3.Items.Add(dr["Name"].ToString());
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
                cmbcusItmRqDetyp1.Items.Add(dr["Type"].ToString());
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
                cmbcusItmRqDetyp2.Items.Add(dr["Type"].ToString());
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
                cmbcusItmRqDetyp3.Items.Add(dr["Type"].ToString());
            }
        }

       
        //Update
        private void btncusupd_Click(object sender, EventArgs e)
        {
            int Rec_No = Convert.ToInt32(this.txtcusrec.Text.Trim());
            String NIC_No = this.txtcusnic.Text.Trim();
            String Name_with_Initials = this.txtcusnmi.Text.Trim();
            String Address = this.txtcusadr.Text.Trim();
            String I_Name_1 = this.cmbcusItmRqDenm1.Text.Trim();
            String I_Type_1 = this.cmbcusItmRqDetyp1.Text.Trim();
            String I_Unit_Price_1 = this.txtcusItmRqDeUnPrc1.Text.Trim();
            int I_Quantity_1 = Convert.ToInt32(this.txtcusItmRqDeqty1.Text.Trim());
            String I_Total_Price_1 = this.txtcusItmRqDeTtlPrc1.Text.Trim();

            String P_Type_1 = this.cmbcusPstItmDetyp1.Text.Trim();
            String P_Category_1 = this.cmbcusPstItmDeCtgry1.Text.Trim();
            String P_Item_1 = this.cmbcusPstItmDeItm1.Text.Trim();
            String Weight_1 = this.cmbcusPstItmDeWgt1.Text.Trim();
            String Country_1 = this.cmbcusPstItmDeCntry1.Text.Trim();
            String P_Total_Price_1 = this.txtcusPstItmDeTtlPrc1.Text.Trim();

            String I_Name_2 = this.cmbcusItmRqDenm2.Text.Trim();
            String I_Type_2 = this.cmbcusItmRqDetyp2.Text.Trim();
            String I_Unit_Price_2 = this.txtcusItmRqDeUnPrc2.Text.Trim();
            int I_Quantity_2 = Convert.ToInt32(this.txtcusItmRqDeqty2.Text.Trim());
            String I_Total_Price_2 = this.txtcusItmRqDeTtlPrc2.Text.Trim();

            String P_Type_2 = this.cmbcusPstItmDetyp2.Text.Trim();
            String P_Category_2 = this.cmbcusPstItmDeCtgry2.Text.Trim();
            String P_Item_2 = this.cmbcusPstItmDeItm2.Text.Trim();
            String Weight_2 = this.cmbcusPstItmDeWgt2.Text.Trim();
            String Country_2 = this.cmbcusPstItmDeCntry2.Text.Trim();
            String P_Total_Price_2 = this.txtcusPstItmDeTtlPrc2.Text.Trim();

            String I_Name_3 = this.cmbcusItmRqDenm3.Text.Trim();
            String I_Type_3 = this.cmbcusItmRqDetyp3.Text.Trim();
            String I_Unit_Price_3 = this.txtcusItmRqDeUnPrc3.Text.Trim();
            int I_Quantity_3 = Convert.ToInt32(this.txtcusItmRqDeqty3.Text.Trim());
            String I_Total_Price_3 = this.txtcusItmRqDeTtlPrc3.Text.Trim();

            String P_Type_3 = this.cmbcusPstItmDetyp3.Text.Trim();
            String P_Category_3 = this.cmbcusPstItmDeCtgry3.Text.Trim();
            String P_Item_3 = this.cmbcusPstItmDeItm3.Text.Trim();
            String Weight_3 = this.cmbcusPstItmDeWgt3.Text.Trim();
            String Country_3 = this.cmbcusPstItmDeCntry3.Text.Trim();
            String P_Total_Price_3 = this.txtcusPstItmDeTtlPrc3.Text.Trim();

            String I_R_Total_Price = this.txtcusItmRqDeTtlPrcRs.Text.Trim();
            String P_I_Total_Price = this.txtcusPstItmDeTtlPrcRs.Text.Trim();
            String Gross_Price = this.txtcusttl.Text.Trim();

            DateTime Create_Date = Convert.ToDateTime(this.dtpcuscdt.Text.Trim());
            DateTime Delivery_Date = Convert.ToDateTime(this.dtpcusddt.Text.Trim());
            String Status = this.cmbcussts.Text.Trim();

            Customer_DB CUD = new Customer_DB();
            CUD.UpdateData(Rec_No, NIC_No, Name_with_Initials, Address, I_Name_1, I_Name_2, I_Name_3, I_Type_1, I_Type_2, I_Type_3, I_Unit_Price_1, I_Unit_Price_2, I_Unit_Price_3, I_Quantity_1, I_Quantity_2, I_Quantity_3, I_Total_Price_1, I_Total_Price_2, I_Total_Price_3, P_Type_1, P_Type_2, P_Type_3, P_Category_1, P_Category_2, P_Category_3, P_Item_1, P_Item_2, P_Item_3, Weight_1, Weight_2, Weight_3, Country_1, Country_2, Country_3, P_Total_Price_1, P_Total_Price_2, P_Total_Price_3, I_R_Total_Price, P_I_Total_Price, Gross_Price, Create_Date, Delivery_Date, Status);



            clear();
            this.txtcusrec.Text = Convert.ToString(CUD.GetNextNo());
            MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
           
            this.btncuscrt.Visible = true;
            this.btncussrh.Visible = true;
            this.btncusedt.Visible = false;
            this.btncusdlt.Visible = false;
            this.btncusupd.Visible = false;
            this.btncusbk.Visible = false;
            Customer_DB obj1 = new Customer_DB();
            this.txtcusrec.Text = Convert.ToString(obj1.GetNextNo());
            getItemName1();
            getItemName2();
            getItemName3();
            getItemType1();
            getItemType2();
            getItemType3();
            Allzero();

            addstatus();
            addPostType1();
            addPostType2();
            addPostType3();

            addCategory1();
            addCategory2();
            addCategory3();

            addWeight1();
            addWeight2();
            addWeight3();

            addItem1();
            addItem2();
            addItem3();

            addCountry1();
            addCountry2();
            addCountry3();

            this.grpbxcusItmRqDe.Enabled = false;
            this.grpbxcuspstitm.Enabled = false;

            LVcusdtl.Items.Clear();
            LVcusItmDe.Items.Clear();
            LVcusPstItmDe1.Items.Clear();

        }

        private void cmbcusItmRqDenm1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcusItmRqDetyp1.Items.Clear();

            String I_Name_1 = cmbcusItmRqDenm1.SelectedItem.ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            string addD = "Select * from Item where(Name = '" + I_Name_1 + "') ";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbcusItmRqDetyp1.Items.Add(dr["Type"].ToString());
            }
        }

        private void cmbcusItmRqDenm2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcusItmRqDetyp2.Items.Clear();

            String Item_Name_2 = cmbcusItmRqDenm2.SelectedItem.ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            string addD = "Select * from Item where(Name = '" + Item_Name_2 + "')";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbcusItmRqDetyp2.Items.Add(dr["Type"].ToString());
            }
        }

        private void cmbcusItmRqDenm3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcusItmRqDetyp3.Items.Clear();

            String Item_Name_3 = cmbcusItmRqDenm3.SelectedItem.ToString();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            string addD = "Select * from Item where(Name = '" + Item_Name_3 + "')";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmbcusItmRqDetyp3.Items.Add(dr["Type"].ToString());
            }
        }

        private void LlblcusItmDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LVcusItmDe.Items.Clear();
            //LVcusItmDe1.Items.Clear();
            //LVcusItmDe2.Items.Clear();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter data = new SqlCeDataAdapter("select * from Supplier_Detail", conn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["I_Name1"].ToString());

                //listview.SubItems.Add(dr["I_Name1"].ToString());
                listview.SubItems.Add(dr["I_Type1"].ToString());
                listview.SubItems.Add(dr["SalesPrise1"].ToString());


                LVcusItmDe.Items.Add(listview);
                LVcusItmDe.Show();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["I_Name2"].ToString());

              //  listview.SubItems.Add(dr["I_Name2"].ToString());
                listview.SubItems.Add(dr["I_Type2"].ToString());
                listview.SubItems.Add(dr["SalesPrise2"].ToString());


                LVcusItmDe.Items.Add(listview);
                LVcusItmDe.Show();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["I_Name3"].ToString());

               // listview.SubItems.Add(dr["I_Name3"].ToString());
                listview.SubItems.Add(dr["I_Type3"].ToString());
                listview.SubItems.Add(dr["SalesPrise3"].ToString());


                LVcusItmDe.Items.Add(listview);
                LVcusItmDe.Show();
            }
        }

        private void txtcusItmRqDeqty1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int untprc1 = Convert.ToInt32(this.txtcusItmRqDeUnPrc1.Text.Trim());
                int qnt1 = Convert.ToInt32(this.txtcusItmRqDeqty1.Text.Trim());

                int ttlprc1 = untprc1 * qnt1;

                this.txtcusItmRqDeTtlPrc1.Text = Convert.ToString(ttlprc1);
            }
            catch (Exception)
            {
                this.txtcusItmRqDeqty1.Text = Convert.ToString(0);
            }
        }

        private void txtcusItmRqDeqty2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int untprc2 = Convert.ToInt32(this.txtcusItmRqDeUnPrc2.Text.Trim());
                int qnt2 = Convert.ToInt32(this.txtcusItmRqDeqty2.Text.Trim());

                int ttlprc2 = untprc2 * qnt2;

                this.txtcusItmRqDeTtlPrc2.Text = Convert.ToString(ttlprc2);
            }
            catch (Exception)
            {
                this.txtcusItmRqDeqty2.Text = Convert.ToString(0);
            }
        }

        private void txtcusItmRqDeqty3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int untprc3 = Convert.ToInt32(this.txtcusItmRqDeUnPrc3.Text.Trim());
                int qnt3 = Convert.ToInt32(this.txtcusItmRqDeqty3.Text.Trim());

                int ttlprc3 = untprc3 * qnt3;

                this.txtcusItmRqDeTtlPrc3.Text = Convert.ToString(ttlprc3);
            }
            catch (Exception)
            {
                this.txtcusItmRqDeqty3.Text = Convert.ToString(0);
            }
        }

        private void btncusItmRqDecal_Click(object sender, EventArgs e)
        {
            try
            {
                int ttlprc1 = Convert.ToInt32(this.txtcusItmRqDeTtlPrc1.Text.Trim());
                int ttlprc2 = Convert.ToInt32(this.txtcusItmRqDeTtlPrc2.Text.Trim());
                int ttlprc3 = Convert.ToInt32(this.txtcusItmRqDeTtlPrc3.Text.Trim());

                int alltp = ttlprc1 + ttlprc2 + ttlprc3;

                this.txtcusItmRqDeTtlPrcRs.Text = Convert.ToString(alltp);
            }
            catch (Exception)
            {
                //this.txtcusItmRqDeqty3.Text = Convert.ToString(0);
            }
        }

        private void btncusPstItmDecal_Click(object sender, EventArgs e)
        {
            try
            {
                int ttlPprc1 = Convert.ToInt32(this.txtcusPstItmDeTtlPrc1.Text.Trim());
                int ttlPprc2 = Convert.ToInt32(this.txtcusPstItmDeTtlPrc2.Text.Trim());
                int ttlPprc3 = Convert.ToInt32(this.txtcusPstItmDeTtlPrc3.Text.Trim());

                int alltp = ttlPprc1 + ttlPprc2 + ttlPprc3;

                this.txtcusPstItmDeTtlPrcRs.Text = Convert.ToString(alltp);
            }
            catch (Exception)
            {
                //this.txtcusItmRqDeqty3.Text = Convert.ToString(0);
            }

        }

        private void btncusgprc_Click(object sender, EventArgs e)
        {
            try
            {
                int ttlIprc = Convert.ToInt32(this.txtcusItmRqDeTtlPrcRs.Text.Trim());
                int ttlPprc = Convert.ToInt32(this.txtcusPstItmDeTtlPrcRs.Text.Trim());

                int alltp = ttlIprc + ttlPprc;

                this.txtcusttl.Text = Convert.ToString(alltp);
            }
            catch (Exception)
            {
                //this.txtcusItmRqDeqty3.Text = Convert.ToString(0);
            }

        }

        //Edit data

        private void btncusedt_Click(object sender, EventArgs e)
        {
            Enable();
            this.btncuscrt.Visible = false;
            this.btncusupd.Visible = true;
            this.btncusdlt.Visible = true;
            this.btncusbk.Visible = true;
            this.btncussrh.Visible = false;

        }

        //Enable Data

        private void Enable()
        {
            this.txtcusrec.Enabled = true;
            this.txtcusnic.Enabled = true;
            this.txtcusnmi.Enabled = true;
            this.txtcusadr.Enabled = true;
            this.cmbcusItmRqDenm1.Enabled = true;
            this.cmbcusItmRqDetyp1.Enabled = true;
            this.txtcusItmRqDeUnPrc1.Enabled = true;
            this.txtcusItmRqDeqty1.Enabled = true;
            this.txtcusItmRqDeTtlPrc1.Enabled = true;


            this.cmbcusPstItmDetyp1.Enabled = true;
            this.cmbcusPstItmDeCtgry1.Enabled = true;
            this.cmbcusPstItmDeItm1.Enabled = true;
            this.cmbcusPstItmDeWgt1.Enabled = true;
            this.cmbcusPstItmDeCntry1.Enabled = true;
            this.txtcusPstItmDeTtlPrc1.Enabled = true;


            this.cmbcusItmRqDenm2.Enabled = true;
            this.cmbcusItmRqDetyp2.Enabled = true;
            this.txtcusItmRqDeUnPrc2.Enabled = true;
            this.txtcusItmRqDeqty2.Enabled = true;
            this.txtcusItmRqDeTtlPrc2.Enabled = true;


            this.cmbcusPstItmDetyp2.Enabled = true;
            this.cmbcusPstItmDeCtgry2.Enabled = true;
            this.cmbcusPstItmDeItm2.Enabled = true;
            this.cmbcusPstItmDeWgt2.Enabled = true;
            this.cmbcusPstItmDeCntry2.Enabled = true;
            this.txtcusPstItmDeTtlPrc2.Enabled = true;


            this.cmbcusItmRqDenm3.Enabled = true;
            this.cmbcusItmRqDetyp3.Enabled = true;
            this.txtcusItmRqDeUnPrc3.Enabled = true;
            this.txtcusItmRqDeqty3.Enabled = true;
            this.txtcusItmRqDeTtlPrc3.Enabled = true;

            this.cmbcusPstItmDetyp3.Enabled = true;
            this.cmbcusPstItmDeCtgry3.Enabled = true;
            this.cmbcusPstItmDeItm3.Enabled = true;
            this.cmbcusPstItmDeWgt3.Enabled = true;
            this.cmbcusPstItmDeCntry3.Enabled = true;
            this.txtcusPstItmDeTtlPrc3.Enabled = true;

            this.txtcusItmRqDeTtlPrcRs.Enabled = true;
            this.txtcusPstItmDeTtlPrcRs.Enabled = true;
            this.txtcusttl.Enabled = true;


            this.dtpcuscdt.Enabled = true;
            this.dtpcusddt.Enabled = true;
            this.cmbcussts.Enabled = true;
        }

    
       // Customer Details Delete
        private void btncusdlt_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtcusnic.Text))
            {
                MessageBox.Show("Please Enter Your NIC No...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Customer_DB DltCus = new Customer_DB();
                    string NIC_No = this.txtcusnic.Text.ToString();
                    DltCus.delete(NIC_No);
                    clear();

                    MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtcusrec.Text = Convert.ToString(GetNextNo());
                    getItemName1();
                    getItemName2();
                    getItemName3();
                    getItemType1();
                    getItemType2();
                    getItemType3();
                    Allzero();

                    addstatus();
                    addPostType1();
                    addPostType2();
                    addPostType3();

                    addCategory1();
                    addCategory2();
                    addCategory3();

                    addWeight1();
                    addWeight2();
                    addWeight3();

                    addItem1();
                    addItem2();
                    addItem3();

                    addCountry1();
                    addCountry2();
                    addCountry3();

                    this.grpbxcusItmRqDe.Enabled = false;
                    this.grpbxcuspstitm.Enabled = false;

                    LVcusdtl.Items.Clear();
                    LVcusItmDe.Items.Clear();
                    LVcusPstItmDe1.Items.Clear();

                    this.btncusedt.Visible = false;
                    this.btncusdlt.Visible = false;
                    this.btncusupd.Visible = false;
                    this.txtcusrec.Enabled = false;
                    this.btncusbk.Visible = false;
                    this.btncuscrt.Visible = true;
                    this.btncussrh.Visible = true;
                    this.grpbxcusItmRqDe.Enabled = false;
                    this.grpbxcuspstitm.Enabled = false;
                    this.btncusgprc.Enabled = false;
                    this.lblcusttl.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Deleted Failed..!");
                }
            }

        }

        private int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd = new SqlCeCommand();
                string addDt = "Select max(Rec_No) from Customer";

                cmd.CommandText = addDt;
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

        private void LlblpkgdlvPstItm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LVcusPstItmDe1.Items.Clear();
            //LVcusItmDe1.Items.Clear();
            //LVcusItmDe2.Items.Clear();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter data = new SqlCeDataAdapter("select * from Post_Type", conn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["Type"].ToString());

                listview.SubItems.Add(dr["Category"].ToString());
                listview.SubItems.Add(dr["Item"].ToString());
                listview.SubItems.Add(dr["Weight_Category"].ToString());
                listview.SubItems.Add(dr["Country"].ToString());
                listview.SubItems.Add(dr["Price"].ToString());


                LVcusPstItmDe1.Items.Add(listview);
                LVcusPstItmDe1.Show();
            }
            
       
        }


        // Back Button

        private void btncusbk_Click(object sender, EventArgs e)
        {
            clear();
            Customer_DB obj1 = new Customer_DB();
            this.txtcusrec.Text = Convert.ToString(obj1.GetNextNo());
            this.btncusedt.Visible = false;
            this.btncusdlt.Visible = false;
            this.btncusupd.Visible = false;
            this.txtcusrec.Enabled = false;
            this.btncusbk.Visible = false;
            this.btncuscrt.Visible = true;
            this.btncussrh.Visible = true;
            Enable();

            this.txtcusrec.Text = Convert.ToString(GetNextNo());
            getItemName1();
            getItemName2();
            getItemName3();
            getItemType1();
            getItemType2();
            getItemType3();
            Allzero();

            addstatus();
            addPostType1();
            addPostType2();
            addPostType3();

            addCategory1();
            addCategory2();
            addCategory3();

            addWeight1();
            addWeight2();
            addWeight3();

            addItem1();
            addItem2();
            addItem3();

            addCountry1();
            addCountry2();
            addCountry3();

            this.grpbxcusItmRqDe.Enabled = false;
            this.grpbxcuspstitm.Enabled = false;

            LVcusdtl.Items.Clear();
            LVcusItmDe.Items.Clear();
            LVcusPstItmDe1.Items.Clear();
        }

        private void cmbcusPstItmDeCntry1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String type = cmbcusPstItmDetyp1.SelectedItem.ToString();
                String category = cmbcusPstItmDeCtgry1.SelectedItem.ToString();
                String item = cmbcusPstItmDeItm1.SelectedItem.ToString();
                String weight = cmbcusPstItmDeWgt1.SelectedItem.ToString();
                String country = cmbcusPstItmDeCntry1.SelectedItem.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                string addD = "Select * from Post_Type where ((Type = '" + type + "' ) and (Category = '" + category + "') and (Item = '" + item + "') and (Weight_Category = '" + weight + "') and (Country = '" + country + "') )";

                cmd1.CommandText = addD;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    this.txtcusPstItmDeTtlPrc1.Text = dr1["Price"].ToString();
                }
            }

            catch (Exception)
            {
               // MessageBox.Show("Invalid PostType...", "Error");
            }



        }

        private void txtcusnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Llblcusdtl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LVcusdtl.Items.Clear();


            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter data = new SqlCeDataAdapter("select * from Customer", conn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["Rec_No"].ToString());

                listview.SubItems.Add(dr["NIC_No"].ToString());
                listview.SubItems.Add(dr["Name_with_Initials"].ToString());
                listview.SubItems.Add(dr["Address"].ToString());
                listview.SubItems.Add(dr["I_R_Total_Price"].ToString());
                listview.SubItems.Add(dr["P_I_Total_Price"].ToString());
                listview.SubItems.Add(dr["Gross_Price"].ToString());
                listview.SubItems.Add(dr["Create_Date"].ToString());
                listview.SubItems.Add(dr["Delivery_Date"].ToString());
                listview.SubItems.Add(dr["Status"].ToString());


                LVcusdtl.Items.Add(listview);
                LVcusdtl.Show();
            }
        }

        //radio btn both

        private void rbtnbth_CheckedChanged(object sender, EventArgs e)
        {
            this.grpbxcusItmRqDe.Enabled = true;
            this.grpbxcuspstitm.Enabled = true;
            this.btncusgprc.Enabled = true;
            this.lblcusttl.Enabled = true;
        }

        //radio btn Item Request

        private void rbtnItmRstdtl_CheckedChanged(object sender, EventArgs e)
        {
            this.grpbxcusItmRqDe.Enabled = true;
            this.grpbxcuspstitm.Enabled = false;
            this.btncusgprc.Enabled = true;
            this.lblcusttl.Enabled = true;
        }

        //radio btn Post Type Request

        private void rbtnPstItmRstDtl_CheckedChanged(object sender, EventArgs e)
        {
            this.grpbxcuspstitm.Enabled = true;
            this.grpbxcusItmRqDe.Enabled = false;
            this.btncusgprc.Enabled = true;
            this.lblcusttl.Enabled = true;

        }

        private void cmbcusPstItmDeCntry2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String type = cmbcusPstItmDetyp2.SelectedItem.ToString();
                String category = cmbcusPstItmDeCtgry2.SelectedItem.ToString();
                String item = cmbcusPstItmDeItm2.SelectedItem.ToString();
                String weight = cmbcusPstItmDeWgt2.SelectedItem.ToString();
                String country = cmbcusPstItmDeCntry2.SelectedItem.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                string addD = "Select * from Post_Type where ((Type = '" + type + "' ) and (Category = '" + category + "') and (Item = '" + item + "') and (Weight_Category = '" + weight + "') and (Country = '" + country + "') )";

                cmd1.CommandText = addD;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    this.txtcusPstItmDeTtlPrc2.Text = dr1["Price"].ToString();
                }
            }

            catch (Exception)
            {
                // MessageBox.Show("Invalid PostType...", "Error");
            }


        }

  

        private void cmbcusItmRqDetyp1_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                string name = cmbcusItmRqDenm1.SelectedItem.ToString();
                string type = cmbcusItmRqDetyp1.SelectedItem.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                // string addD = " SELECT * FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ) OR ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ) OR ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ) ) ";
                string addD = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ))";

                cmd1.CommandText = addD;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (Convert.ToInt32(dr1[0]) > 0)
                    {
                        SqlCeConnection connsp1 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp1 = new SqlCeCommand();
                        string sp1 = " SELECT SalesPrise1 FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ))";

                        cmd1sp1.CommandText = sp1;
                        cmd1sp1.Connection = connsp1;
                        connsp1.Open();
                        SqlCeDataReader drsp1 = cmd1sp1.ExecuteReader();
                        while (drsp1.Read())
                        {
                            this.txtcusItmRqDeUnPrc1.Text = drsp1["SalesPrise1"].ToString();
                        }
                        connsp1.Close();
                    }
                }
                conn.Close();

                ///////item2

                string addD2 = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ))";

                cmd1.CommandText = addD2;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr2 = cmd1.ExecuteReader();
                while (dr2.Read())
                {
                    if (Convert.ToInt32(dr2[0]) > 0)
                    {
                        SqlCeConnection connsp2 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp2 = new SqlCeCommand();
                        string sp2 = " SELECT SalesPrise2 FROM Supplier_Detail WHERE ( ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ))";

                        cmd1sp2.CommandText = sp2;
                        cmd1sp2.Connection = connsp2;
                        connsp2.Open();
                        SqlCeDataReader drsp2 = cmd1sp2.ExecuteReader();
                        while (drsp2.Read())
                        {
                            this.txtcusItmRqDeUnPrc1.Text = drsp2["SalesPrise2"].ToString();
                        }
                        connsp2.Close();
                    }
                }

                conn.Close();

                ///////item3

                string addD3 = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ))";

                cmd1.CommandText = addD3;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr3 = cmd1.ExecuteReader();
                while (dr3.Read())
                {
                    if (Convert.ToInt32(dr3[0]) > 0)
                    {

                        SqlCeConnection connsp3 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp3 = new SqlCeCommand();
                        string sp3 = " SELECT SalesPrise3 FROM Supplier_Detail WHERE ( ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ))";

                        cmd1sp3.CommandText = sp3;
                        cmd1sp3.Connection = connsp3;
                        connsp3.Open();
                        SqlCeDataReader drsp3 = cmd1sp3.ExecuteReader();
                        while (drsp3.Read())
                        {
                            this.txtcusItmRqDeUnPrc1.Text = drsp3["SalesPrise3"].ToString();
                        }
                    }
                }
                conn.Close();

            }

            catch (Exception)
            {
                // MessageBox.Show("Invalid PostType...", "Error");

            }
            

        }

        private void cmbcusItmRqDetyp2_SelectedValuedChanged(object sender, EventArgs e)
        {
            try
            {
                string name = cmbcusItmRqDenm2.SelectedItem.ToString();
                string type = cmbcusItmRqDetyp2.SelectedItem.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                // string addD = " SELECT * FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ) OR ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ) OR ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ) ) ";
                string addD = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ))";

                cmd1.CommandText = addD;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (Convert.ToInt32(dr1[0]) > 0)
                    {
                        SqlCeConnection connsp1 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp1 = new SqlCeCommand();
                        string sp1 = " SELECT SalesPrise1 FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ))";

                        cmd1sp1.CommandText = sp1;
                        cmd1sp1.Connection = connsp1;
                        connsp1.Open();
                        SqlCeDataReader drsp1 = cmd1sp1.ExecuteReader();
                        while (drsp1.Read())
                        {
                            this.txtcusItmRqDeUnPrc2.Text = drsp1["SalesPrise1"].ToString();
                        }
                        connsp1.Close();
                    }
                }
                conn.Close();

                ///////item2

                string addD2 = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ))";

                cmd1.CommandText = addD2;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr2 = cmd1.ExecuteReader();
                while (dr2.Read())
                {
                    if (Convert.ToInt32(dr2[0]) > 0)
                    {
                        SqlCeConnection connsp2 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp2 = new SqlCeCommand();
                        string sp2 = " SELECT SalesPrise2 FROM Supplier_Detail WHERE ( ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ))";

                        cmd1sp2.CommandText = sp2;
                        cmd1sp2.Connection = connsp2;
                        connsp2.Open();
                        SqlCeDataReader drsp2 = cmd1sp2.ExecuteReader();
                        while (drsp2.Read())
                        {
                            this.txtcusItmRqDeUnPrc2.Text = drsp2["SalesPrise2"].ToString();
                        }
                        connsp2.Close();
                    }
                }

                conn.Close();

                ///////item3

                string addD3 = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ))";

                cmd1.CommandText = addD3;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr3 = cmd1.ExecuteReader();
                while (dr3.Read())
                {
                    if (Convert.ToInt32(dr3[0]) > 0)
                    {

                        SqlCeConnection connsp3 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp3 = new SqlCeCommand();
                        string sp3 = " SELECT SalesPrise3 FROM Supplier_Detail WHERE ( ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ))";

                        cmd1sp3.CommandText = sp3;
                        cmd1sp3.Connection = connsp3;
                        connsp3.Open();
                        SqlCeDataReader drsp3 = cmd1sp3.ExecuteReader();
                        while (drsp3.Read())
                        {
                            this.txtcusItmRqDeUnPrc2.Text = drsp3["SalesPrise3"].ToString();
                        }
                    }
                }
                conn.Close();

            }

            catch (Exception)
            {
                // MessageBox.Show("Invalid PostType...", "Error");

            }
            
        }

        private void cmbcusItmRqDetyp3_SelectedValuedChanged(object sender, EventArgs e)
        {
            try
            {
                string name = cmbcusItmRqDenm3.SelectedItem.ToString();
                string type = cmbcusItmRqDetyp3.SelectedItem.ToString();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                // string addD = " SELECT * FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ) OR ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ) OR ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ) ) ";
                string addD = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ))";

                cmd1.CommandText = addD;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (Convert.ToInt32(dr1[0]) > 0)
                    {
                        SqlCeConnection connsp1 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp1 = new SqlCeCommand();
                        string sp1 = " SELECT SalesPrise1 FROM Supplier_Detail WHERE ( ( (I_Name1 = '" + name + "') AND (I_TYPE1 = '" + type + "') ))";

                        cmd1sp1.CommandText = sp1;
                        cmd1sp1.Connection = connsp1;
                        connsp1.Open();
                        SqlCeDataReader drsp1 = cmd1sp1.ExecuteReader();
                        while (drsp1.Read())
                        {
                            this.txtcusItmRqDeUnPrc3.Text = drsp1["SalesPrise1"].ToString();
                        }
                        connsp1.Close();
                    }
                }
                conn.Close();

                ///////item2

                string addD2 = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ))";

                cmd1.CommandText = addD2;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr2 = cmd1.ExecuteReader();
                while (dr2.Read())
                {
                    if (Convert.ToInt32(dr2[0]) > 0)
                    {
                        SqlCeConnection connsp2 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp2 = new SqlCeCommand();
                        string sp2 = " SELECT SalesPrise2 FROM Supplier_Detail WHERE ( ( (I_Name2 = '" + name + "') AND (I_TYPE2 = '" + type + "') ))";

                        cmd1sp2.CommandText = sp2;
                        cmd1sp2.Connection = connsp2;
                        connsp2.Open();
                        SqlCeDataReader drsp2 = cmd1sp2.ExecuteReader();
                        while (drsp2.Read())
                        {
                            this.txtcusItmRqDeUnPrc3.Text = drsp2["SalesPrise2"].ToString();
                        }
                        connsp2.Close();
                    }
                }

                conn.Close();

                ///////item3

                string addD3 = " SELECT COUNT(Reg_No) AS Count FROM Supplier_Detail WHERE ( ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ))";

                cmd1.CommandText = addD3;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr3 = cmd1.ExecuteReader();
                while (dr3.Read())
                {
                    if (Convert.ToInt32(dr3[0]) > 0)
                    {

                        SqlCeConnection connsp3 = new SqlCeConnection(db.path);
                        SqlCeCommand cmd1sp3 = new SqlCeCommand();
                        string sp3 = " SELECT SalesPrise3 FROM Supplier_Detail WHERE ( ( (I_Name3 = '" + name + "') AND (I_TYPE3 = '" + type + "') ))";

                        cmd1sp3.CommandText = sp3;
                        cmd1sp3.Connection = connsp3;
                        connsp3.Open();
                        SqlCeDataReader drsp3 = cmd1sp3.ExecuteReader();
                        while (drsp3.Read())
                        {
                            this.txtcusItmRqDeUnPrc3.Text = drsp3["SalesPrise3"].ToString();
                        }
                    }
                }
                conn.Close();

            }

            catch (Exception)
            {
                // MessageBox.Show("Invalid PostType...", "Error");

            }
            
        }
    

       

    }
} 
