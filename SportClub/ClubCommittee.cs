using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    class ClubCommittee
    {
        static Member[] mlist = new Member[100];
        static int count;

        public ClubCommittee()
        {

        }
        public void AddMember(Member mem)
        {
            mlist[++count] = mem;
        }

        public static void TotalCommittee()
        {
            Console.WriteLine("Total Committee: ");
            Console.WriteLine("");
            for (int i=0; i<mlist.Length;i++)
            {
                Member.GetAllDetails(mlist[i]);
            }
        }
    }
}
