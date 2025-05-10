using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class Plant
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Bitkinin bağlı olduğu seranın ID'si (Greenhouse tablosuna Foreign Key bağlantılı)
        public int GreenhouseId { get; set; }

        // Bitkinin tür ID'si (PlantType tablosuna Foreign Key bağlantılı)
        public int PlantTypeId { get; set; }

        // Bitkinin yetiştiği bölge kodu
        public string AreaCode { get; set; }

        // Bitkinin ekim tarihi
        public DateTime SowingDate { get; set; }

        // Bitkinin gelişim yüzdesi (0-100 arası)
        public float GrowthPercentage { get; set; }

        // Tahmini hasat tarihi (boş olabilir)
        public DateTime? EstimatedHarvestDate { get; set; }

        // Bitki ile ilgili notlar
        public string Note { get; set; }

        // Bitkinin durumu (aktif, hasat edildi, iptal)
        public string Status { get; set; }

        // Bitki kaydının en son güncellendiği tarih
        public DateTime LastUpdate { get; set; }
    }
}
