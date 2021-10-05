using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12
{
    class Teacher: Person
    {
        public Teacher(int iDz, string fn, string add, int money, int yrofService) : base(iDz, fn, add)
        {
            Salary = money;
            YearsofService = yrofService;
        }

        public int Salary { get; set; }
        public int YearsofService { get; set; }
    }
}
