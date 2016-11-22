using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TestHouse
    {
        static void Main(string[] args)
        {
            House house = new House();

            house.BldType = "single family";
            string housetype = house.BldType;

            house.Name = "mi casa";
            string waffle = house.Name;


            Console.WriteLine($"{housetype} : {waffle}");
            Console.ReadLine();
        }
    }

}
