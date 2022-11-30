using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Drive
{
    public partial class RentVehicle : Form
    {
        public RentVehicle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=NADU-PC;Initial Catalog=AyuboDriveDB;Integrated Security=True");

        void getAllData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Rented_Vehicle", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvRentvehicle.DataSource = dt;
        }

        private void btnRentvehicle_Click(object sender, EventArgs e)
        {
            try
            {
                string vtype = cbVehicletype.Text;
                DateTime rentdate = dtpRenteddate.Value;
                DateTime returndate = dtpReturndate.Value;
                string driver = rdoYes.Text;
                float total = float.Parse(txtRenttotal.Text);

                if (rdoYes.Checked == true)
                {
                    string query_select = "insert into Rented_Vehicle values ('" + vtype + "','" + rentdate + "','" + returndate + "','Yes','" + total + "')";
                    SqlCommand cmd = new SqlCommand(query_select, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                else if(rdoNo.Checked == true)
                {
                    string query_select = "insert into Rented_Vehicle values ('" + vtype + "','" + rentdate + "','" + returndate + "','No','" + total + "')";
                    SqlCommand cmd = new SqlCommand(query_select, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Vehicle rented successfully !", "Successfull !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot rent a vehicle !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
