using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SDND_Web.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string FName { get; set; }
        public string Mobile { get; set; }
        public string CNIC { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }


        public DataTable GetAllStudent()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=WINWS11;" + "Initial Catalog=Students;" + "User id=sa;" + "password=sa1*";
            //con.Open();
            SqlCommand cmd = new SqlCommand("GetAllStudent", Connection.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Connection = Connection.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            return dt;  
        }

        public void SaveStudent()
        {
            SqlCommand cmd = new SqlCommand("SaveStudent", Connection.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentId", this.StudentId);
            cmd.Parameters.AddWithValue("@StdName", this.StudentName);
            cmd.Parameters.AddWithValue("@FName", this.FName);
            cmd.Parameters.AddWithValue("@Mobile", this.Mobile);
            cmd.Parameters.AddWithValue("@CNIC", this.CNIC);
            cmd.Parameters.AddWithValue("@Gender", this.Gender);
            cmd.Parameters.AddWithValue("@Address", this.Address);
            cmd.ExecuteNonQuery();
        }

        public void UpdateStudent()
        {
            SqlCommand cmd = new SqlCommand("UpdateStudent", Connection.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentId", this.StudentId);
            cmd.Parameters.AddWithValue("@StdName", this.StudentName);
            cmd.Parameters.AddWithValue("@FName", this.FName);
            cmd.Parameters.AddWithValue("@Mobile", this.Mobile);
            cmd.Parameters.AddWithValue("@CNIC", this.CNIC);
            cmd.Parameters.AddWithValue("@Gender", this.Gender);
            cmd.Parameters.AddWithValue("@Address", this.Address);
            cmd.ExecuteNonQuery();

        }

        public DataTable GetStudentById(int StudentId)
        {
            SqlCommand cmd = new SqlCommand("GetStudentById", Connection.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentId", this.StudentId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }    

        public void DeleteStudent()
        {

        }
    }
}