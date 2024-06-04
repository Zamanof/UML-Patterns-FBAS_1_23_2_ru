// Bridge pattern



interface IColor
{
    string? Name { get; set; }
    float Opacity { get; set; }

    void FromRGB(byte r, byte g, byte b);
}
