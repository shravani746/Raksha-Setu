using System;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // -------------------------------
        // VALIDATION METHOD
        // -------------------------------
        private bool ValidateDonationInputs()
        {
            // Donor Name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter Donor Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Contact number
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                textBox2.Text.Length != 10 ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Please enter a valid 10-digit Contact Number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Item Category
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item Category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Item Name
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter the Item Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Quantity
            if (!int.TryParse(textBox5.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Price
            if (!double.TryParse(textBox6.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Price per item must be a valid positive number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All good
        }

        // -------------------------------
        // CALCULATE TOTAL BUTTON
        // -------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            if (!ValidateDonationInputs()) return;

            int qty = int.Parse(textBox5.Text);
            double price = double.Parse(textBox6.Text);

            double total = qty * price;

            textBox3.Text = total.ToString();
            MessageBox.Show("Total calculated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -------------------------------
        // CALCULATE POINTS BUTTON
        // -------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please calculate total first.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double total = double.Parse(textBox3.Text);

            // 1 point for every ₹100
            int points = (int)(total / 100);

            textBox7.Text = points.ToString();

            MessageBox.Show("Reward points calculated!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -------------------------------
        // PROCEED BUTTON
        // -------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            if (!ValidateDonationInputs()) return;

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please calculate the total donation value.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please calculate reward points.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Donation submitted successfully!\nThank you for your support.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
