using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    abstract class AbsStudent
    {
        public abstract string ID { get; }
        public abstract string Name { get; set; }

        public abstract double Cgpa { get; }

        public abstract void print();
    }
}
