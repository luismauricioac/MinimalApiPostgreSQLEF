using System;
namespace MinimalApiPostgreSQLEF.Models
{
    public class Employee
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Branch { set; get; }
        public int Age { set; get; }
    }
}

