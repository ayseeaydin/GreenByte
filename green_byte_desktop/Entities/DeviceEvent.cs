using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenByte.Entities
{
    public class DeviceEvent
    {
        // Birincil anahtar, otomatik artan
        public int Id { get; set; }

        // Olayın ait olduğu cihazın ID'si (Device tablosuna Foreign Key bağlantılı)
        public int DeviceId { get; set; }

        // Cihazın gerçekleştirdiği işlem (Aç/Kapat)
        public DeviceAction Action { get; set; }

        // Olayın tetiklenme şekli (Manuel/Otomatik)
        public TriggerType Trigger { get; set; }

        // Olayın gerçekleştiği zaman
        public DateTime Time { get; set; }
    }

    // Cihazın gerçekleştirdiği işlem türü (Veritabanında 'ac' ve 'kapat' olarak tutuluyor)
    public enum DeviceAction
    {
        On,    // Aç
        Off  // Kapat
    }

    // Tetikleyici türü (Veritabanında 'manuel' ve 'otomatik' olarak tutuluyor)
    public enum TriggerType
    {
        Manual,   // Manuel işlem
        Automatic  // Otomatik işlem
    }
}
