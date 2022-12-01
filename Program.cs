using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                         canlilar 
            //             bitkiler               hayvanlar 
            //      tohumlu    tohumsuz      kuslar     surungenler 


            tohumluBitkiler tohumluBitki = new tohumluBitkiler();
            tohumluBitki.tohumlaCogalma();
            Console.WriteLine("****************");
            kuslar marti = new kuslar();
            marti.ucmak();




            Console.ReadLine();
        }
    }
}
