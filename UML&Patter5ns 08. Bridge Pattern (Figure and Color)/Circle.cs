// Bridge pattern



class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(IColor? color, double radius)
        :base(color, 3.14*Math.Pow(radius, 2), 0, nameof(Circle))
    {
        Radius = radius;
    }
}