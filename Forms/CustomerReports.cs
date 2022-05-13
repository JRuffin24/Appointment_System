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
using System.Collections;

namespace Appointment_System
{
    public partial class CustomerReports : Form
    {
        public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
        public static DataTable dt = new DataTable();
        
        public CustomerReports()
        {
            InitializeComponent();
            resultTextBox.ReadOnly = true;
            ReportResultTextBox.ReadOnly = true;
            populateComboBox();

        }

        private void ApptCountSearchButton_Click(object sender, EventArgs e)
        {          
            string Month = MonthDropDown.Text;
            string type = ApptTypeComboBox.Text;

            DataManipulator.CountByMonthInText(Month, type);
            resultTextBox.Text = DataManipulator.apptByMonthCount.ToString();
        }

        public void populateComboBox()
        {

            List<string> appointmentType = new List<string>
            {
                "Tire Replacement",
                "Free Alignment Check",
                "Tire Rotation",
                "Battery Check",
                "Oil Change",
                "Suspension Check",
                "Brakes"
            };
            
            appointmentType.Sort((x, y) => string.Compare(x, y)); // Lambda to order the appointment type dropdown list
            var bindingSource = new BindingSource();
            bindingSource.DataSource = appointmentType;
            ApptTypeComboBox.DataSource = bindingSource.DataSource;
        }

        private void ConsultantSearchButton_Click(object sender, EventArgs e)
        {
            string CustomerAppointments = $"SELECT customer.customerName, appointment.appointmentId, appointment.type,  appointment.start, appointment.end, user.userName FROM customer INNER JOIN appointment ON appointment.customerId = customer.customerId INNER JOIN user ON appointment.userId = user.userId WHERE user.userName = @USERNAME ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(CustomerAppointments, c);
            cmd.Parameters.AddWithValue("@USERNAME", ConsultantSearchTextBox.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
           
            UserScheduleDG.DataSource = dt;
            UserScheduleDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserScheduleDG.ReadOnly = true;
            UserScheduleDG.MultiSelect = false;
            UserScheduleDG.AllowUserToAddRows = false;
            UserScheduleDG.RowHeadersVisible = false;
            c.Close();
        }

        private void ReportFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {        
            string Customers = "select * FROM customer INNER JOIN appointment ON appointment.customerId = customer.customerId INNER JOIN user ON appointment.userId = user.userId";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(Customers, c);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            int numberOfCustomers = dt.AsEnumerable().Where(r => r["active"].Equals(true)).Count(); // Lambda expression to get number of active customers
            

            ReportResultTextBox.Text = numberOfCustomers.ToString();
           
            c.Close();

        }

        private void CloseReportsButton_Click(object sender, EventArgs e)
        { 
            Hide();
            MainForm mainForm = new MainForm();
           
            mainForm.Show();
        }

       
    }
}
