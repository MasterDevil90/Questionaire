using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApplication12;
namespace Questionaire
{
    class Staff
    {
        public String name;
        public String age;
        public String salary;
    }
    class doctor : Staff
    {

        string lectureTime = "";
    }
    class Ta : Staff
    {

        string[] slotTime = new string[3];
    }
}
