using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MostriVSEroi.DBRepository
{
   
        public  class  UtenteDBRepository : IUtenteRepository
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

      
        public  List<Utente> FetchUtenti()
            {
                List<Utente> utenti = new List<Utente>();

                using (SqlConnection connection = GetConnection())
                {
                    string sqlString = "SELECT * FROM Utenti";

                    SqlCommand command = new SqlCommand(sqlString, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        string username = (string)reader[1];
                        int password = (int)reader[2];

                        Utente utente = new Utente(username, password);
                        Console.WriteLine(utente);

                    }
                    connection.Close();
                }

                return utenti;
            }

        public Utente GetUser(Utente utente)
        {
            throw new NotImplementedException();
        }

      
        public bool CheckUsername(Utente utente)
        {
            throw new NotImplementedException();
        }

        public Utente UpdateUtenti(Utente utente)
        {
            throw new NotImplementedException();
        }
    }
    }



