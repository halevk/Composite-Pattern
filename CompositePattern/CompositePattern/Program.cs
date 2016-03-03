using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var com = new Computer();

            var mb = new MotherBoard("abc mother board", 500);
            var rm = new Ram("2048 Mb ram", 300);
            var hdd = new HDD("256 GB HDD", 500);
            var cpu = new CPU("intel i7 ", 500);

            mb.Add(rm);
            mb.Add(hdd);
            mb.Add(cpu);

            com.Add(mb);

            Console.WriteLine(com.Price);

        }
    }
}
