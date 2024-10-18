using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStore
{
    internal class MyConnect
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        SqlConnection conAdmin = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345");
        public SqlConnection getConnectionAdmin
        {
            get
            {
                return conAdmin;
            }
        }
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }
        public void openConnectionAdmin()
        {
            if (conAdmin.State == ConnectionState.Closed)
            {
                conAdmin.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void closeConnectionAdmin()
        {
            if (conAdmin.State == ConnectionState.Open)
            {
                conAdmin.Close();
            }
        }
    }

}


