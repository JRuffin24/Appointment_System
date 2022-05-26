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
    public partial class AppointmentSelectionForm : Form
    {
        public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
        //public static string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=passw0rd!;";
        public AppointmentSelectionForm()
        {
            InitializeComponent();
            System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
            DateTime Now = DateTime.Now;
            string SHOWAPPTS = "SELECT * FROM appointment";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(SHOWAPPTS, c);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                DateTime start = DateTime.Parse(row["start"].ToString()).ToLocalTime();
                DateTime end = DateTime.Parse(row["end"].ToString()).ToLocalTime();
            }

            ApptSelectionGrid.DataSource = dt;
            ApptSelectionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ApptSelectionGrid.ReadOnly = true;
            ApptSelectionGrid.MultiSelect = false;
            ApptSelectionGrid.AllowUserToAddRows = false;
            ApptSelectionGrid.RowHeadersVisible = false;
            

        }

        private void EditAppointment_Click(object sender, EventArgs e)
        {
            if(ApptSelectionGrid.SelectedRows.Count > 0)
            {
                Appointment SelectedAppointment = new Appointment();
                SelectedAppointment.apptId = (int)ApptSelectionGrid.CurrentRow.Cells[0].Value;
                SelectedAppointment.custId = (int)ApptSelectionGrid.CurrentRow.Cells[1].Value;
                SelectedAppointment.userId = (int)ApptSelectionGrid.CurrentRow.Cells[2].Value;
                SelectedAppointment.type = (string)ApptSelectionGrid.CurrentRow.Cells[7].Value;
                SelectedAppointment.start = (DateTime)ApptSelectionGrid.CurrentRow.Cells[9].Value;
                SelectedAppointment.end = (DateTime)ApptSelectionGrid.CurrentRow.Cells[10].Value;

                UpdateOrDeleteAppointment updateOrDelete = new UpdateOrDeleteAppointment(SelectedAppointment);
                Hide();
                updateOrDelete.Show();
            } 
            else
            {
                MessageBox.Show("You must select an appointment to edit.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Hide();
            mainForm.Show();
        }

        //private void SystemEvents_TimeChanged(object sender, EventArgs e)
        //{
        //    System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
        //}
    }
}
