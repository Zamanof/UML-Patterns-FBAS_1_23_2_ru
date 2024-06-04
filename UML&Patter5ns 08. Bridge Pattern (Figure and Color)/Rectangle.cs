// Bridge pattern



class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(IColor color, double width, double height)
        :base(color, width* height, 4, nameof(Rectangle))
    {
        Width = width;
        Height = height;
    }
}
