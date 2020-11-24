using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    interface ISchool
    {
        bool Add(string id, string name);
        bool Remove(string id);

        bool Update(string id, double cgpa);
    }
}
