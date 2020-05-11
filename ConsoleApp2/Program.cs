using System;

class Program
{
    static public void Example(double a, double b)
    {

      
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Гiпотенуза = " + c); 
        double p = a + b + c;
        Console.WriteLine("Периметр = " + p);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть перше число"); 
        string S1 = Console.ReadLine();
        double a = double.Parse(S1); 
        Console.WriteLine("Введiть друге число"); 
        string S2 = Console.ReadLine();
        double b = double.Parse(S2); 
        Example(a, b);
        Console.ReadLine();
    }
}