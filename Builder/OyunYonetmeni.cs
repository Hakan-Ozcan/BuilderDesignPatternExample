using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Yönetmen sınıf - OyunYonetmeni
    public class OyunYonetmeni
    {
        private KarakterBuilder karakterBuilder;

        public void SetKarakterBuilder(KarakterBuilder builder)
        {
            karakterBuilder = builder;
        }

        public OyunKarakteri KarakterOlustur()
        {
            karakterBuilder.YeniKarakterOlustur();
            karakterBuilder.AdBelirle();
            karakterBuilder.SaldiriGucuBelirle();
            karakterBuilder.SavunmaBelirle();
            karakterBuilder.SilahBelirle();
            karakterBuilder.ZirhBelirle();
            return karakterBuilder.KarakteriAl();
        }
    }
}
