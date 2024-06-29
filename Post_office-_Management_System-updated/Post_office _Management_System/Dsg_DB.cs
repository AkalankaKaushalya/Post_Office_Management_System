using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace Post_office__Management_System
{
    class Dsg_DB
    {
        DBConnect db = new DBConnect();

        internal void AddData(int dsgrecno, int dsgno, string dsgnm, string dsgsts, string dsgdes)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String addD = "insert into Designation values('" + dsgno + "','" + dsgnm + "','" + dsgsts + "','" + dsgdes + "','" + dsgrecno + "')";

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
                string addD = "Select max(Rec_No) from Designation";

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

        internal void UpdateData(int dsgrecno1, int dsgno1, string dsgnm1, string dsgsts1, string dsgdes1)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String updD = "UPDATE Designation SET No = '" + dsgno1 + "' , Name = '" + dsgnm1 + "' , Status = '" + dsgsts1 + "' , Description = '" + dsgdes1 + "' WHERE Rec_No = '" + dsgrecno1 + "' ";

            cmd1.CommandText = updD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void DeleteData(int dsgno)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String DelD = "DELETE from  Designation where (No ='" + dsgno + "')";

            cmd1.CommandText = DelD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
    }
}
