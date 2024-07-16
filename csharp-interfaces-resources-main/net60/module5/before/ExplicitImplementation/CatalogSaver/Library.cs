namespace CatalogSaver;

public interface ISaveable
{
    void Save();
}

public class Catalog : ISaveable
{
    void ISaveable.Save() // <== The explicitly implemented interface method is HERE, dumbass
    {
        Console.WriteLine("Saved");
    }
}
