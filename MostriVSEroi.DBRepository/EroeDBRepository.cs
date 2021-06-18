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
                                                 "Initial Catalog = MostriVEroi;" +
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
                string sqlString = "delate dbo.Eroi";

                SqlCommand command = new SqlCommand(sqlString, connection);

                //da testare non sono sicura che funzioni
                command.CommandText = "delate from dbo.Eroi where @Nome = @Nome";
                command.Parameters.AddWithValue("@Nome", nome);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

       


        public static void AddEroe(string categoria, string nome, string nomearma, int puntidanno, string username)
        {
            using (SqlConnection connection = GetConnection())
            {
                string sqlString = "Insert into dbo.Eroi";

                SqlCommand command = new SqlCommand(sqlString, connection);


                command.CommandText = "insert into dbo.Eroi values(@Categoria, @Nome, @Arma, @ArmaPuntiDanno)";
                command.Parameters.AddWithValue("@Categoria", categoria);
                command.Parameters.AddWithValue("@Nome", nomearma);
                command.Parameters.AddWithValue("@Arma", puntidanno);
                command.Parameters.AddWithValue("@ArmaPuntiDanno", nome);
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
