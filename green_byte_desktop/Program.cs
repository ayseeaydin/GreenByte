using greenByte;
using greenByte.DataAccess;
using greenByte.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greenByte
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Veritabanı bağlantısını test etme
                DatabaseContext dbContext = new DatabaseContext();
                using (var connection = dbContext.CreateConnection())
                {
                    MessageBox.Show("Veritabanı bağlantısı başarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantı hatası: {ex.Message}");
            }

            Application.Run(new Form());  // Geçici olarak boş bir form açıyoruz
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            */
        }
    }
}
