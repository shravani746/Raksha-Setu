namespace loginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // You can leave this empty
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string role = comboBox1.Text;

            // --- Username validation ---
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Letters + numbers only
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Username can contain only letters and numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Password validation ---
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Success ---
            MessageBox.Show("Login Successful!", "Welcome",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open Donation Form
            if (role == "Donor")
            {
                Form2 donationForm = new Form2();
                donationForm.Show();
                this.Hide();
            }
            if (role == "Relief Center")
            {
                Form3 reliefrequest = new Form3();
                reliefrequest.Show();
                this.Hide();
            }
            if (role == "Volunteer")
            {
                VolunteerReportForm volunteer = new VolunteerReportForm();
                volunteer.Show();
                this.Hide();
            }
            if (role == "Admin")
            {
                Form5 Admin = new Form5();
                Admin.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear button logic
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
            this.Hide();
        }
    }
}
