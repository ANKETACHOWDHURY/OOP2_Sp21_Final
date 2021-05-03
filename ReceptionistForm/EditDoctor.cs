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
    public partial class EditDoctor : Form
    {
        public EditDoctor()
        {
            InitializeComponent();
        }

        private void EditDoctor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbCcodeUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCnameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSearchCId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }


        //This portion for hide privious form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void SearchClick(object sender, EventArgs e)
        {
            string id = "";

            string errMsg = null;
            if (tbSearchId.Text.Equals(""))
            {
                errMsg += "\nId Required";
            }
            else
            {
                id = tbSearchId.Text;
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
                int Id = Int32.Parse(tbSearchId.Text);
                string query = "select * from doctors where id = " + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Doctor d = new Doctor();
                while (reader.Read()) //using while invalid number will not show but don't give any error
                {
                    d.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    d.DoctorName = reader.GetString(reader.GetOrdinal("DoctorName"));
                    d.Email = reader.GetString(reader.GetOrdinal("Email"));
                    d.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                    d.Shift = reader.GetString(reader.GetOrdinal("shift"));
                    d.DoctorQualificaton = reader.GetString(reader.GetOrdinal("DoctorQualification"));

                }

                conn.Close();
              
                tbUpdateName.Text = d.DoctorName;
                tbUpdateEmail.Text = d.Email;
                tbupdateDMobileno.Text = d.MobileNo;
                tbUpdateDShift.Text = d.Shift;
                tbUpdateDQualification.Text = d.DoctorQualificaton;
            }
            else
            {
                MessageBox.Show(errMsg);
            }
           
        }
        private void UpdateClick(object sender, EventArgs e)
        {
            string id = "";
            string doctorName = "";
            string email = "";
            string mobile = "";
            string shift = "";
            string dQualification = "";

            string errMsg = null;
            if (tbSearchId.Text.Equals(""))
            {
                errMsg += "\nId Required";
            }
            else
            {
                id = tbSearchId.Text;
            }

            if (tbUpdateName.Text.Equals(""))
            {
                errMsg += "\nDoctorName Required";
            }
            else
            {
                doctorName = tbUpdateName.Text;
            }

            if (tbUpdateEmail.Text.Equals(""))
            {
                errMsg += "\nEmail Required";
            }
            else
            {
                email = tbUpdateEmail.Text;
            }

            if (tbupdateDMobileno.Text.Equals(""))
            {
                errMsg += "\nMobileNumber Required";
            }
            else
            {
                mobile = tbupdateDMobileno.Text;
            }

            if (tbUpdateDShift.Text.Equals(""))
            {
                errMsg += "\nShift Required";
            }
            else
            {
                shift = tbUpdateDShift.Text;
            }

            if (tbUpdateDQualification.Text.Equals(""))
            {
                errMsg += "\nDoctorQualification Required";
            }
            else
            {
                dQualification = tbUpdateDQualification.Text;
            }

            if (errMsg == null)
            {
                int Id = Int32.Parse(tbSearchId.Text);
                string DoctorName = tbUpdateName.Text;
                string Email = tbUpdateEmail.Text;
                string Mobile = tbupdateDMobileno.Text.Trim(); //trim fuction remove multiple white space
                string Shift = tbUpdateDShift.Text;
                string DQualification = tbUpdateDQualification.Text;


                var conn = Database.ConnectDB();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string query = string.Format("update doctors set DoctorName='{0}' ,Email='{1}' ,MobileNo='{2}' ,Shift='{3}' ,DoctorQualification='{4}' where id={5}", doctorName, email, mobile, shift, dQualification, id);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Update Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to Update");
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
                tbSearchId.Text = "";
                tbUpdateName.Text = "";
                tbUpdateEmail.Text = "";
                tbupdateDMobileno.Text = "";
                tbUpdateDShift.Text = "";
                tbUpdateDQualification.Text = "";
            }

        }

        private void tbUpdateDQualification_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
    
}
