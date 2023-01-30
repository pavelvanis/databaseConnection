using System.Data.SqlClient;

namespace databaseConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
            consStringBuilder.UserID = "sa";
            consStringBuilder.Password = "student";
            consStringBuilder.InitialCatalog = "firstConnect";
            consStringBuilder.DataSource = "PC963";
            consStringBuilder.ConnectTimeout = 3;
            try
            {
                using (SqlConnection connection = new SqlConnection(consStringBuilder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Pripojeno");



                    client client = new client("Novak", "Dw41vr2x") ;
                    //client.insert(connection);

                    //client.select(connection, 2);

                    client.selectAll(connection);

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}