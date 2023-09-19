using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OOP4
{
    class Program
    {
        //encapsulation
        private static int pilihan;
        //metod non void
        public int getpilihan()
        {
            pilihan = Convert.ToInt32(Console.ReadLine());
            return pilihan;
        }
        //metod void
        static void Main(string[] args)
        {
            //object
            Fitur masuk = new Fitur();
            masuk.utama();
            Console.ReadKey();
        }
    }
}
