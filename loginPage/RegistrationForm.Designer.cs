namespace loginPage
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            lblTitle = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblMobile = new Label();
            lblPassword = new Label();
            lblPin = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtPassword = new TextBox();
            txtPin = new TextBox();
            btnRegister = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(92, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(240, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Registration";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Sylfaen", 12F);
            lblUsername.Location = new Point(91, 94);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Sylfaen", 12F);
            lblEmail.Location = new Point(91, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblMobile
            // 
            lblMobile.Font = new Font("Sylfaen", 12F);
            lblMobile.Location = new Point(91, 174);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(100, 23);
            lblMobile.TabIndex = 3;
            lblMobile.Text = "Mobile Number";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Sylfaen", 12F);
            lblPassword.Location = new Point(91, 214);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblPin
            // 
            lblPin.Font = new Font("Sylfaen", 12F);
            lblPin.Location = new Point(91, 254);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(100, 23);
            lblPin.TabIndex = 5;
            lblPin.Text = "PIN Code";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Sylfaen", 10.2F);
            txtUsername.Location = new Point(221, 94);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 30);
            txtUsername.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Sylfaen", 10.2F);
            txtEmail.Location = new Point(221, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 30);
            txtEmail.TabIndex = 7;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Sylfaen", 10.2F);
            txtMobile.Location = new Point(221, 174);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(100, 30);
            txtMobile.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sylfaen", 10.2F);
            txtPassword.Location = new Point(221, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 30);
            txtPassword.TabIndex = 9;
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Sylfaen", 10.2F);
            txtPin.Location = new Point(221, 254);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(100, 30);
            txtPin.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.ForestGreen;
            btnRegister.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(165, 325);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(117, 48);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(7, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 85);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(98, 27);
            label7.Name = "label7";
            label7.Size = new Size(191, 34);
            label7.TabIndex = 16;
            label7.Text = "Raksha Setu";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(18, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(83, 71);
            panel3.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(525, 26);
            button2.Name = "button2";
            button2.Size = new Size(108, 43);
            button2.TabIndex = 14;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(txtPin);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(txtMobile);
            panel2.Controls.Add(lblMobile);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblPin);
            panel2.Location = new Point(123, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 432);
            panel2.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            ClientSize = new Size(667, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrationForm";
            Text = "Registration Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle, lblUsername, lblEmail, lblMobile, lblPassword, lblPin;
        private System.Windows.Forms.TextBox txtUsername, txtEmail, txtMobile, txtPassword, txtPin;
        private System.Windows.Forms.Button btnRegister;
        private Panel panel1;
        private Label label7;
        private Panel panel3;
        private Button button2;
        private Panel panel2;
    }
}
