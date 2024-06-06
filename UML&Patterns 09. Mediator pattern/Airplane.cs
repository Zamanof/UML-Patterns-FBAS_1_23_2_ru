
// Mediator pattern

abstract class Airplane
{
    public string Code { get; set; }
    private readonly ICenter _center;
    public ICenter Center=> _center;

    protected Airplane(ICenter center)
    {
        _center = center;
    }

    public virtual void HandleMessage(Airplane airplane, string message)
    {
        Console.WriteLine($"Message: {message} from airplane board number {Code}, " +
            $"to airplane board number {airplane.Code}");
    }
    public abstract void LandingPermission();
    public abstract void TakeOffPermission();
}


