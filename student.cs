using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSSP_V3
{
    class student
    {
        public static int CountStudent = 100;
        string Family;
        string Name;
        string Password;
        char gender;
        string Class;
        int ID_ClassRuk;
        public int ID;
        student
        (
        string _Family,
        string _Name,
        string _Password,
        char _gender,
        string _Class,
        int _ID_ClassRuk
        )

        {
            ID = CountStudent;//присваиваем айдишник текущему последнему
            CountStudent++;//увеличиваем на 1 
            Family = _Family;
            Name = _Name;
            Password = _Password;
            gender = _gender;
            Class = _Class;
            ID_ClassRuk = _ID_ClassRuk;
        }


        void ChangeClass(string NewClass)
        {

        }

        void LookMarks()
        {

        }

        public string ReturnName()
        {
            return Name;
        }

      
        public string ReturnFamily()
        {
            return Family;
        }

        

        public string ReturnPassword()
        {
            return Password;
        }

    }
}
