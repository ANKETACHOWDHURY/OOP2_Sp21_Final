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

namespace db_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //do validation
            //This portion for value insertion
            string cname = tbCName.Text;
            string ccode = tbCCode.Text;

            /* string connString = @"Server=DESKTOP-IECT90H\SQLEXPRESS;Database=demo;Integrated Security=true"; 
             SqlConnection conn = new SqlConnection(connString);*/
            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            string query = string.Format("insert into courses values ('{0}','{1}')",cname,ccode);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Course Inserted");
                }
                else
                {
                    MessageBox.Show("Failed to Insert Course");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            conn.Close();//Here insertion finish

            //When click Add and automatic load 
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
            RefreshControls(); //for refresh

        }

        //This portion for Data Load
        private void loadData_Click(object sender, EventArgs e)
        {
            /* string connString = @"Server=DESKTOP-IECT90H\SQLEXPRESS;Database=demo;Integrated Security=true";
             SqlConnection conn = new SqlConnection(connString);
             List<Course> courses = new List<Course>();

             try
             {
                 conn.Open();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

             string query = "select * from courses";
             try
             {
                 SqlCommand cmd = new SqlCommand(query, conn);
                 SqlDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     Course c = new Course();
                     c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                     c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                     c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                     courses.Add(c);
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

             conn.Close();*/
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
           
       

        }
        //all data show in output
        List<Course> GetAllCourses()
        {
            /* string connString = @"Server=DESKTOP-IECT90H\SQLEXPRESS;Database=demo;Integrated Security=true";
             SqlConnection conn = new SqlConnection(connString);*/
            var conn = Database.ConnectDB();
            List<Course> courses = new List<Course>();

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = "select * from courses";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course c = new Course();
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                    courses.Add(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return courses;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;

        }

        //refresh

        void RefreshControls()
        {
            tbCCode.Text = "";
            tbCName.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //This portion for edit panel

        private void btnSearch_Click(object sender, EventArgs e)
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
            int id = Int32.Parse(tbSearchCId.Text);
            string query = "select * from courses where id = " + id;
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Course c = new Course();
            while (reader.Read()) //using while invalid number will not show but don't give any error
            {
                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));

            }
            conn.Close();
            tbCcodeUpdate.Text = c.CourseCode;
            tbCnameUpdate.Text = c.CourseName;

        }

        //This portion for value Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbSearchCId.Text);
            string cCode = tbCcodeUpdate.Text.Trim(); //trim fuction remove multiple white space
            string cName = tbCnameUpdate.Text;

            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = string.Format("update courses set CourseName='{0}',CourseCode='{1}' where id={2}", cName, cCode, id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();

            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
            conn.Close();
        }
    }
    
}
