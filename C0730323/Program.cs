using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730323
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary", 3.5, 20);
            StudentInformation _John = new StudentInformation("John", 2.0, 10);
            StudentInformation _Mark = new StudentInformation("Mark", 0.2, 3);
            StudentInformation _steve = new StudentInformation("Steve", 2.9, 16);
            StudentInformation _Cindy = new StudentInformation("Cindy", 2.8, 18);

            var studentlist = new List<StudentInformation>();
            studentlist.Add(_Mary);
            studentlist.Add(_John);
            studentlist.Add(_Mark);
            studentlist.Add(_steve);
            studentlist.Add(_Cindy);
            foreach (var student in studentlist)
            {
                Console.WriteLine(student.NAME);
            }
                Console.ReadLine();
            }
        }
    }



    class StudentInformation


    {
        public string NAME;
        public double GPA;
        public int Attendence;
        public StudentInformation(string aNAME, double cGPA, int dAttendence)

        {
            NAME = aNAME;
            GPA = cGPA;
        Attendence = dAttendence;
            

        }
    }


    

