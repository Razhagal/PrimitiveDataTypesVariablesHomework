using System;
class CompareFloats
{
    static void Main()
    {
        double esp = 0.000001;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool checker = Math.Abs(a - b) < esp; //Math.Abs takes the absolute difference between the two numbers

        Console.WriteLine(checker);
    }
}
