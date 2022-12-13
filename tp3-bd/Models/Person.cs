using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp3_bd.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Country { get; set; }

        public Person(int id, string firstName, string lastName, string email, string image, string country)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Image = image;
            Country = country;
        }
        public Person(string firstName, string country)
        {
            
            FirstName = firstName;
           
            Country = country;
        }
        public Person()
        {
        }
    }
}