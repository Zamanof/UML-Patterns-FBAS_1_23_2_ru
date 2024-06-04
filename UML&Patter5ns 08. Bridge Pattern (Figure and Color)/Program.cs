// Bridge pattern

IColor color = new Red();
Shape shape = new Rectangle(color, 10, 7);
color = new Blue();
shape = new Circle(color, 32);

Console.WriteLine(shape.Name);
Console.WriteLine(shape.Area);
Console.WriteLine(shape.Corner);
Console.WriteLine(shape.Color?.Name);
Console.WriteLine(shape.Color?.Opacity);

shape.Color?.FromRGB(22, 14, 22);
