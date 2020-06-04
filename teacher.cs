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

        /*добавить день
 обработка запрсоса на смену класса
 записать замечение родителю про ребенка(вводятся Фамилия Имя родителя (1 из 2) и текст замечания)*/

        public void AddDay() // параметры для создания дня
        {

        }
        public bool ChangeClassStudent(string _OldClass, string _NewClass, int _ID_Student) // параметры для смены класса
        {
           if ( Baza.CountStudentsInClass(_OldClass)>10 && Baza.CountStudentsInClass(_NewClass)<35 )
            {

                return true;
            }
            return false;
        }

        public void WriteNote(string Name, string Familiya, string Note) //параметры для записки родителю
        {
            //параметры - имя фамилия родителя и запись ему
            //сделать типом bool 
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
