
namespace Appointment_System
{
    partial class AddAppointmentCustomerSelectionForm
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
            this.CustomerSelectionGrid = new System.Windows.Forms.DataGridView();
            this.CreateAppointmentButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectCustomerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSelectionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSelectionGrid
            // 
            this.CustomerSelectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerSelectionGrid.Location = new System.Drawing.Point(79, 47);
            this.CustomerSelectionGrid.Name = "CustomerSelectionGrid";
            this.CustomerSelectionGrid.Size = new System.Drawing.Size(641, 243);
            this.CustomerSelectionGrid.TabIndex = 0;
            // 
            // CreateAppointmentButton
            // 
            this.CreateAppointmentButton.Location = new System.Drawing.Point(147, 330);
            this.CreateAppointmentButton.Name = "CreateAppointmentButton";
            this.CreateAppointmentButton.Size = new System.Drawing.Size(177, 53);
            this.CreateAppointmentButton.TabIndex = 1;
            this.CreateAppointmentButton.Text = "Create Appointment for Customer";
            this.CreateAppointmentButton.UseVisualStyleBackColor = true;
            this.CreateAppointmentButton.Click += new System.EventHandler(this.CreateAppointmentButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(443, 330);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(130, 53);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SelectCustomerLabel
            // 
            this.SelectCustomerLabel.AutoSize = true;
            this.SelectCustomerLabel.Location = new System.Drawing.Point(88, 15);
            this.SelectCustomerLabel.Name = "SelectCustomerLabel";
            this.SelectCustomerLabel.Size = new System.Drawing.Size(236, 13);
            this.SelectCustomerLabel.TabIndex = 3;
            this.SelectCustomerLabel.Text = "Select A Customer To Make An Appointment for:";
            // 
            // AddAppointmentCustomerSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectCustomerLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CreateAppointmentButton);
            this.Controls.Add(this.CustomerSelectionGrid);
            this.Name = "AddAppointmentCustomerSelectionForm";
            this.Text = "AddAppointmentCustomerSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSelectionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerSelectionGrid;
        private System.Windows.Forms.Button CreateAppointmentButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label SelectCustomerLabel;
    }
}