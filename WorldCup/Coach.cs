using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    class Coach: Person
    {
        
        double experience;
        static int cidcount = -1;

        public double Experience { get => experience; }

        public Coach()
        {
            cidcount++;
            string cid = "";
            if (cidcount < 10)
            {
                cid = "00" + Convert.ToString(cidcount);
            }
            else if (cidcount < 100 && cidcount > 9)
            {
                cid = "0" + Convert.ToString(cidcount);
            }
            else if (cidcount < 1000 && cidcount > 99)
            {
                cid = Convert.ToString(cidcount);
            }

            this.id = "SC-" + cid + "-18";
        }

        public Coach(string name, string address, double experience)
        {
            cidcount++;
            string cid = "";
            if (cidcount < 10)
            {
                cid = "00" + Convert.ToString(cidcount);
            }
            else if (cidcount < 100 && cidcount > 9)
            {
                cid = "0" + Convert.ToString(cidcount);
            }
            else if (cidcount < 1000 && cidcount > 99)
            {
                cid = Convert.ToString(cidcount);
            }

            this.id = "SC-" + cid + "-18";

            this.name = name;
            this.address = address;
            this.experience = experience;
        }

        public bool PlayerStatus(Player pl)
        {

            bool k;
            if (pl.Performancerate >= 75 && pl.Performancerate <= 100 && pl.Noofgoal > 20)
            {
                k = true;
            }
            else
            {
                k = false;
            }

            /*Person.ShowDetails(pl);

            

            if(k == true)
            {
                Console.WriteLine("Player Eligible");
            }
            else
            {
                Console.WriteLine("Player Not Eligible");
            }

            Console.WriteLine("");*/

            return k;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Coach's ID: "+ id);
            Console.WriteLine("Coach's Name: " + name);
            Console.WriteLine("Coach's Address: " + address);
            Console.WriteLine("Coach's Experience: " + Experience);
            Console.WriteLine("");
        }




    }
}
