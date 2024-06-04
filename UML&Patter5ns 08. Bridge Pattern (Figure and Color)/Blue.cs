// Bridge pattern



class Blue : IColor
{
    public string? Name { get; set; } = "Blue";
    public float Opacity { get; set; } = 100f;

    public void FromRGB(byte r, byte g, byte b)
    {
        Console.WriteLine($"FromRGB R: {r}, G: {g}, B: {b}");
    }
}
