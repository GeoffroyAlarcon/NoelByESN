using NoelByEsnParis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Repository.Interface
{
    interface IPersonRepository
    {
        public Person AddPerson(Person person);
        public List<Person> GetAllParticipants();
    }
}
