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
    public partial class Post_Type_Details : Form
    {
        public Post_Type_Details()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        int psttrecno;
        String pssttptyp, psstpcat, psttpitm, psttpwgh, psttpcnt, psttpprc, psttpdes;

        private void btnpsttphm_Click(object sender, EventArgs e)
        {
            Dashboard x = new Dashboard();
            this.Hide();
        }

        private void Post_Type_Details_Load(object sender, EventArgs e)
        {
            this.txtpsttrec.Enabled = false;
            PostTypeDB adv = new PostTypeDB();
            this.txtpsttrec.Text = Convert.ToString(adv.GetNextNo());
        }

        //create post type
        private void btnpsttpcrt_Click(object sender, EventArgs e)
        {
            psttrecno = Convert.ToInt32(this.txtpsttrec.Text.Trim());
            pssttptyp = this.cmbpssttptyp.Text.Trim();
            psstpcat = this.cmbpsstpcat.Text.Trim();
            psttpitm = this.cmbpsttpitm.Text.Trim();
            psttpwgh = this.cmbpsttpwgh.Text.Trim();
            psttpcnt = this.cmbpsttpcnt.Text.Trim();
            psttpprc = this.txtpsttpprc.Text.Trim();
            psttpdes = this.txtpsttpdes.Text.Trim();

            PostTypeDB psttypDB = new PostTypeDB();
            psttypDB.addData(psttrecno, pssttptyp, psstpcat, psttpitm, psttpwgh, psttpcnt, psttpprc, psttpdes);

            Clear();

            this.txtpsttrec.Text = Convert.ToString(psttypDB.GetNextNo());
            MessageBox.Show("Succesfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear()
        {
            this.txtpsttrec.Text = "";
            this.cmbpssttptyp.SelectedIndex = -1;
            this.cmbpsstpcat.SelectedIndex = -1;
            this.cmbpsttpitm.SelectedIndex = -1;
            this.cmbpsttpwgh.SelectedIndex = -1;
            this.cmbpsttpcnt.SelectedIndex = -1;
            this.txtpsttpprc.Text = "";
            this.txtpsttpdes.Text = "";
        }

        //search
        private void linkLabel_ViewDt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstvPSTP.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(db.path);
            SqlCeDataAdapter ada = new SqlCeDataAdapter("select * from Post_Type", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listview = new ListViewItem(dr["Rec_No"].ToString());
                listview.SubItems.Add(dr["Type"].ToString());
                listview.SubItems.Add(dr["Category"].ToString());
                listview.SubItems.Add(dr["Item"].ToString());
                listview.SubItems.Add(dr["Weight_Category"].ToString());
                listview.SubItems.Add(dr["Country"].ToString());
                listview.SubItems.Add(dr["Price"].ToString());
                listview.SubItems.Add(dr["Description"].ToString());
                lstvPSTP.Items.Add(listview);
                lstvPSTP.Show();
            }
        }

        private void lstvPSTP_DoubleClick(object sender, EventArgs e)
        {
            Clear();
            this.txtpsttrec.Text = this.lstvPSTP.SelectedItems[0].SubItems[0].Text;
            this.cmbpssttptyp.Text = this.lstvPSTP.SelectedItems[0].SubItems[1].Text;
            this.cmbpsstpcat.Text = this.lstvPSTP.SelectedItems[0].SubItems[2].Text;
            this.cmbpsttpitm.Text = this.lstvPSTP.SelectedItems[0].SubItems[3].Text;
            this.cmbpsttpwgh.Text = this.lstvPSTP.SelectedItems[0].SubItems[4].Text;
            this.cmbpsttpcnt.Text = this.lstvPSTP.SelectedItems[0].SubItems[5].Text;
            this.txtpsttpprc.Text = this.lstvPSTP.SelectedItems[0].SubItems[6].Text;
            this.txtpsttpdes.Text = this.lstvPSTP.SelectedItems[0].SubItems[7].Text;
        }

        //update
        private void btnpsttpupd_Click(object sender, EventArgs e)
        {
            psttrecno = Convert.ToInt32(this.txtpsttrec.Text.Trim());
            pssttptyp = this.cmbpssttptyp.Text.Trim();
            psstpcat = this.cmbpsstpcat.Text.Trim();
            psttpitm = this.cmbpsttpitm.Text.Trim();
            psttpwgh = this.cmbpsttpwgh.Text.Trim();
            psttpcnt = this.cmbpsttpcnt.Text.Trim();
            psttpprc = this.txtpsttpprc.Text.Trim();
            psttpdes = this.txtpsttpdes.Text.Trim();

            PostTypeDB UpdtPsttyp = new PostTypeDB();
            UpdtPsttyp.UpdateData(psttrecno, pssttptyp, psstpcat, psttpitm, psttpwgh, psttpcnt, psttpprc, psttpdes);

            Clear();

            this.txtpsttrec.Text = Convert.ToString(UpdtPsttyp.GetNextNo());
            MessageBox.Show("Succesfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lstvPSTP.Items.Clear();
            this.txtpsttrec.Text = Convert.ToString(UpdtPsttyp.GetNextNo());
        }

        private void btnpsttpdlt_Click(object sender, EventArgs e)
        {
                PostTypeDB DltPsttyp = new PostTypeDB();
                int psttrecno = Convert.ToInt32(this.txtpsttrec.Text.ToString());
                DltPsttyp.DeleteData(psttrecno);
                Clear();
                lstvPSTP.Items.Clear();
                MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.txtpsttrec.Text = Convert.ToString(DltPsttyp.GetNextNo());
        }

    }
}
