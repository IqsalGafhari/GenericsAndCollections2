using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    //Abstraction
    public abstract class Abstract
    {
        protected List<string> user = new List<string>() { "admin", "admin" };
        protected List<string> password = new List<string>() { "admin123", "admin123" };
        protected List<string> namabuku = new List<string>() { "Matematika", "Fisika" };
        protected List<int> tahun = new List<int>() { 2015, 2016 };
        protected List<string> penulis = new List<string>() { "Andi", "Budi" };
        

        //Polymorph override
        public virtual void Daftarnasabah(List<string> daftarbuku, List<int> tahun, List<string> penulis)
        {
            Console.Clear();
            Console.WriteLine("Daftar Buku");
            Console.WriteLine("");
            int b = daftarbuku.Count;
            for (int a = 0; a < b; a++)
            {
                Console.WriteLine("ID [" + (a + 1) + "]");
                Console.WriteLine("Title :" + daftarbuku[a]);
                Console.WriteLine("Publication Year : " + tahun[a]);
                Console.WriteLine("Author: " + penulis[a]);
                Console.WriteLine(" ");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
            }
        }

        //Polymorph overload
        public void Daftarnasabah(List<string> daftarbuku, List<int> tahun, List<string> penulis, int a)
        {
            Console.Clear();
            Console.WriteLine("Data Buku");
            Console.WriteLine("");
            Console.WriteLine("ID [" + (a + 1) + "]");
            Console.WriteLine();
            Console.WriteLine("Title :" + daftarbuku[a]);
            Console.WriteLine("Publication Year : " + tahun[a]);
            Console.WriteLine("Author: " + penulis[a]);
            
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
        }
    }
}