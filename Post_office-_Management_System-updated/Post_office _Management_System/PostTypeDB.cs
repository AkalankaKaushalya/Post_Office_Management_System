using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;


namespace Post_office__Management_System
{
    class PostTypeDB
    {

        DBConnect db = new DBConnect();

        internal void addData(int psttrecno, string pssttptyp, string psstpcat, string psttpitm, string psttpwgh, string psttpcnt, string psttpprc, string psttpdes)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);  
            SqlCeCommand cmd1 = new SqlCeCommand();
            String addD = "insert into Post_Type values('" + psttrecno + "','" + pssttptyp + "','" + psstpcat + "','" + psttpitm + "','" + psttpwgh + "','" + psttpcnt + "','" + psttpprc + "','" + psttpdes + "')";

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
                SqlCeCommand adv1 = new SqlCeCommand();
                String msq2 = "select max(Rec_No) from Post_Type";

                adv1.CommandText = msq2;
                adv1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = adv1.ExecuteReader();
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

        internal void UpdateData(int psttrecno, string pssttptyp, string psstpcat, string psttpitm, string psttpwgh, string psttpcnt, string psttpprc, string psttpdes)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String updD = "UPDATE Post_Type SET Type = '" + pssttptyp + "' , Category = '" + psstpcat + "' , Item = '" + psttpitm + "' , Weight_Category = '" + psttpwgh + "' , Country = '" + psttpcnt + "', Price = '" + psttpprc + "', Description = '" + psttpdes + "' WHERE Rec_No = '" + psttrecno + "' ";

            cmd1.CommandText = updD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void DeleteData(int psttrecno)
        {
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String DelD = "DELETE from  Post_Type where (Rec_No ='" + psttrecno + "')";

            cmd1.CommandText = DelD;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
    }
}

