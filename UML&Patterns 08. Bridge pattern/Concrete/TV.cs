// Bridge pattern

class TV : IDevice
{
    public bool IsEnabled { get; private set; }

    public int Volume { get ; set; }
    public int Channel { get; set; }

    public void Disable()=> IsEnabled = false;

    public void Enable()=>IsEnabled = true;
}
