using System;
class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";

        object box = hello + " " + world;
        string result = (string)box;
        Console.WriteLine(result);
    }
}
