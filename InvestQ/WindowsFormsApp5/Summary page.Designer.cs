namespace WindowsFormsApp5
{
    partial class Summary_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summary_page));
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.summaryListView = new System.Windows.Forms.ListView();
            this.transactionNumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.displayLabel3 = new System.Windows.Forms.Label();
            this.displayLabel4 = new System.Windows.Forms.Label();
            this.displayLabel5 = new System.Windows.Forms.Label();
            this.totalIntrestValueLabel = new System.Windows.Forms.Label();
            this.averageTermValueLabel = new System.Windows.Forms.Label();
            this.totalInvestmentValueLabel = new System.Windows.Forms.Label();
            this.displayLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.summaryListView);
            this.summaryGroupBox.Controls.Add(this.displayLabel2);
            this.summaryGroupBox.Controls.Add(this.displayLabel3);
            this.summaryGroupBox.Controls.Add(this.displayLabel4);
            this.summaryGroupBox.Controls.Add(this.displayLabel5);
            this.summaryGroupBox.Controls.Add(this.totalIntrestValueLabel);
            this.summaryGroupBox.Controls.Add(this.averageTermValueLabel);
            this.summaryGroupBox.Controls.Add(this.totalInvestmentValueLabel);
            this.summaryGroupBox.Controls.Add(this.displayLabel1);
            this.summaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryGroupBox.Location = new System.Drawing.Point(68, 78);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(504, 286);
            this.summaryGroupBox.TabIndex = 14;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Total Summary";
            // 
            // summaryListView
            // 
            this.summaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transactionNumbers});
            this.summaryListView.Location = new System.Drawing.Point(215, 155);
            this.summaryListView.Name = "summaryListView";
            this.summaryListView.Size = new System.Drawing.Size(92, 97);
            this.summaryListView.TabIndex = 16;
            this.summaryListView.UseCompatibleStateImageBehavior = false;
            this.summaryListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // transactionNumbers
            // 
            this.transactionNumbers.Text = "Transaction Numbers";
            this.transactionNumbers.Width = 119;
            // 
            // displayLabel2
            // 
            this.displayLabel2.AutoSize = true;
            this.displayLabel2.Location = new System.Drawing.Point(47, 73);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(99, 16);
            this.displayLabel2.TabIndex = 15;
            this.displayLabel2.Text = "Total Interset";
            // 
            // displayLabel3
            // 
            this.displayLabel3.AutoSize = true;
            this.displayLabel3.Location = new System.Drawing.Point(47, 114);
            this.displayLabel3.Name = "displayLabel3";
            this.displayLabel3.Size = new System.Drawing.Size(107, 16);
            this.displayLabel3.TabIndex = 14;
            this.displayLabel3.Text = "Average Term";
            // 
            // displayLabel4
            // 
            this.displayLabel4.AutoSize = true;
            this.displayLabel4.Location = new System.Drawing.Point(47, 155);
            this.displayLabel4.Name = "displayLabel4";
            this.displayLabel4.Size = new System.Drawing.Size(143, 16);
            this.displayLabel4.TabIndex = 13;
            this.displayLabel4.Text = "List of Transactions";
            // 
            // displayLabel5
            // 
            this.displayLabel5.AutoSize = true;
            this.displayLabel5.Location = new System.Drawing.Point(43, 200);
            this.displayLabel5.Name = "displayLabel5";
            this.displayLabel5.Size = new System.Drawing.Size(0, 16);
            this.displayLabel5.TabIndex = 12;
            // 
            // totalIntrestValueLabel
            // 
            this.totalIntrestValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalIntrestValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIntrestValueLabel.Location = new System.Drawing.Point(215, 73);
            this.totalIntrestValueLabel.Name = "totalIntrestValueLabel";
            this.totalIntrestValueLabel.Size = new System.Drawing.Size(200, 16);
            this.totalIntrestValueLabel.TabIndex = 7;
            this.totalIntrestValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageTermValueLabel
            // 
            this.averageTermValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTermValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTermValueLabel.Location = new System.Drawing.Point(215, 114);
            this.averageTermValueLabel.Name = "averageTermValueLabel";
            this.averageTermValueLabel.Size = new System.Drawing.Size(200, 16);
            this.averageTermValueLabel.TabIndex = 5;
            this.averageTermValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalInvestmentValueLabel
            // 
            this.totalInvestmentValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalInvestmentValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInvestmentValueLabel.Location = new System.Drawing.Point(215, 33);
            this.totalInvestmentValueLabel.Name = "totalInvestmentValueLabel";
            this.totalInvestmentValueLabel.Size = new System.Drawing.Size(200, 16);
            this.totalInvestmentValueLabel.TabIndex = 1;
            this.totalInvestmentValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel1
            // 
            this.displayLabel1.AutoSize = true;
            this.displayLabel1.Location = new System.Drawing.Point(47, 33);
            this.displayLabel1.Name = "displayLabel1";
            this.displayLabel1.Size = new System.Drawing.Size(127, 16);
            this.displayLabel1.TabIndex = 0;
            this.displayLabel1.Text = "Total Investrment";
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
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(260, 389);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 23);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "&Close Summary";
            this.toolTip1.SetToolTip(this.clearButton, "Press to go back to the main page     Alt & C");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(199, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 60);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // Summary_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Summary_page";
            this.Text = "Summary Page";
            this.Load += new System.EventHandler(this.Summary_page_Load);
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label displayLabel2;
        private System.Windows.Forms.Label displayLabel3;
        private System.Windows.Forms.Label displayLabel4;
        private System.Windows.Forms.Label displayLabel5;
        private System.Windows.Forms.Label totalIntrestValueLabel;
        private System.Windows.Forms.Label averageTermValueLabel;
        private System.Windows.Forms.Label totalInvestmentValueLabel;
        private System.Windows.Forms.Label displayLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView summaryListView;
        private System.Windows.Forms.ColumnHeader transactionNumbers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}