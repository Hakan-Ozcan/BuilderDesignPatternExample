using Builder;

class Program
{
    static void Main(string[] args)
    {
        OyunYonetmeni yonetmen = new OyunYonetmeni();

        // Asker karakterini oluşturma
        KarakterBuilder askerBuilder = new AskerBuilder();
        yonetmen.SetKarakterBuilder(askerBuilder);
        OyunKarakteri asker = yonetmen.KarakterOlustur();
        asker.Goster();

        // Ninja karakterini oluşturma
        KarakterBuilder ninjaBuilder = new NinjaBuilder();
        yonetmen.SetKarakterBuilder(ninjaBuilder);
        OyunKarakteri ninja = yonetmen.KarakterOlustur();
        ninja.Goster();
    }
}