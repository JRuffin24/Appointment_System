
namespace Appointment_System
{
    partial class UpdateCustomerSelectionForm
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
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSelectionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSelectionGrid
            // 
            this.CustomerSelectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerSelectionGrid.Location = new System.Drawing.Point(12, 53);
            this.CustomerSelectionGrid.Name = "CustomerSelectionGrid";
            this.CustomerSelectionGrid.Size = new System.Drawing.Size(598, 218);
            this.CustomerSelectionGrid.TabIndex = 0;
            this.CustomerSelectionGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bindingComplete);
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Location = new System.Drawing.Point(144, 331);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(134, 56);
            this.EditCustomerButton.TabIndex = 1;
            this.EditCustomerButton.Text = "Edit Customer";
            this.EditCustomerButton.UseVisualStyleBackColor = true;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(340, 331);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(137, 56);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdateCustomerSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 476);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditCustomerButton);
            this.Controls.Add(this.CustomerSelectionGrid);
            this.Name = "UpdateCustomerSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSelectionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerSelectionGrid;
        private System.Windows.Forms.Button EditCustomerButton;
        private System.Windows.Forms.Button CloseButton;
    }
}