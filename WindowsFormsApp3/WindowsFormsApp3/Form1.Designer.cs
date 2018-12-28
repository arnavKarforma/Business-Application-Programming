namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.cashierNameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfAdultsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfStudentsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfChildTextBox = new System.Windows.Forms.TextBox();
            this.ticketSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.childLabel = new System.Windows.Forms.Label();
            this.adultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.summaryDataGroupBox = new System.Windows.Forms.GroupBox();
            this.cSummAvgPricePaidDisplay = new System.Windows.Forms.Label();
            this.cSummDataTotalRecieptsDisplay = new System.Windows.Forms.Label();
            this.cSummDataTotalTicketDisplay = new System.Windows.Forms.Label();
            this.cSummDataNameDisplay = new System.Windows.Forms.Label();
            this.cSummAvgPricePaidLabel = new System.Windows.Forms.Label();
            this.cashierLabel = new System.Windows.Forms.Label();
            this.cSummTotalRecieptsDisplay = new System.Windows.Forms.Label();
            this.cSumDataTotalTicketsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.ticketSoldGroupBox.SuspendLayout();
            this.summaryDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashierNameLabel
            // 
            this.cashierNameLabel.AutoSize = true;
            this.cashierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNameLabel.Location = new System.Drawing.Point(233, 68);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(106, 16);
            this.cashierNameLabel.TabIndex = 0;
            this.cashierNameLabel.Text = "Cashier Name";
            // 
            // cashierNameTextBox
            // 
            this.cashierNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNameTextBox.Location = new System.Drawing.Point(383, 65);
            this.cashierNameTextBox.Name = "cashierNameTextBox";
            this.cashierNameTextBox.Size = new System.Drawing.Size(179, 22);
            this.cashierNameTextBox.TabIndex = 1;
            this.toolTip2.SetToolTip(this.cashierNameTextBox, "Please enter Cashier Name to proceed");
            this.cashierNameTextBox.TextChanged += new System.EventHandler(this.cashierNameTextBox_TextChanged);
            // 
            // numberOfAdultsTextBox
            // 
            this.numberOfAdultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfAdultsTextBox.Location = new System.Drawing.Point(129, 26);
            this.numberOfAdultsTextBox.Name = "numberOfAdultsTextBox";
            this.numberOfAdultsTextBox.Size = new System.Drawing.Size(80, 22);
            this.numberOfAdultsTextBox.TabIndex = 2;
            this.toolTip3.SetToolTip(this.numberOfAdultsTextBox, "Please enter number of tickets sold for adults");
            this.numberOfAdultsTextBox.TextChanged += new System.EventHandler(this.numberOfAdultsTextBox_TextChanged);
            // 
            // numberOfStudentsTextBox
            // 
            this.numberOfStudentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfStudentsTextBox.Location = new System.Drawing.Point(130, 61);
            this.numberOfStudentsTextBox.Name = "numberOfStudentsTextBox";
            this.numberOfStudentsTextBox.Size = new System.Drawing.Size(79, 22);
            this.numberOfStudentsTextBox.TabIndex = 3;
            this.toolTip4.SetToolTip(this.numberOfStudentsTextBox, "Please enter number of tickets sold for Students");
            this.numberOfStudentsTextBox.TextChanged += new System.EventHandler(this.numberOfStudentsTextBox_TextChanged);
            // 
            // numberOfChildTextBox
            // 
            this.numberOfChildTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfChildTextBox.Location = new System.Drawing.Point(129, 99);
            this.numberOfChildTextBox.Name = "numberOfChildTextBox";
            this.numberOfChildTextBox.Size = new System.Drawing.Size(80, 22);
            this.numberOfChildTextBox.TabIndex = 4;
            this.toolTip5.SetToolTip(this.numberOfChildTextBox, "Please enter number of tickets sold for child");
            this.numberOfChildTextBox.TextChanged += new System.EventHandler(this.numberOfChildTextBox_TextChanged);
            // 
            // ticketSoldGroupBox
            // 
            this.ticketSoldGroupBox.Controls.Add(this.studentLabel);
            this.ticketSoldGroupBox.Controls.Add(this.childLabel);
            this.ticketSoldGroupBox.Controls.Add(this.adultLabel);
            this.ticketSoldGroupBox.Controls.Add(this.numberOfAdultsTextBox);
            this.ticketSoldGroupBox.Controls.Add(this.numberOfStudentsTextBox);
            this.ticketSoldGroupBox.Controls.Add(this.numberOfChildTextBox);
            this.ticketSoldGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketSoldGroupBox.Location = new System.Drawing.Point(254, 117);
            this.ticketSoldGroupBox.Name = "ticketSoldGroupBox";
            this.ticketSoldGroupBox.Size = new System.Drawing.Size(326, 164);
            this.ticketSoldGroupBox.TabIndex = 5;
            this.ticketSoldGroupBox.TabStop = false;
            this.ticketSoldGroupBox.Text = "Tickets Sold";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.Location = new System.Drawing.Point(40, 64);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(60, 16);
            this.studentLabel.TabIndex = 17;
            this.studentLabel.Text = "Student";
            // 
            // childLabel
            // 
            this.childLabel.AutoSize = true;
            this.childLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childLabel.Location = new System.Drawing.Point(42, 103);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(43, 16);
            this.childLabel.TabIndex = 14;
            this.childLabel.Text = "Child";
            // 
            // adultLabel
            // 
            this.adultLabel.AutoSize = true;
            this.adultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultLabel.Location = new System.Drawing.Point(45, 29);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(43, 16);
            this.adultLabel.TabIndex = 15;
            this.adultLabel.Text = "Adult";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(180, 308);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 31);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Please fill all data above and press to feed cashier summary data");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(325, 308);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 31);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.toolTip6.SetToolTip(this.clearButton, "Clear to calculate new record");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Enabled = false;
            this.summaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.Location = new System.Drawing.Point(470, 308);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(85, 31);
            this.summaryButton.TabIndex = 8;
            this.summaryButton.Text = "Summary";
            this.toolTip7.SetToolTip(this.summaryButton, "Click to get details of all the Cashiers entry");
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(615, 308);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 31);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.toolTip8.SetToolTip(this.exitButton, "Press to kill the spplication");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // summaryDataGroupBox
            // 
            this.summaryDataGroupBox.Controls.Add(this.cSummAvgPricePaidDisplay);
            this.summaryDataGroupBox.Controls.Add(this.cSummDataTotalRecieptsDisplay);
            this.summaryDataGroupBox.Controls.Add(this.cSummDataTotalTicketDisplay);
            this.summaryDataGroupBox.Controls.Add(this.cSummDataNameDisplay);
            this.summaryDataGroupBox.Controls.Add(this.cSummAvgPricePaidLabel);
            this.summaryDataGroupBox.Controls.Add(this.cashierLabel);
            this.summaryDataGroupBox.Controls.Add(this.cSummTotalRecieptsDisplay);
            this.summaryDataGroupBox.Controls.Add(this.cSumDataTotalTicketsLabel);
            this.summaryDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryDataGroupBox.Location = new System.Drawing.Point(254, 391);
            this.summaryDataGroupBox.Name = "summaryDataGroupBox";
            this.summaryDataGroupBox.Size = new System.Drawing.Size(370, 275);
            this.summaryDataGroupBox.TabIndex = 10;
            this.summaryDataGroupBox.TabStop = false;
            this.summaryDataGroupBox.Text = "Cashier Summary Data";
            this.summaryDataGroupBox.Visible = false;
            // 
            // cSummAvgPricePaidDisplay
            // 
            this.cSummAvgPricePaidDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cSummAvgPricePaidDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSummAvgPricePaidDisplay.Location = new System.Drawing.Point(171, 205);
            this.cSummAvgPricePaidDisplay.Name = "cSummAvgPricePaidDisplay";
            this.cSummAvgPricePaidDisplay.Size = new System.Drawing.Size(103, 22);
            this.cSummAvgPricePaidDisplay.TabIndex = 15;
            // 
            // cSummDataTotalRecieptsDisplay
            // 
            this.cSummDataTotalRecieptsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cSummDataTotalRecieptsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSummDataTotalRecieptsDisplay.Location = new System.Drawing.Point(171, 149);
            this.cSummDataTotalRecieptsDisplay.Name = "cSummDataTotalRecieptsDisplay";
            this.cSummDataTotalRecieptsDisplay.Size = new System.Drawing.Size(103, 23);
            this.cSummDataTotalRecieptsDisplay.TabIndex = 14;
            // 
            // cSummDataTotalTicketDisplay
            // 
            this.cSummDataTotalTicketDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cSummDataTotalTicketDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSummDataTotalTicketDisplay.Location = new System.Drawing.Point(172, 91);
            this.cSummDataTotalTicketDisplay.Name = "cSummDataTotalTicketDisplay";
            this.cSummDataTotalTicketDisplay.Size = new System.Drawing.Size(103, 22);
            this.cSummDataTotalTicketDisplay.TabIndex = 13;
            // 
            // cSummDataNameDisplay
            // 
            this.cSummDataNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cSummDataNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSummDataNameDisplay.Location = new System.Drawing.Point(171, 39);
            this.cSummDataNameDisplay.Name = "cSummDataNameDisplay";
            this.cSummDataNameDisplay.Size = new System.Drawing.Size(147, 23);
            this.cSummDataNameDisplay.TabIndex = 12;
            // 
            // cSummAvgPricePaidLabel
            // 
            this.cSummAvgPricePaidLabel.AutoSize = true;
            this.cSummAvgPricePaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSummAvgPricePaidLabel.Location = new System.Drawing.Point(22, 211);
            this.cSummAvgPricePaidLabel.Name = "cSummAvgPricePaidLabel";
            this.cSummAvgPricePaidLabel.Size = new System.Drawing.Size(143, 16);
            this.cSummAvgPricePaidLabel.TabIndex = 16;
            this.cSummAvgPricePaidLabel.Text = "Average Price Paid";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLabel.Location = new System.Drawing.Point(22, 46);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(106, 16);
            this.cashierLabel.TabIndex = 11;
            this.cashierLabel.Text = "Cashier Name";
            // 
            // cSummTotalRecieptsDisplay
            // 
            this.cSummTotalRecieptsDisplay.AutoSize = true;
            this.cSummTotalRecieptsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSummTotalRecieptsDisplay.Location = new System.Drawing.Point(22, 156);
            this.cSummTotalRecieptsDisplay.Name = "cSummTotalRecieptsDisplay";
            this.cSummTotalRecieptsDisplay.Size = new System.Drawing.Size(110, 16);
            this.cSummTotalRecieptsDisplay.TabIndex = 13;
            this.cSummTotalRecieptsDisplay.Text = "Total Reciepts";
            // 
            // cSumDataTotalTicketsLabel
            // 
            this.cSumDataTotalTicketsLabel.AutoSize = true;
            this.cSumDataTotalTicketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSumDataTotalTicketsLabel.Location = new System.Drawing.Point(22, 97);
            this.cSumDataTotalTicketsLabel.Name = "cSumDataTotalTicketsLabel";
            this.cSumDataTotalTicketsLabel.Size = new System.Drawing.Size(131, 16);
            this.cSumDataTotalTicketsLabel.TabIndex = 12;
            this.cSumDataTotalTicketsLabel.Text = "Toal Tickets Sold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Daily Ticket Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(798, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summaryDataGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.ticketSoldGroupBox);
            this.Controls.Add(this.cashierNameTextBox);
            this.Controls.Add(this.cashierNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Belmullet Mega Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ticketSoldGroupBox.ResumeLayout(false);
            this.ticketSoldGroupBox.PerformLayout();
            this.summaryDataGroupBox.ResumeLayout(false);
            this.summaryDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cashierNameLabel;
        private System.Windows.Forms.TextBox cashierNameTextBox;
        private System.Windows.Forms.TextBox numberOfAdultsTextBox;
        private System.Windows.Forms.TextBox numberOfStudentsTextBox;
        private System.Windows.Forms.TextBox numberOfChildTextBox;
        private System.Windows.Forms.GroupBox ticketSoldGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox summaryDataGroupBox;
        private System.Windows.Forms.Label cashierLabel;
        private System.Windows.Forms.Label cSumDataTotalTicketsLabel;
        private System.Windows.Forms.Label cSummTotalRecieptsDisplay;
        private System.Windows.Forms.Label childLabel;
        private System.Windows.Forms.Label adultLabel;
        private System.Windows.Forms.Label cSummAvgPricePaidLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cSummDataTotalTicketDisplay;
        private System.Windows.Forms.Label cSummDataNameDisplay;
        private System.Windows.Forms.Label cSummDataTotalRecieptsDisplay;
        private System.Windows.Forms.Label cSummAvgPricePaidDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
    }
}

