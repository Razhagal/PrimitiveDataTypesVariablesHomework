using System;
class ASCIITable
{
    static void Main()
    {
        //Default ASCII = 127 characters
        for (int i = 0; i <= 127; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}
