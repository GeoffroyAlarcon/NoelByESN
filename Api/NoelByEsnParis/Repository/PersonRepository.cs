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
        public bool AddPerson(Person person)
        {
            DB.Connection.Open();
            string query = "insert into personne (nom, prenom) VALUES(@nom, @prenom)";
            MySqlCommand cmd = DB.Connection.CreateCommand();
            cmd.Parameters.AddWithValue("@nom", person.LastName);
            cmd.Parameters.AddWithValue("@prenom", person.FirstName);
            cmd.CommandText = query;
            int rowAffected = cmd.ExecuteNonQuery();
            DB.Connection.Close();
            if (rowAffected > 0) return true;
            return false;
        }

        public bool DeletePerson(int personId)
        {
            DB.Connection.Open();
            string query = "delete from personne where id = @id && estEnCouple != 1";
            MySqlCommand cmd = DB.Connection.CreateCommand();
            cmd.Parameters.AddWithValue("@nom", personId);
            cmd.CommandText = query;
            int rowAffected = cmd.ExecuteNonQuery();
            DB.Connection.Close();
            if (rowAffected > 0) return true;
            return false;
        }

        public List<Person> GetAllPeople()
        {
            DB.Connection.Open();
            string query = "select nom,id, prenom, estEnCouple from personne";
            List<Person> result = new List<Person>();

            using var cmd = DB.Connection.CreateCommand();
            cmd.CommandText= query;
            DbDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                Person person = new Person();
                person.Id=  (int)myReader["id"];
                person.FirstName = myReader["prenom"].ToString();
                person.LastName= myReader["nom"].ToString();
                person.IsEngaged = Convert.ToBoolean((sbyte)myReader["estEnCouple"]);
                result.Add(person);
            }
            DB.Connection.Close();

            return result.OrderBy(elt => elt.LastName).ToList(); ;
        }

        public Person GetPersonById(int personId)
        {
            DB.Connection.Open();
            string query = "select nom,id, prenom, estEnCouple from personne where id = @id";
            using var cmd = DB.Connection.CreateCommand();
            cmd.CommandText= query;
            cmd.Parameters.AddWithValue("@id", personId);
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

        public bool PersonIsEngaged(int personId)
        {
            DB.Connection.Open();
            string query = "update personne set estEnCouple = 1 where id = @id ";
            MySqlCommand cmd = DB.Connection.CreateCommand();
            cmd.Parameters.AddWithValue("@id", personId);

            cmd.CommandText = query;
            int rowAffected = cmd.ExecuteNonQuery();
            DB.Connection.Close();
            if (rowAffected > 0) return true;
            return false;
        }

        public bool UpdatePerson(Person person)
        {
            DB.Connection.Open();
            string query = "update personne set nom = @nom, prenom= @prenom where id = @id";
            MySqlCommand cmd = DB.Connection.CreateCommand();
            cmd.Parameters.AddWithValue("@nom", person.LastName);
            cmd.Parameters.AddWithValue("@prenom", person.FirstName);
            cmd.Parameters.AddWithValue("@id", person.FirstName);

            cmd.CommandText = query;
            int rowAffected = cmd.ExecuteNonQuery();
            DB.Connection.Close();
            if (rowAffected > 0) return true;
            return false;
        }
    }
}
