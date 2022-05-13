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
    public partial class AddAppointmentCustomerSelectionForm : Form
    {
        public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
        public static DataTable dt = new DataTable();
        public AddAppointmentCustomerSelectionForm()
        {
            InitializeComponent();
            string SELECTALLCUSTOMERS = "SELECT customer.customerId, customer.customerName, address.address, city.city, country.country, address.postalCode, address.phone FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON city.cityId = address.cityId INNER JOIN country ON city.countryId = country.countryId;";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(SELECTALLCUSTOMERS, c);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            CustomerSelectionGrid.DataSource = dt;

            CustomerSelectionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerSelectionGrid.ReadOnly = true;
            CustomerSelectionGrid.MultiSelect = false;
            CustomerSelectionGrid.AllowUserToAddRows = false;
            CustomerSelectionGrid.RowHeadersVisible = false;
        }

        private void CreateAppointmentButton_Click(object sender, EventArgs e)
        {
            if (CustomerSelectionGrid.SelectedRows.Count > 0)
            {
                Customer selectedCustomer = new Customer();
                selectedCustomer.id = (int)CustomerSelectionGrid.CurrentRow.Cells[0].Value;
                selectedCustomer.name = (string)CustomerSelectionGrid.CurrentRow.Cells[1].Value;
                AddAppointment addAppointment = new AddAppointment(selectedCustomer);
                Hide();
                addAppointment.Show();
            }
            else
            {
                MessageBox.Show("You must select a customer to create an appointment for.");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void bindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomerSelectionGrid.ClearSelection();
        }
    }
}
