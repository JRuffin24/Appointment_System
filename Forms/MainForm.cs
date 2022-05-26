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
    public partial class MainForm : Form
    {
        public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
       // public static string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=passw0rd!;";
        public MainForm()
        {
            InitializeComponent();
            
            string CustomerAppointments = $"SELECT appointment.appointmentId, user.userName, customer.customerName, appointment.type,  appointment.start, appointment.end, address.address, city.city, country.country, address.phone, address.postalCode  FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city  ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId  INNER JOIN appointment   ON appointment.customerId = customer.customerId INNER JOIN user ON appointment.userId = user.userId ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(CustomerAppointments, c);
           
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
            foreach(DataRow row in dt.Rows)
            {DateTime Now = DateTime.Now;
                DateTime start = DateTime.Parse(row["start"].ToString()).ToLocalTime();
                DateTime end = DateTime.Parse(row["end"].ToString()).ToLocalTime();
            }
            calendarDataGrid.DataSource = dt;
            calendarDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calendarDataGrid.ReadOnly = true;
            calendarDataGrid.MultiSelect = false;
            calendarDataGrid.AllowUserToAddRows = false;
            calendarDataGrid.RowHeadersVisible = false;
            ViewAllApptsRadioButton.Checked = true;
            
            reminderCheck(calendarDataGrid);
            
            

        }


        static public void reminderCheck(DataGridView calendar)
        {
            foreach (DataGridViewRow row in calendar.Rows)
            {
                DateTime now = DateTime.UtcNow;
                DateTime start = DateTime.Parse(row.Cells[4].Value.ToString()).ToUniversalTime();
                TimeSpan nowUntilStartOfApp = start - now;
                if (nowUntilStartOfApp.TotalMinutes <= 15 && nowUntilStartOfApp.TotalMinutes > 1)
                {
                    MessageBox.Show($"Reminder: You have a meeting with {row.Cells[2].Value} at {row.Cells[4].Value}");
                }
            }
        }

       

        private void NewAppointmentButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddAppointmentCustomerSelectionForm customerSelectionForm = new AddAppointmentCustomerSelectionForm();
            customerSelectionForm.Show();
        }
       
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.ShowDialog();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
           Hide();
            UpdateCustomerSelectionForm updateCustomerSelectionForm = new UpdateCustomerSelectionForm();
            updateCustomerSelectionForm.Show();

    }

        private void UpdateAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentSelectionForm appointmentSelectionForm = new AppointmentSelectionForm();
            Hide();
            appointmentSelectionForm.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Hide();
            CustomerReports customerReports = new CustomerReports();
            customerReports.ShowDialog();
        }

      

        private void ViewAllApptsRadioButton_CheckedChanged(object sender, EventArgs e)
        {   
            
            string CustomerAppointments = $"SELECT appointment.appointmentId, user.userName, customer.customerName, appointment.type,  appointment.start, appointment.end, address.address, city.city, country.country, address.phone, address.postalCode  FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city  ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId  INNER JOIN appointment   ON appointment.customerId = customer.customerId INNER JOIN user ON appointment.userId = user.userId ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(CustomerAppointments, c);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
            foreach (DataRow row in dt.Rows)
            {
        
                DateTime Now = DateTime.Now;
                DateTime start = DateTime.Parse(row["start"].ToString()).ToLocalTime();
                DateTime end = DateTime.Parse(row["end"].ToString()).ToLocalTime();
            }
            calendarDataGrid.DataSource = dt;
            calendarDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calendarDataGrid.ReadOnly = true;
            calendarDataGrid.MultiSelect = false;
            calendarDataGrid.AllowUserToAddRows = false;
            calendarDataGrid.RowHeadersVisible = false;
           
        }

        private void ViewMonthlyApptsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            string CustomerAppointments = $"SELECT appointment.appointmentId, user.userName, customer.customerName, appointment.type,  appointment.start, appointment.end, address.address, city.city, country.country, address.phone, address.postalCode FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId  INNER JOIN appointment ON appointment.customerId = customer.customerId INNER JOIN user ON appointment.userId = user.userId where month(start) = Month(current_date()) ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(CustomerAppointments, c);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
            foreach (DataRow row in dt.Rows)
            {DateTime Now = DateTime.Now;
                DateTime start = DateTime.Parse(row["start"].ToString()).ToLocalTime();
                DateTime end = DateTime.Parse(row["end"].ToString()).ToLocalTime();
            }
            calendarDataGrid.DataSource = dt;
            calendarDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calendarDataGrid.ReadOnly = true;
            calendarDataGrid.MultiSelect = false;
            calendarDataGrid.AllowUserToAddRows = false;
            calendarDataGrid.RowHeadersVisible = false;
            
            
        }

        private void WeeklyApptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            String CustomerAppointmentsByWeek = $"SELECT appointment.appointmentId, user.userName, customer.customerName, appointment.type,  appointment.start, appointment.end, address.address, city.city, country.country, address.phone, address.postalCode  FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city  ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId  INNER JOIN appointment   ON appointment.customerId = customer.customerId INNER JOIN user ON appointment.userId = user.userId where month(start) = month(current_date()) and week(start) = week(current_date())";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(CustomerAppointmentsByWeek, c);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
            foreach (DataRow row in dt.Rows)
            {   DateTime Now = DateTime.Now;
                DateTime start = DateTime.Parse(row["start"].ToString()).ToLocalTime();
                DateTime end = DateTime.Parse(row["end"].ToString()).ToLocalTime();
            }
            calendarDataGrid.DataSource = dt;
            calendarDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calendarDataGrid.ReadOnly = true;
            calendarDataGrid.MultiSelect = false;
            calendarDataGrid.AllowUserToAddRows = false;
            calendarDataGrid.RowHeadersVisible = false;
            
            
        }
        //private void SystemEvents_TimeChanged(object sender, EventArgs e)
        //{
        //    System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
        //}
    }
}
