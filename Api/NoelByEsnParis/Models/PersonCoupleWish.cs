using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Models
{
  public  class PersonCoupleWish
    {
        public PersonCoupleWish() { }
      public  int Id { get; set; }
        public Person firstPerson { get; set; }
       public Person SecondPerson { get; set; }
    }
}
