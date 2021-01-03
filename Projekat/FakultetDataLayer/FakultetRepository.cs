using FakultetDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakultetDataLayer
{
    public class FakultetRepository
    {
        public List<Profesor> GetProfesors()
        {
            List<Profesor> profesors = new List<Profesor>();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Profesori";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Profesor p = new Profesor();
                    p.Id = sqlDataReader.GetInt32(0);
                    p.Ime = sqlDataReader.GetString(1);
                    p.Prezime = sqlDataReader.GetString(2);
                    profesors.Add(p);
                }
                return profesors;
            }
        }


        public int InsertProfesor(Profesor p)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format(
                    "INSERT INTO Profesori VALUES('{0}','{1}')",
                     p.Ime, p.Prezime
                    );
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
    }
}
