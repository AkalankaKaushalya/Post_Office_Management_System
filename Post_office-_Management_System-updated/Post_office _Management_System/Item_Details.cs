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
    public partial class Item_Details : Form
    {
        public Item_Details()
        {
            InitializeComponent();
            TableLoad();
        }

        DBConnect db = new DBConnect();

        int itmNo;
        String itmName, itmRecNo, itmType, itmStatus, itmDescription;
       

        private void btnitmhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        //Item Data Insert 
        private void btnitmcrt_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtitmno.Text))
            {
                MessageBox.Show("       Number is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(txtitmnm.Text))
            {
                MessageBox.Show("       Item Name is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(txtitmtyp.Text))
            {
                MessageBox.Show("       Item Type is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(txtitmdes.Text))
            {
                MessageBox.Show("       Discription is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(cmbitmsts.Text))
            {
                MessageBox.Show("       Select Status", "Message");
            }
            else
            {
                try
                {
                    itmNo = Convert.ToInt32(this.txtitmno.Text.Trim());
                    itmName = this.txtitmnm.Text.Trim();
                    itmType = this.txtitmtyp.Text.Trim();
                    itmStatus = this.cmbitmsts.Text.Trim();
                    itmDescription = this.txtitmdes.Text.Trim();
                    itmRecNo = this.txtitmrec.Text.Trim();

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();
                    String addD = "insert into  Item (No, Name, Type, Status, Description, Rec_no) VALUES ('" + itmNo + "','" + itmName + "','" + itmType + "','" + itmStatus + "','" + itmDescription + "','" + itmRecNo + "')";

                    cmd1.CommandText = addD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    this.txtitmrec.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");
                    Clear();
                    TableLoad();



                }
                catch (Exception)
                {
                    MessageBox.Show("        Data Not Insert", "Message");
                    Clear();
                }
            }
           
        }
  //-----------------------------------------------------------------------------------------------//

        //Record Number auto Increment Method
        public int GetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                string addD = "Select max(Rec_No) from Item";

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

        //All Filed Clear Method
        private void Clear()
        {
            this.txtitmno.Text = "";
            this.txtitmnm.Text = "";
            this.txtitmtyp.Text = "";
            this.cmbitmsts.SelectedIndex = -1;
            this.txtitmdes.Text = "";
        }

        //Interface Load Mathod
        private void Item_Details_Load(object sender, EventArgs e)
        {
            this.txtitmrec.Enabled = false;
            //EmpDB obj1 = new EmpDB();
            this.txtitmrec.Text = Convert.ToString(GetNextNo());
        }


        //Only Can Type Number
        private void txtitmno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Seach Quary
        private void btnimtsrh_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtitmno.Text))
            {
                MessageBox.Show("Plice Enter Item Number.");
            }
            else
            {
                int itmNo = Convert.ToInt32(this.txtitmno.Text.ToString());

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String SrhDt = "SELECT * FROM Item WHERE (No ='" + itmNo + "')";

                cmd1.CommandText = SrhDt;
                cmd1.Connection = conn;

                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                
                if (dr.Read())
                {
                    do
                    {
                        txtitmnm.Text = dr[1].ToString();
                        txtitmtyp.Text = dr[2].ToString();
                        txtitmdes.Text = dr[3].ToString();
                        cmbitmsts.SelectedItem = dr[4].ToString();
                        txtitmrec.Text = dr[5].ToString();
                    } while (dr.Read());
                }
                else
                {
                    MessageBox.Show("No Item found for this item number.");
                    Clear();
                }

                conn.Close();
                conn.Dispose();
            }
        }


        //Delete Quary
        private void btnempdlt_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtitmno.Text))
            {
                MessageBox.Show("Plice Enter Item Number.");
            }
            else
            {
                int itmNo = Convert.ToInt32(this.txtitmno.Text.ToString());
                try
                {

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String dataDelete = "DELETE FROM Item WHERE No='" + itmNo + "' ";

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


        //Update Quary
        private void btnitmedt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtitmno.Text))
            {
                MessageBox.Show("       Number is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(txtitmnm.Text))
            {
                MessageBox.Show("       Item Name is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(txtitmtyp.Text))
            {
                MessageBox.Show("       Item Type is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(txtitmdes.Text))
            {
                MessageBox.Show("       Discription is Empty", "Message");
            }
            else if (String.IsNullOrEmpty(cmbitmsts.Text))
            {
                MessageBox.Show("       Select Status", "Message");
            }
            else
            {
                try
                {
                    itmNo = Convert.ToInt32(this.txtitmno.Text.Trim());
                    itmName = this.txtitmnm.Text.Trim();
                    itmType = this.txtitmtyp.Text.Trim();
                    itmStatus = this.cmbitmsts.Text.Trim();
                    itmDescription = this.txtitmdes.Text.Trim();
                    itmRecNo = this.txtitmrec.Text.Trim();

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();
                    String dataupdate = "UPDATE Item SET Name = '" + itmName + "', Type = '" + itmType + "', Description = '" + itmDescription + "', Status = '" + itmStatus + "', Rec_no = '" + itmRecNo + "' where No ='" + itmNo + "'";

                    cmd1.CommandText = dataupdate;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    this.txtitmrec.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("       Update Succesfully Created", "Message");
                    Clear();
                    TableLoad();
                }

                catch (Exception)
                {
                    MessageBox.Show("        Update Faile", "Message");
                    Clear();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        //-------------------Loan itme data to tabale------------//
        private void TableLoad()
        {
            ItemTable.Items.Clear();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter data = new SqlCeDataAdapter("SELECT * FROM Item", conn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["No"].ToString());

                listview.SubItems.Add(dr["Name"].ToString());
                listview.SubItems.Add(dr["Type"].ToString());
                listview.SubItems.Add(dr["Status"].ToString());
               

                
                ItemTable.Items.Add(listview);
                ItemTable.Show();
            }
        }
    }


}
