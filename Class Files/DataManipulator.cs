using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Appointment_System
{
    class DataManipulator
    {
        public static int currentUserId;
        public static string currentUserName;
        public static string connectionString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!;";
        //public static string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=passw0rd!;";
        public static string currentCustomerAddress;
        public static int currentCustomerId;
        public static string currentCustomerName;
        public static int currentCustomerAddressId;
        public static string currentCustomerCity;
        public static int currentCustomerCityId;
        public static string currentCustomerCountry;
        public static string currentCustomerPhoneNumber;
        public static int currentCustomerCountryId;
        public static int currentApptId;
        public static string apptType;
        public static DateTime startTime;
        public static DateTime endTime;
        public static int apptByMonthCount;
        public static int totalCustomers;
        public static int appointmentCount;

        public static int GetTotalCustomerCount()
        {
            return totalCustomers;
        }
        public static void SetCustomerAmount(int customerCount)
        {
            totalCustomers = customerCount;
        }

        public static int GetApptCountByMonth()
        {
            return apptByMonthCount;
        }

        public static void SetApptCountByMonth(int count)
        {
            apptByMonthCount = count;
        }

        public static string GetCurrentApptType()
        {
            return apptType;
        }
        public static void SetCurrentApptType(string type)
        {
            apptType = type;
        }
        public static DateTime GetCurrentStartTime()
        {
            return startTime;
        }
        public static void SetStartTime(DateTime start)
        {
            startTime = start;
        }
        public static DateTime GetCurrentEndTime()
        {
            return endTime;
        }
        public static void SetEndTime(DateTime end)
        {
            endTime = end;
        }
        public static int GetCurrentApptId()
        {
            return currentApptId;
        }
        public static void SetCurrentApptId(int ApptId)
        {
            currentApptId = ApptId;
        }
        public static int GetCurrentCustCountryId()
        {
            return currentCustomerCountryId;
        }
        public static void SetCurrentCustomerCountryId(int countryId)
        {
            currentCustomerCountryId = countryId;
        }

        public static int GetCurrentCustCityId()
        {
            return currentCustomerCityId;
        }

        public static void SetCurrentCustomerCityId(int cityId)
        {
            currentCustomerCityId = cityId;
        }

        public static int GetCurrentCustID()
        {
            return currentCustomerId;
        }

        public static void SetCurrentCustomerId(int customerId)
        {
            currentCustomerId = customerId;
        }

        public static int GetCurrentUserId()
        {
            return currentUserId;
        }

        public static string GetCurrentCustomerName()
        {
            return currentCustomerName;
        }

        public static void SetCurrentCustomerName(string updatedName)
        {
            currentCustomerName = updatedName;
        }

        public static int GetCurrentAddressId()
        {
            return currentCustomerAddressId;
        }

        public static void SetCurrentAddressId(int addressId)
        {
            currentCustomerAddressId = addressId;
        }

        public static string GetCurrentCustomerAddress()
        {
            return currentCustomerAddress;
        }

        public static void SetCurrentCustomerAddress(string customerAddress)
        {
            currentCustomerAddress = customerAddress;
        }

        public static string GetCurrentCustomerCity()
        {
            return currentCustomerCity;
        }

        public static void SetCurrentCustomerCity(string customerCity)
        {
            currentCustomerCity = customerCity;
        }

        public static string GetCurrentCustomerCountry()
        {
            return currentCustomerCountry;
        }

        public static void SetCurrentCustomerCountry(string customerCountry)
        {
            currentCustomerCountry = customerCountry;
        }

        public static string GetCurrentCustomerPhone()
        {
            return currentCustomerPhoneNumber;
        }

        public static void SetCurrentCustomerPhone(string customerPhone)
        {
            currentCustomerPhoneNumber = customerPhone;
        }

        public static void SetCurrentUserId(int currentUId)
        {
            currentUserId = currentUId;
        }

        public static string GetCurrentUserName()
        {
            return currentUserName;
        }

        public static void SetCurrentUserName(string currentUName)
        {
            currentUserName = currentUName;
        }

        public static string CreateTimestamp()
        {
            return DateTime.Now.ToString("u");
        }
        public static string ConvertToTimezone(string dateTime)
        {
            DateTime utcDateTime = DateTime.Parse(dateTime.ToString());
            DateTime localDateTime = utcDateTime.ToLocalTime();

            return localDateTime.ToString("MM/dd/yyyy hh:mm tt");
        }

        public static int FindAppointmentId(int appointmentId)
        {
            string APPTID = $"SELECT appointmentId FROM appointment WHERE appointmentId = @APPTID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(APPTID, c);
            cmd.Parameters.AddWithValue("@APPTID", appointmentId);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentApptId(Convert.ToInt32(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentApptId();
            }
            c.Close();
            return currentApptId;
        }

        public static DateTime GetAppointmentStart(int appointmentId)
        {
            string APPTSTART = $"SELECT start FROM appointment WHERE appointmentId = @APPTID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(APPTSTART, c);
            cmd.Parameters.AddWithValue("@APPTID", appointmentId);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetStartTime(Convert.ToDateTime(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentStartTime();
            }
            c.Close();
            return startTime;
        }

        public static DateTime GetAppointmentEnd(int appointmentId)
        {
            string APPTSTART = $"SELECT end FROM appointment WHERE appointmentId = @APPTID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(APPTSTART, c);
            cmd.Parameters.AddWithValue("@APPTID", appointmentId);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetEndTime(Convert.ToDateTime(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentEndTime();
            }
            c.Close();
            return endTime;
        }

        public static string GetAppointmentType(int appointmentId)
        {
            string APPTTYPE = $"SELECT type FROM appointment WHERE appointmentId = @APPTID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(APPTTYPE, c);
            cmd.Parameters.AddWithValue("@APPTID", appointmentId);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentApptType(Convert.ToString(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentApptType();
            }
            c.Close();
            return apptType;
        }

        public static int FindUser(string username, string password) 
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE username = '{username}' AND password = '{password}'", c);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentUserId(Convert.ToInt32(dataReader[0]));
                SetCurrentUserName(username);
                dataReader.Close();
                c.Close();
                return GetCurrentUserId();
            }
            c.Close();
            return 0;
        }

        public static string FindCustomerName(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            String CUSTOMERNAME = "SELECT customerName FROM customer WHERE customerId = @ID";
            MySqlCommand cmd = new MySqlCommand(CUSTOMERNAME, c);
            cmd.Parameters.AddWithValue("ID", customerId);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerName((string)dataReader[0]);
                dataReader.Close();
                c.Close();
                return GetCurrentCustomerName();
            }
            c.Close();
            return currentCustomerName;
        }

        public static string FindCustomerAddress(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand address = new MySqlCommand($"SELECT address FROM address INNER JOIN customer ON address.addressId = customer.addressId WHERE customer.customerId = '{customerId}'", c);
            MySqlDataReader dataReader = address.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerAddress(Convert.ToString(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentCustomerAddress();
            }
            c.Close();
            return currentCustomerAddress ;
        }

        public static string FindCustomerCity(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand city = new MySqlCommand($"SELECT city FROM city INNER JOIN address ON city.cityId = address.cityId INNER JOIN customer ON customer.addressId = address.addressId WHERE customer.customerId = '{customerId}'", c);
            MySqlDataReader dataReader = city.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerCity(Convert.ToString(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentCustomerCity();
            }
            c.Close();
            return currentCustomerCity;
        }

        public static string FindCustomerPhone(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand city = new MySqlCommand($"SELECT phone FROM address INNER JOIN customer ON address.addressId = customer.addressId WHERE customer.customerId = '{customerId}'", c);
            MySqlDataReader dataReader = city.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerPhone(Convert.ToString(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentCustomerPhone();
            }
            c.Close();
            return currentCustomerPhoneNumber;
        }

        public static int FindCustomerCityId(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cityId = new MySqlCommand($"SELECT city.cityId FROM city INNER JOIN address ON city.cityId = address.cityId INNER JOIN customer ON customer.addressId = address.addressId WHERE customer.customerId = '{customerId}'", c);
            MySqlDataReader dataReader = cityId.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerCityId((int)dataReader[0]);
                dataReader.Close();
                c.Close();
                return GetCurrentCustCityId();
            }
            c.Close();
            return currentCustomerCityId;
        }

        public static int FindCustomerCountryId(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand countryId = new MySqlCommand($"SELECT country.countryId FROM country INNER JOIN city ON country.countryId = city.countryId INNER JOIN address ON address.cityId = city.cityId INNER JOIN customer ON address.addressId = customer.addressId WHERE customer.customerId = '{customerId}'", c);
            MySqlDataReader dataReader = countryId.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerCountryId((int)dataReader[0]);
                dataReader.Close();
                c.Close();
                return GetCurrentCustCountryId();
            }
            c.Close();
            return currentCustomerCountryId;
        }

        public static string FindCustomerCountry(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand country = new MySqlCommand($"SELECT country FROM country INNER JOIN city ON country.countryId = city.countryId INNER JOIN address ON address.cityId = city.cityId INNER JOIN customer ON customer.addressId = address.addressId WHERE customer.customerId = '{customerId}'", c);
            MySqlDataReader dataReader = country.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerCountry(Convert.ToString(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetCurrentCustomerCountry();
            }
            c.Close();
            return currentCustomerCountry;
        }

        public static void UpdateCountry(string customerName, string customerCountry)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            string UPDATECOUNTRY = "UPDATE country JOIN city ON country.countryId = city.countryId JOIN address ON address.cityId = city.cityId  JOIN customer ON customer.addressId = address.addressId SET country.country = @NEWCOUNTRY WHERE customer.customerName = @CUSTOMERNAME ";
            MySqlCommand cmd = new MySqlCommand(UPDATECOUNTRY, c);
            cmd.Parameters.AddWithValue("@NEWCOUNTRY", customerCountry);
            cmd.Parameters.AddWithValue("@CUSTOMERNAME", customerName);
            cmd.ExecuteNonQuery();
            c.Close();
        }

        public static void UpdateCustomerAddress(int addressId, string customerAddress)
        {
            string UPDATEADDRESS = "UPDATE address SET address = @NEWADDRESS WHERE addressId = @ADDRESSID ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(UPDATEADDRESS,c);
            cmd.Parameters.AddWithValue("@NEWADDRESS",customerAddress);
            cmd.Parameters.AddWithValue("ADDRESSID", addressId);
            cmd.ExecuteNonQuery();
            c.Close();
        }

        public static int FindAddressId(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand address = new MySqlCommand($"SELECT address.addressId FROM address INNER JOIN customer ON address.addressId = customer.addressId WHERE customer.customerId = '{customerId}'", c);
            MySqlDataReader dataReader = address.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentAddressId((int)dataReader[0]);
                dataReader.Close();
                c.Close();
                return GetCurrentAddressId();
            }
            c.Close();
            return currentCustomerAddressId;
        }

        public static void UpdateCustomerName(int customerId, string customerNewName)
        {
            string UPDATEDNAME = "UPDATE customer SET customerName = @NEWNAME WHERE customerId = @CUSTOMERID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(UPDATEDNAME, c);
            cmd.Parameters.AddWithValue("@NEWNAME", customerNewName);
            cmd.Parameters.AddWithValue("@CUSTOMERID", customerId);
            cmd.ExecuteNonQuery();
            c.Close();
        }

        public static void UpdateCustomerCity(int cityId, string customerNewAddress)
        {
            string UPDATECITY = "UPDATE city SET city = @NEWCITY WHERE cityId = @CITYID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(UPDATECITY, c);
            cmd.Parameters.AddWithValue("@NEWCITY", customerNewAddress);
            cmd.Parameters.AddWithValue("@CITYID", cityId);
            cmd.ExecuteNonQuery();
            c.Close();
        }

        public static void UpdateCustomerPhone(int addressId, string phoneNumber)
        {
            string UPDATEADDRESS = "UPDATE address SET phone = @NEWPHONE WHERE addressId = @ADDRESSID ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(UPDATEADDRESS, c);
            cmd.Parameters.AddWithValue("@NEWPHONE", phoneNumber);
            cmd.Parameters.AddWithValue("ADDRESSID", addressId);
            cmd.ExecuteNonQuery();
            c.Close();
        }

        public static int FindCustomerId(int customerId)
        {
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            String CUSTOMERNAME = "SELECT customerId FROM customer WHERE customerId = @ID";
            MySqlCommand cmd = new MySqlCommand(CUSTOMERNAME, c);
            cmd.Parameters.AddWithValue("ID", customerId);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCurrentCustomerId((int)dataReader[0]);
                dataReader.Close();
                c.Close();
                return GetCurrentCustID();
            }
            c.Close();
            return currentCustomerId;
        }
        
        public static void DeleteCustomer(string customerName)
        {
            string DELETECUSTOMER = "DELETE customer, address, city, country FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON city.cityId = address.cityId INNER JOIN country ON city.countryId = country.countryId WHERE customer.customerName = @CUSTOMERNAME";
            
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(DELETECUSTOMER, c);
 
            cmd.Parameters.AddWithValue("@CUSTOMERNAME", customerName);
           
            cmd.ExecuteNonQuery();

        }

        public static void DeleteAppointment(int ApptId)
        {
            string DELETEAPPT = "DELETE FROM appointment WHERE appointmentId = @APPTID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(DELETEAPPT, c);
            cmd.Parameters.AddWithValue("@APPTID", ApptId);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateApptStartTime(DateTime startingTime, int ApptId)
        {
            string UPDATESTARTINGTIME = "UPDATE appointment SET start = @STARTTIME WHERE appointmentId = @APPTID";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(UPDATESTARTINGTIME, c);
            cmd.Parameters.AddWithValue("@STARTTIME", startingTime);
            cmd.Parameters.AddWithValue("@APPTID", ApptId);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateApptEndTime(DateTime endingTime, int ApptId)
        {
            string UPDATEENDINGTIME = "UPDATE appointment SET end = @ENDTIME WHERE appointmentId = @APPTID ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(UPDATEENDINGTIME, c);
            cmd.Parameters.AddWithValue("@ENDTIME", endingTime);
            cmd.Parameters.AddWithValue("@APPTID", ApptId);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateApptType(string type, int ApptId)
        {
            string UPDATETYPE = "UPDATE appointment SET type = @TYPE WHERE appointmentId = @APPTID ";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(UPDATETYPE, c);
            cmd.Parameters.AddWithValue("@TYPE", type);
            cmd.Parameters.AddWithValue("@APPTID", ApptId);
            cmd.ExecuteNonQuery();
        }

        public static int CountByMonthInText(string month, string type)
        {
            string MONTHSEARCHVIATEXT = "SELECT Count(appointmentId) FROM appointment WHERE monthname(start) = @MONTH  AND type = @TYPE" ;
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(MONTHSEARCHVIATEXT, c);
            cmd.Parameters.AddWithValue("@MONTH", month);
            cmd.Parameters.AddWithValue("@TYPE", type);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetApptCountByMonth(Convert.ToInt32(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetApptCountByMonth();
            }
            c.Close();
            return apptByMonthCount;
        }

        public static int TotalCustomerCount()
        {
            string TOTALCUSTOMERCOUNT = "SELECT COUNT(*) FROM customer";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(TOTALCUSTOMERCOUNT, c);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                SetCustomerAmount(Convert.ToInt32(dataReader[0]));
                dataReader.Close();
                c.Close();
                return GetTotalCustomerCount();
            }
            c.Close();
            return totalCustomers;
        }
        
        public static int AppointmentCount()
        {
            string appointmentsCount = "Select count(*) from appointment";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(appointmentsCount, c);
            Object obj = cmd.ExecuteScalar();
            appointmentCount = Convert.ToInt32(obj.ToString());
            return appointmentCount;
        }

       
    }
}
