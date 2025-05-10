using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class SensorData
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Veri kaydının ait olduğu sensör ID'si (Sensor tablosuna Foreign Key bağlantılı)
        public int SensorId { get; set; }

        // Sensörün kaydettiği değer (örneğin: sıcaklık, nem vb.)
        public float Value { get; set; }

        // Verinin kaydedildiği tarih ve saat
        public DateTime RecordTime { get; set; }
    }
}
