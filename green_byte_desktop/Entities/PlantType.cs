using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class PlantType
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Bitki türünün adı (örneğin: Domates, Biber)
        public string Name { get; set; }

        // Minimum ve maksimum sıcaklık değerleri (°C)
        public float MinTemperature { get; set; }
        public float MaxTemperature { get; set; }

        // Minimum ve maksimum nem değerleri (%)
        public float MinHumidity { get; set; }
        public float MaxHumidity { get; set; }

        // Günlük minimum ve maksimum ışık saati (saat)
        public float MinDailyLightHours { get; set; }
        public float MaxDailyLightHours { get; set; }

        // Işık yoğunluğu (lüks)
        public int MinLightIntensity { get; set; }
        public int MaxLightIntensity { get; set; }

        // Toprak nemi (yüzde)
        public float MinSoilMoisture { get; set; }
        public float MaxSoilMoisture { get; set; }

        // Sulama sıklığı (gün)
        public int IrrigationFrequency { get; set; }

        // Yetiştirme süresi (gün)
        public int GrowingTime { get; set; }

        // Bitki hakkında notlar
        public string Notes { get; set; }

        // Bitki türünün sisteme eklenme tarihi
        public DateTime AddedDate { get; set; }
    }
}
