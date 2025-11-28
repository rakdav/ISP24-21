//DayOfWeek NextDay(DayOfWeek day)
//{
//    return (day<DayOfWeek.Sunday)?++day:DayOfWeek.Monday;
//}

//DayOfWeek enumDay = DayOfWeek.Monday;//обращение к элементу перечисления
//Console.WriteLine(NextDay(DayOfWeek.Friday));
/*Console.Write("Введите число от 1до 5:");
int number=int.Parse(Console.ReadLine());
if (number > 0 && number < 6)
{
    CommodityType commodity=(CommodityType)Enum.GetValues(typeof(CommodityType)).GetValue(number-1);
    TransportType transport = TransportType.Semitrailer;
    switch (commodity)
    {
        case CommodityType.FrozenFood:
            transport=TransportType.Refrigerator; break;
        case CommodityType.Food:
            transport = TransportType.Semitrailer; break;
        case CommodityType.DomesticChemistry:
            transport = TransportType.Coupling; break;
        case CommodityType.BuildingMaterils:
            transport = TransportType.OpenSideTruck; break;
        case CommodityType.Petrol:
            transport = TransportType.FuelTrack;break;
    }
    Console.WriteLine($"Для товара {commodity} " +
        $"необходим транспорт - {transport}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}
*/
//Console.Write("Введите название планеты:");
//string planetName=Console.ReadLine();
//if (!Enum.IsDefined(typeof(DistanceSun), planetName))
//{
//    Console.WriteLine($"Значения {planetName} нет в перечислении DistanceSun");
//}
//foreach(DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
//{
//    Console.WriteLine("{0,-10} {1,-10} {2,20}",Enum.Format(typeof(DistanceSun),item,"G"), Enum.Format(typeof(DistanceSun), item, "D"),
//        Enum.Format(typeof(DistanceSun), item, "X"));
//}
//foreach(string str in Enum.GetNames(typeof(DistanceSun)))
//{
//    Console.WriteLine(str);
//}
//enum DistanceSun : ulong
//{
//    Sun=0,Mercury=57900000, Venus=108200000,
//    Earth=149600000,Mars=227900000,Jupiter=778300000,
//    Saturn=1427000000, Uranus=2870000000,Neptune=449600000,Pluto=5946000000
//}
//enum CommodityType
//{
//    FrozenFood, Food, DomesticChemistry,
//    BuildingMaterils,Petrol
//}
//enum Discount
//{
//    Default,Incentive=2, Patron=5,VIP=15
//}
//enum DayOfWeek
//{
//    Monday,Tuesday,Wednesday,Thursday,Friday,Saturday, Sunday
//}
//enum TransportType
//{
//    Semitrailer, Coupling, Refrigerator,OpenSideTruck,
//    Tank,FuelTrack
//}

//Person tom=new Person();
//tom.name = "Tom";
//tom.age = 40;
//tom.Print();
//Person bob=new Person { name="Bob",age=23};
//bob.Print();
//Person jerry = tom with { name = "Jerry" };
//jerry.Print();
//struct Person
//{
//    public string name;
//    public int age;
//    public void Print()
//    {
//        Console.WriteLine($"Имя:{name} Возраст:{age}");
//    }
//}

//Вариант 5. Базовый уровень.
//Console.Write("Введите количество продуктов:");
//int n = int.Parse(Console.ReadLine());
//Product[] products = new Product[n];
//try
//{ 
//    for (int i = 0; i < products.Length; i++)
//    {
//        Console.WriteLine($"Введите данные об {i + 1} продукте:");
//        Console.Write("Введите наименование продукта:");
//        products[i].name = Console.ReadLine();
//        Console.Write("Введите производителя продукта:");
//        products[i].manufactor = Console.ReadLine();
//        Console.Write("Введите год выпуска продукта:");
//        products[i].year = int.Parse(Console.ReadLine());
//        Console.Write("Введите количество продукта:");
//        products[i].count = int.Parse(Console.ReadLine());
//        Console.Write("Введите цену продукта:");
//        products[i].price = decimal.Parse(Console.ReadLine());
//    }
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//decimal sum = 0;
//foreach (Product product in products)
//{
//    if(product.year==DateTime.Now.Year)
//    {
//        sum+=product.price*product.count;
//        product.Print();
//    }
//}
//Console.WriteLine($"Итог:{sum:F2}");
//struct Product
//{
//    public string name;
//    public string manufactor;
//    public int year;
//    public int count;
//    public decimal price;
//    public void Print()
//    {
//        Console.WriteLine($"{name}, {manufactor}, {year}, {count}, {price}");
//    }
//}
//Вариант 5. Средний уровень.

try
{
    Console.Write("Введите количество сотрудников:");
    int n = int.Parse(Console.ReadLine());
    Employee[] people = new Employee[n];
    for (int i = 0; i < people.Length; i++)
    {
        Console.WriteLine($"Введите данные об {i + 1} сотруднике:");
        Console.Write("Введите имя сотрудника:");
        people[i].firstName = Console.ReadLine();
        Console.Write("Введите отчество сотрудника:");
        people[i].middleName= Console.ReadLine();
        Console.Write("Введите фамилию сотрудника:");
        people[i].lastName = Console.ReadLine();
        Console.Write("Введите должность сотрудника:");
        people[i].position = Console.ReadLine();
        Console.Write("Введите зарплату сотрудника:");
        people[i].salary = decimal.Parse(Console.ReadLine());
        Console.Write("Введите дату рождения сотрудника:");
        people[i].dateBirth = DateTime.Parse(Console.ReadLine());
    }
    foreach (Employee emp in people)
    {
        if (emp.dateBirth.Month == 5)
        {
            emp.Print();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Employee
{
    public string firstName;
    public string middleName;
    public string lastName;
    public string position;
    public decimal salary;
    public DateTime dateBirth;
    public void Print()
    {
        Console.WriteLine($"{firstName} {middleName} {lastName}," +
            $"{position},{salary},{dateBirth}");
    }
}