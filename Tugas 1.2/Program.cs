using System;

namespace BelajarCSHARP
{
    class ProgramHW
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama kamu siapa? ");
            
            string nama = Console.ReadLine();
            Console.WriteLine("Nama kamu : " + nama);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}