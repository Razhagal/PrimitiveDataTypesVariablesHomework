using System;
class IsoscelesTriangle
{
    static void Main()
    {
        //Change the output encoding!
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //cr - copy right
        char cr = (char)0x00A9;
        //{0} - placeholder
        Console.WriteLine("   {0}", cr);
        Console.WriteLine("  {0} {0}", cr);
        Console.WriteLine(" {0}   {0}", cr);
        Console.WriteLine("{0} {0} {0} {0}", cr);
    }
}
