using SaveTheOcean2.DTOs;
using SaveTheOcean2.Persistence.DAO;
using SaveTheOcean2.Persistence.Utils;
using Npgsql;

namespace SaveTheOcean2.Persistence.Mapping
{
    public class RescuedBBDDDAO : IRescuedBBDDDAO
    {
        private readonly string connectionString;

        public RescuedBBDDDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Afaegix un nou rescat a la base de dades
        /// </summary>
        /// <param name="rescued">Objecte RescuedBBDD</param>
        public void AddRescuedBBDD(RescuedBBDD rescued)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO \"rescuedanimal\" (\"idrescured\", \"rescuedate\", \"superfamily\", \"gradeafectation\", \"location\", \"nameplayer\", \"isrescued\") VALUES (@RescuedId, @RescuedDate, @Superfamily, @GradeAfectation, @Location, @NamePlayer, @IsRescued)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@RescuedId", rescued.IdRescured);
                command.Parameters.AddWithValue("@RescuedDate", rescued.Rescuedate);
                command.Parameters.AddWithValue("@Superfamily", rescued.Superfamily);
                command.Parameters.AddWithValue("@GradeAfectation", rescued.GradeAfectation);
                command.Parameters.AddWithValue("@Location", rescued.Location);
                command.Parameters.AddWithValue("@NamePlayer", rescued.NamePlayer);
                command.Parameters.AddWithValue("@IsRescued", rescued.IsRescued);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retorna tots els rescats de la base de dades
        /// </summary>
        /// <returns>IEnumerable</returns>
        public IEnumerable<RescuedBBDD> GetAllRescuedsBBDD()
        {
            List<RescuedBBDD> rescueds = new List<RescuedBBDD>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"id\", \"idrescured\", \"rescuedate\", \"superfamily\", \"gradeafectation\", \"location\", \"nameplayer\", \"isrescued\" FROM \"rescuedanimal\"";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    RescuedBBDD rescued = NpgsqlUtils.GetRescuedBBDD(reader);
                    rescueds.Add(rescued);
                }
            }
            return rescueds;
        }
        public void DeleteRescuedBBDD(int id)
        {
            throw new NotImplementedException();
        }

        public RescuedBBDD GetRescuedBBDDById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRescuedBBDD(RescuedBBDD animal)
        {
            throw new NotImplementedException();
        }
    }
}