// Bridge pattern



class Red : IColor
{
    public string? Name { get; set; } = "Red";
    public float Opacity { get; set; } = 100f;

    public void FromRGB(byte r, byte g, byte b)
    {
        Console.WriteLine($"FromRGB R: {r}, G: {g}, B: {b}");
    }
}
