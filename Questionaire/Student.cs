using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApplication12;

namespace Questionaire
{
    class student
    {
        public int id;

        public string pass;
        public course[]cor=new course[20];
        //public course course2;
        //public course course3;
        //public course course4;
        //public course course5;
        //public course course6;
        public bool g = false;

        public student()
        {
            for (int i = 0; i < 20; i++)
            {
                cor[i] = new course();
            }
            //    course1 = new course();
            //course2 = new course();
            //course3 = new course();
            //course4 = new course();
            //course5 = new course();
            //course6 = new course();
        }
        public void check(int x, string y, student[] s)
        {

            for (int i = 0; i < 15; i++)
            {
                if (s[i].g == false)
                {
                    if (x == s[i].id)
                    {
                        if (y == s[i].pass)
                        {
                            // survey(s[i].level);
                            course cou = new course();
                            //Console.WriteLine(i);
                            cou.survey(s[i]);

                            // s[i].g = true;

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("sorry your password doesn't fit your id , you can't fill the survey!!");
                        }
                    }

                }

            }
        }
    }
}
