using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    class Person
    {
       protected string id, name, address;

        /*public static void ShowDetails(Player p1)
        {
            p1.ShowInfo();
        }*/

        public static void ShowDetails(Person p1)
        {
            if (p1 is Player)
            {
                Player p = (Player)p1;
                p.ShowInfo();
                

            }
            else if(p1 is Coach)
            {
                Coach p = (Coach)p1;
                p.ShowInfo();
                
            }
        }

        /*public static void ShowDetails(Coach c1)
        {
            c1.ShowInfo();
        }*/
    }
}
