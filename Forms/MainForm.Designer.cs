namespace Appointment_System
{
    partial class MainForm
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
            this.NewAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.calendarDataGrid = new System.Windows.Forms.DataGridView();
            this.AppointmentSystemLabel = new System.Windows.Forms.Label();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ViewAllApptsRadioButton = new System.Windows.Forms.RadioButton();
            this.ViewMonthlyApptsRadioButton = new System.Windows.Forms.RadioButton();
            this.WeeklyApptRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NewAppointmentButton
            // 
            this.NewAppointmentButton.Location = new System.Drawing.Point(12, 63);
            this.NewAppointmentButton.Name = "NewAppointmentButton";
            this.NewAppointmentButton.Size = new System.Drawing.Size(134, 23);
            this.NewAppointmentButton.TabIndex = 0;
            this.NewAppointmentButton.Text = "New Appointment";
            this.NewAppointmentButton.UseVisualStyleBackColor = true;
            this.NewAppointmentButton.Click += new System.EventHandler(this.NewAppointmentButton_Click);
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(12, 105);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(134, 23);
            this.UpdateAppointmentButton.TabIndex = 1;
            this.UpdateAppointmentButton.Text = "Update Appointment";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = true;
            this.UpdateAppointmentButton.Click += new System.EventHandler(this.UpdateAppointmentButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(12, 150);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(93, 23);
            this.AddCustomerButton.TabIndex = 4;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.Location = new System.Drawing.Point(15, 198);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(106, 23);
            this.UpdateCustomerButton.TabIndex = 5;
            this.UpdateCustomerButton.Text = "Update Customer";
            this.UpdateCustomerButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // calendarDataGrid
            // 
            this.calendarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDataGrid.Location = new System.Drawing.Point(170, 63);
            this.calendarDataGrid.Name = "calendarDataGrid";
            this.calendarDataGrid.Size = new System.Drawing.Size(533, 298);
            this.calendarDataGrid.TabIndex = 8;
            // 
            // AppointmentSystemLabel
            // 
            this.AppointmentSystemLabel.AutoSize = true;
            this.AppointmentSystemLabel.Location = new System.Drawing.Point(291, 18);
            this.AppointmentSystemLabel.Name = "AppointmentSystemLabel";
            this.AppointmentSystemLabel.Size = new System.Drawing.Size(103, 13);
            this.AppointmentSystemLabel.TabIndex = 9;
            this.AppointmentSystemLabel.Text = "Appointment System";
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(15, 251);
            this.ReportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(52, 21);
            this.ReportsButton.TabIndex = 10;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(15, 399);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(70, 21);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ViewAllApptsRadioButton
            // 
            this.ViewAllApptsRadioButton.AutoSize = true;
            this.ViewAllApptsRadioButton.Location = new System.Drawing.Point(195, 399);
            this.ViewAllApptsRadioButton.Name = "ViewAllApptsRadioButton";
            this.ViewAllApptsRadioButton.Size = new System.Drawing.Size(129, 17);
            this.ViewAllApptsRadioButton.TabIndex = 13;
            this.ViewAllApptsRadioButton.TabStop = true;
            this.ViewAllApptsRadioButton.Text = "View All Appointments";
            this.ViewAllApptsRadioButton.UseVisualStyleBackColor = true;
            this.ViewAllApptsRadioButton.CheckedChanged += new System.EventHandler(this.ViewAllApptsRadioButton_CheckedChanged);
            // 
            // ViewMonthlyApptsRadioButton
            // 
            this.ViewMonthlyApptsRadioButton.AutoSize = true;
            this.ViewMonthlyApptsRadioButton.Location = new System.Drawing.Point(345, 399);
            this.ViewMonthlyApptsRadioButton.Name = "ViewMonthlyApptsRadioButton";
            this.ViewMonthlyApptsRadioButton.Size = new System.Drawing.Size(155, 17);
            this.ViewMonthlyApptsRadioButton.TabIndex = 14;
            this.ViewMonthlyApptsRadioButton.TabStop = true;
            this.ViewMonthlyApptsRadioButton.Text = "View Monthly Appointments";
            this.ViewMonthlyApptsRadioButton.UseVisualStyleBackColor = true;
            this.ViewMonthlyApptsRadioButton.CheckedChanged += new System.EventHandler(this.ViewMonthlyApptsRadioButton_CheckedChanged);
            // 
            // WeeklyApptRadioButton
            // 
            this.WeeklyApptRadioButton.AutoSize = true;
            this.WeeklyApptRadioButton.Location = new System.Drawing.Point(523, 399);
            this.WeeklyApptRadioButton.Name = "WeeklyApptRadioButton";
            this.WeeklyApptRadioButton.Size = new System.Drawing.Size(154, 17);
            this.WeeklyApptRadioButton.TabIndex = 15;
            this.WeeklyApptRadioButton.TabStop = true;
            this.WeeklyApptRadioButton.Text = "View Weekly Appointments";
            this.WeeklyApptRadioButton.UseVisualStyleBackColor = true;
            this.WeeklyApptRadioButton.CheckedChanged += new System.EventHandler(this.WeeklyApptRadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 461);
            this.Controls.Add(this.WeeklyApptRadioButton);
            this.Controls.Add(this.ViewMonthlyApptsRadioButton);
            this.Controls.Add(this.ViewAllApptsRadioButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.AppointmentSystemLabel);
            this.Controls.Add(this.calendarDataGrid);
            this.Controls.Add(this.UpdateCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.UpdateAppointmentButton);
            this.Controls.Add(this.NewAppointmentButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAppointmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.DataGridView calendarDataGrid;
        private System.Windows.Forms.Label AppointmentSystemLabel;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.RadioButton ViewAllApptsRadioButton;
        private System.Windows.Forms.RadioButton ViewMonthlyApptsRadioButton;
        private System.Windows.Forms.RadioButton WeeklyApptRadioButton;
    }
}