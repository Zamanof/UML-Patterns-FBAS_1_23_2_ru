// Bridge pattern

class AdvancedRemoteControl: RemoteControl
{
    public AdvancedRemoteControl(IDevice? device)
        : base(device) { }

    public void Mute()
    {
        if(_device is not null)
        {
            _device.Volume = 0;
        }
    }

}