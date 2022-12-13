using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace tp3_bd.Models
{
    public class Personal_info
    {
        public List<Person> GetAllPerson()
        {
            List<Person> listePersonnes = new List<Person>();
            SQLiteConnection dbCon = new SQLiteConnection(@"Data Source =C:\Users\katko\Desktop\2022 GL3 .NET Framework TP3 - SQLite database.db");
            dbCon.Open();

            using (dbCon)
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM personal_info", dbCon);
                SQLiteDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string first_name = (string)reader["first_name"];
                        string last_name = (string)reader["last_name"];
                        string email = (string)reader["email"];
                        string image = (string)reader["image"];
                        string country = (string)reader["country"];
                        listePersonnes.Add(new Person(id, first_name, last_name, email, image, country));
                    }
                }
            }

            return listePersonnes;
        }
        public Person GetPerson(int id)
        {
            List<Person> listePersonnes = GetAllPerson();
            for (int i = 0; i < listePersonnes.Count; i++)
            {
                if (listePersonnes[i].Id == id)
                {
                    return listePersonnes[i];
                }
            }
            return null;

        }
    }
}