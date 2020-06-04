using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSSP_V3
{
    class day
    {
        public int Day;
        public int Month;

        public int ID_Teacher;
        public int ID_Student;
        public int Mark;

     public day
        (
        int _Day, 
        int _Month, 
        int _ID_Teacher, 
        int _ID_Student, 
        int _Mark
        )
        {
            Day = _Day;
            Month = _Month;
            ID_Teacher = _ID_Teacher;
            ID_Student = _ID_Student;
            Mark = _Mark;

        }
    }
}
