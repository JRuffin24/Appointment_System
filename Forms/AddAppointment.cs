using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Text.RegularExpressions;

namespace Appointment_System
{
    public partial class AddAppointment : Form
    {

        public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
        //public static string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=passw0rd!;";
        public static int appointmentId;
        public static DataTable dt = new DataTable();

        public AddAppointment()
        {
            InitializeComponent();
           string SELECTALLAPPTS = "SELECT * FROM appointment";
        MySqlConnection c = new MySqlConnection(connectionString);
        c.Open();
            MySqlCommand cmd = new MySqlCommand(SELECTALLAPPTS, c);
        
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

        da.Fill(dt);

        }

        public AddAppointment(Customer customer)
        {
            InitializeComponent();
            AddApptCustIDTextBox.Text = customer.id.ToString();
            AddApptCustNameTextBox.Text = customer.name;
            AddApptCustNameTextBox.ReadOnly = true;
            AddApptCustIDTextBox.ReadOnly = true;


        }

        private void AddApptScheduleButton_Click(object sender, EventArgs e)
        {
            DataManipulator.GetCurrentUserName();
            DataManipulator.GetCurrentUserId();



			//DateTime start = TimeZoneInfo.ConvertTimeToUtc(StartPicker.Value);
			//DateTime end = TimeZoneInfo.ConvertTimeToUtc(EndPicker.Value);

			DateTime start = StartPicker.Value;
			DateTime end = EndPicker.Value;

			string ApptType = ApptTypeComboBox.Text;
            int CustId = int.Parse(AddApptCustIDTextBox.Text);

            try
            {
                if( ApptHasConflict(start, end, dt))
                {
                    throw new appointmentException();
                }
                else
                {
                    try
                    {
                        if(ApptOutsideBusinessHours(start, end))
                        {
                            throw new appointmentException();
                        }
                        else
                        {
                            string INSERTAPPT = "INSERT into appointment VALUES(Null,@CUSTOMERID, @USERID, 'not needed', 'not needed', 'not needed', 'not needed', @TYPE, 'not needed', @START, @END, NOW(), @USERNAME, NOW(), @USERNAME)";
                            MySqlConnection c = new MySqlConnection(connectionString);
                            c.Open();
                            MySqlCommand cmd = new MySqlCommand(INSERTAPPT, c);
                            cmd.Parameters.AddWithValue("@CUSTOMERID", CustId);
                            cmd.Parameters.AddWithValue("@USERID", DataManipulator.currentUserId);
                            cmd.Parameters.AddWithValue("@USERNAME", DataManipulator.currentUserName);
                            cmd.Parameters.AddWithValue("@TYPE", ApptTypeComboBox.Text);
                            cmd.Parameters.AddWithValue("@START", start);
                            cmd.Parameters.AddWithValue("@END", end);


                            cmd.ExecuteNonQuery();
                            appointmentId = (int)cmd.LastInsertedId;
                            c.Close();
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

            AddAppointmentCustomerSelectionForm addAppointmentCustomer = new AddAppointmentCustomerSelectionForm();
            addAppointmentCustomer.Show();
            Hide();
                
        }

        private void AddApptCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddAppointmentCustomerSelectionForm addAppointmentCustomer = new AddAppointmentCustomerSelectionForm();
            addAppointmentCustomer.Show();
        }

        public static bool ApptOutsideBusinessHours(DateTime startingTime, DateTime endingTime)
        {
            startingTime = startingTime.ToLocalTime();            
            endingTime = endingTime.ToLocalTime();
            DateTime BusinessStartTime = DateTime.Today.AddHours(8); //8:00AM
            DateTime BusinessEndTime = DateTime.Today.AddHours(17); //5PM

            if ((startingTime > BusinessStartTime) && (startingTime < BusinessEndTime)
                && (endingTime > BusinessStartTime) && (endingTime < BusinessEndTime))
            {
                return false;
            }
            else 
            { 
                return true; 
            }


        }

        public static bool ApptHasConflict(DateTime startingTime, DateTime endingTime, DataTable dt)
        {

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DateTime ApptStart = DateTime.Parse(dt.Rows[i]["start"].ToString());
            //    DateTime ApptEnd = DateTime.Parse(dt.Rows[i]["end"].ToString());

            //    if ((startingTime < ApptEnd) && (ApptStart < endingTime))
            //    {
            //        return true;
            //    }
            //}

            //return false;
            foreach (DataRow row in dt.Rows)
            {

                //DateTime ApptEnd = DateTime.Parse(row["end"].ToString()).ToLocalTime();

                if ((startingTime < DateTime.Parse(row["end"].ToString())) && (DateTime.Parse(row["start"].ToString()) < endingTime))
                {
                    return true;
                }

            }

            return false;
        }
    }
}
