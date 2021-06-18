using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MostriVSEroi.DBRepository
{
   
        public  class  UtenteDBRepository : IUtenteRepository
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

       

        public  List<Utente> FetchUtenti()
            {
                List<Utente> utenti = new List<Utente>();

                using (SqlConnection connection = GetConnection())
                {
                    string sqlString = "SELECT * FROM Utente";

                    SqlCommand command = new SqlCommand(sqlString, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        string username = (string)reader[0];
                        int password = (int)reader[1];

                        Utente utente = new Utente(username, password);
                        Console.WriteLine(utente);

                    }
                    connection.Close();
                }

                return utenti;
            }

        public Utente GetUser(Utente utente)
        {
            using (SqlConnection connection = GetConnection())
            {
              
                string sqlString = "SELECT * FROM Utente where @Password = @Password"+ 
                    "and @UserName = @UserName";

                SqlCommand command = new SqlCommand(sqlString, connection);
                command.Parameters.AddWithValue("@Password", utente.Password);
                command.Parameters.AddWithValue("@UserName", utente.Username);
                command.ExecuteScalar();
                try
                {
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.Read())
                    {
                        utente.IsAuthenticated = true;
                        Console.WriteLine("Hai effetuato l accesso");
                    }
                    else utente.IsAuthenticated = false;
                    Console.WriteLine("L utente non e registarto");
                }
                finally
                {
                   connection.Close();
                }
               
            }
                return utente;
            }
        public static void RegistraUtente(string username, int password)
        {
            using (SqlConnection connection = GetConnection())
            {
                string sqlString = "Insert into dbo.Utente where @UserName = @UserName";

                SqlCommand command = new SqlCommand(sqlString, connection);
                try
                {
                    if (CheckDoubleRegistrations(username))
                    {
                        command.CommandText = "insert into dbo.utente values(@UserName, @Password)";
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteScalar();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }            

               }

            }

        private static bool CheckDoubleRegistrations(string username)
        {
            using (SqlConnection connection = GetConnection())
            {
                string sqlString = "SELECT * FROM Utente";
                SqlCommand command = new SqlCommand(sqlString, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string username2 = (string)reader[0];
                    if (username2 == username)
                        return true;
                }
                connection.Close();
            }
            return false;
        }
    }


       
    }
    



