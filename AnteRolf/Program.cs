using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnteRolf
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDemo = new Demo(1,"Adam");
            Console.WriteLine("Welcome to my Git-Demo");

            Console.WriteLine(myDemo.writeHello());

            Demo.HejPaDaj();
            Console.WriteLine("Dags att åka hem?");

            Console.WriteLine("hepp - Rolfs nya bransch");
        }
    }
}
