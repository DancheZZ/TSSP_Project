using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSSP_V3
{
    class teacher
    {
        /*    ID
     Фамилия
     Имя
     Пароль
     Возраст
     Предмет */
        public static int CountTeachers = 300;
        public int ID;
        string Family;
        string Name;
        string Password;
        string Subject;
        int age;

        public teacher
        (
            string _Family, 
            string _Name, 
            string _Password, 
            string _Subject, 
            int _age
        )

        {
            Family = _Family;
            Name = _Name;
            Password = _Password;
            Subject = _Subject;
            age = _age;
            ID = CountTeachers;//присваиваем айдишник текущему последнему
            CountTeachers++;//увеличиваем его на 1
        }

        


        public void AddDay(string _Name, string _Familiya, int _Day, int _Month, int _Mark) // параметры для создания дня
        {
            Baza.AddDay(_Day, _Month, ID, _Familiya, _Name, _Mark);
        }

        public static bool ChangeClassStudent(string _OldClass, string _NewClass, int _ID_Student) // параметры для смены класса
        {
           if ( Baza.CountStudentsInClass(_OldClass)>10 && Baza.CountStudentsInClass(_NewClass)<35 )
            {
                Baza.ChangeClassStudent(_ID_Student, _NewClass);
                return true;
            }
            return false;
        }

        public void WriteNote(string _Name, string _Familiya, string _Note) //параметры для записки родителю
        {
            Baza.WriteNote(_Familiya,_Name,ID,_Note);
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
