using NoelByEsnParis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Repository.Interface
{
 public   interface IPersonRepository
    {
        public void AddPerson(Person person);
        public List<Person> GetAllPeople();
        public void UpdatePerson(Person person);
        public void DeletePerson(Person person);
        public Person GetPersonById(int personId);
        public void PersonIsEngaged(int personId);
    }
}
