// Strategy pattern


// Dependency Inversion Principles
SerializeStrategy serializeStrategy = new SerializeStrategy(new BinarySerializer());
serializeStrategy.Serialize();
serializeStrategy = new SerializeStrategy(new XMLSerializer());
serializeStrategy.Serialize();

interface ISerializer
{
    void Serialize();
}
class JsonSerializer : ISerializer
{
    public void Serialize()
    {
        Console.WriteLine("Json Serializer");
    }
}

class XMLSerializer : ISerializer
{
    public void Serialize()
    {
        Console.WriteLine("XML Serializer");
    }
}

class BinarySerializer : ISerializer
{
    public void Serialize()
    {
        Console.WriteLine("Binary Serializer");
    }
}

class SerializeStrategy
{
    private readonly ISerializer _serializer;

    public SerializeStrategy(ISerializer serializer)
    {
        _serializer = serializer;
    }

    public void Serialize()
    {
        _serializer.Serialize();
    }
}
