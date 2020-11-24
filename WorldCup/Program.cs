using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Coach c = new Coach("HC", "T", 4.5);
            Player[] p = new Player[4];
            p[0] = new Player("A", "W", 87, 31, "Striker");
            p[1] = new Player("B", "X", 60, 38, "Striker");
            p[2] = new Player("C", "Y", 73, 19, "Striker");
            p[3] = new Player("D", "Z", 92, 47, "Striker");

            for (int i = 0; i < p.Length; i++)
            {
                if(i==0)
                {
                    Console.WriteLine("Eligible Players: ");
                    Console.WriteLine("");
                }
                if (c.PlayerStatus(p[i]) == true)
                    Person.ShowDetails(p[i]);

            }

            Console.WriteLine("The Coach: ");
            Console.WriteLine("");
            Person.ShowDetails(c);

            Console.ReadKey();

        }
    }


}
