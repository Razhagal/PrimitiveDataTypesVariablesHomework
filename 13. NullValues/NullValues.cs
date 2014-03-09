using System;
class NullValues
{
    static void Main()
    {
        int? integerNum = null;
        double? doubleNum = null;
        Console.WriteLine("Here are both variables with null literals:");
        Console.WriteLine(integerNum);
        Console.WriteLine(doubleNum);

        integerNum = 5;
        doubleNum = 2.5;
        Console.WriteLine("Here are both variables with values asigned to them:");
        Console.WriteLine(integerNum);
        Console.WriteLine(doubleNum);

    }
}
