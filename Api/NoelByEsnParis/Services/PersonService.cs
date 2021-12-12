using NoelByEsnParis.Models;
using NoelByEsnParis.Repository.Interface;
using NoelByEsnParis.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Services
{
    public class PersonService: IPersonService
    {
        private readonly IPersonRepository _personRepository;
       public PersonService(IPersonRepository personRepository)
        {
            _personRepository=personRepository;
        }
        public bool AddPerson(Person person)
        {
        var result =   _personRepository.AddPerson(person);
            return result;
        }
        public List<Person> GetAllPeople()
        {
            var result = _personRepository.GetAllPeople();
            return result;
        }

        public bool UpdatePerson(Person person)
        {
           var result = _personRepository.UpdatePerson(person);
            return result;
        }

        public bool  DeletePerson(int personId)
        {
         var result =   _personRepository.DeletePerson(personId);
            return result;
        }
    }
}