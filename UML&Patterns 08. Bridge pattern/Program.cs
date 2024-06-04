// Bridge pattern

IDevice device = new TV();
var remote = new AdvancedRemoteControl(device);
remote.TogglePower();
remote.VolumeUp();
remote.ChannelUp();

Console.WriteLine(device.IsEnabled);
Console.WriteLine(device.Volume);
Console.WriteLine(device.Channel);

remote.ChannelDown();
Console.WriteLine(device.Channel);

remote.TogglePower();
Console.WriteLine(device.IsEnabled);
