using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // 🔗 Database Connection
        SqlConnection con = new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\Users\shrav\source\repos\loginPage\loginPage\SmartAidDB.mdf;
Integrated Security=True;Connect Timeout=30");

        // 📌 Load DB Records into Grid
        private void LoadData()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ReliefRequests", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // 📌 Select Row to Edit/Delete
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtRequestID.Text = dataGridView1.Rows[e.RowIndex].Cells["RequestID"].Value.ToString();
                txtCenterName.Text = dataGridView1.Rows[e.RowIndex].Cells["CenterName"].Value.ToString();
                txtLocation.Text = dataGridView1.Rows[e.RowIndex].Cells["Location"].Value.ToString();
                cmbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                cmbPriority.Text = dataGridView1.Rows[e.RowIndex].Cells["Priority"].Value.ToString();
            }
        }

        // 📝 UPDATE Record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRequestID.Text == "")
            {
                MessageBox.Show("Select a record to update!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "UPDATE ReliefRequests SET CenterName=@CenterName, Location=@Location, Category=@Category, Quantity=@Quantity, Priority=@Priority WHERE RequestID=@RequestID", con);

                cmd.Parameters.AddWithValue("@CenterName", txtCenterName.Text);
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@Priority", cmbPriority.Text);
                cmd.Parameters.AddWithValue("@RequestID", int.Parse(txtRequestID.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Updated Successfully!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }

        // ❌ DELETE Record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRequestID.Text == "")
            {
                MessageBox.Show("Select a record to delete!");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                    "DELETE FROM ReliefRequests WHERE RequestID=@RequestID", con);
                    cmd.Parameters.AddWithValue("@RequestID", int.Parse(txtRequestID.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Deleted Successfully!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
            }
        }

        // 🔄 REFRESH BUTTON
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // 🔙 BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }
    }
}
