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
        public List<string> CadeauNoel(List<string> listPrenom)
        {
            int nombreDePersone = listPrenom.Count;
            List<string> result = new List<string>();
            List<string> listPourCouplePrenom = listPrenom;
            for (int x = 0; x < nombreDePersone / 2; x++)
            {
                Random randomNumber = new Random();
                int tirageAuSort = randomNumber.Next(1, listPourCouplePrenom.Count);
                string couplePourCadeau = listPourCouplePrenom[0] + " / " + listPourCouplePrenom[tirageAuSort];
                listPourCouplePrenom.RemoveAt(tirageAuSort);
                listPourCouplePrenom.RemoveAt(0);
                result.Add(couplePourCadeau);
            }
            return result;
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