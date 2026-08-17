using System;
using System.Collections.Generic;

namespace ASP_NET_Core_WebAPI.Models
{
    public class Department { public int Id { get; set; } public string Name { get; set; } }
    public class Skill { public int Id { get; set; } public string Name { get; set; } }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}