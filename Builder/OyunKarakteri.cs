using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OyunKarakteri
    {
        public string Ad { get; set; }
        public int SaldiriGucu { get; set; }
        public int Savunma { get; set; }
        public string Silah { get; set; }
        public string Zirh { get; set; }

        public void Goster()
        {
            Console.WriteLine($"Karakter Adı: {Ad}");
            Console.WriteLine($"Saldırı Gücü: {SaldiriGucu}");
            Console.WriteLine($"Savunma: {Savunma}");
            Console.WriteLine($"Silah: {Silah}");
            Console.WriteLine($"Zırh: {Zirh}");
            Console.WriteLine();
        }
    }
}
