using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{

    class Program
    {
        static void Main(string[] args)
        {
            //Address(houseNO,roadNo,area,district) 

            Address a1 = new Address(2, 5, "Uttara", "Dhaka");
            Address a2 = new Address(3, 15, "Banani", "Dhaka");

            string a3 = a1.getbuildingbnumber.ToString() +", " + a1.getroadnumber.ToString() + ", " + a1.getthana + ", " + a1.getcity;
            string a4 = a2.getbuildingbnumber.ToString() + ", " + a2.getroadnumber.ToString() + ", " + a2.getthana + ", " + a2.getcity;

            Staff s = new Staff("ST-000", "BRUCE", a3, "Coach");

            Player[] list = new Player[2];
            list[0] = new Player("PL-000", "TONY", a3, 10000, "Striker", 87);
            list[1] = new Player("PL-000", "CLERK" , a4, 14000 , "Defender" , 71);

            Player p1 = list[0];
            Player p2 = list[1];

            Player.setplaystatus(p1);
            Player.setplaystatus(p2);
            

            for (int i = 0; i < list.Length; i++)
            {
                if (s.PlayerStatus(list[i]) == true)
                      Member.GetAllDetails(list[i]);
        }
            Member.GetAllDetails(s);         
 
            ClubCommittee cc = new ClubCommittee();
            cc.AddMember(s);
            cc.AddMember(p1);
 
            cc.AddMember(p2);

            ClubCommittee.TotalCommittee();

            Console.ReadKey();
        }
    }
}
