namespace LearnToProg
{
    partial class BookingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.displayButton = new System.Windows.Forms.Button();
            this.mealsListBox = new System.Windows.Forms.ListBox();
            this.lodgesticListBox = new System.Windows.Forms.ListBox();
            this.workShopListBox = new System.Windows.Forms.ListBox();
            this.summaryButton = new System.Windows.Forms.Button();
            this.printedYesRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.userHelpLabel = new System.Windows.Forms.Label();
            this.displayValueLabel6 = new System.Windows.Forms.Label();
            this.displayLabel6 = new System.Windows.Forms.Label();
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.displayLabel3 = new System.Windows.Forms.Label();
            this.displayLabel4 = new System.Windows.Forms.Label();
            this.displayLabel5 = new System.Windows.Forms.Label();
            this.displayValueLabel2 = new System.Windows.Forms.Label();
            this.displayValueLabel3 = new System.Windows.Forms.Label();
            this.displayValueLabel5 = new System.Windows.Forms.Label();
            this.displayValueLabel4 = new System.Windows.Forms.Label();
            this.displayValueLabel1 = new System.Windows.Forms.Label();
            this.displayLabel1 = new System.Windows.Forms.Label();
            this.printedCertificateGroupBox = new System.Windows.Forms.GroupBox();
            this.printedNoRadio = new System.Windows.Forms.RadioButton();
            this.userInputGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisplayToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BookToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LogOutToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip18 = new System.Windows.Forms.ToolTip(this.components);
            this.summaryGroupBox.SuspendLayout();
            this.printedCertificateGroupBox.SuspendLayout();
            this.userInputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(73, 356);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(113, 23);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "&Display";
            this.DisplayToolTip.SetToolTip(this.displayButton, "Once you click the display button you will get the total cost based on your choic" +
        "es.     Alt+D ");
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // mealsListBox
            // 
            this.mealsListBox.FormatString = "\'\'\' ";
            this.mealsListBox.FormattingEnabled = true;
            this.mealsListBox.Items.AddRange(new object[] {
            "Full Board       €39.50 ",
            "Half Board      €27.50  ",
            "Breakfast        €12.50"});
            this.mealsListBox.Location = new System.Drawing.Point(611, 53);
            this.mealsListBox.Margin = new System.Windows.Forms.Padding(8);
            this.mealsListBox.Name = "mealsListBox";
            this.mealsListBox.Size = new System.Drawing.Size(125, 43);
            this.mealsListBox.TabIndex = 1;
            // 
            // lodgesticListBox
            // 
            this.lodgesticListBox.FormattingEnabled = true;
            this.lodgesticListBox.Items.AddRange(new object[] {
            "Cork\t\t   €150",
            "Dublin\t\t   €225",
            "Galway\t\t   €175",
            "Belmullet\t\t   €305",
            "Limerick\t\t   €135",
            "Wexford\t\t   €89"});
            this.lodgesticListBox.Location = new System.Drawing.Point(361, 53);
            this.lodgesticListBox.Name = "lodgesticListBox";
            this.lodgesticListBox.Size = new System.Drawing.Size(175, 82);
            this.lodgesticListBox.TabIndex = 2;
            // 
            // workShopListBox
            // 
            this.workShopListBox.FormattingEnabled = true;
            this.workShopListBox.Items.AddRange(new object[] {
            "ASP.NET with C#\t\t4\t€1,200",
            "Windows App with C#\t3\t€1,000",
            ".NET Prog using C# Part 1\t4\t€1,500",
            ".NET Prog using C# Part 2\t4\t€1,800",
            "Digital Deto\t\t1\t€599"});
            this.workShopListBox.Location = new System.Drawing.Point(20, 52);
            this.workShopListBox.Name = "workShopListBox";
            this.workShopListBox.Size = new System.Drawing.Size(284, 69);
            this.workShopListBox.TabIndex = 3;
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(376, 356);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(126, 23);
            this.summaryButton.TabIndex = 4;
            this.summaryButton.Text = "&Summary";
            this.SummaryToolTip.SetToolTip(this.summaryButton, "Click on this to view previous enteries.       Alt+S");
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // printedYesRadio
            // 
            this.printedYesRadio.AutoSize = true;
            this.printedYesRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedYesRadio.Location = new System.Drawing.Point(6, 19);
            this.printedYesRadio.Name = "printedYesRadio";
            this.printedYesRadio.Size = new System.Drawing.Size(45, 19);
            this.printedYesRadio.TabIndex = 5;
            this.printedYesRadio.TabStop = true;
            this.printedYesRadio.Text = "Yes";
            this.printedYesRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Workshop           Training \t      Registration\r\n                              Da" +
    "y                 Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Meals          Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lodging Fees\r\n    Per Day\r\n";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(687, 356);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(103, 23);
            this.logOutButton.TabIndex = 10;
            this.logOutButton.Text = "&Log Out";
            this.LogOutToolTip.SetToolTip(this.logOutButton, "Please logOut to exit            Alt+L");
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(537, 356);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "&Clear";
            this.ClearToolTip.SetToolTip(this.clearButton, "Clear to make another entry.          Alt+C");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(220, 356);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(112, 23);
            this.bookButton.TabIndex = 12;
            this.bookButton.Text = "&Book";
            this.BookToolTip.SetToolTip(this.bookButton, "Book Workshop to proceed with the payment.        Alt+B");
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.userHelpLabel);
            this.summaryGroupBox.Controls.Add(this.displayValueLabel6);
            this.summaryGroupBox.Controls.Add(this.displayLabel6);
            this.summaryGroupBox.Controls.Add(this.displayLabel2);
            this.summaryGroupBox.Controls.Add(this.displayLabel3);
            this.summaryGroupBox.Controls.Add(this.displayLabel4);
            this.summaryGroupBox.Controls.Add(this.displayLabel5);
            this.summaryGroupBox.Controls.Add(this.displayValueLabel2);
            this.summaryGroupBox.Controls.Add(this.displayValueLabel3);
            this.summaryGroupBox.Controls.Add(this.displayValueLabel5);
            this.summaryGroupBox.Controls.Add(this.displayValueLabel4);
            this.summaryGroupBox.Controls.Add(this.displayValueLabel1);
            this.summaryGroupBox.Controls.Add(this.displayLabel1);
            this.summaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryGroupBox.Location = new System.Drawing.Point(111, 402);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(671, 286);
            this.summaryGroupBox.TabIndex = 13;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Display";
            // 
            // userHelpLabel
            // 
            this.userHelpLabel.AutoSize = true;
            this.userHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userHelpLabel.Location = new System.Drawing.Point(95, 244);
            this.userHelpLabel.Name = "userHelpLabel";
            this.userHelpLabel.Size = new System.Drawing.Size(408, 16);
            this.userHelpLabel.TabIndex = 18;
            this.userHelpLabel.Text = "If you are happy with the selections. Please  \"Book\"  Your workshop.";
            // 
            // displayValueLabel6
            // 
            this.displayValueLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayValueLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValueLabel6.Location = new System.Drawing.Point(323, 244);
            this.displayValueLabel6.Name = "displayValueLabel6";
            this.displayValueLabel6.Size = new System.Drawing.Size(120, 16);
            this.displayValueLabel6.TabIndex = 17;
            this.displayValueLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel6
            // 
            this.displayLabel6.AutoSize = true;
            this.displayLabel6.Location = new System.Drawing.Point(43, 244);
            this.displayLabel6.Name = "displayLabel6";
            this.displayLabel6.Size = new System.Drawing.Size(222, 16);
            this.displayLabel6.TabIndex = 16;
            this.displayLabel6.Text = "Average Revenue Per Booking";
            this.displayLabel6.Visible = false;
            // 
            // displayLabel2
            // 
            this.displayLabel2.AutoSize = true;
            this.displayLabel2.Location = new System.Drawing.Point(43, 73);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(133, 16);
            this.displayLabel2.TabIndex = 15;
            this.displayLabel2.Text = "Location Selected";
            // 
            // displayLabel3
            // 
            this.displayLabel3.AutoSize = true;
            this.displayLabel3.Location = new System.Drawing.Point(43, 114);
            this.displayLabel3.Name = "displayLabel3";
            this.displayLabel3.Size = new System.Drawing.Size(108, 16);
            this.displayLabel3.TabIndex = 14;
            this.displayLabel3.Text = "Meal Selected";
            // 
            // displayLabel4
            // 
            this.displayLabel4.AutoSize = true;
            this.displayLabel4.Location = new System.Drawing.Point(43, 155);
            this.displayLabel4.Name = "displayLabel4";
            this.displayLabel4.Size = new System.Drawing.Size(188, 16);
            this.displayLabel4.TabIndex = 13;
            this.displayLabel4.Text = "Printed Copy of Certificate";
            // 
            // displayLabel5
            // 
            this.displayLabel5.AutoSize = true;
            this.displayLabel5.Location = new System.Drawing.Point(43, 200);
            this.displayLabel5.Name = "displayLabel5";
            this.displayLabel5.Size = new System.Drawing.Size(151, 16);
            this.displayLabel5.TabIndex = 12;
            this.displayLabel5.Text = "Total Workshop cost";
            // 
            // displayValueLabel2
            // 
            this.displayValueLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayValueLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValueLabel2.Location = new System.Drawing.Point(323, 73);
            this.displayValueLabel2.Name = "displayValueLabel2";
            this.displayValueLabel2.Size = new System.Drawing.Size(200, 16);
            this.displayValueLabel2.TabIndex = 7;
            this.displayValueLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayValueLabel3
            // 
            this.displayValueLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayValueLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValueLabel3.Location = new System.Drawing.Point(323, 114);
            this.displayValueLabel3.Name = "displayValueLabel3";
            this.displayValueLabel3.Size = new System.Drawing.Size(200, 16);
            this.displayValueLabel3.TabIndex = 5;
            this.displayValueLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayValueLabel5
            // 
            this.displayValueLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayValueLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValueLabel5.Location = new System.Drawing.Point(323, 199);
            this.displayValueLabel5.Name = "displayValueLabel5";
            this.displayValueLabel5.Size = new System.Drawing.Size(200, 16);
            this.displayValueLabel5.TabIndex = 4;
            this.displayValueLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayValueLabel4
            // 
            this.displayValueLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayValueLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValueLabel4.Location = new System.Drawing.Point(323, 155);
            this.displayValueLabel4.Name = "displayValueLabel4";
            this.displayValueLabel4.Size = new System.Drawing.Size(200, 16);
            this.displayValueLabel4.TabIndex = 2;
            this.displayValueLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayValueLabel1
            // 
            this.displayValueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayValueLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValueLabel1.Location = new System.Drawing.Point(323, 33);
            this.displayValueLabel1.Name = "displayValueLabel1";
            this.displayValueLabel1.Size = new System.Drawing.Size(200, 16);
            this.displayValueLabel1.TabIndex = 1;
            this.displayValueLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel1
            // 
            this.displayLabel1.AutoSize = true;
            this.displayLabel1.Location = new System.Drawing.Point(43, 33);
            this.displayLabel1.Name = "displayLabel1";
            this.displayLabel1.Size = new System.Drawing.Size(144, 16);
            this.displayLabel1.TabIndex = 0;
            this.displayLabel1.Text = "Workshop Selected";
            // 
            // printedCertificateGroupBox
            // 
            this.printedCertificateGroupBox.Controls.Add(this.printedNoRadio);
            this.printedCertificateGroupBox.Controls.Add(this.printedYesRadio);
            this.printedCertificateGroupBox.Location = new System.Drawing.Point(31, 179);
            this.printedCertificateGroupBox.Name = "printedCertificateGroupBox";
            this.printedCertificateGroupBox.Size = new System.Drawing.Size(211, 48);
            this.printedCertificateGroupBox.TabIndex = 14;
            this.printedCertificateGroupBox.TabStop = false;
            this.printedCertificateGroupBox.Text = "Do you need a Printed Copy?";
            // 
            // printedNoRadio
            // 
            this.printedNoRadio.AutoSize = true;
            this.printedNoRadio.Location = new System.Drawing.Point(77, 21);
            this.printedNoRadio.Name = "printedNoRadio";
            this.printedNoRadio.Size = new System.Drawing.Size(39, 17);
            this.printedNoRadio.TabIndex = 6;
            this.printedNoRadio.TabStop = true;
            this.printedNoRadio.Text = "No";
            this.printedNoRadio.UseVisualStyleBackColor = true;
            // 
            // userInputGroupBox
            // 
            this.userInputGroupBox.Controls.Add(this.label6);
            this.userInputGroupBox.Controls.Add(this.lodgesticListBox);
            this.userInputGroupBox.Controls.Add(this.printedCertificateGroupBox);
            this.userInputGroupBox.Controls.Add(this.mealsListBox);
            this.userInputGroupBox.Controls.Add(this.workShopListBox);
            this.userInputGroupBox.Controls.Add(this.label1);
            this.userInputGroupBox.Controls.Add(this.label2);
            this.userInputGroupBox.Controls.Add(this.label3);
            this.userInputGroupBox.Controls.Add(this.label4);
            this.userInputGroupBox.Location = new System.Drawing.Point(57, 53);
            this.userInputGroupBox.Name = "userInputGroupBox";
            this.userInputGroupBox.Size = new System.Drawing.Size(753, 274);
            this.userInputGroupBox.TabIndex = 15;
            this.userInputGroupBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "**Meal is Optional.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Learn2Prog  Ltd.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(870, 724);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userInputGroupBox);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.displayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Portal of Learn2Prog";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.printedCertificateGroupBox.ResumeLayout(false);
            this.printedCertificateGroupBox.PerformLayout();
            this.userInputGroupBox.ResumeLayout(false);
            this.userInputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox mealsListBox;
        private System.Windows.Forms.ListBox lodgesticListBox;
        private System.Windows.Forms.ListBox workShopListBox;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.RadioButton printedYesRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.GroupBox printedCertificateGroupBox;
        private System.Windows.Forms.Label displayLabel2;
        private System.Windows.Forms.Label displayLabel3;
        private System.Windows.Forms.Label displayLabel4;
        private System.Windows.Forms.Label displayLabel5;
        private System.Windows.Forms.Label displayValueLabel2;
        private System.Windows.Forms.Label displayValueLabel3;
        private System.Windows.Forms.Label displayValueLabel5;
        private System.Windows.Forms.Label displayValueLabel4;
        private System.Windows.Forms.Label displayValueLabel1;
        private System.Windows.Forms.Label displayLabel1;
        private System.Windows.Forms.RadioButton printedNoRadio;
        private System.Windows.Forms.GroupBox userInputGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label displayValueLabel6;
        private System.Windows.Forms.Label displayLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userHelpLabel;
        private System.Windows.Forms.ToolTip DisplayToolTip;
        private System.Windows.Forms.ToolTip BookToolTip;
        private System.Windows.Forms.ToolTip SummaryToolTip;
        private System.Windows.Forms.ToolTip ClearToolTip;
        private System.Windows.Forms.ToolTip LogOutToolTip;
        private System.Windows.Forms.ToolTip toolTip18;
    }
}