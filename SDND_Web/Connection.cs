using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SDND_Web.Models;
using System.Security.Cryptography;
using System.Web.Configuration;
using System.Configuration;

namespace SDND_Web
{
    public static class Connection
    {
        private static SqlConnection con;


        public static SqlConnection GetConnection()
        {

            if (con == null)
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=WINWS11;Initial Catalog=Students;User id=sa;password=sa1*";


            }
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }


        //public static SqlConnection GetConnection()
        //{
        //    if (con == null)
        //    {
        //        con = new SqlConnection();
        //        con.ConnectionString = "Data Source=WINWS11;Initial Catalog=Students;User id=sa;password=sa1*";
        //        con.OpenAsync();
        //    }

        //    if (con.State == System.Data.ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }

        //    return con;
        //}

    }
}