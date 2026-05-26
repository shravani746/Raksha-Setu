namespace loginPage
{
    partial class VolunteerReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblTitle = new Label();
            panelLeft = new Panel();
            btnOpen = new Button();
            btnSave = new Button();
            btnFont = new Button();
            btnColor = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkSlateGray;
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(964, 60);
            panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(509, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SmartAid Network – Volunteer Field Report";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Gainsboro;
            panelLeft.Controls.Add(btnOpen);
            panelLeft.Controls.Add(btnSave);
            panelLeft.Controls.Add(btnFont);
            panelLeft.Controls.Add(btnColor);
            panelLeft.Controls.Add(btnPrint);
            panelLeft.Controls.Add(btnExit);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 60);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(180, 527);
            panelLeft.TabIndex = 1;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(15, 20);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(150, 40);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open Guidelines";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(15, 75);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Report";
            btnSave.Click += btnSave_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(15, 130);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(150, 40);
            btnFont.TabIndex = 2;
            btnFont.Text = "Change Font";
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(15, 185);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(150, 40);
            btnColor.TabIndex = 3;
            btnColor.Text = "Text Color";
            btnColor.Click += btnColor_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(15, 240);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(150, 40);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(15, 295);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 11F);
            richTextBox1.Location = new Point(180, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(784, 527);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // VolunteerReportForm
            // 
            ClientSize = new Size(964, 587);
            Controls.Add(richTextBox1);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "VolunteerReportForm";
            Text = "Volunteer Report";
            WindowState = FormWindowState.Maximized;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
