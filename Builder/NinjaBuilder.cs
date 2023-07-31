using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Somut İnşaatçı sınıfı - NinjaBuilder
    public class NinjaBuilder : CharacterBuilder
    {
        public override void AdBelirle()
        {
            karakter.Ad = "Ninja";
        }

        public override void SaldiriGucuBelirle()
        {
            karakter.SaldiriGucu = 90;
        }

        public override void SavunmaBelirle()
        {
            karakter.Savunma = 60;
        }

        public override void SilahBelirle()
        {
            karakter.Silah = "Kunai";
        }

        public override void ZirhBelirle()
        {
            karakter.Zirh = "Hafif Zırh";
        }
    }
}
