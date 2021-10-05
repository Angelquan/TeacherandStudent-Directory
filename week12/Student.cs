using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12
{
    class Student : Person
    {
        public Student(int iDz, string fn, string add, string major, string advisor)  : base (iDz,  fn, add)
        {
            Major1 = major;
            Counselor = advisor;
        }

        public String Major1 { get; set; }
        public String Counselor { get; set; }
    }
}
