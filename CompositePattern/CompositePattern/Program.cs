using System;
using System.Collections.Generic;
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
            
            var computer=new Computer(){ Name = "Asus KJ51"};

            var board = new MotherBoard() {Name = "ASX 1254 board", Price = 500};

            board.Add(new Ram(){Name = "Kingston 2048 mb ram", Price = 240.5m});
            board.Add(new Hdd(){Name = "Kingstone 250 Gb SSD", Price = 350});

            computer.Add(board);

            var price = computer.GetPrice();

            Console.WriteLine(string.Format("Total:{0} $", price));
            Console.ReadLine();
        }
    }


    public class Computer : ContainerBase
    {
        public override decimal GetPrice()
        {
            return base.Components.Sum(i => i.GetPrice()) + this.Price;
        }
    }

    public class MotherBoard : ContainerBase
    {
        public override decimal GetPrice()
        {
            return base.Components.Sum(o => o.GetPrice()) + this.Price;
        }
    }

    public class Ram : ComponentBase
    {
        
    }


    public class Hdd : ComponentBase
    {
        
    }


    

}
