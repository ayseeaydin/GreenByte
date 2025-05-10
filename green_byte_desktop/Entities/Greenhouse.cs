using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class Greenhouse
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Sera sahibinin kullanıcı ID'si (User tablosuna Foreign Key bağlantılı)
        public int UserId { get; set; }

        // Seranın adı
        public string Name { get; set; }

        // Seranın bulunduğu konum
        public string Location { get; set; }

        // Seranın oluşturulma tarihi
        public DateTime CreationDate { get; set; }
    }
}
