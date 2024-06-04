// Bridge pattern

class RemoteControl
{
    protected IDevice? _device;
    public RemoteControl(IDevice? device)
    {
        _device = device;
    }

    public void TogglePower()
    {
        if (_device?.IsEnabled ?? false)
        {
            _device.Disable();
        }
        else
        {
            if(_device is not null)
            {
                _device.Enable();
            }
        }
    }
    public void VolumeDown()
    {
        if (_device is not null)
        {
            _device.Volume--;
        }
    }

    public void VolumeUp()
    {
        if (_device is not null)
        {
            _device.Volume++;
        }
    }

    public void ChannelDown()
    {
        if (_device is not null)
        {
            _device.Channel--;
        }
    }

    public void ChannelUp()
    {
        if (_device is not null)
        {
            _device.Channel++;
        }
    }
}
