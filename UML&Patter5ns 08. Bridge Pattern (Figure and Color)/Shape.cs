// Bridge pattern



abstract class Shape
{
    public IColor? Color { get; set; }
    public double Area { get; protected set; }
    public byte Corner { get; init; }
    public string? Name { get; set; }

    protected Shape(IColor? color, double area, byte corner, string? name)
    {
        Color = color;
        Area = area;
        Corner = corner;
        Name = name;
    }
}
