using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace Post_office__Management_System
{
    class Customer_DB
    {

        DBConnect db = new DBConnect();

    
      public void addData(int Rec_No, string NIC_No, string Name_with_Initials, string I_R_Total_Price, string P_I_Total_Price, string Address, string I_Name_1, string I_Type_1, string P_Type_1, string P_Category_1, string P_Item_1, string Country_1, string I_Name_2, string I_Type_2, string P_Type_2, string P_Category_2, string P_Item_2, string Country_2, string I_Name_3, string I_Type_3, string P_Type_3, string P_Category_3, string P_Item_3, string Country_3, string Status, string I_Unit_Price_1, int I_Quantity_1, string Weight_1, string I_Unit_Price_2, int I_Quantity_2, string Weight_2, string I_Unit_Price_3, int I_Quantity_3, string Weight_3, string I_Total_Price_1, string I_Total_Price_2, string I_Total_Price_3, string P_Total_Price_1, string P_Total_Price_2, string P_Total_Price_3, string Gross_Price, DateTime Create_Date, DateTime Delivery_Date)

        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd = new SqlCeCommand();
            String addDt = "insert into Customer values('" + Rec_No + "', '" + NIC_No + "','" + Name_with_Initials + "','" + Address + "','" + I_Name_1 + "','" + I_Type_1 + "','" + I_Unit_Price_1 + "','" + I_Quantity_1 + "','" + I_Total_Price_1 + "','" + I_Name_2 + "','" + I_Type_2 + "','" + I_Unit_Price_2 + "','" + I_Quantity_2 + "','" + I_Total_Price_2 + "','" + I_Name_3 + "','" + I_Type_3 + "','" + I_Unit_Price_3 + "','" + I_Quantity_3 + "','" + I_Total_Price_3 + "','" + I_R_Total_Price + "','" + P_Type_1 + "','" + P_Category_1 + "','" + P_Item_1 + "','" + Weight_1 + "','" + Country_1 + "','" + P_Total_Price_1 + "','" + P_Type_2 + "','" + P_Category_2 + "','" + P_Item_2 + "','" + Weight_2 + "','" + Country_2 + "','" + P_Total_Price_2 + "','" + P_Type_3 + "','" + P_Category_3 + "','" + P_Item_3 + "','" + Weight_3 + "','" + Country_3 + "', '" + P_Total_Price_3 + "', '" + P_I_Total_Price + "', '" + Gross_Price + "','" + Create_Date + "','" + Delivery_Date + "','" + Status + "' )";

            cmd.CommandText = addDt;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
           
        }

        public int GetNextNo()
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




        internal void UpdateData(int Rec_No, string NIC_No, string Name_with_Initials, string Address, string I_Name_1, string I_Name_2, string I_Name_3, string I_Type_1, string I_Type_2, string I_Type_3, string I_Unit_Price_1, string I_Unit_Price_2, string I_Unit_Price_3, int I_Quantity_1, int I_Quantity_2, int I_Quantity_3, string I_Total_Price_1, string I_Total_Price_2, string I_Total_Price_3, string P_Type_1, string P_Type_2, string P_Type_3, string P_Category_1, string P_Category_2, string P_Category_3, string P_Item_1, string P_Item_2, string P_Item_3, string Weight_1, string Weight_2, string Weight_3, string Country_1, string Country_2, string Country_3, string P_Total_Price_1, string P_Total_Price_2, string P_Total_Price_3, string I_R_Total_Price, string P_I_Total_Price, string Gross_Price, DateTime Delivery_Date, DateTime Create_Date, string Status)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd = new SqlCeCommand();
            String updD = "UPDATE Customer SET Rec_No = '" + Rec_No + "', Name_with_Initials = '" + Name_with_Initials + "' , Address = '" + Address + "' , I_Name_1 = '" + I_Name_1 + "', I_Name_2 = '" + I_Name_2 + "',  I_Name_3 = '" + I_Name_3 + "', I_Type_1 = '" + I_Type_1 + "',  I_Type_2 = '" + I_Type_2 + "', I_Type_3 = '" + I_Type_3 + "',  I_Unit_Price_1 = '" + I_Unit_Price_1 + "', I_Unit_Price_2 = '" + I_Unit_Price_2 + "',   I_Unit_Price_3 = '" + I_Unit_Price_3 + "', I_Quantity_1 = '" + I_Quantity_1 + "', I_Quantity_2 = '" + I_Quantity_2 + "', I_Quantity_3 = '" + I_Quantity_3 + "', I_Total_Price_1 = '" + I_Total_Price_1 + "' , I_Total_Price_2 = '" + I_Total_Price_2 + "' , I_Total_Price_3 = '" + I_Total_Price_3 + "', P_Type_1 = '" + P_Type_1 + "',  P_Type_2 = '" + P_Type_2 + "', P_Type_3 = '" + P_Type_3 + "',  P_Category_1 = '" + P_Category_1 + "', P_Category_2 = '" + P_Category_2 + "',  P_Category_3 = '" + P_Category_3 + "', P_Item_1 = '" + P_Item_1 + "',   P_Item_2 = '" + P_Item_2 + "', P_Item_3 = '" + P_Item_3 + "', Weight_1 = '" + Weight_1 + "', Weight_2 = '" + Weight_2 + "', Weight_3 = '" + Weight_3 + "', Country_1 = '" + Country_1 + "', Country_2 = '" + Country_2 + "', Country_3 = '" + Country_3 + "', P_Total_Price_1 = '" + P_Total_Price_1 + "',  P_Total_Price_2 = '" + P_Total_Price_2 + "', P_Total_Price_3 = '" + P_Total_Price_3 + "' , I_R_Total_Price = '" + I_R_Total_Price + "', P_I_Total_Price ='" + P_I_Total_Price + "', Gross_Price = '" + Gross_Price + "', Create_Date = '"+Create_Date+"', Delivery_Date = '" + Delivery_Date + "', Status = '" + Status + "'  WHERE NIC_No = '" + NIC_No + "'  ";

            cmd.CommandText = updD;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void delete(string NIC_No)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String DelD = "DELETE from  Customer where (NIC_No ='" + NIC_No + "')";

            cmd1.CommandText = DelD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
    }
}
