//Rectangle rect1=new Rectangle();
//Console.WriteLine($"{rect1.getArea():F2}");
//Console.WriteLine($"{rect1.getPerimetr():F2}");
//Rectangle rect2=new Rectangle(100,300);
//Console.WriteLine($"{rect2.Width}*{rect2.Height}={rect2.getArea():F2}");
//Console.WriteLine($"2*({rect2.Width}+{rect2.Height})={rect2.getPerimetr():F2}");
////rect2.setWidth(150);
////rect2.setHeight(500);
//rect2.Width = 150;
//rect2.Height = 500;
//Console.WriteLine($"{rect2.Width}*{rect2.Height}={rect2.getArea():F2}");
//Console.WriteLine($"2*({rect2.Width}+{rect2.Height})={rect2.getPerimetr():F2}");

//class Rectangle
//{
//    private double width;
//    private double height;

//    public Rectangle(double _width, double _height)
//    {
//        this.width = _width;
//        this.height = _height;
//    }

//    public Rectangle()//конструктор по умолчанию
//    {
//        width = 1;
//        height = 1;
//    }
//    public double Width
//    {
//        get { return width; }
//        set { if(value>0) width = value; }
//    }
//    public double Height
//    {
//        get { return height; }
//        set {if(value>0) height = value; }
//    }
//    //геттеры
//    //public double getWidth()
//    //{
//    //    return width;
//    //}
//    //public double getHeight()
//    //{
//    //    return height;
//    //}
//    ////сеттеры
//    //public void setWidth(double _width) 
//    //{
//    //    width = _width;
//    //}
//    //public void setHeight(double _height)
//    //{
//    //    height = _height;
//    //}
//    public double getArea()
//    {
//        return width*height;
//    }
//    public double getPerimetr()
//    {
//        return 2*(width+height);
//    }
//}
Console.Write("Введите день:");
int day=int.Parse(Console.ReadLine()!);
Console.Write("Введите время разговора в минутах:");
double time = double.Parse(Console.ReadLine()!);
Console.Write("Введите цену минуты разговора:");
decimal price = decimal.Parse(Console.ReadLine()!);
Tel tel=new Tel(day,time,price);
tel.Print();
class Tel
{
    private int day;
    private double time;
    private decimal price;
    public Tel(int day, double time, decimal price)
    {
        this.day = day;
        this.time = time;
        this.price = price;
    }
    public int Day
    {
        get { return day; }
    }
    public double Time
    {
        get { return time; }
    }
    public decimal Price
    {
        get { return price; }
    }
    public decimal getTotal()
    {
        return day switch
        {
            1 => (decimal)time * price,
            2 => (decimal)time * price,
            3 => (decimal)time * price,
            4 => (decimal)time * price,
            5 => (decimal)time * price,
            6 => (decimal)0.9 * ((decimal)time * price),
            7 => (decimal)0.9*((decimal)time * price)
        };
    }
    public void Print()
    {
        Console.WriteLine($"Стоимость {time} минут разговора: {getTotal():F2}");
    }
}