using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    class Player: Person
    {

        int noofgoal;
        string playingposition;
        static int pidcount = -1;
        private int performancerate;

        public int Noofgoal
        {
            get { return noofgoal; }
        }

        public int Performancerate
        {
            get { return performancerate; }
        }
        

        public Player()
        {
            pidcount++;
            string pid = "";
            if (pidcount < 10)
            {
                pid = "000" + Convert.ToString(pidcount);
            }
            else if (pidcount < 100 && pidcount > 9)
            {
                pid = "00" + Convert.ToString(pidcount);
            }
            else if (pidcount < 1000 && pidcount > 99)
            {
                pid = "0" + Convert.ToString(pidcount);
            }
            else if (pidcount > 999)
            {
                pid = Convert.ToString(pidcount);
            }
            this.id = "PL-" + pid;
        }

        public Player(string name, string address, int pfrate, int ngoal, string plpos)
        {
            pidcount++;
            string pid = "";
            if (pidcount < 10)
            {
                pid = "000" + Convert.ToString(pidcount);
            }
            else if (pidcount < 100 && pidcount > 9)
            {
                pid = "00" + Convert.ToString(pidcount);
            }
            else if (pidcount < 1000 && pidcount > 99)
            {
                pid = "0" + Convert.ToString(pidcount);
            }
            else if (pidcount > 999)
            {
                pid = Convert.ToString(pidcount);
            }
            this.id = "PL-" + pid;
            this.name = name;
            this.address = address;
            this.performancerate = pfrate;
            this.noofgoal = ngoal;
            this.playingposition = plpos;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Player's ID: " + id);
            Console.WriteLine("Player's Name: " + name);
            Console.WriteLine("Player's Address: " + address);
            Console.WriteLine("Player's Performance: "+ performancerate + "%");
            Console.WriteLine("Player's No. of Goals: "+ noofgoal);
            Console.WriteLine("");
        }



    }
}
