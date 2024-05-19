interface IDb
{
    void Create();
    void Read();
    void Update();
    void Delete();
}

class MsSQL : IDb
{
    public void Create() => Console.WriteLine("Create with MS SQL");

    public void Delete() => Console.WriteLine("Delete with MS SQL");

    public void Read() => Console.WriteLine("Read with MS SQL");

    public void Update() => Console.WriteLine("Update with MS SQL");
}

class PostgreeSQL : IDb
{
    public void Create() => Console.WriteLine("Create with PostgreeSQL");

    public void Delete() => Console.WriteLine("Delete with PostgreeSQL");

    public void Read() => Console.WriteLine("Read with PostgreeSQL");

    public void Update() => Console.WriteLine("Update with PostgreeSQL");
}

class MySQL : IDb
{
    public void Create() => Console.WriteLine("Create with  MySQL");

    public void Delete() => Console.WriteLine("Delete with  MySQL");

    public void Read() => Console.WriteLine("Read with  MySQL");

    public void Update() => Console.WriteLine("Update with  MySQL");
}

class Application
{
    private IDb _db;

    public Application(IDb db)
    {
        _db = db;
    }
    public void DoSomething()
    {
        _db.Create();
        _db.Read();
        _db.Update();
        _db.Delete();
    }
}