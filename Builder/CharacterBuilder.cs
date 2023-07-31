using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // İnşaatçı sınıf - KarakterBuilder
    public abstract class CharacterBuilder
    {
        protected GameCharacter karakter;

        public void YeniKarakterOlustur()
        {
            karakter = new GameCharacter();
        }

        public GameCharacter KarakteriAl()
        {
            return karakter;
        }

        public abstract void AdBelirle();
        public abstract void SaldiriGucuBelirle();
        public abstract void SavunmaBelirle();
        public abstract void SilahBelirle();
        public abstract void ZirhBelirle();
    }
}
