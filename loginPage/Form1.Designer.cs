namespace loginPage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            linkLabel3 = new LinkLabel();
            richTextBox1 = new RichTextBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(40, 203);
            label2.Name = "label2";
            label2.Size = new Size(211, 45);
            label2.TabIndex = 1;
            label2.Text = "Welcome to";
            label2.Click += label2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(40, 250);
            label5.Name = "label5";
            label5.Size = new Size(319, 57);
            label5.TabIndex = 13;
            label5.Text = "Raksha Setu";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 85);
            panel1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(456, 34);
            label8.Name = "label8";
            label8.Size = new Size(94, 26);
            label8.TabIndex = 14;
            label8.Text = "AboutUs";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(617, 34);
            label9.Name = "label9";
            label9.Size = new Size(110, 26);
            label9.TabIndex = 15;
            label9.Text = "ContactUs";
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
            button2.Location = new Point(986, 26);
            button2.Name = "button2";
            button2.Size = new Size(142, 43);
            button2.TabIndex = 14;
            button2.Text = "Register now";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Volunteer", "Donor", "Relief Center", "Admin" });
            comboBox1.Location = new Point(46, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 28);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Volunteer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(24, 166);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 195);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter your Password";
            textBox2.Size = new Size(314, 43);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your username";
            textBox1.Size = new Size(314, 43);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(24, 262);
            label4.Name = "label4";
            label4.Size = new Size(95, 26);
            label4.TabIndex = 3;
            label4.Text = "Login As";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Perpetua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.DarkSlateGray;
            checkBox1.Location = new Point(236, 336);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(107, 372);
            button1.Name = "button1";
            button1.Size = new Size(187, 43);
            button1.TabIndex = 7;
            button1.Text = "Login >";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(145, 19);
            label6.Name = "label6";
            label6.Size = new Size(105, 44);
            label6.TabIndex = 12;
            label6.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(24, 71);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(663, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 472);
            panel2.TabIndex = 13;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.DarkSlateGray;
            linkLabel3.Location = new Point(237, 427);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(136, 19);
            linkLabel3.TabIndex = 13;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Forgot password?";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.DarkSlateGray;
            richTextBox1.Location = new Point(51, 330);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(505, 100);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "Empowering people to help people.\nConnecting compassion with action, we unite donors, volunteers, and relief workers to uplift communities affected by disasters.\nTogether, we create hope.";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(71, 445);
            panel4.Name = "panel4";
            panel4.Size = new Size(436, 321);
            panel4.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1167, 826);
            Controls.Add(panel4);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label5;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private CheckBox checkBox1;
        private Button button1;
        private Label label6;
        private Label label1;
        private Panel panel2;
        private LinkLabel linkLabel3;
        private Button button2;
        private Panel panel3;
        private RichTextBox richTextBox1;
        private Label label7;
        private Panel panel4;
        private Label label8;
        private Label label9;
    }
}
