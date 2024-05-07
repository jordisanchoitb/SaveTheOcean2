using Microsoft.Extensions.Configuration;
using Npgsql;
using SaveTheOcean2.DTOs;

namespace SaveTheOcean2.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static Animal GetAnimal(NpgsqlDataReader reader)
        {
            Animal a = new Animal
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Specie = reader.GetString(2),
                Superfamily = reader.GetString(3),
                WeightAprox = reader.GetDouble(4)
            };
            return a;
        }

        public static RescuedBBDD GetRescuedBBDD(NpgsqlDataReader reader)
        {
            RescuedBBDD r = new RescuedBBDD
            {
                Id = reader.GetInt32(0),
                IdRescured = reader.GetString(1),
                Rescuedate = reader.GetDateTime(2),
                Superfamily = reader.GetString(3),
                GradeAfectation = reader.GetInt32(4),
                Location = reader.GetString(5),
                NamePlayer = reader.GetString(6),
                IsRescued = reader.GetBoolean(7),
            };
            return r;
        }
    }
}
