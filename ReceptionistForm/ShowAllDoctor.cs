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
    public partial class ShowAllDoctor : Form
    {
        public ShowAllDoctor()
        {
            InitializeComponent();
        }

        //This portion for hide privious form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        List<Doctor> GetAllDoctors()
        {
            
            var conn = Database.ConnectDB();
            List<Doctor> doctors = new List<Doctor>();

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = "select * from doctors";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Doctor d = new Doctor();
                    d.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    d.DoctorName = reader.GetString(reader.GetOrdinal("DoctorName"));
                    d.Email = reader.GetString(reader.GetOrdinal("Email"));
                    d.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                    d.Shift = reader.GetString(reader.GetOrdinal("Shift"));
                    d.DoctorType = reader.GetString(reader.GetOrdinal("DoctorType"));
                    d.DoctorQualificaton = reader.GetString(reader.GetOrdinal("DoctorQualification"));
                    doctors.Add(d);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            conn.Close();
            return doctors;
        }


        private void ShowAllDoctor_Load(object sender, EventArgs e)
        {
            var doctors = GetAllDoctors();
            dtShowAllDoctors.DataSource = doctors;         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
