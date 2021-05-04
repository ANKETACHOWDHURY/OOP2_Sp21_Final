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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        //This portion for hide privious form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }


        private void SubmitClick(object sender, EventArgs e)
        {
            //Value Insertion and null validation

            string userName = "";
            string email = "";
            string mobile = "";
            string address = "";
            string password = "";
            string confirmPassword = "";
            string category = "";
            string gender = "";
            string day = "";
            string month = "";
            string year = "";

            string errMsg = null;
            if (tbUserName.Text.Equals(""))
            {
                errMsg += "\nUserName Required";
            }
            else
            {
                userName = tbUserName.Text;
            }

            if (tbEmail.Text.Equals(""))
            {
                errMsg += "\nEmail Required";
            }
            else
            {
                email = tbEmail.Text;
            }

            if (tbMobileNumber.Text.Equals(""))
            {
                errMsg += "\nMobileNumber Required";
            }
            else
            {
                mobile = tbMobileNumber.Text;
            }

            if (tbAddress.Text.Equals(""))
            {
                errMsg += "\nAddress Required";
            }
            else
            {
                address = tbAddress.Text;
            }

            if (tbPassword.Text.Equals(""))
            {
                errMsg += "\nPasswordRequired";
            }
            else
            {
                password = tbPassword.Text;
            }

            if (tbConfirmPassword.Text.Equals(""))
            {
                errMsg += "\nConfirmPassword Required";
            }
            else
            {
                confirmPassword = tbConfirmPassword.Text;
            }

            if (cbCategory.SelectedItem == null)
            {
                errMsg += "\nCategory Required";
            }
            else
            {
                category = cbCategory.SelectedItem.ToString();
            }

            if (cbGender.SelectedItem == null)
            {
                errMsg += "\nGender Required";
            }
            else
            {
                gender = cbGender.SelectedItem.ToString();
            }

            if (cbDay.SelectedItem == null)
            {
                errMsg += "\nDay Required for Date Of Birth";
            }
            else
            {
                day = cbDay.SelectedItem.ToString();
            }


            if (cbMonth.SelectedItem == null)
            {
                errMsg += "\nMonth Required for Date Of Birth";
            }
            else
            {
                month = cbMonth.SelectedItem.ToString();
            }

            if (cbYear.SelectedItem == null)
            {
                errMsg += "\nYear Required for Date Of Birth";
            }
            else
            {
                month = cbYear.SelectedItem.ToString();
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

                string query = string.Format("insert into registrations values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", userName, email, mobile, address, password, confirmPassword, category, gender, day + month + year);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Person Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Insert person");
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
                tbUserName.Text = "";
                tbEmail.Text = "";
                tbMobileNumber.Text = "";
                tbAddress.Text = "";
                tbPassword.Text = "";
                tbConfirmPassword.Text = "";
                cbCategory.SelectedItem ="";
                cbGender.SelectedItem ="";
                cbDay.SelectedItem ="";
                cbMonth.SelectedItem ="";
                cbYear.SelectedItem = "";
            }


        }

        private void btnBackLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }


        private void cmDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
