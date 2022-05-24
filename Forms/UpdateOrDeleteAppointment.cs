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
    public partial class UpdateOrDeleteAppointment : Form
    {
        public static DataTable dt = new DataTable();
        public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
        //public static string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=passw0rd!;";
        public UpdateOrDeleteAppointment()
        {
            InitializeComponent();
        }
        public UpdateOrDeleteAppointment(Appointment appointment)
        {
            AddAppointment addAppointment = new AddAppointment();

            InitializeComponent();
            ApptCustIDTextBox.Text = appointment.custId.ToString();
            ApptIdTextBox.Text = appointment.apptId.ToString();
            ApptStartPicker.Value = appointment.start;
            ApptEndPicker.Value = appointment.end;
            ApptTypeComboBox.Text = appointment.type;
            ApptIdTextBox.ReadOnly = true;
            ApptCustIDTextBox.ReadOnly = true;
             

            string SELECTALLAPPTS = "SELECT * FROM appointment";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(SELECTALLAPPTS, c);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

        }

        private void UpdateApptCancelButton_Click(object sender, EventArgs e)
        {
            AppointmentSelectionForm appointmentSelectionForm = new AppointmentSelectionForm();
            Hide();
            appointmentSelectionForm.Show();
        }

        private void UpdateApptSaveButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (AddAppointment.ApptHasConflict(ApptStartPicker.Value,ApptEndPicker.Value))
                {
                    throw new appointmentException();
                }
                else
                {
                    try
                    {
                        if(AddAppointment.ApptOutsideBusinessHours(ApptStartPicker.Value, ApptEndPicker.Value))
                        {
                            throw new appointmentException();
                        }
                        else
                        {
                             if (ApptStartPicker.Text != DataManipulator.startTime.ToString())
                                {
                                    DataManipulator.GetAppointmentStart(Convert.ToInt32(ApptIdTextBox.Text));
                                    DataManipulator.UpdateApptStartTime(DateTime.Parse(ApptStartPicker.Text), Convert.ToInt32(ApptIdTextBox.Text));
                                }
                             else if (ApptEndPicker.Text != DataManipulator.endTime.ToString())
                                {
                                    DataManipulator.GetAppointmentEnd(Convert.ToInt32(ApptIdTextBox.Text));
                                    DataManipulator.UpdateApptEndTime(DateTime.Parse(ApptStartPicker.Text), Convert.ToInt32(ApptIdTextBox.Text));
                                }
                             else if (ApptTypeComboBox.Text != DataManipulator.apptType)
                                {
                                    DataManipulator.GetAppointmentType(Convert.ToInt32(ApptIdTextBox.Text));
                                    DataManipulator.UpdateApptType(ApptTypeComboBox.Text, Convert.ToInt32(ApptIdTextBox.Text));
                                }
                             else
                                {
                                    MessageBox.Show("No changes have been made.");
                                }
                        }   
                    
                    }
                    catch (appointmentException ex)
                    {
                        ex.businessHours();
                        return;
                    }
                }
               }
            catch (appointmentException ex)
            {
                ex.appOverlap();
                return;
            }
            

            AppointmentSelectionForm appointmentSelection = new AppointmentSelectionForm();
            appointmentSelection.Show();
            Hide();
        }

        private void UpdateApptDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment? This action cannot be undone once completed.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataManipulator.FindAppointmentId(int.Parse(ApptIdTextBox.Text));
                DataManipulator.DeleteAppointment(DataManipulator.currentApptId);

            }
            else
            {
                return;
            }
            AppointmentSelectionForm appointmentSelectionForm = new AppointmentSelectionForm();
            Hide();
            appointmentSelectionForm.Show();
        }

       
    }
}
