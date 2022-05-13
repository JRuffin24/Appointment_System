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
    public partial class CreateCustomer : Form
    {
        public static string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=passw0rd!;";
        public CreateCustomer()
        {
            InitializeComponent();
        }
       

        private void CreateCustSaveButton_Click(object sender, EventArgs e)
        {
            //get info from textboxes (Name, address, address 2, city name, country name, phone number) 
            //Insert into Customer Table 

            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;
            string address2 = Address2TextBox.Text;
            string cityName = CityNameTextBox.Text;
            int postalCode = Int32.Parse(PostalCodeTextBox.Text);
            string countryName = CountryNameTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;
            int addressId;
      
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(cityName) ||
                string.IsNullOrEmpty(countryName) ||
                string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter all fields.");
            }
            else
            {

                string INSERTCOUNTRY = "INSERT INTO country VALUES (NULL, @COUNTRYNAME, NOW(), 'test', NOW(),'test')";

                MySqlConnection c = new MySqlConnection(connectionString);
                c.Open();
                MySqlCommand cmd = new MySqlCommand(INSERTCOUNTRY, c);
                cmd.Parameters.AddWithValue("@COUNTRYNAME", countryName);
                cmd.ExecuteNonQuery();
                int countryId = (int)cmd.LastInsertedId;

                string INSERTCITY = "INSERT INTO city VALUES (NULL, @CITYNAME, @COUNTRYID, NOW(), 'test', NOW(), 'test')";
                MySqlCommand cmd2 = new MySqlCommand(INSERTCITY, c);
                cmd2.Parameters.AddWithValue("@CITYNAME", cityName);
                cmd2.Parameters.AddWithValue("@COUNTRYID", countryId);
                cmd2.ExecuteNonQuery();
                int cityId = (int)cmd2.LastInsertedId;

                //int addressId;

               
                if (address2 == " ")
                {
                string INSERTADDRESS = "INSERT INTO address VALUES(NULL, @ADDRESS, ' ' ,@CITYID, @POSTALCODE, @PHONENUMBER, NOW(),'test', NOW(),'test')";
                MySqlCommand cmd3 = new MySqlCommand(INSERTADDRESS, c);
                cmd3.Parameters.AddWithValue("@ADDRESS", address);
                cmd3.Parameters.AddWithValue("@CITYID", cityId);
                cmd3.Parameters.AddWithValue("@POSTALCODE", postalCode);
                cmd3.Parameters.AddWithValue("@PHONENUMBER", phoneNumber);
                cmd3.ExecuteNonQuery();
                addressId = (int)cmd3.LastInsertedId;
                }
                else
                {
                    string INSERTADDRESS = "INSERT INTO address VALUES(NULL, @ADDRESS, @ADDRESS2, @CITYID, @POSTALCODE, @PHONENUMBER, NOW(),'test', NOW(),'test')";
                    MySqlCommand cmd3 = new MySqlCommand(INSERTADDRESS, c);
                    cmd3.Parameters.AddWithValue("@ADDRESS", address);
                    cmd3.Parameters.AddWithValue("@ADDRESS2", address2);
                    cmd3.Parameters.AddWithValue("@CITYID", cityId);
                    cmd3.Parameters.AddWithValue("@POSTALCODE", postalCode);
                    cmd3.Parameters.AddWithValue("@PHONENUMBER", phoneNumber);
                    cmd3.ExecuteNonQuery();
                    addressId = (int)cmd3.LastInsertedId;
                }
                

                String INSERTCUSTOMER = "INSERT INTO customer VALUES(NULL, @NAME, @ADDRESSID, 1, NOW(), 'test', NOW(), 'test') ";
                MySqlCommand cmd4 = new MySqlCommand(INSERTCUSTOMER, c);
                cmd4.Parameters.AddWithValue("@NAME", name);
                cmd4.Parameters.AddWithValue("@ADDRESSID", addressId);
                cmd4.ExecuteNonQuery();
                int customerID = (int)cmd4.LastInsertedId;
                c.Close();
                
            }
            
            Close();

        }

        private void CreateCustCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

   

               


      


