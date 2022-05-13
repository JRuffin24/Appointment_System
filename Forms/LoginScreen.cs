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

namespace Appointment_System
{
    public partial class LoginScreen : Form
    {
         public string enterUsernameOrPassword = "Username and password must be entered.";
         public string UsernameOrPasswordIncorrect = "Username or password incorrect.";

        public LoginScreen()
        {
            InitializeComponent();
           DataManipulator DM = new DataManipulator();
            

            if (CultureInfo.CurrentUICulture.LCID == 2058)
            {
                titleLabel.Text = "Inicio de sesión de usuario";
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                LoginButton.Text = "Iniciar sesión";
                CloseProgramButton.Text = "Cerrar programa";
                enterUsernameOrPassword = "Se debe ingresar el nombre de usuario y la contraseña.";
                UsernameOrPasswordIncorrect = "Usuario o contraseña incorrectos.";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Gather user info from textboxes
            //Search users table for user name and password
                    // SELECT username, password FROM USERS
            //If there is a match, open the main screen
            //Else, return error message saying "Incorrect username or password
            //based on user location (America = English,  other = spanish)
            //return back to login screen
            
            if(DataManipulator.FindUser(usernameTextBox.Text, passwordTextBox.Text) !=0)
            {
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                AuditLogger.UserLoginReport(DataManipulator.GetCurrentUserId());
            }
            else if(usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show(enterUsernameOrPassword);
                return;
            }
            else
            {

                MessageBox.Show(UsernameOrPasswordIncorrect);
                return;

            }
            
            
        }

        private void CloseProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
