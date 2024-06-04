List<Player?> units = new();
FlyWeightFactory factory = new();

for (int i = 0; i < 100000000; i++)
{
    //units.Add(new Archer());
    //units.Add(new Warrior());

    units.Add(factory?.GetUnit("Archer"));
    //Console.WriteLine(units.Last()?.GetHashCode());
    units.Add(factory?.GetUnit("Warrior"));
    //Console.WriteLine(units.Last()?.GetHashCode());
}
Console.WriteLine("Terminated");
Console.ReadKey();

abstract class Player
{
    public string? Name { get; set; }
    public int AttackPoint { get; set; }
    public short Health { get; set; }

    public abstract void Display();
}

class Archer : Player
{
    public Archer()
    {
        Name = "Archer";
        AttackPoint = 94;
        Health = 480;
    }
    public override void Display()
    {
        Console.WriteLine("Archer created");
    }
}

class Warrior : Player
{
    public Warrior()
    {
        Name = "Warrior";
        AttackPoint = 75;
        Health = 658;
    }

    public override void Display()
    {
        Console.WriteLine("Warrior created");
    }
}

class FlyWeightFactory
{
    private Dictionary<string, Player?> _units = new();
    public Player? GetUnit(string key)
    {
        Player? unit = null;
        if (_units.ContainsKey(key))
        {
            unit = _units[key];
        }
        else
        {
            switch (key)
            {
                case "Archer":
                    unit = new Archer();
                    break;
                case "Warrior":
                    unit = new Warrior();
                    break;
            }
            _units.Add(key, unit);
        }
        return unit;
    }
}
