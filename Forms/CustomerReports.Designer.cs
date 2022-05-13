namespace Appointment_System
{
    partial class CustomerReports
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
            this.Reportlabel1 = new System.Windows.Forms.Label();
            this.ReportLabel2 = new System.Windows.Forms.Label();
            this.ReportLabel3 = new System.Windows.Forms.Label();
            this.UserScheduleDG = new System.Windows.Forms.DataGridView();
            this.ConsultantSearchButton = new System.Windows.Forms.Button();
            this.ConsultantSearchTextBox = new System.Windows.Forms.TextBox();
            this.ReportMonthLabel = new System.Windows.Forms.Label();
            this.ReportApptTypeLabel = new System.Windows.Forms.Label();
            this.ApptCountSearchButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.Report = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportFormCloseButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ReportResultTextBox = new System.Windows.Forms.TextBox();
            this.CloseReportsButton = new System.Windows.Forms.Button();
            this.MonthDropDown = new System.Windows.Forms.ComboBox();
            this.ApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserScheduleDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Reportlabel1
            // 
            this.Reportlabel1.AutoSize = true;
            this.Reportlabel1.Location = new System.Drawing.Point(16, 19);
            this.Reportlabel1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Reportlabel1.Name = "Reportlabel1";
            this.Reportlabel1.Size = new System.Drawing.Size(431, 29);
            this.Reportlabel1.TabIndex = 9;
            this.Reportlabel1.Text = "Number of appointment types by month";
            // 
            // ReportLabel2
            // 
            this.ReportLabel2.AutoSize = true;
            this.ReportLabel2.Location = new System.Drawing.Point(16, 370);
            this.ReportLabel2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ReportLabel2.Name = "ReportLabel2";
            this.ReportLabel2.Size = new System.Drawing.Size(321, 29);
            this.ReportLabel2.TabIndex = 10;
            this.ReportLabel2.Text = "Schedule for each consultant";
            // 
            // ReportLabel3
            // 
            this.ReportLabel3.AutoSize = true;
            this.ReportLabel3.Location = new System.Drawing.Point(129, 766);
            this.ReportLabel3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ReportLabel3.Name = "ReportLabel3";
            this.ReportLabel3.Size = new System.Drawing.Size(318, 29);
            this.ReportLabel3.TabIndex = 11;
            this.ReportLabel3.Text = "Number of Active Customers";
            // 
            // UserScheduleDG
            // 
            this.UserScheduleDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserScheduleDG.Location = new System.Drawing.Point(21, 444);
            this.UserScheduleDG.Margin = new System.Windows.Forms.Padding(7);
            this.UserScheduleDG.Name = "UserScheduleDG";
            this.UserScheduleDG.RowHeadersWidth = 92;
            this.UserScheduleDG.Size = new System.Drawing.Size(892, 221);
            this.UserScheduleDG.TabIndex = 12;
            // 
            // ConsultantSearchButton
            // 
            this.ConsultantSearchButton.Location = new System.Drawing.Point(642, 370);
            this.ConsultantSearchButton.Margin = new System.Windows.Forms.Padding(7);
            this.ConsultantSearchButton.Name = "ConsultantSearchButton";
            this.ConsultantSearchButton.Size = new System.Drawing.Size(175, 51);
            this.ConsultantSearchButton.TabIndex = 13;
            this.ConsultantSearchButton.Text = "Search";
            this.ConsultantSearchButton.UseVisualStyleBackColor = true;
            this.ConsultantSearchButton.Click += new System.EventHandler(this.ConsultantSearchButton_Click);
            // 
            // ConsultantSearchTextBox
            // 
            this.ConsultantSearchTextBox.Location = new System.Drawing.Point(351, 370);
            this.ConsultantSearchTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.ConsultantSearchTextBox.Name = "ConsultantSearchTextBox";
            this.ConsultantSearchTextBox.Size = new System.Drawing.Size(249, 35);
            this.ConsultantSearchTextBox.TabIndex = 14;
            // 
            // ReportMonthLabel
            // 
            this.ReportMonthLabel.AutoSize = true;
            this.ReportMonthLabel.Location = new System.Drawing.Point(16, 74);
            this.ReportMonthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ReportMonthLabel.Name = "ReportMonthLabel";
            this.ReportMonthLabel.Size = new System.Drawing.Size(79, 29);
            this.ReportMonthLabel.TabIndex = 17;
            this.ReportMonthLabel.Text = "Month";
            // 
            // ReportApptTypeLabel
            // 
            this.ReportApptTypeLabel.AutoSize = true;
            this.ReportApptTypeLabel.Location = new System.Drawing.Point(356, 71);
            this.ReportApptTypeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ReportApptTypeLabel.Name = "ReportApptTypeLabel";
            this.ReportApptTypeLabel.Size = new System.Drawing.Size(209, 29);
            this.ReportApptTypeLabel.TabIndex = 18;
            this.ReportApptTypeLabel.Text = "Appointment Type";
            // 
            // ApptCountSearchButton
            // 
            this.ApptCountSearchButton.Location = new System.Drawing.Point(328, 140);
            this.ApptCountSearchButton.Margin = new System.Windows.Forms.Padding(7);
            this.ApptCountSearchButton.Name = "ApptCountSearchButton";
            this.ApptCountSearchButton.Size = new System.Drawing.Size(175, 65);
            this.ApptCountSearchButton.TabIndex = 19;
            this.ApptCountSearchButton.Text = "Search";
            this.ApptCountSearchButton.UseVisualStyleBackColor = true;
            this.ApptCountSearchButton.Click += new System.EventHandler(this.ApptCountSearchButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(306, 275);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(228, 35);
            this.resultTextBox.TabIndex = 20;
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Location = new System.Drawing.Point(193, 281);
            this.Report.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(81, 29);
            this.Report.TabIndex = 21;
            this.Report.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(897, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "____________________________________________________________________";
            // 
            // ReportFormCloseButton
            // 
            this.ReportFormCloseButton.Location = new System.Drawing.Point(719, 1330);
            this.ReportFormCloseButton.Margin = new System.Windows.Forms.Padding(7);
            this.ReportFormCloseButton.Name = "ReportFormCloseButton";
            this.ReportFormCloseButton.Size = new System.Drawing.Size(175, 51);
            this.ReportFormCloseButton.TabIndex = 24;
            this.ReportFormCloseButton.Text = "Close";
            this.ReportFormCloseButton.UseVisualStyleBackColor = true;
            this.ReportFormCloseButton.Click += new System.EventHandler(this.ReportFormCloseButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(510, 755);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(142, 50);
            this.GenerateButton.TabIndex = 25;
            this.GenerateButton.Text = "Search";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ReportResultTextBox
            // 
            this.ReportResultTextBox.Location = new System.Drawing.Point(351, 870);
            this.ReportResultTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.ReportResultTextBox.Name = "ReportResultTextBox";
            this.ReportResultTextBox.Size = new System.Drawing.Size(249, 35);
            this.ReportResultTextBox.TabIndex = 26;
            // 
            // CloseReportsButton
            // 
            this.CloseReportsButton.Location = new System.Drawing.Point(681, 976);
            this.CloseReportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseReportsButton.Name = "CloseReportsButton";
            this.CloseReportsButton.Size = new System.Drawing.Size(175, 78);
            this.CloseReportsButton.TabIndex = 27;
            this.CloseReportsButton.Text = "Close";
            this.CloseReportsButton.UseVisualStyleBackColor = true;
            this.CloseReportsButton.Click += new System.EventHandler(this.CloseReportsButton_Click);
            // 
            // MonthDropDown
            // 
            this.MonthDropDown.FormattingEnabled = true;
            this.MonthDropDown.Items.AddRange(new object[] {
            "January",
            "Februrary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthDropDown.Location = new System.Drawing.Point(104, 74);
            this.MonthDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.MonthDropDown.Name = "MonthDropDown";
            this.MonthDropDown.Size = new System.Drawing.Size(228, 37);
            this.MonthDropDown.TabIndex = 28;
            // 
            // ApptTypeComboBox
            // 
            this.ApptTypeComboBox.FormattingEnabled = true;
            this.ApptTypeComboBox.Location = new System.Drawing.Point(579, 66);
            this.ApptTypeComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.ApptTypeComboBox.Name = "ApptTypeComboBox";
            this.ApptTypeComboBox.Size = new System.Drawing.Size(277, 37);
            this.ApptTypeComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 700);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(897, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "____________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 876);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Result";
            // 
            // CustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 1113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApptTypeComboBox);
            this.Controls.Add(this.MonthDropDown);
            this.Controls.Add(this.CloseReportsButton);
            this.Controls.Add(this.ReportResultTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ReportFormCloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.ApptCountSearchButton);
            this.Controls.Add(this.ReportApptTypeLabel);
            this.Controls.Add(this.ReportMonthLabel);
            this.Controls.Add(this.ConsultantSearchTextBox);
            this.Controls.Add(this.ConsultantSearchButton);
            this.Controls.Add(this.UserScheduleDG);
            this.Controls.Add(this.ReportLabel3);
            this.Controls.Add(this.ReportLabel2);
            this.Controls.Add(this.Reportlabel1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CustomerReports";
            ((System.ComponentModel.ISupportInitialize)(this.UserScheduleDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reportlabel1;
        private System.Windows.Forms.Label ReportLabel2;
        private System.Windows.Forms.Label ReportLabel3;
        private System.Windows.Forms.DataGridView UserScheduleDG;
        private System.Windows.Forms.Button ConsultantSearchButton;
        private System.Windows.Forms.TextBox ConsultantSearchTextBox;
        private System.Windows.Forms.Label ReportMonthLabel;
        private System.Windows.Forms.Label ReportApptTypeLabel;
        private System.Windows.Forms.Button ApptCountSearchButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReportFormCloseButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox ReportResultTextBox;
        private System.Windows.Forms.Button CloseReportsButton;
        private System.Windows.Forms.ComboBox MonthDropDown;
        private System.Windows.Forms.ComboBox ApptTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}