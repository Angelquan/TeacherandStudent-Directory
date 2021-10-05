using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace week12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            List<Student> studentlist = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();

            WriteLine("Hello Welcome to the Teacher/Student Roster \n");
            WriteLine("How Many students would you like to enter?");
            int studentcount = Convert.ToInt32(ReadLine());

            for (int x = 0; x < studentcount; ++x)
            {
                WriteLine("please enter their ID number");
                int idNum = Convert.ToInt32(ReadLine());
                WriteLine("PLease enter their full name");
                string fullname = ReadLine();
                WriteLine("Please enter their address");
                string address = ReadLine();
                WriteLine("What is their Major?");
                string major = ReadLine();
                WriteLine("Who is their advisor?");
                string advisor = ReadLine();


               
                studentlist.Add(new Student(idNum, fullname, address, major, advisor));
            }

            WriteLine("ID\tLegalName\tAddress\tMajor1\tAdvisor");
            foreach (Student co in studentlist)
                
                WriteLine(co.IdenNum + "\t" + co.LegalName + "\t" + co.Addy + "\t" + co.Major1 + "\t"+co.Counselor);

            WriteLine(" How Many teachers would you like to enter?");
            int teachercount = Convert.ToInt32(ReadLine());
            for (int y = 0; y < teachercount; ++y)
            {
                WriteLine("please enter their ID number");
                int idNum = Convert.ToInt32(ReadLine());
                WriteLine("PLease enter their full name");
                string fullname = ReadLine();
                WriteLine("Please enter their address");
                string address = ReadLine();
                WriteLine("What is their Salary?");
                int money = Convert.ToInt32(ReadLine());
                WriteLine("How many years of service have they had?");
                int yrofService = Convert.ToInt32( ReadLine());

                teacherList.Add(new Teacher(idNum, fullname, address, money, yrofService));
            }
            WriteLine("ID\tLegalName\tAddress\tsalary\tYOS");

            foreach (Person ac in personList)
                WriteLine(ac.LegalName + "\t" + ac.IdenNum + "\t" + ac.Addy);

           
            ReadKey();
        }
    }
}
