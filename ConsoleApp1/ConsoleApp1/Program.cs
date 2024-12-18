// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;

double x, V;
string res;
Console.Clear();
Console.WriteLine("Введите Х: ");
x = Convert.ToDouble(Console.ReadLine());
V = (Math.Exp(x) * Math.Tan(Math.Cbrt(Math.Pow(x,2)+5.3)) + Math.Pow(x,5)) / (1 + Math.Log(Math.Abs(x)));
res = "Result: ";
Convert.ToString(V);
Console.WriteLine(res);
Console.WriteLine(V);


