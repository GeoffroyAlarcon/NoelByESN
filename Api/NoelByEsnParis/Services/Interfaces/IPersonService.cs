using NoelByEsnParis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Services.Interfaces
{
   public interface IPersonService
    {
        public bool AddPerson(Person person);
        public List<Person> GetAllPeople();
        public bool UpdatePerson(Person person);
        public bool DeletePerson(int personId);
    }
}
