using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnteRolf
{
    class Demo
    {
        public static void HejPaDaj()
        {
            Console.WriteLine("Tjosan!");
        }

        public Demo(int id, string name )
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
        public string writeHello()
        {
            return "Hello " + Name;
        }
    }
}
