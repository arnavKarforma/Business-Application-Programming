namespace WindowsFormsApp5
{
    partial class DisplayDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayDetails));
            this.investmentsListBox = new System.Windows.Forms.ListBox();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telephoneNumTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.transactionTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.displayLabel3 = new System.Windows.Forms.Label();
            this.displayLabel4 = new System.Windows.Forms.Label();
            this.displayLabel1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baseValueLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.detailsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // investmentsListBox
            // 
            this.investmentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentsListBox.FormattingEnabled = true;
            this.investmentsListBox.HorizontalScrollbar = true;
            this.investmentsListBox.ItemHeight = 16;
            this.investmentsListBox.Location = new System.Drawing.Point(250, 180);
            this.investmentsListBox.Name = "investmentsListBox";
            this.investmentsListBox.Size = new System.Drawing.Size(355, 100);
            this.investmentsListBox.TabIndex = 2;
            this.investmentsListBox.SelectedIndexChanged += new System.EventHandler(this.investmentsListBox_SelectedIndexChanged);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Controls.Add(this.clearButton);
            this.detailsGroupBox.Controls.Add(this.nameTextBox);
            this.detailsGroupBox.Controls.Add(this.telephoneNumTextBox);
            this.detailsGroupBox.Controls.Add(this.emailTextBox);
            this.detailsGroupBox.Controls.Add(this.transactionTextBox);
            this.detailsGroupBox.Controls.Add(this.confirmButton);
            this.detailsGroupBox.Controls.Add(this.displayLabel2);
            this.detailsGroupBox.Controls.Add(this.displayLabel3);
            this.detailsGroupBox.Controls.Add(this.displayLabel4);
            this.detailsGroupBox.Controls.Add(this.displayLabel1);
            this.detailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGroupBox.Location = new System.Drawing.Point(100, 346);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(671, 236);
            this.detailsGroupBox.TabIndex = 14;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Client\'s Details";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(322, 207);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "C&lear";
            this.toolTip7.SetToolTip(this.clearButton, "Press to clear all the Client\'S Details     Alt & l");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(341, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 22);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telephoneNumTextBox
            // 
            this.telephoneNumTextBox.Location = new System.Drawing.Point(341, 75);
            this.telephoneNumTextBox.Name = "telephoneNumTextBox";
            this.telephoneNumTextBox.Size = new System.Drawing.Size(211, 22);
            this.telephoneNumTextBox.TabIndex = 8;
            this.telephoneNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(341, 114);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(211, 22);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transactionTextBox
            // 
            this.transactionTextBox.Location = new System.Drawing.Point(341, 152);
            this.transactionTextBox.Name = "transactionTextBox";
            this.transactionTextBox.Size = new System.Drawing.Size(211, 22);
            this.transactionTextBox.TabIndex = 10;
            this.transactionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(179, 207);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(113, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "C&onfirm";
            this.toolTip6.SetToolTip(this.confirmButton, "Once done with the enteries press Confirm   Alt & O");
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // displayLabel2
            // 
            this.displayLabel2.AutoSize = true;
            this.displayLabel2.Location = new System.Drawing.Point(43, 73);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(141, 16);
            this.displayLabel2.TabIndex = 15;
            this.displayLabel2.Text = "Telephone Number";
            // 
            // displayLabel3
            // 
            this.displayLabel3.AutoSize = true;
            this.displayLabel3.Location = new System.Drawing.Point(43, 114);
            this.displayLabel3.Name = "displayLabel3";
            this.displayLabel3.Size = new System.Drawing.Size(113, 16);
            this.displayLabel3.TabIndex = 14;
            this.displayLabel3.Text = "Email Address ";
            // 
            // displayLabel4
            // 
            this.displayLabel4.AutoSize = true;
            this.displayLabel4.Location = new System.Drawing.Point(43, 155);
            this.displayLabel4.Name = "displayLabel4";
            this.displayLabel4.Size = new System.Drawing.Size(148, 16);
            this.displayLabel4.TabIndex = 13;
            this.displayLabel4.Text = "Transaction Number";
            // 
            // displayLabel1
            // 
            this.displayLabel1.AutoSize = true;
            this.displayLabel1.Location = new System.Drawing.Point(43, 33);
            this.displayLabel1.Name = "displayLabel1";
            this.displayLabel1.Size = new System.Drawing.Size(49, 16);
            this.displayLabel1.TabIndex = 0;
            this.displayLabel1.Text = "Name";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(479, 298);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(113, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "&Reset";
            this.toolTip4.SetToolTip(this.resetButton, "Press it To Clear all the enteries done    Alt & R");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(100, 298);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(113, 23);
            this.ProceedButton.TabIndex = 3;
            this.ProceedButton.Text = "&Proceed";
            this.toolTip2.SetToolTip(this.ProceedButton, "Choose the pDuration to proceed  Alt & P");
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Investment Amount";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(390, 21);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(113, 23);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "&Change";
            this.toolTip1.SetToolTip(this.ChangeButton, "Press on it if you want to change the investment amount Alt & C");
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baseValueLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChangeButton);
            this.groupBox1.Location = new System.Drawing.Point(155, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 64);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // baseValueLabel
            // 
            this.baseValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseValueLabel.Location = new System.Drawing.Point(155, 21);
            this.baseValueLabel.Name = "baseValueLabel";
            this.baseValueLabel.Size = new System.Drawing.Size(200, 23);
            this.baseValueLabel.TabIndex = 24;
            this.baseValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(289, 298);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.toolTip3.SetToolTip(this.exitButton, "Press it to get back to the homepage    Alt & E");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(658, 298);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(113, 23);
            this.SummaryButton.TabIndex = 6;
            this.SummaryButton.Text = "&Summary";
            this.toolTip5.SetToolTip(this.SummaryButton, "Press to go to the summary Page Alt & S");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Duration";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(303, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 60);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp5.Properties.Resources.InvestQLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "InvestQ Client\'s Portal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(250, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 28);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // DisplayDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(835, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.investmentsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DisplayDetails";
            this.Text = "DisplayDetails";
            this.Load += new System.EventHandler(this.DisplayDetails_Load);
            this.detailsGroupBox.ResumeLayout(false);
            this.detailsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox investmentsListBox;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.Label displayLabel2;
        private System.Windows.Forms.Label displayLabel3;
        private System.Windows.Forms.Label displayLabel4;
        private System.Windows.Forms.Label displayLabel1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox telephoneNumTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox transactionTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label baseValueLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
    }
}