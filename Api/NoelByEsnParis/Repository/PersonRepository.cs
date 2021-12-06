using NoelByEsnParis.Context;
using NoelByEsnParis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Repository { 
    public class PersonRepository
    {

     public  PersonRepository(MySQLConnector Db)
        {
            DB = DB;
        }
        private MySQLConnector DB { get; set; }
       public void addPerson(Person person)
        {

        }
    public List<Person> getAllPersons()
        {
            DB.Connection.Open();
            List < Person > result= null;
            DB.Connection.Close();
            return result;
        }
    }
}
