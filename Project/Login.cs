using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ReceptionistForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if(e.CloseReason !=CloseReason.WindowsShutDown)
            Application.Exit();
        }
        private void LoginClick(object sender, EventArgs e)
        {
            string userName = "";
            string password = "";

            string errMsg = null;

            if (tbUname.Text.Equals(""))
            {
                errMsg += "\nUserName Required";
            }
            else
            {
                userName = tbUname.Text;
            }

            if (tbPassword.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
            }
            else
            {
               
                password = tbPassword.Text;
            }

            if (errMsg == null)
            {
                var conn = Database.ConnectDB();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string query = string.Format("select * from registrations where username='{0}' and password='{1}'",userName,password);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("LogIn Successful");
                        this.Hide();
                        new Dashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
                RefreshControls();

            }
            else
            {
                MessageBox.Show(errMsg);
            }

            void RefreshControls()
            {
                tbUname.Text = "";
                tbPassword.Text = "";

            }

        }

        private void RegistrationClick(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
