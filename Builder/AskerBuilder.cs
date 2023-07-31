using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    // Somut İnşaatçı sınıfı - AskerBuilder
    public class AskerBuilder : KarakterBuilder
    {
        public override void AdBelirle()
        {
            karakter.Ad = "Asker";
        }

        public override void SaldiriGucuBelirle()
        {
            karakter.SaldiriGucu = 100;
        }

        public override void SavunmaBelirle()
        {
            karakter.Savunma = 75;
        }

        public override void SilahBelirle()
        {
            karakter.Silah = "Kılıç";
        }

        public override void ZirhBelirle()
        {
            karakter.Zirh = "Zırh";
        }
    }
}
