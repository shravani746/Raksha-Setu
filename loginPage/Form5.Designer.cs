namespace loginPage
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            txtRequestID = new TextBox();
            txtCenterName = new TextBox();
            txtLocation = new TextBox();
            txtQuantity = new TextBox();
            cmbCategory = new ComboBox();
            cmbPriority = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(185, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(379, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Relief Requests Management";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 229);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtRequestID
            // 
            txtRequestID.Location = new Point(586, 494);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.ReadOnly = true;
            txtRequestID.Size = new Size(233, 27);
            txtRequestID.TabIndex = 2;
            // 
            // txtCenterName
            // 
            txtCenterName.Location = new Point(586, 546);
            txtCenterName.Name = "txtCenterName";
            txtCenterName.Size = new Size(233, 27);
            txtCenterName.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(586, 593);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(233, 27);
            txtLocation.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(586, 692);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(233, 27);
            txtQuantity.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Food", "Clothing", "Medicines", "Blankets", "Kits", "Other" });
            cmbCategory.Location = new Point(586, 639);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(233, 28);
            cmbCategory.TabIndex = 6;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "High", "Medium", "Low" });
            cmbPriority.Location = new Point(586, 742);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(233, 28);
            cmbPriority.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Font = new Font("Sitka Heading", 10.1999989F);
            btnUpdate.Location = new Point(944, 525);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Font = new Font("Sitka Heading", 10.1999989F);
            btnDelete.Location = new Point(944, 591);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ActiveCaption;
            btnRefresh.Font = new Font("Sitka Heading", 10.1999989F);
            btnRefresh.Location = new Point(944, 652);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 43);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Sitka Heading", 10.1999989F);
            btnBack.Location = new Point(944, 718);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 43);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(372, 514);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(364, 555);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 13;
            label2.Text = "CENTER NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(364, 602);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 14;
            label3.Text = "LOCATION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(364, 644);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 15;
            label4.Text = "ITEMS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(364, 696);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 16;
            label5.Text = "QUANTITY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(364, 747);
            label6.Name = "label6";
            label6.Size = new Size(103, 23);
            label6.TabIndex = 17;
            label6.Text = "PRIORITY";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(295, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 61);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 85);
            panel2.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(1032, -10);
            panel5.Name = "panel5";
            panel5.Size = new Size(125, 97);
            panel5.TabIndex = 17;
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
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(9, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 714);
            panel4.TabIndex = 22;
            // 
            // button7
            // 
            button7.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            button7.ForeColor = Color.DarkSlateGray;
            button7.Location = new Point(8, 635);
            button7.Name = "button7";
            button7.Size = new Size(224, 56);
            button7.TabIndex = 6;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            button6.ForeColor = Color.DarkSlateGray;
            button6.Location = new Point(10, 229);
            button6.Name = "button6";
            button6.Size = new Size(224, 56);
            button6.TabIndex = 5;
            button6.Text = "Inventory";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            button5.ForeColor = Color.DarkSlateGray;
            button5.Location = new Point(8, 566);
            button5.Name = "button5";
            button5.Size = new Size(224, 56);
            button5.TabIndex = 4;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            button4.ForeColor = Color.DarkSlateGray;
            button4.Location = new Point(8, 303);
            button4.Name = "button4";
            button4.Size = new Size(224, 56);
            button4.TabIndex = 3;
            button4.Text = "Contributions";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(8, 156);
            button3.Name = "button3";
            button3.Size = new Size(224, 56);
            button3.TabIndex = 2;
            button3.Text = "Volunteer List";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(8, 84);
            button2.Name = "button2";
            button2.Size = new Size(224, 56);
            button2.TabIndex = 1;
            button2.Text = "Manage Requests";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(8, 13);
            button1.Name = "button1";
            button1.Size = new Size(224, 56);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(337, 200);
            label10.Name = "label10";
            label10.Size = new Size(142, 22);
            label10.TabIndex = 23;
            label10.Text = "Pending Requests:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 849);
            Controls.Add(label10);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cmbPriority);
            Controls.Add(cmbCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtLocation);
            Controls.Add(txtCenterName);
            Controls.Add(txtRequestID);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Manage Requests";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dataGridView1;
        private TextBox txtRequestID;
        private TextBox txtCenterName;
        private TextBox txtLocation;
        private TextBox txtQuantity;
        private ComboBox cmbCategory;
        private ComboBox cmbPriority;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Label label8;
        private Label label9;
        private Label label7;
        private Panel panel3;
        private Panel panel4;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label10;
    }
}