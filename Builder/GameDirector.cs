using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Yönetmen sınıf - OyunYonetmeni
    public class GameDirector
    {
        private CharacterBuilder karakterBuilder;

        public void SetKarakterBuilder(CharacterBuilder builder)
        {
            karakterBuilder = builder;
        }

        public GameCharacter KarakterOlustur() //karakter olustur metodu içerisinde diğer tüm o alt metotları barındırıyor.
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
