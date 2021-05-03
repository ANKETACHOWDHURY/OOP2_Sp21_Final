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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //This portion for hide privious form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }


        private void AddClick(object sender, EventArgs e)
        {
            string doctorName = "";
            string email = "";
            string mobile = "";
            string shift = "";
            string type = "";
            string qualification = "";

            string errMsg = null;
            if (tbDName.Text.Equals(""))
            {
                errMsg += "\nDoctor Name Required";
            }
            else
            {
                doctorName = tbDName.Text;
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

            if (cbDshift.SelectedItem == null)
            {
                errMsg += "\nShift Required";
            }
            else
            {
                shift = cbDshift.SelectedItem.ToString();
            }


            if (cbType.SelectedItem == null)
            {
                errMsg += "\nDoctor Type Required";
            }
            else
            {
                type = cbType.SelectedItem.ToString();
            }


            if (cbDQualification.SelectedItem == null)
            {
                errMsg += "\nDoctor Qualification Required";
            }
            else
            {
                qualification = cbDQualification.SelectedItem.ToString();
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

                string query = string.Format("insert into doctors values ('{0}','{1}','{2}','{3}','{4}','{5}')", doctorName, email, mobile, shift,type,qualification);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Doctor Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Insert Doctor");
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
                tbDName.Text = "";
                tbEmail.Text = "";
                tbMobileNumber.Text = "";
                cbDshift.SelectedItem = -1;
                cbType.SelectedItem = -1;
                cbDQualification.SelectedItem = -1;
            }





        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void tbDoctorEmail_Click(object sender, EventArgs e)
        {

        }

        private void tbDoctorMobile_Click(object sender, EventArgs e)
        {

        }

        private void cbShift_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
