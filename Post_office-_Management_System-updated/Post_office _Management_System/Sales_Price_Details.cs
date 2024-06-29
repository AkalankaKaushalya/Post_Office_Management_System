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
    
    public partial class Sales_Price_Details : Form
    {

        DBConnect db = new DBConnect();

        String spdStatus, spdDiscription;
        int spdNo, spdValue, spdRecNo;
        DateTime spdDate;
       
        public Sales_Price_Details()
        {
            InitializeComponent();
            TableLoad();
           
        }
           
        //SPD Page Lode
        private void Sales_Price_Details_Load(object sender, EventArgs e)
        {
            
            this.txtslsprcrec.Enabled = false;
            this.txtslsprcrec.Text = Convert.ToString(GetNextNo());

        }


        //---------------- Insert Data-----------------//
        private void btnslsprcrt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtslsprcno.Text))
            {
                MessageBox.Show("        Please Enter Nomber", "Message");
            }
            else if (String.IsNullOrEmpty(txtslsprcvlu.Text))
            {
                MessageBox.Show("        Please Enter Value", "Message");
            }
            else if (String.IsNullOrEmpty(cmbslsprcsts.Text)) 
            {
                MessageBox.Show("        Please Select Status", "Message");
            }
            else if (String.IsNullOrEmpty(txtslsprcdes.Text))
            {
                MessageBox.Show("        Please Enter Discription", "Message");
            }
            else if (txtslsprcvlu.Text.Length > 2) 
            {
                MessageBox.Show("        Value Filed max Lenth is 2", "Message");
            }
            else if (txtslsprcdes.Text.Length > 100)
            {
                MessageBox.Show("       Description Field max Lenth is 100", "Message");
            }
            else
            {
               /* try
                {*/
                    spdRecNo = Convert.ToInt32(this.txtslsprcrec.Text.Trim());
                    spdNo = Convert.ToInt32(this.txtslsprcno.Text.Trim());
                    spdValue = Convert.ToInt32(this.txtslsprcvlu.Text.Trim());
                    spdDate = Convert.ToDateTime(this.dtpslsprcsdt.Text.Trim());
                    spdStatus = this.cmbslsprcsts.Text.Trim();
                    spdDiscription = this.txtslsprcdes.Text.Trim();

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();
                    String addD = "insert into Sales_Price values('" + spdNo + "','" + spdValue + "','" + spdDate + "','" + spdStatus + "','" + spdDiscription + "', '" + spdRecNo + "')";

                    cmd1.CommandText = addD;
                    cmd1.Connection = conn;
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    this.txtslsprcrec.Text = Convert.ToString(GetNextNo());
                    MessageBox.Show("        Succesfully Created", "Message");
                    Clear();
                    TableLoad();
                /*}
                catch (Exception el)
                {
                    //MessageBox.Show("        This number already assigned"+spdNo, "Message");
                }*/

            }
        }


        //Back To Home
        private void btnslsprhm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        //All Filed Clear Method
        private void Clear()
        {
            this.txtslsprcno.Text = "";
            this.txtslsprcvlu.Text = "";
            this.dtpslsprcsdt.Text = "";
            this.cmbslsprcsts.SelectedIndex = -1;
            this.txtslsprcdes.Text = "";
        }

        //Record Number auto Increment Method
        public int GetNextNo()
        {
            try
            {
                int newNo = 0;

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();
                string genaretrecNo = "Select max(Rec_no) from Sales_Price";

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

        //Only Can Type Number
        private void txtslsprcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

        }

        //Only Can Type Number Decimal
        private void txtslsprcvlu_KeyPress(object sender, KeyPressEventArgs e)
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

        
        //-------- Serach Data ----------------//
        private void btnslsprsrh_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtslsprcno.Text))
            {
                MessageBox.Show("Plice Enter Item Number.");
            }
            else
            {
                int spdNo = Convert.ToInt32(this.txtslsprcno.Text.ToString());

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String SrhDt = "select * from Sales_Price where (No ='" + spdNo + "')";

                cmd1.CommandText = SrhDt;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {

                    do
                    {
                        this.txtslsprcvlu.Text = dr[1].ToString();
                        this.dtpslsprcsdt.Text = dr[2].ToString();
                        this.cmbslsprcsts.SelectedItem = dr[3].ToString();
                        this.txtslsprcdes.Text = dr[4].ToString();
                        this.txtslsprcrec.Text = dr[5].ToString();
                    }
                    while (dr.Read());
                }
                else
                {
                    MessageBox.Show("This number not data have yet now");
                }

                conn.Close();
                conn.Dispose();
            }
        }

        //-------- Update Data ---------------//
        private void btnslspredt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtslsprcno.Text))
            {
                MessageBox.Show("        Please Enter Nomber", "Message");
            }
            else if (String.IsNullOrEmpty(txtslsprcvlu.Text))
            {
                MessageBox.Show("        Please Enter Value", "Message");
            }
            else if (String.IsNullOrEmpty(cmbslsprcsts.Text))
            {
                MessageBox.Show("        Please Select Status", "Message");
            }
            else if (String.IsNullOrEmpty(txtslsprcdes.Text))
            {
                MessageBox.Show("        Please Enter Discription", "Message");
            }
            else if (txtslsprcvlu.Text.Length > 2)
            {
                MessageBox.Show("        Value Filed max Lenth is 2", "Message");
            }
            else if (txtslsprcdes.Text.Length > 100)
            {
                MessageBox.Show("       Description Field max Lenth is 100", "Message");
            }
            else
            {
                 /*try
                 {*/
                spdRecNo = Convert.ToInt32(this.txtslsprcrec.Text.Trim());
                spdNo = Convert.ToInt32(this.txtslsprcno.Text.Trim());
                spdValue = Convert.ToInt32(this.txtslsprcvlu.Text.Trim());
                spdDate = Convert.ToDateTime(this.dtpslsprcsdt.Text.Trim());
                spdStatus = this.cmbslsprcsts.Text.Trim();
                spdDiscription = this.txtslsprcdes.Text.Trim();

                SqlCeConnection conn = new SqlCeConnection(db.path);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String addD = "UPDATE Sales_Price SET Value = '" + spdValue + "', Start_Date = '" + spdDate + "', Status = '" + spdStatus + "', Description = '" + spdDiscription + "', Rec_no = '" + spdRecNo + "' where No ='" + spdNo + "'";
                cmd1.CommandText = addD;
                cmd1.Connection = conn;
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();

                this.txtslsprcrec.Text = Convert.ToString(GetNextNo());
                MessageBox.Show("        Succesfully Created", "Message");
                Clear();
                TableLoad();
                /*}
                catch (Exception el)
                {
                    MessageBox.Show("        This number already assigned"+spdNo, "Message");
                }*/

            }
        }

        //-------- Delete Data --------------//
        private void btnslsprdlt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtslsprcno.Text))
            {
                MessageBox.Show("Plice Enter  Number.");
            }
            else
            {
                //int spdRec_No = Convert.ToInt32(this.txtrecno.Text.ToString());
                int spdNo = Convert.ToInt32(this.txtslsprcno.Text.ToString());
                try
                {

                    SqlCeConnection conn = new SqlCeConnection(db.path);
                    SqlCeCommand cmd1 = new SqlCeCommand();

                    String dataDelete = "DELETE FROM Sales_Price WHERE No='" + spdNo + "' ";

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


        //-------------------Loan Sales Price data to tabale------------//
        private void TableLoad()
        {
            ItemTable.Items.Clear();

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter data = new SqlCeDataAdapter("SELECT * FROM Sales_Price", conn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["No"].ToString());
                listview.SubItems.Add(dr["Value"].ToString());
                listview.SubItems.Add(dr["Start_Date"].ToString());
                listview.SubItems.Add(dr["Status"].ToString());

                ItemTable.Items.Add(listview);
                ItemTable.Show();
            }
        }
    }
}
