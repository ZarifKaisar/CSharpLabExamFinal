using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    class Member
    {
        protected string id, name, address;
        

        
        public static void GetAllDetails(Member m1)
        {
            if (m1 is Player)
            {
                Player p = (Player)m1;
                p.AllInfo();
                
                
            }
            else if(m1 is Staff)
            {
                Staff s = (Staff)m1;
                s.AllInfo();
                

            }
        }
    }
}
