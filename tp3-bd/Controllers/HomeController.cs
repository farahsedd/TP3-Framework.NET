using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.SqlServer.Server;
using System.Web.UI.WebControls;
using System.Xml;
using System.Reflection;

namespace tp3_bd.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Data()
        {

            SQLiteConnection con = new SQLiteConnection(@"Data Source =C:\Users\katko\Desktop\2022 GL3 .NET Framework TP3 - SQLite database.db");
            con.Open();
            using (con)
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM personal_info",con);
                SQLiteDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                     while(reader.Read())
                    {
                        int id = (int)reader["id"];
                        string first_name = (string)reader["first_name"];
                        string last_name = (string)reader["last_name"];
                        string email = (string)reader["email"];
                        string image = (string)reader["image"];
                        string country = (string)reader["country"];
                       Debug.WriteLine("id:{0} first name:{1}  last name:{2}  email:{3}   image:{4}  country:{5} ", id, first_name, last_name, email , image, country);
                    }
                }
            }
            return View();
        }
    }
}