Console.Write("Введите тип кабеля:");
string type=Console.ReadLine()!;
Console.Write("Введите количество жил:");
int count =int.Parse(Console.ReadLine()!);
Console.Write("Введите диаметр кабеля:");
double diametr =double.Parse(Console.ReadLine()!);
Kabel kabel1=new Kabel(type,count,diametr);
Console.WriteLine(kabel1);
Console.WriteLine(kabel1.GetHashCode());
Console.Write("Введите наличие оплетки:1-да, 2-нет");
bool braid = (int.Parse(Console.ReadLine()!) == 1 ? true : false);
SuperKabel kabel2=new SuperKabel(type,count,diametr,braid);
Console.WriteLine(kabel2);
Console.WriteLine(kabel2.GetHashCode());

class Kabel
{
    private string? type;
    private int countZhil;
    private double diametr;
    public Kabel(string? _type, int _countZhil, double _diametr)
    {
        this.type =_type;
        this.countZhil =_countZhil;
        this.diametr =_diametr;
    }
    public string? Type
    {
        get { return type; }
        set { type = value; }
    }
    public int CountZhil
    {
        get { return countZhil; }
        set { if(value>0) countZhil = value; }
    }
    public double Diametr
    {
        get { return diametr; }
        set {  if(value>0) diametr = value; }
    }

    public  virtual double Quality()
    {
        return diametr/countZhil;
    }

    public override string? ToString()
    {
        return $"Кабель типа {type}, c количеством жил {countZhil}," +
            $" диаметром {diametr} имеет качество:{Quality():F2}";
    }
}

class SuperKabel : Kabel
{
    public bool braid;

    public SuperKabel(string? _type, int _countZhil, double _diametr,bool _braid) : base(_type, _countZhil, _diametr)
    {
        braid= _braid;
    }
    public bool Braid
    {
        get { return braid; }
        set { braid = value; }
    }

    public override double Quality()
    {
        if(braid) return 2*base.Quality();
        return 0.7*base.Quality();
    }

    public override string? ToString()
    {
        return $"Кабель типа {Type}, c количеством жил {CountZhil}," +(braid?" с оплеткой,":"")+
            $" диаметром {Diametr} имеет качество:{Quality():F2}";
    }
}