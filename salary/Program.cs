using salary.Models;
Salary salary = new Salary();
int x;
int y;
int z;
double a;
double b;
double c;
int salaryy;
int workhours;
int hoursrate;
int total;


Console.WriteLine("Enter number");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number");
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(salary.Add(x, y));


Console.WriteLine("Enter number");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number");
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number");
z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(salary.Add(x, y, z));


Console.WriteLine("Enter number");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(salary.Add(x, y, z));

Console.WriteLine("Enter number");
salaryy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number");
workhours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number");
hoursrate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(salary.Add(salaryy, workhours, hoursrate));

