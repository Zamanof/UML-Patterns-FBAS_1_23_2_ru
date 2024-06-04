// Bridge pattern

interface IDevice
{
    bool IsEnabled { get; }
    
    int Volume { get; set; }
    int Channel { get; set; }

    void Enable();
    void Disable();
}
