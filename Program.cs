using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosen
{
    class Program
    {
        static void Main(string[] args)
        {
            dosen dosenku = new dosen(1, "Kamarudin", 21114314, "Laki-laki", "Pemrograman");
            dosenku.hasil();
            Console.WriteLine();
            dosenku.attDosen();
            dosenku.addcourse();
            Console.WriteLine();
            dosenku.akhir();


            Console.ReadKey();
        }
    }
}
