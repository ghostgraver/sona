using System.Runtime.InteropServices;

namespace sona;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        a = 2;
        a = 3;
        a = 4;
        a = 5;
        Console.WriteLine("Hello, World!");
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Console.ReadLine();
        }
    }
}