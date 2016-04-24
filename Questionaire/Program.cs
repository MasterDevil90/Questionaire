using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Questionaire;

namespace ConsoleApplication12
{

    
    class course
    {
        doctor d;
        public void setDoctor(doctor c)
        {
            d = c;
        }
        public doctor getDoctr()
        {
            return d;
        }
        Ta t;
        public void setTa(Ta c)
        {
            t = c;
        }
        public Ta getTa()
        {
            return t;
        }


        public int excelent;
        public int vgood;
        public int good;
        public int bad;

        string name;
        string code;

        public void survey(student s)
        {
            if (true)
            {
                int x;
                Console.ForegroundColor = ConsoleColor.Cyan;
                /*if (code[0] == 1)
                {
                    Console.WriteLine("subjects\n1- Arabic Language  2- Introduction to Computer Applications  3-Introduction to Computer Programming  4- English Language I  5- Calculus I  6- Physics I\n\n enter the number of the subject you want ");
                }
                if (code[0] == 2)
                {
                    Console.WriteLine("subjects\n1- Structured Programming  2-English Language II  3- Behavior Psychology  4-Fundamentals of Information Sys.  5-Calculus II.  6-Physcis II.\n\n enter the number of the subject you want ");
                }
                if (code[0] == 3)
                {
                    Console.WriteLine("subjects\n1- Data Structures  2-Logic Design  3- English Language III  4- Scientific Thinking  5- Linear Algebra  6- Discrete Mathematics\n\n enter the number of the subject you want ");
                }
                if (code[0] == 4)
                {
                    Console.WriteLine("subjects\n1-concept  2- Object-Oriented Programming  3- Operating Systems I  4- Electronics For Computers  5-  Applied Prob. and Statistics  6- operation research\n\n enter the number of the subject you want ");
                }
                if (code[0] == 5)
                {
                    Console.WriteLine("subjects\n1-file organization  2-software engenering  3-modern and development toles  4-compiler  5-algorithm  6-computer archetecture\n\n enter the number of the subject you want ");
                }
                if (code[0] == 6)
                {
                     Console.WriteLine("subjects\n1- Data Communication and Networking  2- System Programming and Assembley Lang.  3-Introduction to Artificial Intelligence  4-Introduction to Database  5-numerical methods  6-  Computer Graphics\n\n enter the number of the subject you want ");
                }
                if (code[0] == 7)
                {
                    Console.WriteLine("subjects\n1-Selected Topics in Computer Science  2- Pattern Recognition  3- Computer Interface and Multimedia Systems  4- Senior CS Project I.  5- Introduction to Advertising  6- Human Anatomy I  7-  Medical Biochemistry I (Elective)\n\n enter the number of the subject you want ");
                }
                if (code[0]== 8)
                {
                    Console.WriteLine("subjects\n1- Computer Science Seminar  2-Senior CS Project II.  3-Modeling and Simulation  4- Systems Analysis & Design  5- Electronic Commerce\n\n enter the number of the subject you want ");
                }*/
                for (int j = 1; j <= 6; j++)
                {
                    Console.WriteLine(s.cor[j].name + "   dr." + " " + s.cor[j].getDoctr().name);
                }
                //Console.WriteLine(s.cor[2].name + "   dr." + " " + s.cor[2].getDoctr().name);
                //Console.WriteLine(s.cor[3].name + "   dr." + " " + s.cor[3].getDoctr().name);
                //Console.WriteLine(s.cor[4].name + "   dr." + " " + s.cor[4].getDoctr().name);
                //Console.WriteLine(s.cor[5].name + "   dr." + " " + s.cor[5].getDoctr().name);
                //Console.WriteLine(s.cor[6].name + "   dr." + " " + s.cor[6].getDoctr().name);

                Console.WriteLine("enter the number of course ");

                Console.ForegroundColor = ConsoleColor.White;
                int subject = Convert.ToInt32(Console.ReadLine());
                if (true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int j = 1; j <= 6; j++)
                    {
                        if (subject == j)
                            Console.WriteLine((s.cor[j].name) + " " + (s.cor[j].code) + "\n\n");
                    }

                    //if (subject == 1)
                    //    Console.WriteLine((s.cor[1].name) + " " + (s.cor[1].code) + "\n\n");
                    //if (subject == 2)
                    //    Console.WriteLine((s.cor[2].name) + " " + (s.cor[2].code) + "\n\n");
                    //if (subject == 3)
                    //    Console.WriteLine((s.cor[3].name) + " " + (s.cor[3].code) + "\n\n");
                    //if (subject == 4)
                    //    Console.WriteLine((s.cor[4].name) + " " + (s.cor[4].code) + "\n\n");
                    //if (subject == 5)
                    //    Console.WriteLine((s.cor[5].name) + " " + (s.cor[5].code) + "\n\n");
                    //if (subject == 6)
                    //    Console.WriteLine((s.cor[6].name) + " " + (s.cor[6].code) + "\n\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("quistionaire roles : for excelent press 1 for vgood press 2 fpr good press 3 for bad press 4 \n");
                    Console.WriteLine("The Lecture:\n");

                    Boolean flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" Allows opportunities for asking questions");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Has an effective lecture delivery");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Has good rapport with learners");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Is approachable and friendly");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Is respectful towards students");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Is able to teach at the students’ level");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Enables easy note-taking");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Provides useful handouts of notes");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Would help students by providing printed notes");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Has a wide subject knowledge");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Maintains student interest during lectures");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Gives varied and lively lectures");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Is clear and comprehensible in lectures");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Gives lectures which are too fast to take in");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Gives audible lectures");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }
                    flag = false;
                    while (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Gives structured and organised lectures");
                        Console.ForegroundColor = ConsoleColor.White;
                        x = Convert.ToInt32(Console.ReadLine());
                        flag = quistioner(x);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    total_rate(excelent * 4, vgood * 3, good * 2, bad * 1);

                }
            }
        }

        public Boolean quistioner(int x)
        {

            if (x == 1)
            {
                excelent++;

            }
            else if (x == 2)
            {
                vgood++;

            }
            else if (x == 3)
            {
                good++;

            }
            else if (x == 4)
            {
                bad++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid INPUT");
                return false;
            }
            return true;
        }

        static void total_rate(int excelent, int vgood, int good, int bad)
        {
            int sum = excelent + vgood + good + bad;
            if (sum < 28)
            {
                Console.WriteLine("\n\ntotal rate is bad\n\n");
            }
            else if (sum >= 28)
            {
                if (sum < 40)
                {
                    Console.WriteLine("\n\ntotal rate is good\n\n");
                }
                else if (sum >= 40)
                {
                    if (sum < 52)
                    {
                        Console.WriteLine("\n\ntotal rate is vgood\n\n");
                    }
                    else if (sum >= 52)
                    {
                        if (sum <= 64)
                        {
                            Console.WriteLine("\n\ntotal rate is excellent\n\n");
                        }
                    }

                }

            }
        }
        class program
        {
            //source of the quistions "http://www.economicsnetwork.ac.uk/handbook/questionnaires/5"
            //source of how to change the font color "http://www.dotnetperls.com/console-color" 
            //rating (bad=1point good=2points vgood=3points excellent=4points) worest case(all are bad )=16 the max case (all are excellent)=64 , 12 point between each other
            //if we want the second method of rating change all "total_rate(excelent*4, vgood*3, good*2, bad*1);" to "total_rate(excelent, vgood, good, bad);"



        }




        static void Main(string[] args)
        {
            int[] id = new int[15];

            string[] pass = new string[15];
            student[] s = new student[15];
            for (int j = 0; j <= 14; j++)
            {
                s[j] = new student();
            }
            //s[1] = new student();
            //s[2] = new student();
            //s[3] = new student();
            //s[4] = new student();
            //s[5] = new student();
            //s[6] = new student();
            //s[7] = new student();
            //s[8] = new student();
            //s[9] = new student();
            //s[10] = new student();
            //s[11] = new student();
            //s[12] = new student();
            //s[13] = new student();
            //s[14] = new student();
            s[0].id = Convert.ToInt32(7);
            s[1].id = Convert.ToInt32(5);
            s[2].id = Convert.ToInt32(6);
            s[3].id = Convert.ToInt32(8);
            s[4].id = Convert.ToInt32(43190);
            s[5].id = Convert.ToInt32(44627);
            s[6].id = Convert.ToInt32(45931);
            s[7].id = Convert.ToInt32(458);
            s[8].id = Convert.ToInt32(4587);
            s[9].id = Convert.ToInt32(4582);
            s[10].id = Convert.ToInt32(232);
            s[11].id = Convert.ToInt32(124);
            s[12].id = Convert.ToInt32(159);
            s[13].id = Convert.ToInt32(147);
            s[14].id = Convert.ToInt32(111);
            s[0].pass = "a1b1";
            s[1].pass = "a2b2";
            s[2].pass = "a3b3";
            s[3].pass = "a4b4";
            s[4].pass = "a5b5";
            s[5].pass = "a6b6";
            s[6].pass = "a7b7";
            s[7].pass = "a8b8";
            s[8].pass = "a9b9";
            s[9].pass = "a10b10";
            s[10].pass = "a11b11";
            s[11].pass = "a12b12";
            s[12].pass = "a13b13";
            s[13].pass = "a14b14";
            s[14].pass = "a15b15";


            doctor d85 = new doctor();
            doctor d86 = new doctor();
            doctor d87 = new doctor();
            doctor d88 = new doctor();
            doctor d89 = new doctor();
            doctor d90 = new doctor();

            d85.name = "mohamed";
            d86.name = "ibrahim";
            d87.name = "essam";
            d88.name = "alaa";
            d89.name = "yasser";
            d90.name = "howida";

            s[0].cor[1].name = ("1-arabic language");
            s[0].cor[2].name = ("2-Introduction to Computer Aplication");
            s[0].cor[3].name = ("3-Introduction to Computer Programming ");
            s[0].cor[4].name = ("4- English Language I");
            s[0].cor[5].name = ("5-Calculus I");
            s[0].cor[6].name = ("6-PhysicsI");
            s[0].cor[1].setDoctor(d85);
            s[0].cor[2].setDoctor(d86);
            s[0].cor[3].setDoctor(d87);
            s[0].cor[4].setDoctor(d88);
            s[0].cor[5].setDoctor(d89);
            s[0].cor[6].setDoctor(d90);
            s[0].cor[1].code = "ARAB 101";
            s[0].cor[2].code = "COMP 101";
            s[0].cor[3].code = "CS 101";
            s[0].cor[4].code = "ENG 101";
            s[0].cor[5].code = "MATH 101";
            s[0].cor[6].code = "PHY 101";
            doctor d79 = new doctor();
            doctor d80 = new doctor();
            doctor d81 = new doctor();
            doctor d82 = new doctor();
            doctor d83 = new doctor();
            doctor d84 = new doctor();
            d79.name = "yasser";
            d80.name = "essam";
            d81.name = "alaa";
            d82.name = "howida";
            d83.name = "ibrahim";
            d84.name = "mohamed";

            s[1].cor[1].name = ("1- Structured Programming ");
            s[1].cor[2].name = ("2-English Language II");
            s[1].cor[3].name = ("3- Behavior Psychology  ");
            s[1].cor[4].name = (" 4-Fundamentals of Information Sys");
            s[1].cor[5].name = ("5-Calculus II");
            s[1].cor[6].name = (" 6-Physcis II");
            s[1].cor[1].setDoctor(d79);
            s[1].cor[2].setDoctor(d80);
            s[1].cor[3].setDoctor(d81);
            s[1].cor[4].setDoctor(d82);
            s[1].cor[5].setDoctor(d83);
            s[1].cor[6].setDoctor(d84);
            s[1].cor[1].code = "CS 102";
            s[1].cor[2].code = "ENG 102";
            s[1].cor[3].code = "HUM 101";
            s[1].cor[4].code = "IS 101";
            s[1].cor[5].code = "MATH 102";
            s[1].cor[6].code = "PHY 102";

            doctor d73 = new doctor();
            doctor d74 = new doctor();
            doctor d75 = new doctor();
            doctor d76 = new doctor();
            doctor d77 = new doctor();
            doctor d78 = new doctor();

            d73.name = "howida";
            d74.name = "ibrahim";
            d75.name = "essam";
            d76.name = "alaa";
            d77.name = "mohamed";
            d78.name = "khafagy";

            s[2].cor[1].name = ("1- Data Structures");
            s[2].cor[2].name = ("2-Logic Design  ");
            s[2].cor[3].name = ("3-English Language III  ");
            s[2].cor[4].name = (" 4- Scientific Thinking");
            s[2].cor[5].name = ("5- Linear Algebra");
            s[2].cor[6].name = (" 6- Discrete Mathematics");
            s[2].cor[1].setDoctor(d73);
            s[2].cor[2].setDoctor(d74);
            s[2].cor[3].setDoctor(d75);
            s[2].cor[4].setDoctor(d76);
            s[2].cor[5].setDoctor(d77);
            s[2].cor[6].setDoctor(d78);
            s[2].cor[1].code = "CS 201";
            s[2].cor[2].code = "ECE 202";
            s[2].cor[3].code = "ENG 201";
            s[2].cor[4].code = "HUM 102";
            s[2].cor[5].code = "MATH 241";
            s[2].cor[6].code = "MATH 251";

            doctor d67 = new doctor();
            doctor d68 = new doctor();
            doctor d69 = new doctor();
            doctor d70 = new doctor();
            doctor d71 = new doctor();
            doctor d72 = new doctor();

            d67.name = "howida";
            d68.name = "ibrahim";
            d69.name = "essam";
            d70.name = "alaa";
            d71.name = "yasser";
            d72.name = "mohamed";

            s[3].cor[1].name = ("1-concept");
            s[3].cor[2].name = ("2- Object-Oriented Programming ");
            s[3].cor[3].name = ("3-Operating Systems I ");
            s[3].cor[4].name = ("4-computer graphics ");
            s[3].cor[5].name = ("5-  Applied Prob. and Statistics ");
            s[3].cor[6].name = (" 6- operation research");
            s[3].cor[1].setDoctor(d67);
            s[3].cor[2].setDoctor(d68);
            s[3].cor[3].setDoctor(d69);
            s[3].cor[4].setDoctor(d70);
            s[3].cor[5].setDoctor(d71);
            s[3].cor[6].setDoctor(d72);
            s[3].cor[1].code = "CS 211";
            s[3].cor[2].code = "CS 212";
            s[3].cor[3].code = "CS 251";
            s[3].cor[4].code = "CS 402";
            s[3].cor[5].code = "MATH 301";
            s[3].cor[6].code = "ELECTIVE COURSE 1";

            doctor d61 = new doctor();
            doctor d62 = new doctor();
            doctor d63 = new doctor();
            doctor d64 = new doctor();
            doctor d65 = new doctor();
            doctor d66 = new doctor();
            d61.name = "essam";
            d62.name = "yasser";
            d63.name = "ibrahim";
            d64.name = "alaa";
            d65.name = "howida";
            d66.name = "mohamed";

            s[4].cor[1].name = ("1-file organization");
            s[4].cor[2].name = ("2-software engenering ");
            s[4].cor[3].name = ("3-modern and development toles");
            s[4].cor[4].name = ("4-compiler");
            s[4].cor[5].name = ("5-algorithm");
            s[4].cor[6].name = ("6-computer archetecture");
            s[4].cor[1].setDoctor(d61);
            s[4].cor[2].setDoctor(d62);
            s[4].cor[3].setDoctor(d63);
            s[4].cor[4].setDoctor(d64);
            s[4].cor[5].setDoctor(d65);
            s[4].cor[6].setDoctor(d66);
            s[4].cor[1].code = "IS 311";
            s[4].cor[2].code = "CS 341";
            s[4].cor[3].code = "CS 312";
            s[4].cor[4].code = "CS 311";
            s[4].cor[5].code = "cs 331";
            s[4].cor[6].code = "CS 381";

            doctor d55 = new doctor();
            doctor d56 = new doctor();
            doctor d57 = new doctor();
            doctor d58 = new doctor();
            doctor d59 = new doctor();
            doctor d60 = new doctor();
            d55.name = "alaa";
            d56.name = "mohamed";
            d57.name = "ibrahim";
            d58.name = "howida";
            d59.name = "essam";
            d60.name = "yasser";

            s[5].cor[1].name = ("1- Data Communication and Networking  ");
            s[5].cor[2].name = ("2- System Programming and Assembley Lang.");
            s[5].cor[3].name = ("3-Introduction to Artificial Intelligence ");
            s[5].cor[4].name = ("4-Introduction to Database  ");
            s[5].cor[5].name = ("5-numerical methods ");
            s[5].cor[6].name = (" 6-ELECTIVE COURSE ");
            s[5].cor[1].setDoctor(d55);
            s[5].cor[2].setDoctor(d56);
            s[5].cor[3].setDoctor(d57);
            s[5].cor[4].setDoctor(d58);
            s[5].cor[5].setDoctor(d59);
            s[5].cor[6].setDoctor(d60);
            s[5].cor[1].code = "CS 301";
            s[5].cor[2].code = "CS 352";
            s[5].cor[3].code = "CS 361";
            s[5].cor[4].code = "IS 312";
            s[5].cor[5].code = "ELECTIVE COURSE 2";
            s[5].cor[6].code = "ELECTIVE COURSE 3";

            doctor d49 = new doctor();
            doctor d50 = new doctor();
            doctor d51 = new doctor();
            doctor d52 = new doctor();
            doctor d53 = new doctor();
            doctor d54 = new doctor();
            d49.name = "mohamed";
            d50.name = "essam";
            d51.name = "khafagy";
            d52.name = "ibrahim";
            d53.name = "howida";
            d54.name = "alaa";

            s[6].cor[1].name = ("1-Selected Topics in Computer Science  ");
            s[6].cor[2].name = ("2- Pattern Recognition ");
            s[6].cor[3].name = ("3- Computer Interface and Multimedia Systems ");
            s[6].cor[4].name = ("4- Senior CS Project I ");
            s[6].cor[5].name = ("5- Introduction to Advertising");
            s[6].cor[6].name = ("6- Human Anatomy I  ");
            s[6].cor[1].setDoctor(d49);
            s[6].cor[2].setDoctor(d50);
            s[6].cor[3].setDoctor(d51);
            s[6].cor[4].setDoctor(d52);
            s[6].cor[5].setDoctor(d53);
            s[6].cor[6].setDoctor(d54);
            s[6].cor[1].code = "CS 409";
            s[6].cor[2].code = "CS 481";
            s[6].cor[3].code = "CS 483";
            s[6].cor[4].code = "CS 498";
            s[6].cor[5].code = "ELECTIVE COURSE 4";
            s[6].cor[6].code = "ELECTIVE COURSE 5";

            doctor d43 = new doctor();
            doctor d44 = new doctor();
            doctor d45 = new doctor();
            doctor d46 = new doctor();
            doctor d47 = new doctor();
            doctor d48 = new doctor();
            d43.name = "howida";
            d44.name = "alaa";
            d45.name = "ibrahim";
            d46.name = "essam";
            d47.name = "mohamed";
            d48.name = "khafagy";

            s[7].cor[1].name = ("1- Computer Science Seminar");
            s[7].cor[2].name = ("2-Senior CS Project II. ");
            s[7].cor[3].name = ("3-Modeling and Simulation ");
            s[7].cor[4].name = ("4- Systems Analysis & Design ");
            s[7].cor[5].name = ("5- Electronic Commerce");
            s[7].cor[6].name = ("6- English Language");
            s[7].cor[1].setDoctor(d43);
            s[7].cor[2].setDoctor(d44);
            s[7].cor[3].setDoctor(d45);
            s[7].cor[4].setDoctor(d46);
            s[7].cor[5].setDoctor(d47);
            s[7].cor[6].setDoctor(d48);
            s[7].cor[1].code = "CS 401";
            s[7].cor[2].code = "CS 499";
            s[7].cor[3].code = "ELECTIVE COURSE 6";
            s[7].cor[4].code = "ELECTIVE COURSE 7";
            s[7].cor[5].code = "ELECTIVE COURSE 8";
            s[7].cor[6].code = "ELECTIVE COURSE 9";

            doctor d37 = new doctor();
            doctor d38 = new doctor();
            doctor d39 = new doctor();
            doctor d40 = new doctor();
            doctor d41 = new doctor();
            doctor d42 = new doctor();

            d37.name = "eslam";
            d38.name = "ibrahim";
            d39.name = "mohamed";
            d40.name = "howida";
            d41.name = "essam";
            d42.name = "alaa";
            s[8].cor[1].name = ("1- Computer Science Seminar");
            s[8].cor[2].name = ("2-Senior CS Project II. ");
            s[8].cor[3].name = ("3-Modeling and Simulation ");
            s[8].cor[4].name = ("4- Systems Analysis & Design ");
            s[8].cor[5].name = (" 5- Electronic Commerce");
            s[8].cor[6].name = ("6-Human Anatomy I  ");
            s[8].cor[1].setDoctor(d37);
            s[8].cor[2].setDoctor(d38);
            s[8].cor[3].setDoctor(d39);
            s[8].cor[4].setDoctor(d40);
            s[8].cor[5].setDoctor(d41);
            s[8].cor[6].setDoctor(d42);
            s[8].cor[1].code = "CS 401";
            s[8].cor[2].code = "CS 499";
            s[8].cor[3].code = "IS 331";
            s[8].cor[4].code = "IS 321";
            s[8].cor[5].code = "IS 301";
            s[8].cor[6].code = "ANAT 101";

            doctor d31 = new doctor();
            doctor d32 = new doctor();
            doctor d33 = new doctor();
            doctor d34 = new doctor();
            doctor d35 = new doctor();
            doctor d36 = new doctor();

            d31.name = "maged";
            d32.name = "yasser";
            d33.name = "mohamed";
            d34.name = "essam";
            d35.name = "ibrahim";
            d36.name = "howida";

            s[9].cor[1].name = ("1- Computer Science Seminar");
            s[9].cor[2].name = ("2- Structured Programming  ");
            s[9].cor[3].name = ("3-Modeling and Simulation ");
            s[9].cor[4].name = ("4-Fundamentals of Information Sys. ");
            s[9].cor[5].name = (" 5-Calculus II ");
            s[9].cor[6].name = ("6-English Language  I ");
            s[9].cor[1].setDoctor(d31);
            s[9].cor[2].setDoctor(d32);
            s[9].cor[3].setDoctor(d33);
            s[9].cor[4].setDoctor(d34);
            s[9].cor[5].setDoctor(d35);
            s[9].cor[6].setDoctor(d36);
            s[9].cor[1].code = "CS 401";
            s[9].cor[2].code = "CS 201";
            s[9].cor[3].code = "IS 331";
            s[9].cor[4].code = "ELECTIVE COURSE 9";
            s[9].cor[5].code = "MATH 102";
            s[9].cor[6].code = "ENG 101";

            doctor d25 = new doctor();
            doctor d26 = new doctor();
            doctor d27 = new doctor();
            doctor d28 = new doctor();
            doctor d29 = new doctor();
            doctor d30 = new doctor();
            d25.name = "sedky";
            d26.name = "alaa";
            d27.name = "howida";
            d28.name = "ibrahim";
            d29.name = "essam";
            d30.name = "yasser";

            s[10].cor[1].name = ("1-Electronics For Computers ");
            s[10].cor[2].name = ("2-Senior CS Project II. ");
            s[10].cor[3].name = ("3- Applied Prob. ");
            s[10].cor[4].name = ("4- Systems Analysis & Design ");
            s[10].cor[5].name = ("5- Electronic Commerce");
            s[10].cor[6].name = ("6-Arabic Language  ");
            s[10].cor[1].setDoctor(d25);
            s[10].cor[2].setDoctor(d26);
            s[10].cor[3].setDoctor(d27);
            s[10].cor[4].setDoctor(d28);
            s[10].cor[5].setDoctor(d29);
            s[10].cor[6].setDoctor(d30);
            s[10].cor[1].code = "CS 482";
            s[10].cor[2].code = "CS 499";
            s[10].cor[3].code = "MATH 301";
            s[10].cor[4].code = "IS 321";
            s[10].cor[5].code = "IS 301";
            s[10].cor[6].code = "ARAB 101";

            doctor d19 = new doctor();
            doctor d20 = new doctor();
            doctor d21 = new doctor();
            doctor d22 = new doctor();
            doctor d23 = new doctor();
            doctor d24 = new doctor();

            d19.name = "alaa";
            d20.name = "khafagy";
            d21.name = "ibrahim";
            d22.name = "hossam";
            d23.name = "howida";
            d24.name = "essam";

            s[11].cor[1].name = ("1- Data Communication and Networking");
            s[11].cor[2].name = ("2- Structured Programming ");
            s[11].cor[3].name = ("3-Modeling and Simulation ");
            s[11].cor[4].name = ("4-algorithm ");
            s[11].cor[5].name = ("5- Electronic Commerce");
            s[11].cor[6].name = ("6-operation research ");
            s[11].cor[1].setDoctor(d19);
            s[11].cor[2].setDoctor(d20);
            s[11].cor[3].setDoctor(d21);
            s[11].cor[4].setDoctor(d22);
            s[11].cor[5].setDoctor(d23);
            s[11].cor[6].setDoctor(d24);
            s[11].cor[1].code = "ELECTIVE COURSE 10";
            s[11].cor[2].code = "CS 201";
            s[11].cor[3].code = "IS 331";
            s[11].cor[4].code = "CS 331";
            s[11].cor[5].code = "IS 301";
            s[11].cor[6].code = "IS 321";

            doctor d13 = new doctor();
            doctor d14 = new doctor();
            doctor d15 = new doctor();
            doctor d16 = new doctor();
            doctor d17 = new doctor();
            doctor d18 = new doctor();
            d13.name = "howida";
            d14.name = "ibrahim";
            d15.name = "Essam";
            d16.name = "hossam";
            d17.name = "Alaa";
            d18.name = "mohamed";
            s[12].cor[1].name = ("1- Computer Graphics");
            s[12].cor[2].name = ("2-Senior CS Project II. ");
            s[12].cor[3].name = ("3-Linear Algebra ");
            s[12].cor[4].name = ("4- Systems Analysis & Design ");
            s[12].cor[5].name = ("5-Introduction to Engineering ");
            s[12].cor[6].name = ("6-Pattern Recognition ");
            s[12].cor[1].setDoctor(d13);
            s[12].cor[2].setDoctor(d14);
            s[12].cor[3].setDoctor(d15);
            s[12].cor[4].setDoctor(d16);
            s[12].cor[5].setDoctor(d17);
            s[12].cor[6].setDoctor(d18);
            s[12].cor[1].code = "CS 402";
            s[12].cor[2].code = "CS 499";
            s[12].cor[3].code = "MATH 241";
            s[12].cor[4].code = "IS 321";
            s[12].cor[5].code = "GE 101";
            s[12].cor[6].code = "CS 481";

            doctor d7 = new doctor();
            doctor d8 = new doctor();
            doctor d9 = new doctor();
            doctor d10 = new doctor();
            doctor d11 = new doctor();
            doctor d12 = new doctor();

            d7.name = "mohamed";
            d8.name = "ibrahim";
            d9.name = "howida";
            d10.name = "alaa";
            d11.name = "Essam";
            d12.name = "khafagy";



            s[13].cor[1].name = ("1-computer archetecture ");
            s[13].cor[2].name = ("2-Senior CS Project II. ");
            s[13].cor[3].name = ("3-Introduction to Computer Programming ");
            s[13].cor[4].name = ("4-numerical methods  ");
            s[13].cor[5].name = (" 5- Electronic Commerce");
            s[13].cor[6].name = ("6-Pattern Recognition ");
            s[13].cor[1].setDoctor(d7);
            s[13].cor[2].setDoctor(d8);
            s[13].cor[3].setDoctor(d9);
            s[13].cor[4].setDoctor(d10);
            s[13].cor[5].setDoctor(d11);
            s[13].cor[6].setDoctor(d12);




            s[13].cor[1].code = "CS 381";
            s[13].cor[2].code = "CS 499";
            s[13].cor[3].code = "CS 101";
            s[13].cor[4].code = "CS 371";
            s[13].cor[5].code = "IS 301";
            s[13].cor[6].code = "CS 481";


            doctor d1 = new doctor();
            doctor d2 = new doctor();
            doctor d3 = new doctor();
            doctor d4 = new doctor();
            doctor d5 = new doctor();
            doctor d6 = new doctor();

            d1.name = "ibrahim";
            d2.name = "khafagy";
            d3.name = "Essam";
            d4.name = "mohamed";
            d5.name = "hossam";
            d6.name = "howida";

            s[14].cor[1].name = ("1- Computer Science Seminar");
            s[14].cor[2].name = ("2-Senior CS Project II. ");
            s[14].cor[3].name = ("3-Modeling and Simulation ");
            s[14].cor[4].name = ("4- Systems Analysis & Design ");
            s[14].cor[5].name = (" 5- Electronic Commerce");
            s[14].cor[6].name = ("6-Pattern Recognition ");
            s[14].cor[1].setDoctor(d1);
            s[14].cor[2].setDoctor(d2);
            s[14].cor[3].setDoctor(d3);
            s[14].cor[4].setDoctor(d4);
            s[14].cor[5].setDoctor(d5);
            s[14].cor[6].setDoctor(d6);

            s[14].cor[1].code = "CS 401";
            s[14].cor[2].code = "CS 499";
            s[14].cor[3].code = "IS 331";
            s[14].cor[4].code = "IS 321";
            s[14].cor[5].code = "IS 301";
            s[14].cor[6].code = "CS 409";









            /*
                        s[0].cor[1].code = "11";
                        s[0].cor[1].name = "arabic 101";
                        s[0].cor[2].code = "12";
                        s[0].cor[2].name = "math 101";
                        s[0].cor[3].code = "13";
                        s[0].cor[3].name = "phy 101";
                        s[0].cor[4].code = "13";
                        s[0].cor[4].name = "hum 101";
                        s[0].cor[5].code = "14";
                        s[0].cor[5].name = "cs 101";
                        s[0].cor[6].code = "15";
                        s[0].cor[6].name = "icdl ";
            */

            /*
            s[1].level = Convert.ToInt32(7); 
            s[2].level = Convert.ToInt32(6);
            s[3].level = Convert.ToInt32(6);
            s[4].level = Convert.ToInt32(7);
            s[5].level = Convert.ToInt32(5);
            s[6].level = Convert.ToInt32(1);
            s[7].level = Convert.ToInt32(2);
            s[8].level = Convert.ToInt32(4);
            s[9].level = Convert.ToInt32(1);
            s[10].level = Convert.ToInt32(3);
            s[11].level = Convert.ToInt32(5);
            s[12].level = Convert.ToInt32(6);
            s[13].level = Convert.ToInt32(8);
            s[14].level = Convert.ToInt32(7);
             */

            for (int i = 0; i < 30; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("enter your id:");
                Console.ForegroundColor = ConsoleColor.White;
                id[i] = Convert.ToInt32(Console.ReadLine());
                if (id[i] == 0)
                    break;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("enter your password:");
                Console.ForegroundColor = ConsoleColor.White;
                pass[i] = Console.ReadLine();
                student p = new student();
                p.check(id[i], pass[i], s);

            }

            Console.ReadKey();
        }
    }

}