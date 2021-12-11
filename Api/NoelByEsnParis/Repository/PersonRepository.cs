using MySql.Data.MySqlClient;
using NoelByEsnParis.Context;
using NoelByEsnParis.Models;
using NoelByEsnParis.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Repository
{
    public class PersonRepository : IPersonRepository
    {

        public PersonRepository(MySQLConnector Db)
        {
            DB= Db;
        }
        private MySQLConnector DB { get; set; }
        public void AddPerson(Person person)
        {
            DB.Connection.Open();
            string query = "insert into user(nom, prenom) VALUES(@nom, @prenom)";
            MySqlCommand cmd = DB.Connection.CreateCommand();
            cmd.Parameters.AddWithValue("@nom", person.LastName);
            cmd.Parameters.AddWithValue("@prenom", person.FirstName);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DB.Connection.Close();
        }

        public void DeletePerson(Person person)
        {
            DB.Connection.Open();
            string query = "insert into user(nom, prenom) VALUES(@nom, @prenom)";
            MySqlCommand cmd = DB.Connection.CreateCommand();
            cmd.Parameters.AddWithValue("@nom", person.LastName);
            cmd.Parameters.AddWithValue("@prenom", person.FirstName);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DB.Connection.Close();
        }

        public List<Person> GetAllPeople()
        {
            DB.Connection.Open();
            string query = "select nom,id, prenom, estEnCouple from user";
            List<Person> result = new List<Person>();

            using var cmd = DB.Connection.CreateCommand();
            cmd.CommandText= query;
            DbDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                Person person = new Person();
                person.Id=  (int) myReader["id"];
                person.FirstName = myReader["prenom"].ToString();
                person.LastName= myReader["nom"].ToString();
                person.IsEngaged = Convert.ToBoolean((sbyte)myReader["estEnCouple"]);
                result.Add(person); 
            }
            DB.Connection.Close();

            return result;
        }

        public Person GetPersonById(int personId)
        {
            DB.Connection.Open();
            string query = "select nom,id, prenom, estEnCouple from user where id ="+personId;
            using var cmd = DB.Connection.CreateCommand();
            cmd.CommandText= query;
            DbDataReader myReader = cmd.ExecuteReader();
            Person person = new Person();
            while (myReader.Read())
            {
                person.Id=  (int)myReader["id"];
                person.FirstName = myReader["prenom"].ToString();
                person.LastName= myReader["nom"].ToString();
                person.IsEngaged =(bool)myReader["estEnCouple"];
          
            }
            DB.Connection.Close();
            return person;
        }

        public void PersonIsEngaged(int personId)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
