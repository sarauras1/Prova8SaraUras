using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVSEroi.DBRepository
{
  public static  class PartitaRepository
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

      
        public static void ClassificaGlobale()//mostra classifica globale
        { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                //associo connessione
                command.Connection = connection;
                //definisco il tipo input
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from dbo.ClassificaGlobale";
                 SqlDataReader reader = command.ExecuteReader();
                
                    while(reader.Read())
                    {            
                        int livello = (int)reader[0];
                        int puntivita = (int)reader[1];
                        int puntiaccumulati = (int)reader[2];
                        int user = (int)reader[3];
                    Console.WriteLine($"Il Giocatore -> {user}");
                    Console.WriteLine($"Livelli giocati -> {livello}");
                    Console.WriteLine($"Punteggi -> {puntiaccumulati}");
                    Console.WriteLine($"Punti vita -> {puntivita}");
                }

                connection.Close(); 
            }
        }

        public static void InserisciRisultatiPartita(int livello, int puntivita, int puntiaccumulati, string user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "insert into dbo.Partita values (@Livello, @PuntiVita, @PuntiAccumulati, @UserName)";
                command.Parameters.AddWithValue("@Livello", livello);
                command.Parameters.AddWithValue("@PuntiVita", puntivita);
                command.Parameters.AddWithValue("@PuntiAccumulati", puntiaccumulati);
                command.Parameters.AddWithValue("@userName", user);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
