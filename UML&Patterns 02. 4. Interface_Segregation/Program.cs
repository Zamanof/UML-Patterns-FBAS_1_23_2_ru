#region Interface Segregation Bad Example
//abstract class Animal
//{
//    public abstract void Feed();
//    public abstract void Groom();
//}

//class Dog : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Dog Feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Dog Groom");
//    }
//}

//class Tiger : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Tiger Feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Tiger Groom");
//    }
//}

#endregion

#region Interface Segregation Good Example
abstract class Animal
{
    public abstract void Feed();
}
interface IGroom
{
    void Groom();
}

abstract class Pet : Animal, IGroom
{
    public void Groom()
    {
        throw new NotImplementedException();
    }
}

class Dog : Pet
{
    public override void Feed()
    {
        Console.WriteLine("Dog Feed");
    }

    public  void Groom()
    {
        Console.WriteLine("Dog Groom");
    }
}

abstract class Predator: Animal { }
class Tiger : Predator
{
    public override void Feed()
    {
        Console.WriteLine("Tiger Feed");
    }
}

#endregion
