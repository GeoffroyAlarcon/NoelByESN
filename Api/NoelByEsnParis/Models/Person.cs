using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Models
{
    public class Person
    {
        public Person()
        {

        }
       public Person(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEngaged { get; set; }
    }
}
