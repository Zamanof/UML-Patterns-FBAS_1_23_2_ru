// Observer pattern
// Subject - Publisher
// Observers - Subscribers

ProductManager productManager = new ProductManager();
var client = new ClientObserver();
var employee = new EmployeeObserver();

productManager.Attach(client);
productManager.Attach(employee);

productManager.UpdatePrice();

productManager.Detach(client);
Console.WriteLine();

productManager.UpdatePrice();
// Publisher
class ProductManager
{
    private List<Observer> _observers = new List<Observer>();

    public void UpdatePrice()
    {
        Notify("Product price is changed");
    }

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    private void Notify(string message)
    {
        foreach (Observer observer in _observers)
            observer.Update(message);
    }
}
// Observers
abstract class Observer
{
    public abstract void Update(string message);
}

class ClientObserver: Observer
{
    public override void Update(string message)
    {
        Console.WriteLine($"Message to client: {message}");
    }
}

class EmployeeObserver : Observer
{
    public override void Update(string message)
    {
        Console.WriteLine($"Message to employee: {message}");
    }
}
