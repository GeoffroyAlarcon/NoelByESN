using NoelByEsnParis.Models;
using System.Collections.Generic;

namespace NoelByEsnParis.Services.Interfaces
{
    public interface IPersonCoupleWishService
    {
        public List<PersonCoupleWish> CadeauNoel(List<Person> listPeople);
        public List<PersonCoupleWish> FindAllPairPeopleWish();

    }
}
