namespace Appointment_System
{
    partial class UpdateOrDeleteAppointment
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
            this.ModifyAppointmentLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.ApptStartLabel = new System.Windows.Forms.Label();
            this.AppointmentEndLabel = new System.Windows.Forms.Label();
            this.AppointmentTypeLabel = new System.Windows.Forms.Label();
            this.UpdateApptSaveButton = new System.Windows.Forms.Button();
            this.UpdateApptDeleteButton = new System.Windows.Forms.Button();
            this.UpdateApptCancelButton = new System.Windows.Forms.Button();
            this.ApptCustIDTextBox = new System.Windows.Forms.TextBox();
            this.ApptIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApptEndPicker = new System.Windows.Forms.DateTimePicker();
            this.ApptStartPicker = new System.Windows.Forms.DateTimePicker();
            this.ApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ModifyAppointmentLabel
            // 
            this.ModifyAppointmentLabel.AutoSize = true;
            this.ModifyAppointmentLabel.Location = new System.Drawing.Point(82, 9);
            this.ModifyAppointmentLabel.Name = "ModifyAppointmentLabel";
            this.ModifyAppointmentLabel.Size = new System.Drawing.Size(100, 13);
            this.ModifyAppointmentLabel.TabIndex = 0;
            this.ModifyAppointmentLabel.Text = "Modify Appointment";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(103, 92);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // ApptStartLabel
            // 
            this.ApptStartLabel.AutoSize = true;
            this.ApptStartLabel.Location = new System.Drawing.Point(90, 142);
            this.ApptStartLabel.Name = "ApptStartLabel";
            this.ApptStartLabel.Size = new System.Drawing.Size(91, 13);
            this.ApptStartLabel.TabIndex = 2;
            this.ApptStartLabel.Text = "Appointment Start";
            // 
            // AppointmentEndLabel
            // 
            this.AppointmentEndLabel.AutoSize = true;
            this.AppointmentEndLabel.Location = new System.Drawing.Point(93, 190);
            this.AppointmentEndLabel.Name = "AppointmentEndLabel";
            this.AppointmentEndLabel.Size = new System.Drawing.Size(88, 13);
            this.AppointmentEndLabel.TabIndex = 3;
            this.AppointmentEndLabel.Text = "Appointment End";
            // 
            // AppointmentTypeLabel
            // 
            this.AppointmentTypeLabel.AutoSize = true;
            this.AppointmentTypeLabel.Location = new System.Drawing.Point(93, 245);
            this.AppointmentTypeLabel.Name = "AppointmentTypeLabel";
            this.AppointmentTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.AppointmentTypeLabel.TabIndex = 4;
            this.AppointmentTypeLabel.Text = "Appointment Type";
            // 
            // UpdateApptSaveButton
            // 
            this.UpdateApptSaveButton.Location = new System.Drawing.Point(12, 327);
            this.UpdateApptSaveButton.Name = "UpdateApptSaveButton";
            this.UpdateApptSaveButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateApptSaveButton.TabIndex = 5;
            this.UpdateApptSaveButton.Text = "Save";
            this.UpdateApptSaveButton.UseVisualStyleBackColor = true;
            this.UpdateApptSaveButton.Click += new System.EventHandler(this.UpdateApptSaveButton_Click);
            // 
            // UpdateApptDeleteButton
            // 
            this.UpdateApptDeleteButton.Location = new System.Drawing.Point(93, 327);
            this.UpdateApptDeleteButton.Name = "UpdateApptDeleteButton";
            this.UpdateApptDeleteButton.Size = new System.Drawing.Size(113, 23);
            this.UpdateApptDeleteButton.TabIndex = 6;
            this.UpdateApptDeleteButton.Text = "Delete Appointment";
            this.UpdateApptDeleteButton.UseVisualStyleBackColor = true;
            this.UpdateApptDeleteButton.Click += new System.EventHandler(this.UpdateApptDeleteButton_Click);
            // 
            // UpdateApptCancelButton
            // 
            this.UpdateApptCancelButton.Location = new System.Drawing.Point(212, 327);
            this.UpdateApptCancelButton.Name = "UpdateApptCancelButton";
            this.UpdateApptCancelButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateApptCancelButton.TabIndex = 7;
            this.UpdateApptCancelButton.Text = "Cancel";
            this.UpdateApptCancelButton.UseVisualStyleBackColor = true;
            this.UpdateApptCancelButton.Click += new System.EventHandler(this.UpdateApptCancelButton_Click);
            // 
            // ApptCustIDTextBox
            // 
            this.ApptCustIDTextBox.Location = new System.Drawing.Point(85, 108);
            this.ApptCustIDTextBox.Name = "ApptCustIDTextBox";
            this.ApptCustIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ApptCustIDTextBox.TabIndex = 8;
            // 
            // ApptIdTextBox
            // 
            this.ApptIdTextBox.Location = new System.Drawing.Point(82, 59);
            this.ApptIdTextBox.Name = "ApptIdTextBox";
            this.ApptIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ApptIdTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Appointment ID";
            // 
            // ApptEndPicker
            // 
            this.ApptEndPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ApptEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptEndPicker.Location = new System.Drawing.Point(63, 206);
            this.ApptEndPicker.Name = "ApptEndPicker";
            this.ApptEndPicker.Size = new System.Drawing.Size(164, 20);
            this.ApptEndPicker.TabIndex = 14;
            // 
            // ApptStartPicker
            // 
            this.ApptStartPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ApptStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptStartPicker.Location = new System.Drawing.Point(63, 158);
            this.ApptStartPicker.Name = "ApptStartPicker";
            this.ApptStartPicker.Size = new System.Drawing.Size(164, 20);
            this.ApptStartPicker.TabIndex = 15;
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
            "Suspension Check"});
            this.ApptTypeComboBox.Location = new System.Drawing.Point(82, 273);
            this.ApptTypeComboBox.Name = "ApptTypeComboBox";
            this.ApptTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ApptTypeComboBox.TabIndex = 16;
            // 
            // UpdateOrDeleteAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 385);
            this.Controls.Add(this.ApptTypeComboBox);
            this.Controls.Add(this.ApptStartPicker);
            this.Controls.Add(this.ApptEndPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApptIdTextBox);
            this.Controls.Add(this.ApptCustIDTextBox);
            this.Controls.Add(this.UpdateApptCancelButton);
            this.Controls.Add(this.UpdateApptDeleteButton);
            this.Controls.Add(this.UpdateApptSaveButton);
            this.Controls.Add(this.AppointmentTypeLabel);
            this.Controls.Add(this.AppointmentEndLabel);
            this.Controls.Add(this.ApptStartLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.ModifyAppointmentLabel);
            this.Name = "UpdateOrDeleteAppointment";
            this.Text = "UpdateAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyAppointmentLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label ApptStartLabel;
        private System.Windows.Forms.Label AppointmentEndLabel;
        private System.Windows.Forms.Label AppointmentTypeLabel;
        private System.Windows.Forms.Button UpdateApptSaveButton;
        private System.Windows.Forms.Button UpdateApptDeleteButton;
        private System.Windows.Forms.Button UpdateApptCancelButton;
        private System.Windows.Forms.TextBox ApptCustIDTextBox;
        private System.Windows.Forms.TextBox ApptIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ApptEndPicker;
        private System.Windows.Forms.DateTimePicker ApptStartPicker;
        private System.Windows.Forms.ComboBox ApptTypeComboBox;
    }
}