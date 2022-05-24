using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_System
{
    public class appointmentException : ApplicationException
    {
        public void businessHours()
        {
            MessageBox.Show("Error! Appointments need to be within normal business hours");
        }

        public void appOverlap()
        {
            MessageBox.Show("Error! Your appointment time is conflicting with an already present appointment");
        }
    }
}
