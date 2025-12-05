Rectangle rect1=new Rectangle();
Console.WriteLine($"{rect1.getArea():F2}");
Console.WriteLine($"{rect1.getPerimetr():F2}");
Rectangle rect2=new Rectangle(100,300);
Console.WriteLine($"{rect2.Width}*{rect2.Height}={rect2.getArea():F2}");
Console.WriteLine($"2*({rect2.Width}+{rect2.Height})={rect2.getPerimetr():F2}");
//rect2.setWidth(150);
//rect2.setHeight(500);
rect2.Width = 150;
rect2.Height = 500;
Console.WriteLine($"{rect2.Width}*{rect2.Height}={rect2.getArea():F2}");
Console.WriteLine($"2*({rect2.Width}+{rect2.Height})={rect2.getPerimetr():F2}");

class Rectangle
{
    private double width;
    private double height;

    public Rectangle(double _width, double _height)
    {
        this.width = _width;
        this.height = _height;
    }

    public Rectangle()//конструктор по умолчанию
    {
        width = 1;
        height = 1;
    }
    public double Width
    {
        get { return width; }
        set { if(value>0) width = value; }
    }
    public double Height
    {
        get { return height; }
        set {if(value>0) height = value; }
    }
    //геттеры
    //public double getWidth()
    //{
    //    return width;
    //}
    //public double getHeight()
    //{
    //    return height;
    //}
    ////сеттеры
    //public void setWidth(double _width) 
    //{
    //    width = _width;
    //}
    //public void setHeight(double _height)
    //{
    //    height = _height;
    //}
    public double getArea()
    {
        return width*height;
    }
    public double getPerimetr()
    {
        return 2*(width+height);
    }
}
