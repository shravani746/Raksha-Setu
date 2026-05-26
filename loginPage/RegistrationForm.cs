using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace loginPage
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Username: alphabets + numbers
                if (!Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Username must contain only letters and numbers");
                    return;
                }

                // Email validation
                if (!Regex.IsMatch(txtEmail.Text,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Enter a valid email address");
                    return;
                }

                // Mobile number: 10 digits
                if (!Regex.IsMatch(txtMobile.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Mobile number must be 10 digits");
                    return;
                }

                // Password: min 6 chars, 1 digit, 1 special char
                if (!Regex.IsMatch(txtPassword.Text,
                    @"^(?=.*\d)(?=.*[@$!%*#?&]).{6,}$"))
                {
                    MessageBox.Show("Password must contain at least one digit and one special character");
                    return;
                }

                // PIN code: 6 digits
                if (!Regex.IsMatch(txtPin.Text, @"^\d{6}$"))
                {
                    MessageBox.Show("PIN Code must be 6 digits");
                    return;
                }

                MessageBox.Show("Registration Successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
