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
        public void AddPerson(Person person)
        {
            _personRepository.AddPerson(person);
          
        }
        public List<Person> GetAllPeople()
        {
            return _personRepository.GetAllPeople();
        }

        public void UpdatePerson(Person person)
        {
            _personRepository.UpdatePerson(person);
        }

        public void DeletePerson(Person person)
        {
            _personRepository.DeletePerson(person);
        }
    }
}