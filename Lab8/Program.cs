//using System;

//DateTime data1 = new DateTime();
//Console.WriteLine(data1);
//DateTime data2 = DateTime.Now;
//Console.WriteLine(data2);
//DateTime data3 = new DateTime(2025,11,21);
//Console.WriteLine(data3);
//DateTime data4 = new DateTime(2025, 11, 21,23,22,45);
//Console.WriteLine(data4);
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(DateTime.Today);
//Console.WriteLine(data2.Year);
//Console.WriteLine(data2.Month);
//Console.WriteLine(data2.Day);
//Console.WriteLine(data2.Hour);
//Console.WriteLine(data2.Minute);
//Console.WriteLine(data2.Second);
//Console.WriteLine(data2.Millisecond);
//Console.WriteLine(DateTime.MinValue);
//Console.WriteLine(DateTime.MaxValue);
//Console.WriteLine(data2.Microsecond);
//Console.WriteLine(data2.Nanosecond);
//Console.WriteLine(data2.Kind);
//DateTime data5 = DateTime.Parse("2025-12-3");
//Console.WriteLine(data5.Add(new TimeSpan(4,5,6,45)));
//Console.WriteLine(data5.AddDays(7));
//Console.WriteLine(data5.AddDays(-3));
//Console.WriteLine(data5.AddHours(67));
//Console.WriteLine(data5.AddTicks(7803453453553));
//Console.WriteLine(data5.Subtract(DateTime.Now));
//Console.WriteLine(data5.CompareTo(data4));
//Console.WriteLine(data5==DateTime.Now);
//Console.WriteLine(data5.Day);
//Console.WriteLine(data5.DayOfWeek);
//Console.WriteLine(data5.DayOfYear);
//Console.WriteLine(data2.ToLocalTime());
//Console.WriteLine(data2.ToUniversalTime());
//Console.WriteLine(data2.ToLongDateString());
//Console.WriteLine(data2.ToShortDateString());
//Console.WriteLine(data2.ToLongTimeString());
//Console.WriteLine(data2.ToShortTimeString());

////дата и время во всех форматах
//Console.WriteLine($"D:{data2.ToString("D")}");//Полный формат даты. Например, 17 июля 2015 г.
//Console.WriteLine($"d:{data2.ToString("d")}");
//Console.WriteLine($"F:{data2.ToString("F")}");
//Console.WriteLine($"f:{data2.ToString("f")}");
//Console.WriteLine($"G:{data2:G}");
//Console.WriteLine($"g:{data2:g}");
//Console.WriteLine($"M:{data2:M}");
//Console.WriteLine($"O:{data2:O}");
//Console.WriteLine($"o:{data2:o}");
//Console.WriteLine($"R:{data2:R}");
//Console.WriteLine($"s:{data2:s}");
//Console.WriteLine($"T:{data2:T}");
//Console.WriteLine($"t:{data2:t}");
//Console.WriteLine($"U:{data2:U}");
//Console.WriteLine($"u:{data2:u}");
//Console.WriteLine($"Y:{data2:Y}");
//Console.WriteLine(data2.ToString("yyyy-MM-dd hh:mm:ss"));
////DateOnly
//DateOnly d1=DateOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(d1);
//DateOnly d2 = new DateOnly();
//Console.WriteLine(d2);
//DateOnly d3=new DateOnly(2025,12,3);
//Console.WriteLine(d3);
//Console.WriteLine(d2.Year);
//Console.WriteLine(d2.Month);
//Console.WriteLine(d2.Day);
//Console.WriteLine(d3.DayNumber);
//Console.WriteLine(d3.DayOfWeek);
//Console.WriteLine(d3.DayOfYear);
//Console.WriteLine(DateOnly.MinValue);
//Console.WriteLine(DateOnly.MaxValue);
//Console.WriteLine(d2.ToLongDateString());
//Console.WriteLine(d3.ToShortDateString());
////TimeOnly
//TimeOnly time1 = new TimeOnly();
//Console.WriteLine(time1);
//TimeOnly time2 = TimeOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(time2);
//Console.WriteLine(time2.Hour);
//Console.WriteLine(time2.Minute);
//Console.WriteLine(time2.Second);
//Console.WriteLine(time2.Ticks);

//Базовый уровень 25 вариант.

//1
//Console.Write("Введите время в формате yyyy-MM-dd hh-mm-ss:");
//TimeOnly date = TimeOnly.FromDateTime(DateTime.Parse(Console.ReadLine()));
//string am_pm = "";
//if (date.Hour < 12) am_pm = "AM";
//else am_pm = "PM";
//Console.WriteLine($"{date:hh:mm:ss} "+am_pm);

//2
//Console.Write("Введите время разогрева в минутах:");
//int min=int.Parse(Console.ReadLine());
//Console.WriteLine(TimeOnly.FromDateTime(DateTime.Now).AddMinutes(min));

//Средний уровень 25 вариант.

//NokeOut[] nokes = new NokeOut[3];
//for (int i = 0; i < nokes.Length; i++)
//{ 
//    nokes[i] = new NokeOut();
//    Console.Write("Введите дату:");
//    nokes[i].data = DateOnly.FromDateTime(DateTime.Parse(Console.ReadLine()));
//    Console.Write("Введите время:");
//    nokes[i].time=TimeOnly.Parse(Console.ReadLine());
//    Console.Write("Введите фамилию бойца победителя:");
//    nokes[i].fio_one = Console.ReadLine();
//    Console.Write("Введите фамилию бойца проигравшего:");
//    nokes[i].fio_two = Console.ReadLine();
//    Console.Write("Введите номер раунда:");
//    nokes[i].number = int.Parse(Console.ReadLine());
//    Console.Write("Введите время в минутах:");
//    nokes[i].finishMinutes = int.Parse(Console.ReadLine());
//    Console.Write("Введите время в секундах:");
//    nokes[i].finishSeconds = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < nokes.Length; i++)
//{
//    int seconds = 180 * (nokes[i].number - 1) + 120 * (nokes[i].number - 1) + nokes[i].finishMinutes * 60 + nokes[i].finishSeconds;
//    Console.WriteLine(DateTime.Parse($"{nokes[i].data} {nokes[i].time}").AddSeconds(seconds));
//}
//for (int i = 0; i < nokes.Length; i++)
//{
//    if (nokes[i].data>=DateOnly.FromDateTime(DateTime.Now).AddMonths(-3))
//        nokes[i].Print();
//}

//struct NokeOut
//{
//    public DateOnly data;
//    public TimeOnly time;
//    public string fio_one;
//    public string fio_two;
//    public int number;
//    public int finishMinutes;
//    public int finishSeconds;
//    public void Print()
//    {
//        Console.WriteLine(data+" "+time+fio_one+" "+fio_two);
//    }
//}

//using System;

//int? x1=6;
//if (x1.HasValue)
//{
//    int x2=(int)x1;
//    Console.WriteLine(x2);
//}
//int? x3=x1+6;

//?? null-объединение
//string? text = "my";
//string name = text??"";
//Console.WriteLine(name);
var tuple = (5, 10);
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);
(string, int, double) person = ("Tom", 5, 8.9);
Console.WriteLine(person.Item1);

int a=6,b=7;
(a, b) = (b, a);
Console.WriteLine(a+" "+b);
