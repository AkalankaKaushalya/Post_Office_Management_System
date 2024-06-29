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
    public partial class Designation_Details : Form
    {
        public Designation_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        int dsgrecno, dsgno;
        String dsgnm, dsgsts, dsgdes;

        private void btbdsghm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        //Form load
        private void Designation_Details_Load(object sender, EventArgs e)
        {
            this.txtdsgrecno.Enabled = false;
            Dsg_DB obj1 = new Dsg_DB();
            this.txtdsgrecno.Text = Convert.ToString(obj1.GetNextNo());
            this.btndsgedt.Visible = false;
            this.btndsgdlt.Visible = false;
            this.btndsgupd.Visible = false;
            this.btndsgcncl.Visible = false;
        }

        //Create designation
        private void btndsgcrt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdsgno.Text))
            {
                MessageBox.Show("Number is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtdsgnm.Text))
            {
                MessageBox.Show("Name is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(cmbdsgsts.Text))
            {
                MessageBox.Show("Status is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtdsgdes.Text))
            {
                MessageBox.Show("Description is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    dsgrecno = Convert.ToInt32(this.txtdsgrecno.Text.Trim());
                    dsgno = Convert.ToInt32(this.txtdsgno.Text.Trim());
                    dsgnm = this.txtdsgnm.Text.Trim();
                    dsgsts = this.cmbdsgsts.Text.Trim();
                    dsgdes = this.txtdsgdes.Text.Trim();

                    Dsg_DB CrtDsg = new Dsg_DB();
                    CrtDsg.AddData(dsgrecno, dsgno, dsgnm, dsgsts, dsgdes);

                    Clear();

                    this.txtdsgrecno.Text = Convert.ToString(CrtDsg.GetNextNo());
                    MessageBox.Show("Succesfully Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Data not inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Search designation
        private void btndsgsrh_Click(object sender, EventArgs e)
        {
            int dsgno = Convert.ToInt32(this.txtdsgno.Text.ToString());

            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeCommand cmd1 = new SqlCeCommand();

            String SrhDt = "select * from Designation where (No ='" + dsgno + "')";

            cmd1.CommandText = SrhDt;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtdsgrecno.Text = dr[4].ToString();
                this.txtdsgnm.Text = dr[1].ToString();
                this.cmbdsgsts.SelectedItem = dr[2].ToString();
                this.txtdsgdes.Text = dr[3].ToString();
            }

            conn.Close();
            conn.Dispose();

            Disable();

            this.btndsgedt.Visible = true;
            this.btndsgdlt.Visible = true;
            this.btndsgcrt.Visible = false;
            this.btndsgrst.Visible = false;

        }

        //Update designation
        private void btndsgupd_Click(object sender, EventArgs e)
        {
            int dsgrecno1 = Convert.ToInt32(this.txtdsgrecno.Text.Trim());
            int dsgno1 = Convert.ToInt32(this.txtdsgno.Text.Trim());
            String dsgnm1 = this.txtdsgnm.Text.Trim();
            String dsgsts1 = this.cmbdsgsts.Text.Trim();
            String dsgdes1 = this.txtdsgdes.Text.Trim();

            Dsg_DB UpdDsg = new Dsg_DB();
            UpdDsg.UpdateData(dsgrecno1, dsgno1, dsgnm1, dsgsts1, dsgdes1);

            Clear();

            this.txtdsgrecno.Text = Convert.ToString(UpdDsg.GetNextNo());
            MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndsgedt_Click(object sender, EventArgs e)
        {
            Enable();
            this.btndsgcrt.Visible = false;
            this.btndsgsrh.Visible = false;
            this.btndsgupd.Visible = true;
            this.btndsgdlt.Visible = true;
            this.btndsgrst.Visible = true;
        }

        //Delete designation
        private void btndsgdlt_Click(object sender, EventArgs e)
        {
            Dsg_DB DltDsg = new Dsg_DB();
            int dsgno = Convert.ToInt32(this.txtdsgno.Text.ToString());
            DltDsg.DeleteData(dsgno);
            Clear();
            
            MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtdsgrecno.Text = Convert.ToString(DltDsg.GetNextNo());
            lstvDESG.Items.Clear();
        }

        private void btndsgrst_Click(object sender, EventArgs e)
        {
            Clear();
            Dsg_DB CrtDsg = new Dsg_DB();
            this.txtdsgrecno.Text = Convert.ToString(CrtDsg.GetNextNo());
        }

        private void btndsgcncl_Click(object sender, EventArgs e)
        {
            this.btndsgcrt.Visible = true;
            this.btndsgsrh.Visible = true;
            this.btndsgupd.Visible = false;
            this.btndsgdlt.Visible = false;
            this.btndsgrst.Visible = true;
        }

        private void lnklblDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstvDESG.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter ada = new SqlCeDataAdapter("select * from Designation", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["Rec_No"].ToString());
                listview.SubItems.Add(dr["No"].ToString());
                listview.SubItems.Add(dr["Name"].ToString());
                listview.SubItems.Add(dr["Status"].ToString());
                listview.SubItems.Add(dr["Description"].ToString());
                lstvDESG.Items.Add(listview);
                lstvDESG.Show();
            }
        }

        private void lstvDESG_DoubleClick(object sender, EventArgs e)
        {
            this.txtdsgrecno.Text = this.lstvDESG.SelectedItems[0].SubItems[0].Text;
            this.txtdsgno.Text = this.lstvDESG.SelectedItems[0].SubItems[1].Text;
            this.txtdsgnm.Text = this.lstvDESG.SelectedItems[0].SubItems[2].Text;
            this.cmbdsgsts.Text = this.lstvDESG.SelectedItems[0].SubItems[3].Text;
            this.txtdsgdes.Text = this.lstvDESG.SelectedItems[0].SubItems[4].Text;

            Disable();
            this.btndsgedt.Visible = true;
            this.btndsgrst.Visible = false;
        }

        public void Clear()
        {
            this.txtdsgno.Text = "";
            this.txtdsgnm.Text = "";
            this.cmbdsgsts.SelectedIndex = -1;
            this.txtdsgdes.Text = "";
        }

        private void Enable()
        {
            this.txtdsgno.Enabled = true;
            this.txtdsgnm.Enabled = true;
            this.cmbdsgsts.Enabled = true;
            this.txtdsgdes.Enabled = true;
        }

        private void Disable()
        {
            this.txtdsgno.Enabled = false;
            this.txtdsgnm.Enabled = false;
            this.cmbdsgsts.Enabled = false;
            this.txtdsgdes.Enabled = false;
        }

        private void txtdsgno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

    }
}
