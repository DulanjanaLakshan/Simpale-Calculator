using calculator;

public class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        Console.Write("Enter First Number: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        num2 = double.Parse(Console.ReadLine());

        Calculator cal=new Calculator(num1, num2);
        Console.WriteLine($"{num1} + {num2} = {cal.Add()}");
        Console.WriteLine($"{num1} - {num2} = {cal.Subtract()}");
        Console.WriteLine($"{num1} * {num2} = {cal.Multiply()}");
        Console.WriteLine($"{num1} / {num2} = {cal.Divide()}");
    }
}