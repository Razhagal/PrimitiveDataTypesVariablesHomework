using System;
class UnicodeValue
{
    static void Main()
    {
        //decimal 72 = 48 in hex
        //(char)72 will do the same
        //Source - ASCII table
        char letter = (char)0x48;
        Console.WriteLine(letter);
    }
}
