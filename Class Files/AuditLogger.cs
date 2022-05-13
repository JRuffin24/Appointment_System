using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_System
{
    public class AuditLogger
    {
        public static void UserLoginReport(int userId)
        {
            string path = "log.text";
            string log = $"User with ID of {userId} logged in at {DataManipulator.CreateTimestamp()} " + Environment.NewLine;

            File.AppendAllText(path, log);

            //file path is Appointment-System\Appointment System\bin\Debug
        }
    }
}
