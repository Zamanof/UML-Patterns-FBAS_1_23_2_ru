MSSQL mSSQL = new MSSQL();
mSSQL.TemplateMethod();
Console.WriteLine();
MySQL mySQL = new MySQL();
mySQL.TemplateMethod();

abstract class SQLEngine
{
    public virtual void TemplateMethod()
    {
        Connect();
        ExecuteCommand();
        CloseConnection();
    }
    public abstract void Connect();
    public abstract void ExecuteCommand();
    public abstract void CloseConnection();
}

class MSSQL : SQLEngine
{
    public override void TemplateMethod()
    {
        Connect();
        CloseConnection();
    }
    public override void CloseConnection()
    {
        Console.WriteLine("MS SQL Close Connection");
    }

    public override void Connect()
    {
        Console.WriteLine("MS SQL Connect");
    }

    public override void ExecuteCommand()
    {
        Console.WriteLine("MS SQL Execute command");
    }
}

class MySQL : SQLEngine
{
    public override void CloseConnection()
    {
        Console.WriteLine("MySQL Close Connection");
    }

    public override void Connect()
    {
        Console.WriteLine("MySQL Connect");
    }

    public override void ExecuteCommand()
    {
        Console.WriteLine("MySQL Execute command");
    }
}
