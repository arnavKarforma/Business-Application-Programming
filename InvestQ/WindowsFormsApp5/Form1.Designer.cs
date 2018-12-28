namespace WindowsFormsApp5
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.principalInputTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SummButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchByTrxnRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByEmaiRadiolButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.SearchListView = new System.Windows.Forms.ListView();
            this.TransactionNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // principalInputTextBox
            // 
            this.principalInputTextBox.Location = new System.Drawing.Point(46, 46);
            this.principalInputTextBox.Name = "principalInputTextBox";
            this.principalInputTextBox.Size = new System.Drawing.Size(211, 20);
            this.principalInputTextBox.TabIndex = 0;
            this.principalInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.principalInputTextBox.TextChanged += new System.EventHandler(this.principalInputTextBox_TextChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(10, 67);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(211, 20);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.displayButton);
            this.groupBox1.Controls.Add(this.principalInputTextBox);
            this.groupBox1.Location = new System.Drawing.Point(61, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 293);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.SummButton);
            this.groupBox6.Location = new System.Drawing.Point(124, 209);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(159, 73);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pull Up All Details";
            // 
            // SummButton
            // 
            this.SummButton.Location = new System.Drawing.Point(42, 39);
            this.SummButton.Name = "SummButton";
            this.SummButton.Size = new System.Drawing.Size(75, 23);
            this.SummButton.TabIndex = 5;
            this.SummButton.Text = "&Summary";
            this.toolTip4.SetToolTip(this.SummButton, "Press it to view the summary     Alt & S ");
            this.SummButton.UseVisualStyleBackColor = true;
            this.SummButton.Click += new System.EventHandler(this.SummButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Investment Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.clearSearchButton);
            this.groupBox2.Controls.Add(this.searchByTrxnRadioButton);
            this.groupBox2.Controls.Add(this.searchByEmaiRadiolButton);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Location = new System.Drawing.Point(36, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 108);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.SummaryButton);
            this.groupBox5.Location = new System.Drawing.Point(69, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 54);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pull all the details";
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(64, 72);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(63, 23);
            this.SummaryButton.TabIndex = 6;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(107, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 73);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(313, 64);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(66, 23);
            this.clearSearchButton.TabIndex = 11;
            this.clearSearchButton.Text = "&Clear";
            this.toolTip3.SetToolTip(this.clearSearchButton, "Press it to clear the whole form        Alt & C");
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // searchByTrxnRadioButton
            // 
            this.searchByTrxnRadioButton.AutoSize = true;
            this.searchByTrxnRadioButton.Location = new System.Drawing.Point(95, 32);
            this.searchByTrxnRadioButton.Name = "searchByTrxnRadioButton";
            this.searchByTrxnRadioButton.Size = new System.Drawing.Size(93, 17);
            this.searchByTrxnRadioButton.TabIndex = 10;
            this.searchByTrxnRadioButton.TabStop = true;
            this.searchByTrxnRadioButton.Text = "Transaction Id";
            this.searchByTrxnRadioButton.UseVisualStyleBackColor = true;
            this.searchByTrxnRadioButton.CheckedChanged += new System.EventHandler(this.searchByTrxnRadioButton_CheckedChanged);
            // 
            // searchByEmaiRadiolButton
            // 
            this.searchByEmaiRadiolButton.AutoSize = true;
            this.searchByEmaiRadiolButton.Location = new System.Drawing.Point(10, 32);
            this.searchByEmaiRadiolButton.Name = "searchByEmaiRadiolButton";
            this.searchByEmaiRadiolButton.Size = new System.Drawing.Size(50, 17);
            this.searchByEmaiRadiolButton.TabIndex = 9;
            this.searchByEmaiRadiolButton.TabStop = true;
            this.searchByEmaiRadiolButton.Text = "Email";
            this.searchByEmaiRadiolButton.UseVisualStyleBackColor = true;
            this.searchByEmaiRadiolButton.CheckedChanged += new System.EventHandler(this.searchByEmaiRadiolButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(235, 64);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(65, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "S&earch";
            this.toolTip2.SetToolTip(this.SearchButton, "Press it to Search past details       Alt & E");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(291, 45);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.displayButton, "Press to view all the plans on Client\'s investment Amount     Alt & D");
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // SearchListView
            // 
            this.SearchListView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionNo,
            this.clientName,
            this.phoneNum,
            this.email,
            this.term,
            this.sum,
            this.balance});
            this.SearchListView.Location = new System.Drawing.Point(12, 388);
            this.SearchListView.Name = "SearchListView";
            this.SearchListView.Size = new System.Drawing.Size(540, 129);
            this.SearchListView.TabIndex = 13;
            this.SearchListView.UseCompatibleStateImageBehavior = false;
            this.SearchListView.View = System.Windows.Forms.View.Details;
            // 
            // TransactionNo
            // 
            this.TransactionNo.Text = "Transaction No";
            this.TransactionNo.Width = 98;
            // 
            // clientName
            // 
            this.clientName.Text = "Name";
            this.clientName.Width = 100;
            // 
            // phoneNum
            // 
            this.phoneNum.Text = "Phone No.";
            this.phoneNum.Width = 100;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 120;
            // 
            // term
            // 
            this.term.Text = "Term";
            this.term.Width = 40;
            // 
            // sum
            // 
            this.sum.Text = "Sum";
            this.sum.Width = 120;
            // 
            // balance
            // 
            this.balance.Text = "Balance";
            this.balance.Width = 100;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(166, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 60);
            this.groupBox4.TabIndex = 31;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "InvestQ Client\'s Portal";
            // 
            // ExitButton
            // 
            this.ExitButton.Image = global::WindowsFormsApp5.Properties.Resources.logOut1;
            this.ExitButton.Location = new System.Drawing.Point(498, 27);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(23, 25);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 14;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(564, 565);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SearchListView);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "InvestQ";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox principalInputTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton searchByTrxnRadioButton;
        private System.Windows.Forms.RadioButton searchByEmaiRadiolButton;
        private System.Windows.Forms.ListView SearchListView;
        private System.Windows.Forms.ColumnHeader TransactionNo;
        private System.Windows.Forms.ColumnHeader clientName;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader term;
        private System.Windows.Forms.ColumnHeader sum;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.ColumnHeader phoneNum;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SummButton;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

