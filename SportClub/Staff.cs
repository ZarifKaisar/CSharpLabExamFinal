using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    class Staff: Member
    {
        string position;
        public Staff()
        {

        }

        public Staff(string id, string name, string address, string position)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.position = position;

        }

        public bool PlayerStatus(Player p)
        {
            bool eligiblility;
            if(p.CurrentRank >= 75 && p.CurrentRank <= 100)
            {
                eligiblility = true;
            }
            else
            {
                eligiblility = false;
            }

            return eligiblility;
            
        }

        public void AllInfo()
        {
            Console.WriteLine("Staff's ID: "+ id);
            Console.WriteLine("Staff's Name: "+ name);
            Console.WriteLine("Staff's Address: "+ address);
            Console.WriteLine("Staff's Position: "+ position);
            Console.WriteLine("");

        }
    }
}
