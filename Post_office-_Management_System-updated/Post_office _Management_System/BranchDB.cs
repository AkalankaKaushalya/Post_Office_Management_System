using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;


namespace Post_office__Management_System
{
    class BranchDB
    {

        DBConnect db = new DBConnect();

        internal void addData(int brnrecno, int brnno, int brndepno, string brnname, string brnadr1, string brnadr2, string brneml, string brncon, string brnfax, string brnbcrg, string brnbcrgETF, string brnsts, string brndsc, string brndepnm, string brndeploc, string brndepempno)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String addD = "INSERT INTO Branch VALUES('" + brnno + "','" + brnname + "','" + brnadr1 + "','" + brneml + "','" + brncon + "','" + brnfax + "','" + brnbcrg + "','" + brnbcrgETF + "','" + brndepno + "','" + brndepnm + "','" + brndeploc + "','" + brndepempno + "','" + brnsts + "','" + brndsc + "','" + brnrecno + "','" + brnadr2 + "')";

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
                string addD = "Select max(Rec_No) from Branch";

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

        internal void UpdateData(int brnrecno, int brnno, int brndepno, string brnname, string brnadr1, string brnadr2, string brneml, string brncon, string brnfax, string brnbcrg, string brnbcrgETF, string brnsts, string brndsc, string brndepnm, string brndeploc, string brndepempno)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String addD = "UPDATE Branch SET No = '" + brnno + "', Name = '" + brnname + "', Address = '" + brnadr1 + "', Email = '" + brneml + "', Contact_No = '" + brncon + "', Fax_No = '" + brnfax + "', Branch_in_Charge = '" + brnbcrg + "', ETF_No = '" + brnbcrgETF + "', Dep_No = '" + brndepno + "', Dep_Name = '" + brndepnm + "', Dep_Location = '" + brndeploc + "', Dep_MaX_Emp = '" + brndepempno + "', Status = '" + brnsts + "', Description = '" + brndsc + "' , Address_2 = '" + brnadr2 + "' WHERE Rec_No = '" + brnrecno + "' ";

            cmd1.CommandText = addD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void DeleteData(int brnrecno)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String DelD = "DELETE from  Branch where (Rec_No ='" + brnrecno + "')";

            cmd1.CommandText = DelD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
    }
}
