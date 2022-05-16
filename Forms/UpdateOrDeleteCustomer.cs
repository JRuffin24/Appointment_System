using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Appointment_System
{
    public partial class UpdateOrDeleteCustomer : Form
    {
        //public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
        public static string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=passw0rd!;";
        public UpdateOrDeleteCustomer()
        {
            InitializeComponent();

        }

        public UpdateOrDeleteCustomer(Customer customer)
        {
           
            DataManipulator.FindCustomerAddress(customer.id);
            DataManipulator.FindCustomerCity(customer.id);
            DataManipulator.FindCustomerCountry(customer.id);
            DataManipulator.FindCustomerPhone(customer.id);
            InitializeComponent();
            UpOrDelCustIDTextBox.ReadOnly = true;

            UpOrDelCustIDTextBox.Text = customer.id.ToString();
            UpOrDelCustNameTextBox.Text = customer.name;
            UpOrDelCustAddressTextBox.Text = DataManipulator.currentCustomerAddress;            
            UpOrDelCustCityNameTextBox.Text = DataManipulator.currentCustomerCity;
            UpOrDelCustCountryNameTextBox.Text = DataManipulator.currentCustomerCountry;
            UpOrDelCustPhoneNumberTextBox.Text = DataManipulator.currentCustomerPhoneNumber;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {        

                if (UpOrDelCustAddressTextBox.Text != DataManipulator.currentCustomerAddress)
                {

                    DataManipulator.FindAddressId(int.Parse(UpOrDelCustIDTextBox.Text));
                    DataManipulator.UpdateCustomerAddress(DataManipulator.currentCustomerAddressId, UpOrDelCustAddressTextBox.Text);


                }
                if (UpOrDelCustPhoneNumberTextBox.Text != DataManipulator.currentCustomerPhoneNumber)
                {
                    DataManipulator.FindCustomerPhone(int.Parse(UpOrDelCustIDTextBox.Text));
                    DataManipulator.UpdateCustomerPhone(DataManipulator.currentCustomerAddressId, UpOrDelCustPhoneNumberTextBox.Text);
                }
                if (UpOrDelCustNameTextBox.Text != DataManipulator.currentCustomerName)
                {

                    DataManipulator.FindCustomerId(int.Parse(UpOrDelCustIDTextBox.Text));
                    DataManipulator.UpdateCustomerName(DataManipulator.currentCustomerId, UpOrDelCustNameTextBox.Text);


                }
                if (UpOrDelCustCityNameTextBox.Text != DataManipulator.currentCustomerCity)
                {

                    DataManipulator.FindCustomerCityId(int.Parse(UpOrDelCustIDTextBox.Text));
                    DataManipulator.UpdateCustomerCity(DataManipulator.currentCustomerCityId, UpOrDelCustCityNameTextBox.Text);



                }
                if (UpOrDelCustCountryNameTextBox.Text != DataManipulator.currentCustomerCountry)
                {

                    DataManipulator.FindCustomerCountry(int.Parse(UpOrDelCustIDTextBox.Text));
                    DataManipulator.FindCustomerName(int.Parse(UpOrDelCustIDTextBox.Text));
                    DataManipulator.UpdateCountry(DataManipulator.currentCustomerName, UpOrDelCustCountryNameTextBox.Text);

                }
        
            UpdateCustomerSelectionForm customerSelectionForm = new UpdateCustomerSelectionForm();
            customerSelectionForm.Show();
            Hide();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer? This action cannot be undone once completed.", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                DataManipulator.FindCustomerName(int.Parse(UpOrDelCustIDTextBox.Text));
                DataManipulator.GetCurrentCustomerName();
                DataManipulator.DeleteCustomer(DataManipulator.currentCustomerName);
                
            }
            else
            {
                return;
            }
            UpdateCustomerSelectionForm customerSelectionForm = new UpdateCustomerSelectionForm();
            Hide();
            customerSelectionForm.Show();
        }

        private void UpOrDelCustCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateCustomerSelectionForm updateCustomerSelectionForm = new UpdateCustomerSelectionForm();
            updateCustomerSelectionForm.Show();
        }
    }
}
