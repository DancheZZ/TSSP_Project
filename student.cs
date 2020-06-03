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
       public string Class;
       public int ID_ClassRuk;
        public int ID;
       public student
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


        void ChangeMyClass(string NewClass)
        {
            //Yeas
            //получить объект своего учителя и вызвать у него метод для смены класса 
        }

        public int[] LookMarks()
        {
            return Baza.GetRemarksStudent(ID);
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
