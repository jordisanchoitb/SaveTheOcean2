﻿using SaveTheOcean2.DTOs;
using SaveTheOcean2.Persistence.DAO;
using SaveTheOcean2.Persistence.Utils;
using Npgsql;

namespace SaveTheOcean2.Persistence.Mapping
{
    public class AnimalDAO : IAnimalDAO
    {
        private readonly string connectionString;

        public AnimalDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddAnimal(Animal animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO \"animal\" (\"name\", \"specie\", \"superfamily\", \"weightaprox\") VALUES (@Name, @Specie, @Superfamily, @Weightaprox)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Specie", animal.Specie);
                command.Parameters.AddWithValue("@Superfamily", animal.Superfamily);
                command.Parameters.AddWithValue("@WeightAprox", animal.WeightAprox);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAnimal(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "DELETE FROM \"animal\" WHERE \"ID\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"id\", \"name\", \"specie\", \"superfamily\", \"weightaprox\" FROM \"animal\"";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Animal contact = NpgsqlUtils.GetAnimal(reader);
                    animals.Add(contact);
                }
            }
            return animals;
        }

        public Animal GetAnimalById(int id)
        {
            Animal animal = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"id\", \"name\", \"specie\", \"superfamily\", \"weightaprox\" FROM \"animal\" WHERE \"id\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    animal = NpgsqlUtils.GetAnimal(reader);
                }
            }
            return animal;
        }

        public void UpdateAnimal(Animal animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "UPDATE \"animal\" SET \"name\" = @Name, \"specie\" = @Specie, \"superfamily\" = @Superfamily, \"weightaprox\" = @WeightAprox WHERE \"id\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", animal.Id);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Specie", animal.Specie);
                command.Parameters.AddWithValue("@Superfamily", animal.Superfamily);
                command.Parameters.AddWithValue("@WeightAprox", animal.WeightAprox);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}