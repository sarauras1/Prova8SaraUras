using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVSEroi.DBRepository
{
    public static class EroeDBRepository
    {
        private const string connectionString = @"Data source = (localdb)\mssqllocaldb;" +
                                                 "Initial Catalog = MostriVEroiGioco;" +
                                                 "Integrated Security = true;";
        public static SqlConnection GetConnection()
        {
            Console.WriteLine();

            SqlConnection connection;

            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static void EliminaEroe(string nome)
        {
            using (SqlConnection connection = GetConnection())
            {
                string sqlString = "delate dbo.Eroe";

                SqlCommand command = new SqlCommand(sqlString, connection);


                command.CommandText = "delate dbo.Eroe values(@Nome)";
                command.Parameters.AddWithValue("@Nome", nome);




                command.ExecuteNonQuery();

                connection.Close();
            }
        }

       


        public static void AddEroe(string categoria, string nome, string nomearma, int puntidanno)
        {
            using (SqlConnection connection = GetConnection())
            {
                string sqlString = "Insert into dbo.Eroe";

                SqlCommand command = new SqlCommand(sqlString, connection);


                command.CommandText = "insert into dbo.Utente values(@Categoria, @Arma, @PuntiDanno, @Nome)";
                command.Parameters.AddWithValue("@Categoria", categoria);
                command.Parameters.AddWithValue("@Arma", nomearma);
                command.Parameters.AddWithValue("@PuntiDanno", puntidanno);
                command.Parameters.AddWithValue("@Nome", nome);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
