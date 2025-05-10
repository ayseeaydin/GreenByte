using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class Sensor
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Sensörün bağlı olduğu seranın ID'si (Greenhouse tablosuna Foreign Key bağlantılı)
        public int GreenhouseId { get; set; }

        // Sensörün adı (örneğin: Sıcaklık Sensörü, Nem Sensörü)
        public string Name { get; set; }

        // Sensörün aktiflik durumu (Çalışıyor/Kapalı)
        public bool Status { get; set; }

        // Sensörün sisteme eklenme tarihi
        public DateTime AddedDate { get; set; }
    }
}
