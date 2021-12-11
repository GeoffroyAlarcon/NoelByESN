using NoelByEsnParis.Models;
using System.Collections.Generic;

namespace NoelByEsnParis.Repository.Interface
{
    public interface IPersonCoupleWishRepository
    {
        public void AddPersonCoupleWish(PersonCoupleWish personCoupleWish);
        public List<PersonCoupleWish> GetAllPersonCoupleWIsh();
    }
}
