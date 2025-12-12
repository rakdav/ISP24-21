using System.ComponentModel;
using System.Xml.Linq;

//Console.Write("Введите радиус:");
//double r = double.Parse(Console.ReadLine()!);
//Console.Write("Введите высоту:");
//double h = double.Parse(Console.ReadLine()!);
//Console.Write("Введите количество цилиндров:");
//int n = int.Parse(Console.ReadLine()!);
//CylinderChild cyl = new CylinderChild(r,h,n);
//cyl.Print();
////Базовый уровень. 26 вариант.
//class Cylinder
//{
//    private double radius;
//    private double height;
//    public Cylinder(double radius, double height)
//    {
//        this.radius = radius;
//        this.height = height;
//    }
//    public double getRadius() { return radius; }
//    public double getHeight() { return height; }
//    public double getArea()
//    {
//        return 2 * Math.PI * radius * height;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Площадь поверхности:{getArea():F2}");
//    }
//}

//class CylinderChild : Cylinder
//{
//    private int count;
//    private int Count
//    {
//        get=>count;
//        set { if (value > 0) count = value; }
//    }

//    public CylinderChild(double _radius, double _height,int _count) : base(_radius, _height)
//    {
//        this.count = _count;
//    }
//    public double getAllArea()
//    {
//        return count * getArea();
//    }
//    public new void Print()
//    {
//        Console.WriteLine($"Площадь поверхности:{getAllArea():F2}");
//    }
//}
//Средний уровень. 26 вариант.
Console.Write("Введите название:");
string name=Console.ReadLine()!;
Console.Write("Введите цену:");
double price=double.Parse(Console.ReadLine()!);
Console.Write("Введите производителя:");
string factory = Console.ReadLine()!;
Console.Write("Введите год выпуска:");
int year = int.Parse(Console.ReadLine()!);
Console.Write("Введите скидку:");
int dicount = int.Parse(Console.ReadLine()!);
TovarChild tovar=new TovarChild(name,price,factory,year,dicount);
tovar.Update();
class Tovar
{
    private string? name;
    protected double price;
    private string? manufactory;
    public Tovar(string? name, double price, string? manufactory)
    {
        this.name = name;
        this.price = price;
        this.manufactory = manufactory;
    }
    public string? Name
    {
        get => name;
        set => name = value;
    }
    public double Price
    {
        get => price;
        set
        {
            if (value > 0) price = value;
        }
    }
    public string? Manufactory
    {
        get => manufactory;
        set => manufactory = value;
    }
    public double ToDollars(double kurs)
    {
        return price* kurs;
    }
    public void Add(double addSum)
    {
        if (name == "Toyota") price += addSum;
    }
}

class TovarChild:Tovar
{
    private int year;
    private int discount;

    public TovarChild(string? name, double price, string? manufactory,
        int _year,int _discount) : base(name, price, manufactory)
    {
        this.year = _year;
        this.discount = _discount;
    }
    public int Year
    {
        get { return year; }
        set { if (year > 0) year = value; }
    }
    public int Discount
    {
        get { return discount; }
        set { if(value>0) discount = value; }
    }
    public void Update()
    {
        if (DateTime.Now.Year-year>2) price*=(1-(discount/100.0));
    }
}