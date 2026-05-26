using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // DebugMessage to confirm button click
            MessageBox.Show("Submit Click triggered!");

            // Validate Relief Center Name
            if (string.IsNullOrWhiteSpace(txtCenterName.Text) ||
                !Regex.IsMatch(txtCenterName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Enter a valid Relief Center Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Location
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Location cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Item Category
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Item Category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Quantity
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter a valid Quantity greater than 0.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Priority
            if (cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Priority Level.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Database Insert
                using (SqlConnection con = new SqlConnection(
@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\Users\shrav\source\repos\loginPage\loginPage\SmartAidDB.mdf;
Integrated Security=True;Connect Timeout=30"))

                {
                    string query = @"INSERT INTO ReliefRequests (CenterName, Location, Category, Quantity, Priority) 
                                     VALUES (@CenterName, @Location, @Category, @Quantity, @Priority)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CenterName", txtCenterName.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                    cmd.Parameters.AddWithValue("@Quantity", qty);
                    cmd.Parameters.AddWithValue("@Priority", cmbPriority.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error ❌\n\n" + ex.Message, "DB Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Success Summary
            string summary =
                "📌 Relief Request Summary\n\n" +
                $"Relief Center Name : {txtCenterName.Text}\n" +
                $"Location : {txtLocation.Text}\n" +
                $"Item Category : {cmbCategory.Text}\n" +
                $"Quantity Needed : {qty}\n" +
                $"Priority Level : {cmbPriority.Text}\n\n" +
                "Request Submitted Successfully! 🟢\n" +
                "Our relief team will review it soon.";

            MessageBox.Show(summary, "Request Details",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form after submission
            txtCenterName.Clear();
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            txtQuantity.Clear();
            cmbPriority.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 dashboard = new Form3();
            dashboard.Show();
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
