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
            var query = "";
            using var cmd = DB.Connection.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DB.Connection.Close();
        }



        public List<PersonCoupleWish> GetAllPersonCoupleWIsh()
        {
            List<PersonCoupleWish> personCoupleWishes = new List<PersonCoupleWish>();
            DB.Connection.Open();
            var query = "";
            using var cmd = DB.Connection.CreateCommand();
            cmd.CommandText= query;
            DbDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {

            }
            DB.Connection.Close(); 
            return personCoupleWishes;
        }
    }
}
