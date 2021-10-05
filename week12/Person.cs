using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12
{
    class Person
    {
        public Person(int idNum, string fullName, string address)
        {
            IdenNum = idNum;
            LegalName = fullName;
            Addy = address;
        }

        public int IdenNum { get; set; }
        public string LegalName { get; set; }
        public string Addy { get; set; }

    }
}
