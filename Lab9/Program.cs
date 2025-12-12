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
//Console.Write("Введите день:");
//int day=int.Parse(Console.ReadLine()!);
//Console.Write("Введите время разговора в минутах:");
//double time = double.Parse(Console.ReadLine()!);
//Console.Write("Введите цену минуты разговора:");
//decimal price = decimal.Parse(Console.ReadLine()!);
//Tel tel=new Tel(day,time,price);
//tel.Print();
//class Tel
//{
//    private int day;
//    private double time;
//    private decimal price;
//    public Tel(int day, double time, decimal price)
//    {
//        this.day = day;
//        this.time = time;
//        this.price = price;
//    }
//    public int Day
//    {
//        get { return day; }
//    }
//    public double Time
//    {
//        get { return time; }
//    }
//    public decimal Price
//    {
//        get { return price; }
//    }
//    public decimal getTotal()
//    {
//        return day switch
//        {
//            1 => (decimal)time * price,
//            2 => (decimal)time * price,
//            3 => (decimal)time * price,
//            4 => (decimal)time * price,
//            5 => (decimal)time * price,
//            6 => (decimal)0.9 * ((decimal)time * price),
//            7 => (decimal)0.9*((decimal)time * price)
//        };
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Стоимость {time} минут разговора: {getTotal():F2}");
//    }
//}
//Console.Write("Введите радиус:");
//double r=double.Parse(Console.ReadLine()!);
//Console.Write("Введите высоту:");
//double h = double.Parse(Console.ReadLine()!);
//Cylinder cyl = new Cylinder(r,h);
//cyl.Print();

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

//-----статические поля и методы класса--------------
//Console.Write("Введите числитель первой дроби:");
//int n1=int.Parse(Console.ReadLine()!);
//Console.Write("Введите знаменатель первой дроби:");
//int d1 = int.Parse(Console.ReadLine()!);
//Console.Write("Введите числитель второй дроби:");
//int n2 = int.Parse(Console.ReadLine()!);
//Console.Write("Введите знаменатель второй дроби:");
//int d2 = int.Parse(Console.ReadLine()!);
//Drob drob1 = new Drob(n1, d1);
//drob1.Print();
//Drob drob2 = new Drob(n2, d2);
//drob2.Print();
//Drob drob3=drob1.Add(drob2);
//drob3.Print();
//Drob drob4 = drob1.Sub(drob2);
//drob4.Print();
//Drob drob5 = drob1.Mult(drob2);
//drob5.Print();
//Drob drob6 = drob1.Div(drob2);
//drob6.Print();
//Console.WriteLine($"Количество объектов класса дробь:{Drob.count}");
//class Drob
//{
//    private int numerator;
//    private int denominator;
//    public static int count = 0;
//    public Drob(int _numerator, int _denominator)
//    {
//        this.numerator = _numerator;
//        this.denominator = _denominator;
//        count++;
//    }
//    public int Numerator
//    {
//        get { return numerator; }
//        set { numerator = value; }
//    }
//    public int Denominator
//    {
//        get { return denominator; }
//        set { if(value!=0) denominator = value; }
//    }
//    public Drob Add(Drob drob)
//    {
//        int num=this.numerator*drob.denominator+this.denominator*drob.numerator;
//        int den=this.denominator*drob.denominator;
//        return new Drob(num, den);
//    }
//    public Drob Sub(Drob drob)
//    {
//        int num = this.numerator * drob.denominator - this.denominator * drob.numerator;
//        int den = this.denominator * drob.denominator;
//        return new Drob(num, den);
//    }
//    public Drob Mult(Drob drob)
//    {
//        int num = this.numerator * drob.numerator;
//        int den = this.denominator * drob.denominator;
//        return new Drob(num, den);
//    }
//    public Drob Div(Drob drob)
//    {
//        int num = this.numerator * drob.denominator;
//        int den = this.denominator * drob.numerator;
//        return new Drob(num, den);
//    }
//    public void Print()
//    {
//        Console.WriteLine(numerator+"/"+denominator);
//    }
//}

Person bob = new(68);
bob.СheckAge();     // Уже на пенсии

Person tom = new(37);
tom.СheckAge();     // Сколько лет осталось до пенсии: 28

// получение статического поля
Console.WriteLine(Person.retirementAge); // 65
// изменение статического поля
Person.retirementAge = 67;
Person.CheckRetirementStatus(bob);
Console.WriteLine(Person.RetirementAge);
Console.WriteLine(Operations.Add(5, 4));         // 9
Console.WriteLine(Operations.Subtract(5, 4));    // 1
Console.WriteLine(Operations.Multiply(5, 4));
class Person
{
    int age;
    public static int retirementAge = 65;
    public static int RetirementAge
    {
        get { return retirementAge; }
        set { if(value>1&&value<100) retirementAge=value; }
    }
    public Person(int age)
    {
        this.age = age;
    }
    static Person()
    {
        if (DateTime.Now.Year == 2025) retirementAge = 65;
        else retirementAge = 67;
    }
    public void СheckAge()
    {
        if (age >= retirementAge)
            Console.WriteLine("Уже на пенсии");
        else
            Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
    }
    public static void CheckRetirementStatus(Person person)
    {
        if(person.age >=retirementAge)
            Console.WriteLine("Уже на пенсии");
        else
            Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - person. age}");
    }
}

static class Operations
{
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
}