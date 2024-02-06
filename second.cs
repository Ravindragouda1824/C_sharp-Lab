using System;
public class Armstrong
{
public static void Main(string[] args)
{
int a, b, c, d;
for (int i = 1; i <= 1000; i++)
{
a = i / 100;
b = (i - a * 100) / 10;
c = (i - a * 100 - b * 10);
d = a * a * a + b * b * b + c * c * c;
if (i == d)
{
System.Console.WriteLine("{0}", i);
}
}
Console.ReadKey();
}
}