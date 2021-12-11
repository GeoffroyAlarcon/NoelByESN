using NoelByEsnParis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Services.Interfaces
{
   public interface IPersonService
    {
        public void AddPerson(Person person);
        public List<Person> GetAllPeople();
        public void UpdatePerson(Person person);
        public void DeletePerson(Person person);
    }
}
