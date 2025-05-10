using System;
using MySql.Data.MySqlClient;
using greenByte.Entities;

namespace greenByte.DataAccess
{
    public class AuthRepository
    {
        // Veritabanı bağlantısı için kullanılan DatabaseContext nesnesi
        private readonly DatabaseContext _dbContext;

        // Yapıcı metot: Veritabanı bağlantı nesnesini başlatır
        public AuthRepository()
        {
            _dbContext = new DatabaseContext();
        }

        /// <summary>
        /// Veritabanında kullanıcı adı ve şifreye göre kimlik doğrulama yapar.
        /// </summary>
        /// <param name="username">Kullanıcı adı</param>
        /// <param name="password">Kullanıcı şifresi</param>
        /// <returns>Doğrulama başarılı ise true, değilse false döner</returns>
        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                // Veritabanı bağlantısını oluştur
                using (var connection = _dbContext.CreateConnection())
                {
                    // Kullanıcı adı ve şifreye göre kullanıcıyı arayan SQL sorgusu
                    string query = "SELECT COUNT(*) FROM kullanicilar WHERE kullanici_adi = @Username AND sifre = @Password";

                    // SQL komutunu oluştur
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);  // Şifrelenmiş olacak

                        // Sorguyu çalıştır ve sonuç döndür
                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda konsola mesaj yazdır ve false döndür
                Console.WriteLine($"Giriş hatası: {ex.Message}");
                return false;
            }
        }
    }
}
