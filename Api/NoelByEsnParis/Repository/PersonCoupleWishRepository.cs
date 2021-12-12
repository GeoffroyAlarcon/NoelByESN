using MySql.Data.MySqlClient;
using NoelByEsnParis.Context;
using NoelByEsnParis.Models;
using NoelByEsnParis.Repository.Interface;
using System.Collections.Generic;
using System.Data.Common;

namespace NoelByEsnParis.Repository
{
    public class PersonCoupleWishRepository : IPersonCoupleWishRepository
    {
        public PersonCoupleWishRepository(MySQLConnector db)
        {
            DB= db;
        }
        public MySQLConnector DB { get; set; }

        public void AddPersonCoupleWish(PersonCoupleWish peoplePairWish)
        {
            DB.Connection.Open();
            string query = "insert into pair_people (firstPersonId,secondPersonId ) VALUES(@firstPersonId,@SeconPersonId)";
            MySqlCommand cmd = DB.Connection.CreateCommand();
            cmd.Parameters.AddWithValue("@firstPersonId", peoplePairWish.FirstPerson.Id);
            cmd.Parameters.AddWithValue("@SeconPersonId", peoplePairWish.SecondPerson.Id);
            cmd.CommandText = query;
            int rowAffected = cmd.ExecuteNonQuery();
            DB.Connection.Close();

        }



        public List<PersonCoupleWish> GetAllPersonCoupleWIsh()
        {
            PersonRepository personRepository = new PersonRepository(DB);
            List<PersonCoupleWish> personCoupleWishes = new List<PersonCoupleWish>();
            DB.Connection.Open();
            var query = "select firstPersonId, secondPersonId from pair_people ";
            using var cmd = DB.Connection.CreateCommand();
            cmd.CommandText= query;
            DbDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                PersonCoupleWish personCoupleWish = new PersonCoupleWish();
                personCoupleWish.FirstPerson = new Person((int)myReader["firstPersonId"]);
                personCoupleWish.SecondPerson = new Person((int)myReader["secondPersonId"]);
                personCoupleWishes.Add(personCoupleWish);
            }
            DB.Connection.Close();
            personCoupleWishes.ForEach(elt =>
            {
                elt.FirstPerson= personRepository.GetPersonById(elt.FirstPerson.Id);
                elt.SecondPerson= personRepository.GetPersonById(elt.SecondPerson.Id);
            });
            return personCoupleWishes;
        }
    }
}
