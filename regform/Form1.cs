using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SubmitCkick(object sender, EventArgs e)
        {
            string fname = "";
            string lname ="";
            string month = "";
            string day = "";
            string year = "";
            string gender = "";
            string email = "";
            string reTypeEmail = "";
            string password = "";
            string reTypePassword = "";
            string securityQues ="";
            string securityAns ="";
            string address = "";
            string city = "";
            string state = "";
            string phone ="";
            string mobile = "";

            string errMsg = null;
            if (txtFirstName.Text.Equals(""))
            {
                errMsg += "\nFirstName Required";
            }
            else
            {
                fname = txtFirstName.Text;
            }

            if (txtLastName.Text.Equals(""))
            {
                errMsg += "\nLastName Required";
            }
            else
            {
                lname = txtLastName.Text;
            }

            if(cmMonth.SelectedItem == null)
            {
                errMsg += "\nMonth Required for Date Of Birth";
            }
            else
            {
                month= cmMonth.SelectedItem.ToString();
            }

            if (cmDay.SelectedItem == null)
            {
                errMsg += "\nDay Required for Date Of Birth";
            }
            else
            {
                day = cmDay.SelectedItem.ToString();
            }

            if (cmYear.SelectedItem == null)
            {
                errMsg += "\nYear Required for Date Of Birth";
            }
            else
            {
                month = cmYear.SelectedItem.ToString();
            }

            if (cmGender.SelectedItem == null)
            {
                errMsg += "\nGender Required";
            }
            else
            {
                gender = cmGender.SelectedItem.ToString();
            }

            if (txtEmail.Text.Equals(""))
            {
                errMsg += "\nEmail Required";
            }
            else
            {
                email = txtEmail.Text;
            }

            if (txtReTypeEmail.Text.Equals(""))
            {
                errMsg += "\nRe Type Email Required";
            }
            else
            {
                reTypeEmail = txtReTypeEmail.Text;
            }

            /* if (txtReTypeEmail.Text.Equals(""))
             {
                 errMsg += "\nRe Type Email Required";
             }
             else
             {
                 reTypeEmail = txtReTypeEmail.Text;
             }*/

            if (txtPassword.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
            }
            else
            {
                password= txtPassword.Text;
            }

            if (txtReTypePassword.Text.Equals(""))
            {
                errMsg += "\nRe Type Password Required";
            }
            else
            {
                reTypePassword= txtReTypePassword.Text;
            }

            if (cmSecurityQues.SelectedItem == null)
            {
                errMsg += "\nSecurity Question Required";
            }
            else
            {
                securityQues = cmSecurityQues.SelectedItem.ToString();
            }

            if (txtSecurityAns.Text.Equals(""))
            {
                errMsg += "\nSecurity Answer Required";
            }
            else
            {
                securityAns = txtSecurityAns.Text;
            }

            if (txtAddress.Text.Equals(""))
            {
                errMsg += "\nAddress Required";
            }
            else
            {
                address= txtAddress.Text;
            }

            if (txtCity.Text.Equals(""))
            {
                errMsg += "\nCity Required";
            }
            else
            {
                city = txtCity.Text;
            }


            if (cmState.SelectedItem == null)
            {
                errMsg += "\nState Required";
            }
            else
            {
                state = cmState.SelectedItem.ToString();
            }


            if (txtPhone.Text.Equals(""))
            {
                errMsg += "\nPhone Required";
            }
            else
            {
                phone = txtPhone.Text;
            }

            if (cmMobile.SelectedItem == null)
            {
                errMsg += "\nMobile Required";
            }
            else
            {
                state = cmMobile.SelectedItem.ToString();
            }


            /* string fname = txtFirstName.Text;
             string lname = txtLastName.Text;
             string month = cmMonth.SelectedItem.ToString();
             string day= cmDay.SelectedItem.ToString();
             string year = cmYear.SelectedItem.ToString();
             string gender = cmGender.SelectedItem.ToString();
             string email = txtEmail.Text;
             string reTypeEmail = txtReTypeEmail.Text;
             string password = txtPassword.Text;
             string reTypePassword = txtReTypePassword.Text;
             string securityQues= cmSecurityQues.SelectedItem.ToString();
             string securityAns= txtSecurityAns.Text;
             string address = txtAddress.Text;
             string city = txtCity.Text;
             string state = cmState.SelectedItem.ToString();
             string phone = txtPhone.Text;
             string mobile = cmMobile.SelectedItem.ToString();*/

            if (errMsg==null)
            {
                rtOutput.Text = string.Format("FirstName: {0}\nLastName: {1}\n" +
               "Date of Birth: {2}-{3}-{4}\nGender: {5}\nEmail: {6}\n" +
               "Re Type Email{7}\nRe Type Email: {8}\nPassword: {9}\n" +
               "Re Type Password: {10}\nSecurity Question: {11}\n" +
               "Security Answer: {12}\nAddress: {13}\nCity: {14}\n" +
               "State: {15}\nPhone: {16} Mobile: {17}",
               fname, lname, month, day, year, gender, email, reTypeEmail, reTypeEmail, password,
               reTypePassword, securityQues, securityAns, address, city, state, phone, mobile);

            }
            else
            {
                rtOutput.Text=(errMsg);
            }
           
        }

        private void FirstName(object sender, EventArgs e)
        {
            
        }
    }
}
