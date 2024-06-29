using Post_office__Management_System.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Post_office__Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        //time
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimelblPoMS.Text = DateTime.Now.ToString("T");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();//time
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            Employee_Details x = new Employee_Details();
            x.Show();
        }

        private void btndesig_Click(object sender, EventArgs e)
        {
            Designation_Details x = new Designation_Details();
            x.Show();
        }

        private void btnbrn_Click(object sender, EventArgs e)
        {
            Branch_Details x = new Branch_Details();
            x.Show();
        }

        private void btnpsttyp_Click(object sender, EventArgs e)
        {
            Post_Type_Details x = new Post_Type_Details();
            x.Show();
        }

        private void btnpkg_Click(object sender, EventArgs e)
        {
            Package_Details x = new Package_Details();
            x.Show();
        }

        private void btnslspri_Click(object sender, EventArgs e)
        {
            Sales_Price_Details x = new Sales_Price_Details();
            x.Show();
        }

        private void btncus_Click(object sender, EventArgs e)
        {
            Customer_Details x = new Customer_Details();
            x.Show();
        }

        private void btnadvpay_Click(object sender, EventArgs e)
        {
            Advance_Payment_Details x = new Advance_Payment_Details();
            x.Show();
        }

        private void btnsupdtl_Click(object sender, EventArgs e)
        {
            Supplier_Details x = new Supplier_Details();
            x.Show();
        }

        private void btnitmdtl_Click(object sender, EventArgs e)
        {
            Item_Details x = new Item_Details();
            x.Show();
        }

        private void btnpkgdel_Click(object sender, EventArgs e)
        {
            Package_Delivery_Details x = new Package_Delivery_Details();
            x.Show();
        }

        private void btnvehi_Click(object sender, EventArgs e)
        {
            Vehicle_Details x = new Vehicle_Details();
            x.Show();
        }

        private void btnpaydtl_Click(object sender, EventArgs e)
        {
            Payment_Details x = new Payment_Details();
            x.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            New_Dashboard x = new New_Dashboard();
            x.Show();
        }
    }
}
