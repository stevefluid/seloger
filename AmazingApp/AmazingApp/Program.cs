using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("This app is amazing with amazing animals");
            IAmazingAnimals grumpy = new OctoCat("Grumpy");
            System.Console.WriteLine("Grumpy just joined us.");
            System.Console.WriteLine("Grumpy says : '{0}'", grumpy.says());
            System.Console.WriteLine("Say good by to the amazing animals");
            var goodBy = System.Console.ReadLine();
        }
    }
}
