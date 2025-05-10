using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.DataAccess
{
    public class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext()
        {
            // Uzak veritabanı bağlantı bilgileri
            _connectionString = "Server=92.205.171.9;Database=greenbyte;Uid=admin;Pwd=Ke3@1.3ySq1;" +
                                "Port=3306;SslMode=None;CharSet=utf8mb4;" +
                                "AllowPublicKeyRetrieval=true;ConnectionTimeout=60;" +
                                "DefaultCommandTimeout=60;Pooling=true;";
        }

        // Veritabanı bağlantısını oluşturan metot
        public MySqlConnection CreateConnection()
        {
            try
            {
                var connection = new MySqlConnection(_connectionString);
                connection.Open();
                Console.WriteLine("Veritabanı bağlantısı başarılı.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Veritabanı bağlantı hatası: {ex.Message}");
                throw;
            }
        }

        // Veritabanı bağlantısını kapatan metot
        public void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Veritabanı bağlantısı kapatıldı.");
            }
        }
    }
}
