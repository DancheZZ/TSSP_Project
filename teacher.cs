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
        public void ChangeClass(string OldClass, string NewClass) // параметры для смены класса
        {
            //в параметры вставить новый класс, старый класс
        }

        public void WriteNote(string Name, string Familiya, string Note) //параметры для записки родителю
        {
            //параметры - имя фамилия родителя и запись ему
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
