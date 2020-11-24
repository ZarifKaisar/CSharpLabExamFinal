using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    class Address
    {
        int buildingnumber, roadnumber;
        string thana, city;

        public int getbuildingbnumber
        {
            get { return buildingnumber; }
        }

        public int getroadnumber
        {
            get { return roadnumber; }
        }

        public string getthana
        {
            get { return thana; }
        }

        public string getcity
        {
            get { return city; }
        }

        
        public Address()
        {

        }

        public Address(int build, int rn, string th, string ct)
        {
            this.buildingnumber = build;
            this.roadnumber = rn;
            this.thana = th;
            this.city = ct;
        }

    }
}
