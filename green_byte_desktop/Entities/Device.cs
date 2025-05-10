using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class Device
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Cihazın bağlı olduğu seranın ID'si (Greenhouse tablosuna Foreign Key bağlantılı)
        public int GreenhouseId { get; set; }

        // Cihazın adı
        public string Name { get; set; }

        // Cihazın mevcut durumu (Açık/Kapalı)
        public bool Status { get; set; }

        // Cihazın sisteme eklenme tarihi
        public DateTime AddedDate { get; set; }
    }
}
