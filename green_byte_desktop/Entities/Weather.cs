using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class Weather
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Hava durumunun ait olduğu seranın ID'si (Greenhouse tablosuna Foreign Key bağlantılı)
        public int GreenhouseId { get; set; }

        // Hava sıcaklığı (°C)
        public float Temperature { get; set; }

        // Hava nem oranı (%)
        public float Humidity { get; set; }

        // Rüzgar hızı (km/saat)
        public float WindSpeed { get; set; }

        // Yağış durumu (true = yağmurlu, false = yağmursuz)
        public bool IsRaining { get; set; }

        // Hava durumu açıklaması (örneğin: Güneşli, Bulutlu)
        public string WeatherDescription { get; set; }

        // Hava durumu kaydının alındığı tarih ve saat
        public DateTime RecordTime { get; set; }
    }
}
