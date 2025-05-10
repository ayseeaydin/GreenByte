using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class User
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Kullanıcının benzersiz kullanıcı adı
        public string Username { get; set; }

        // Hashlenmiş kullanıcı şifresi
        public string Password { get; set; }

        // Kullanıcının e-posta adresi (isteğe bağlı)
        public string Email { get; set; }

        // Kullanıcının sisteme kayıt tarihi
        public DateTime RegistrationDate { get; set; }
    }
}
