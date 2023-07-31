using Builder;

class Program
{
    static void Main(string[] args)
    {
        GameDirector yonetmen = new GameDirector();

        // Asker karakterini oluşturma
        CharacterBuilder askerBuilder = new SoldierBuilder();
        yonetmen.SetKarakterBuilder(askerBuilder);
        GameCharacter asker = yonetmen.KarakterOlustur();
        asker.Goster();

        // Ninja karakterini oluşturma
        CharacterBuilder ninjaBuilder = new NinjaBuilder();
        yonetmen.SetKarakterBuilder(ninjaBuilder);
        GameCharacter ninja = yonetmen.KarakterOlustur();
        ninja.Goster();
    }
}