namespace Appointment_System
{
    partial class AddAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddApptScheduleButton = new System.Windows.Forms.Button();
            this.AddApptCancelButton = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.Label();
            this.AppointmentStart = new System.Windows.Forms.Label();
            this.AppointmentEnd = new System.Windows.Forms.Label();
            this.AppointmentType = new System.Windows.Forms.Label();
            this.AddApptCustIDTextBox = new System.Windows.Forms.TextBox();
            this.AddApptCustNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.Label();
            this.StartPicker = new System.Windows.Forms.DateTimePicker();
            this.EndPicker = new System.Windows.Forms.DateTimePicker();
            this.ApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Appointment";
            // 
            // AddApptScheduleButton
            // 
            this.AddApptScheduleButton.Location = new System.Drawing.Point(25, 397);
            this.AddApptScheduleButton.Name = "AddApptScheduleButton";
            this.AddApptScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.AddApptScheduleButton.TabIndex = 1;
            this.AddApptScheduleButton.Text = "Schedule";
            this.AddApptScheduleButton.UseVisualStyleBackColor = true;
            this.AddApptScheduleButton.Click += new System.EventHandler(this.AddApptScheduleButton_Click);
            // 
            // AddApptCancelButton
            // 
            this.AddApptCancelButton.Location = new System.Drawing.Point(154, 397);
            this.AddApptCancelButton.Name = "AddApptCancelButton";
            this.AddApptCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddApptCancelButton.TabIndex = 2;
            this.AddApptCancelButton.Text = "Cancel";
            this.AddApptCancelButton.UseVisualStyleBackColor = true;
            this.AddApptCancelButton.Click += new System.EventHandler(this.AddApptCancelButton_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(102, 35);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(65, 13);
            this.CustomerID.TabIndex = 3;
            this.CustomerID.Text = "Customer ID";
            // 
            // AppointmentStart
            // 
            this.AppointmentStart.AutoSize = true;
            this.AppointmentStart.Location = new System.Drawing.Point(56, 141);
            this.AppointmentStart.Name = "AppointmentStart";
            this.AppointmentStart.Size = new System.Drawing.Size(170, 13);
            this.AppointmentStart.TabIndex = 4;
            this.AppointmentStart.Text = "Appointment Start (Date and Time ";
            // 
            // AppointmentEnd
            // 
            this.AppointmentEnd.AutoSize = true;
            this.AppointmentEnd.Location = new System.Drawing.Point(65, 217);
            this.AppointmentEnd.Name = "AppointmentEnd";
            this.AppointmentEnd.Size = new System.Drawing.Size(164, 13);
            this.AppointmentEnd.TabIndex = 5;
            this.AppointmentEnd.Text = "Appointment End Date and Time ";
            // 
            // AppointmentType
            // 
            this.AppointmentType.AutoSize = true;
            this.AppointmentType.Location = new System.Drawing.Point(89, 284);
            this.AppointmentType.Name = "AppointmentType";
            this.AppointmentType.Size = new System.Drawing.Size(93, 13);
            this.AppointmentType.TabIndex = 6;
            this.AppointmentType.Text = "Appointment Type";
            // 
            // AddApptCustIDTextBox
            // 
            this.AddApptCustIDTextBox.Location = new System.Drawing.Point(72, 51);
            this.AddApptCustIDTextBox.Name = "AddApptCustIDTextBox";
            this.AddApptCustIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.AddApptCustIDTextBox.TabIndex = 7;
            // 
            // AddApptCustNameTextBox
            // 
            this.AddApptCustNameTextBox.Location = new System.Drawing.Point(72, 106);
            this.AddApptCustNameTextBox.Name = "AddApptCustNameTextBox";
            this.AddApptCustNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.AddApptCustNameTextBox.TabIndex = 11;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(89, 90);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(82, 13);
            this.CustomerName.TabIndex = 12;
            this.CustomerName.Text = "Customer Name";
            // 
            // StartPicker
            // 
            this.StartPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartPicker.Location = new System.Drawing.Point(54, 170);
            this.StartPicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.StartPicker.Name = "StartPicker";
            this.StartPicker.Size = new System.Drawing.Size(175, 20);
            this.StartPicker.TabIndex = 13;
            // 
            // EndPicker
            // 
            this.EndPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndPicker.Location = new System.Drawing.Point(51, 244);
            this.EndPicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.EndPicker.Name = "EndPicker";
            this.EndPicker.Size = new System.Drawing.Size(178, 20);
            this.EndPicker.TabIndex = 14;
            // 
            // ApptTypeComboBox
            // 
            this.ApptTypeComboBox.FormattingEnabled = true;
            this.ApptTypeComboBox.Items.AddRange(new object[] {
            "Tire Replacement",
            "Free Alignment Check",
            "Tire Rotation",
            "Battery Check",
            "Oil Change",
            "Suspension Check",
            "Brakes"});
            this.ApptTypeComboBox.Location = new System.Drawing.Point(72, 317);
            this.ApptTypeComboBox.Name = "ApptTypeComboBox";
            this.ApptTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ApptTypeComboBox.TabIndex = 15;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 451);
            this.Controls.Add(this.ApptTypeComboBox);
            this.Controls.Add(this.EndPicker);
            this.Controls.Add(this.StartPicker);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.AddApptCustNameTextBox);
            this.Controls.Add(this.AddApptCustIDTextBox);
            this.Controls.Add(this.AppointmentType);
            this.Controls.Add(this.AppointmentEnd);
            this.Controls.Add(this.AppointmentStart);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.AddApptCancelButton);
            this.Controls.Add(this.AddApptScheduleButton);
            this.Controls.Add(this.label1);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddApptScheduleButton;
        private System.Windows.Forms.Button AddApptCancelButton;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label AppointmentStart;
        private System.Windows.Forms.Label AppointmentEnd;
        private System.Windows.Forms.Label AppointmentType;
        private System.Windows.Forms.TextBox AddApptCustIDTextBox;
        private System.Windows.Forms.TextBox AddApptCustNameTextBox;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.DateTimePicker StartPicker;
        private System.Windows.Forms.DateTimePicker EndPicker;
        private System.Windows.Forms.ComboBox ApptTypeComboBox;
    }
}