using NoelByEsnParis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Repository.Interface
{
 public   interface IPersonRepository
    {
        public bool AddPerson(Person person);
        public List<Person> GetAllPeople();
        public  bool UpdatePerson(Person person);
        public bool DeletePerson(int personID);
        public Person GetPersonById(int personId);
        public bool PersonIsEngaged(int personId);
    }
}
