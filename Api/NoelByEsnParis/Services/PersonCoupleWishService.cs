using NoelByEsnParis.Models;
using NoelByEsnParis.Repository.Interface;
using NoelByEsnParis.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace NoelByEsnParis.Services
{
    public class PersonCoupleWishService : IPersonCoupleWishService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonCoupleWishRepository _personCoupleWishRepository;
        public PersonCoupleWishService(IPersonRepository personRepository, IPersonCoupleWishRepository personCoupleWishRepository)
        {
            _personRepository = personRepository;
            _personCoupleWishRepository=personCoupleWishRepository;
        }

        public List<PersonCoupleWish> CadeauNoel(List<Person> listPeople)
        {
            listPeople =  listPeople.FindAll(elt => elt.IsEngaged != true);
            int nombreDePersone = listPeople.Count;
            List<PersonCoupleWish> result = new List<PersonCoupleWish>();
            List<Person> listPourCouplePrenom = listPeople;
            for (int x = 0; x < nombreDePersone / 2; x++)
            {
                Random randomNumber = new Random();
                int tirageAuSort = randomNumber.Next(1, listPourCouplePrenom.Count);
                PersonCoupleWish personCoupleWish = new PersonCoupleWish();
                personCoupleWish.FirstPerson = new Person();
                personCoupleWish.SecondPerson = new Person();
                personCoupleWish.FirstPerson = listPourCouplePrenom[0];
                personCoupleWish.SecondPerson = listPourCouplePrenom[tirageAuSort];
                listPourCouplePrenom.RemoveAt(tirageAuSort);
                listPourCouplePrenom.RemoveAt(0);
                result.Add(personCoupleWish);
                _personCoupleWishRepository.AddPersonCoupleWish(personCoupleWish);
                _personRepository.PersonIsEngaged(personCoupleWish.FirstPerson.Id);
                _personRepository.PersonIsEngaged(personCoupleWish.SecondPerson.Id);

            }
            return result;
        }

        public List<PersonCoupleWish> FindAllPairPeopleWish()
        {
        return    _personCoupleWishRepository.GetAllPersonCoupleWIsh();
        }
    }
}
