
namespace Appointment_System
{
    partial class AppointmentSelectionForm
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
            this.ApptSelectionGrid = new System.Windows.Forms.DataGridView();
            this.EditAppointment = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ApptSelectionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ApptSelectionGrid
            // 
            this.ApptSelectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApptSelectionGrid.Location = new System.Drawing.Point(48, 53);
            this.ApptSelectionGrid.Name = "ApptSelectionGrid";
            this.ApptSelectionGrid.Size = new System.Drawing.Size(698, 266);
            this.ApptSelectionGrid.TabIndex = 0;
            // 
            // EditAppointment
            // 
            this.EditAppointment.Location = new System.Drawing.Point(216, 350);
            this.EditAppointment.Name = "EditAppointment";
            this.EditAppointment.Size = new System.Drawing.Size(115, 45);
            this.EditAppointment.TabIndex = 1;
            this.EditAppointment.Text = "Edit Appointment";
            this.EditAppointment.UseVisualStyleBackColor = true;
            this.EditAppointment.Click += new System.EventHandler(this.EditAppointment_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(422, 350);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 45);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AppointmentSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditAppointment);
            this.Controls.Add(this.ApptSelectionGrid);
            this.Name = "AppointmentSelectionForm";
            this.Text = "AppointmentSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.ApptSelectionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ApptSelectionGrid;
        private System.Windows.Forms.Button EditAppointment;
        private System.Windows.Forms.Button CancelButton;
    }
}