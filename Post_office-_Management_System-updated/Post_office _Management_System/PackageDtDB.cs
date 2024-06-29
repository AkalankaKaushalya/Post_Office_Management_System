using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace Post_office__Management_System
{
    class PackageDtDB
    {

        DBConnect db = new DBConnect();

        internal void AddData(int pkgno, int pkgrec, string pkgnm, string pkgfrmt, string pkgtot, string pkgidpt1, string pkgidpt2, string pkgidpt3, string pkgidpt4, string pkgidpt5, string pkgidpt6, string pkgidcat1, 
                              string pkgidcat2, string pkgidcat3, string pkgidcat4, string pkgidcat5, string pkgidcat6, string pkgidit1, string pkgidit2, string pkgidit3, string pkgidit4, string pkgidit5, string pkgidit6, 
                              string pkgidcno1, string pkgidcno2, string pkgidcno3, string pkgidcno4, string pkgidcno5, string pkgidcno6, string pkgidqu1, string pkgidqu2, string pkgidqu3, string pkgidqu4, string pkgidqu5,
                              string pkgidqu6, string pkgidw1, string pkgidw2, string pkgidw3, string pkgidw4, string pkgidw5, string pkgidw6, string pkgtotqu, string pkgtotwe, string pkgsts, DateTime pkgfrmd, DateTime pkgtod,
                              DateTime pkgcrdt, DateTime pkgdudt)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String addD = "insert into Package values('" + pkgno + "','" + pkgnm + "','" + pkgfrmd + "','" + pkgtod + "','" + pkgfrmt + "','" + pkgtot + "','" + pkgidpt1 + "','" + pkgidpt2 + "','" + pkgidpt3 + "','" + pkgidpt4 + "','" + pkgidpt5 + "','" + pkgidpt6 + "','" + pkgidcat1 + "','" + pkgidcat2 + "','" + pkgidcat3 + "','" + pkgidcat4 + "','" + pkgidcat5 + "','" + pkgidcat6 + "','" + pkgidit1 + "','" + pkgidit2 + "','" + pkgidit3 + "','" + pkgidit4 + "','" + pkgidit5 + "','" + pkgidit6 + "','" + pkgidcno1 + "','" + pkgidcno2 + "','" + pkgidcno3 + "','" + pkgidcno4 + "','" + pkgidcno5 + "','" + pkgidcno6 + "','" + pkgidqu1 + "','" + pkgidqu2 + "','" + pkgidqu3 + "','" + pkgidqu4 + "','" + pkgidqu5 + "','" + pkgidqu6 + "','" + pkgidw1 + "','" + pkgidw2 + "','" + pkgidw3 + "','" + pkgidw4 + "','" + pkgidw5 + "','" + pkgidw6 + "','" + pkgtotqu + "','" + pkgtotwe + "','" + pkgcrdt + "','" + pkgdudt + "','" + pkgsts + "','" + pkgrec + "')";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                string addD = "Select max(Rec_No) from Package";

                cmd1.CommandText = addD;
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

        internal void UpdData(int pkgno, int pkgrec, string pkgnm, string pkgfrmt, string pkgtot, string pkgidpt1, 
            string pkgidpt2, string pkgidpt3, string pkgidpt4, string pkgidpt5, string pkgidpt6, string pkgidcat1, 
            string pkgidcat2, string pkgidcat3, string pkgidcat4, string pkgidcat5, string pkgidcat6, string pkgidit1, 
            string pkgidit2, string pkgidit3, string pkgidit4, string pkgidit5, string pkgidit6, string pkgidcno1, 
            string pkgidcno2, string pkgidcno3, string pkgidcno4, string pkgidcno5, string pkgidcno6, string pkgidqu1, 
            string pkgidqu2, string pkgidqu3, string pkgidqu4, string pkgidqu5, string pkgidqu6, string pkgidw1, 
            string pkgidw2, string pkgidw3, string pkgidw4, string pkgidw5, string pkgidw6, string pkgtotqu, string 
            pkgtotwe, string pkgsts, DateTime pkgfrmd, DateTime pkgtod, DateTime pkgcrdt, DateTime pkgdudt)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String updD = "UPDATE Package SET No = '" + pkgno + "' , Name = '" + pkgnm + "' , Date_From = '" + pkgfrmd + "' , Date_To = '" + pkgtod + "', Transfer_From = '" + pkgfrmt + "', Transfer_To = '" + pkgtot + "', Post_Type_1 = '" + pkgidpt1 + "', Post_Type_2 = '" + pkgidpt2 + "', Post_Type_3 = '" + pkgidpt3 + "', Post_Type_4 = '" + pkgidpt4 + "', Post_Type_5 = '" + pkgidpt5 + "', Post_Type_6 = '" + pkgidpt6 + "', Category_1 = '" + pkgidcat1 + "', Category_2 = '" + pkgidcat2 + "', Category_3 = '" + pkgidcat3 + "', Category_4 = '" + pkgidcat4 + "', Category_5 = '" + pkgidcat5 + "', Category_6 = '" + pkgidcat6 + "', Item_1 = '" + pkgidit1 + "', Item_2 = '" + pkgidit2 + "', Item_3 = '" + pkgidit3 + "', Item_4 = '" + pkgidit4 + "', Item_5 = '" + pkgidit5 + "', Item_6 = '" + pkgidit6 + "', Customer_No_1 = '" + pkgidcno1 + "', Customer_No_2 = '" + pkgidcno2 + "', Customer_No_3 = '" + pkgidcno3 + "', Customer_No_4 = '" + pkgidcno4 + "', Customer_No_5 = '" + pkgidcno5 + "', Customer_No_6 = '" + pkgidcno6 + "', Quantity_1 = '" + pkgidqu1 + "', Quantity_2 = '" + pkgidqu2 + "', Quantity_3 = '" + pkgidqu3 + "', Quantity_4 = '" + pkgidqu4 + "', Quantity_5 = '" + pkgidqu5 + "', Quantity_6 = '" + pkgidqu6 + "', Weight_1 = '" + pkgidw1 + "', Weight_2 = '" + pkgidw2 + "', Weight_3 = '" + pkgidw3 + "', Weight_4 = '" + pkgidw4 + "', Weight_5 = '" + pkgidw5 + "', Weight_6 = '" + pkgidw6 + "', Total_Quantity  = '" + pkgtotqu + "', Total_Weight = '" + pkgtotwe + "', Create_Date = '" + pkgcrdt + "', Due_Date = '" + pkgdudt + "', Status = '" + pkgsts + "' WHERE Rec_No = '" + pkgrec + "' ";

            cmd1.CommandText = updD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose(); ;
        }

        internal void DeleteData(int pkgrec)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String DelD = "DELETE from Package where (Rec_No ='" + pkgrec + "')";

            cmd1.CommandText = DelD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
    }
}
