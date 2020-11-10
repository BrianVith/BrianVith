using System;
using System.Runtime.Intrinsics.X86;

namespace Morgengry
{

    class Program
    {
        static void Main(string[] args)
        {
            Amulet amu = new Amulet("1");

            Console.WriteLine(amu);



            //Controller ct = new Controller();
            //ct.ValuableRepo.AddValuable(new Book("1"));
            //ct.ValuableRepo.Save();
            //ct.ValuableRepo.Load();
        }
    }
}
