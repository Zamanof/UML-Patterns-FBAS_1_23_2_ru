#region Open/Closed Bad Example
//object[] shapes = new object[] {
//    new Rectangle(){ Height=5, Width=50},
//    new Circle(){ Radius= 64},
//    new Triangle(){Height = 23.6}
//};

//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes));

//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//}

//class Circle
//{
//    public double Radius { get; set; }
//}

//class Triangle
//{
//    // some fields
//    public double Height { get; set; }
//}

//class Calculate
//{
//    public double Areas(object[] shapes)
//    {
//        double areas = 0;
//        foreach (var shape in shapes)
//        {
//            if (shape is Rectangle rectangle)
//            {
//                areas += rectangle.Width * rectangle.Height;
//            }
//            else if (shape is Triangle triangle)
//            {
//                areas += triangle.Height * 36 / 15;
//            }
//            else if (shape is Circle circle)
//            {
//                areas += Math.Pow(circle.Radius, 2) * Math.PI;
//            }
//        }
//        return areas;
//    }
//}
#endregion

#region Open/Closed Good Example

//Shape[] shapes = new Shape[]
//{
//    new Rectangle() { Height = 5, Width = 50 },
//    new Circle() { Radius = 64 },
//    new Triangle() { Height = 23.6 },
//    new Square(){Side = 25}
//};

//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes));
//abstract class Shape
//{
//    public abstract double Area();
//}

//class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public override double Area() => Width * Height;
//}

//class Square : Shape
//{
//    public double Side { get; set; }
//    public override double Area() => Math.Pow(Side, 2);
//}

//class Circle : Shape
//{
//    public double Radius { get; set; }

//    public override double Area() => Math.Pow(Radius, 2) * Math.PI;
//}

//class Triangle : Shape
//{
//    // some fields
//    public double Height { get; set; }

//    public override double Area() => Height * 36 / 15;
//}


//class Calculate
//{
//    public double Areas(Shape[] shapes) => shapes.Sum(x => x.Area());
//}

#endregion

#region Open/Closed Task Bad Example
//class Developer
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Position { get; set; }
//    public double Salary {  get; set; }

//    public Developer(int id, string name, string position, double salary)
//    {
//        Id = id;
//        Name = name;
//        Position = position;
//        Salary = salary;
//    }

//    public double CalculateBonus()
//    {
//        if (Position == "Junior") return Salary * 0.1;
//        else if (Position == "Middle") return Salary * 0.2;
//        else return Salary * 0.3;
//    }
//}

#endregion

#region Open/Closed Task Bad Example
abstract class Developer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Developer(int id, string name, string position, double salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public abstract double CalculateBonus();    
}

class JuniorDeveloper : Developer
{
    public JuniorDeveloper(int id, string name, string position, double salary) 
        : base(id, name, position, salary)
    { }

    public override double CalculateBonus()=> Salary * 0.1;
}

class MiddleDeveloper : Developer
{
    public MiddleDeveloper(int id, string name, string position, double salary) : base(id, name, position, salary)
    {}
    public override double CalculateBonus () => Salary * 0.3;
}

#endregion