using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;

namespace Post_office__Management_System
{
    class Package_Delivery_DB
    {
        DBConnect db = new DBConnect();



        internal void AddData(string Branch_Name, string V_Type, string V_Driver_Name, string Status, int Rec_No, int No, int Branch_No, int Package_No_1, int Package_No_2, int Package_No_3, int V_No, int Quantity_1, int Weight_1, int Quantity_2, int Weight_2, int Quantity_3, int Weight_3, int V_Capacity, int Total_Weight, DateTime Create_Date, DateTime Delivery_Date)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd = new SqlCeCommand();
            String addDt = "Insert into Package_Delivary values('" + Rec_No + "', '"+No+"','" + Branch_Name + "','" + Branch_No + "','" + Package_No_1 + "','" + Quantity_1 + "','" + Weight_1 + "','" + Package_No_2 + "','" + Quantity_2 + "','" + Weight_2 + "', '" + Package_No_3 + "','" + Quantity_3 + "','" + Weight_3 + "','" + Total_Weight + "','" + V_Type + "','" + V_No + "','" + V_Capacity + "','" + V_Driver_Name + "','" + Create_Date + "','" + Delivery_Date + "','" + Status + "')";

            cmd.CommandText = addDt;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }


        internal void UpdateData(int Rec_No, int No, string Branch_Name, int Branch_No, int Package_No_1, int Package_No_2, int Package_No_3, string V_Type, int V_No, int Quantity_1, int Quantity_2, int Quantity_3, int Weight_1, int Weight_2, int Weight_3, int Total_Weight, int V_Capacity, string V_Driver_Name, DateTime Delivery_Date, DateTime Create_Date, string Status)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd = new SqlCeCommand();
            String updD = "UPDATE Package_Delivary SET Rec_No = '" + Rec_No + "', Branch_Name = '" + Branch_Name + "', Branch_No ='" + Branch_No + "', Package_No_1 = '" + Package_No_1 + "' , Package_No_2 = '" + Package_No_2 + "' , Package_No_3 = '" + Package_No_3 + "' , V_Type = '" + V_Type + "', V_No = '" + V_No + "',  Quantity_1 = '" + Quantity_1 + "', Quantity_2 = '" + Quantity_2 + "',  Quantity_3 = '" + Quantity_3 + "', Weight_1 = '" + Weight_1 + "',  Weight_2 = '" + Weight_2 + "', Weight_3 = '" + Weight_3 + "',  Total_Weight = '" + Total_Weight + "', V_Capacity = '" + V_Capacity + "', V_Driver_Name = '" + V_Driver_Name + "' , Status ='" + Status + "', Create_Date = '" + Create_Date + "', Delivery_Date = '" + Delivery_Date + "'   WHERE No = '" + No + "'  ";

            cmd.CommandText = updD;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd = new SqlCeCommand();
                string addDt = "Select max(Rec_No) from Package_Delivary";

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

        internal void delete(int No)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String DelD = "DELETE from  Package_Delivary where (No ='" + No + "')";

            cmd1.CommandText = DelD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

    }
}
