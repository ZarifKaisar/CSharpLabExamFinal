using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{

    class Player : Member
    {
        double salary;
        string playingposition;
        int currentRank;
        bool playingStatus;


        public static void setplaystatus(Player p)
        {
            
            Staff s1 = new Staff();
            p.playingStatus = s1.PlayerStatus(p);
        }

        
        

        public int CurrentRank
        {
            get { return currentRank; }
        }

        public Player()
        {

        }

        public Player(string id, string name, string address, double sal, string playpos, int cr)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.salary = sal;
            this.playingposition = playpos;
            this.currentRank = cr;
            
        }

        public void AllInfo()
        {
            Console.WriteLine("Player's ID: "+ id);
            Console.WriteLine("Player's Name: "+ name);
            Console.WriteLine("Player's Address: "+ address);
            Console.WriteLine("Player's Salary: "+ salary);
            Console.WriteLine("Player's Playing Position: "+ playingposition);
            Console.WriteLine("Player's Current Ranlk: "+ currentRank);
            Console.WriteLine("Player's Play Status: "+ playingStatus);
            Console.WriteLine("");
        }
    }
}
