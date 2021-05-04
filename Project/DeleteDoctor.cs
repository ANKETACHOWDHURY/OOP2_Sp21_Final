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
    public partial class DeleteDoctor : Form
    {
        public DeleteDoctor()
        {
            InitializeComponent();
        }
     
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        //This portion for hide privious form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchId = "";

            string errMsg = null;
            if (tbSearchId.Text.Equals(""))
            {
                errMsg += "\nId Required For Delete Doctor";
            }
            else
            {
                searchId = tbSearchId.Text;
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

                //delete user id info which is currently show in the search box
                int id = Int32.Parse(tbSearchId.Text); //
                string query = "delete from doctors where id = " + id;

                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Delete Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to Delete");
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
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {

        }

        private void tbDoctorEmail_Click(object sender, EventArgs e)
        {

        }

       
    }

}
