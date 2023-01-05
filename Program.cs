// See https://aka.ms/new-console-template for more information

//DATETIME LİBRARY

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);


Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(30));
Console.WriteLine(DateTime.Now.AddHours(2));
Console.WriteLine(DateTime.Now.AddMonths(3));
Console.WriteLine(DateTime.Now.AddYears(2));

//Datetime Format
Console.WriteLine(DateTime.Now.ToString("dd"));//05
Console.WriteLine(DateTime.Now.ToString("ddd"));//Per
Console.WriteLine(DateTime.Now.ToString("dddd"));//Perşembe

Console.WriteLine(DateTime.Now.ToString("MM"));//01
Console.WriteLine(DateTime.Now.ToString("MMM"));//Oca
Console.WriteLine(DateTime.Now.ToString("MMMM"));//Ocak

Console.WriteLine(DateTime.Now.ToString("yy"));//23
Console.WriteLine(DateTime.Now.ToString("yyyy"));//2023

//MATH LIBRARY

Console.WriteLine(Math.Abs(-25));
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));

Console.WriteLine(Math.Ceiling(22.2));
Console.WriteLine(Math.Ceiling(22.7));
Console.WriteLine(Math.Floor(22.2));
Console.WriteLine(Math.Floor(22.7));
Console.WriteLine(Math.Round(22.2));
Console.WriteLine(Math.Round(22.7));

Console.WriteLine(Math.Min(2,9));
Console.WriteLine(Math.Max(2,9));
Console.WriteLine(Math.Pow(3,4));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Log(9));
Console.WriteLine(Math.Log10(10));
Console.WriteLine(Math.Exp(3));


