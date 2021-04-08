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
           
            string fname = txtFirstName.Text;
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
            string mobile = cmMobile.SelectedItem.ToString();


            rtOutput.Text = string.Format("FirstName: {0}\nLastName: {1}\n" +
                "Date of Birth: {2}-{3}-{4}\nGender: {5}\nEmail: {6}\n" +
                "Re Type Email{7}\nRe Type Email: {8}\nPassword: {9}\n" +
                "Re Type Password: {10}\nSecurity Question: {11}\n" +
                "Security Answer: {12}\nAddress: {13}\nCity: {14}\n" +
                "State: {15}\nPhone: {16} Mobile: {17}",
                fname,lname,month,day,year,gender,email,reTypeEmail,password,
                reTypePassword,securityQues,securityAns,address,city,state,phone,mobile);
        }

        private void FirstName(object sender, EventArgs e)
        {
            
        }
    }
}
