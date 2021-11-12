using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class HomeModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public HomeModel(string name, string email, string phone, int age)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Age = age;
        }
    }
}
