using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TSSP_V3
{
    static class Baza
    {
        public static int ID_Now = 0;
     
        
        static parents[] Rodoki = new parents[5];
        static student[] Detki = new student[5];
        static teacher[] Senseys = new teacher[5];
        static List<day> Days = new List<day>();

        public static void  RegistrUsers()
        {
            Rodoki[0] = new parents("Момотюк",    "0",    "0",    "0",     "0", 100);
            Rodoki[1] = new parents("Монок","Монок","Алиса","Андрей","1",101);
            Rodoki[2] = new parents("Горная", "Горный", "Василиса", "Всеволод","2",102);
            Rodoki[3] = new parents("Заболотная", "Заболотный", "Мария",  "Петр", "3", 103);
            Rodoki[4] = new parents("Пушкина", "Пушкин", "Елена",  "Сергей", "4", 104);


            Detki[0] = new student("Момотюк","Александр","1",'м',"9А",301);
            Detki[1] = new student("Монок", "Елизавета", "22", 'ж', "9А", 302);
            Detki[2] = new student("Горный", "Питер", "23", 'м', "9А", 303);
            Detki[3] = new student("Заболотный", "Петр", "24", 'м', "8А", 304);
            Detki[4] = new student("Пушкина", "Саша", "25", 'ж', "8А", 305);


            Senseys[0] = new teacher("3", "3", "3", "3", 30);
            Senseys[1] = new teacher("Добрый", "Иван", "31", "Труд", 35);
            Senseys[2] = new teacher("Строганов", "Виктор", "32", "ТСПП", 18);
            Senseys[3] = new teacher("Дубовая", "Елена", "33", "История", 56);
            Senseys[4] = new teacher("Скороход", "Игнат", "34", "Русский", 67);

            Days.Add(new day(5, 9, 300, 100, 5));
            // вбить сюда данные о 5 объектах каждого класса
        }
        public static bool Search(string Familiya,string Name, string Password )
        {
            for (int i=0; i<5; i++)
            {
                if (Rodoki[i].ReturnFamily1() == Familiya &&
                    Rodoki[i].ReturnName1() == Name &&
                    Rodoki[i].ReturnPassword() == Password
                    ||
                    Rodoki[i].ReturnFamily2() == Familiya &&
                    Rodoki[i].ReturnName2() == Name &&
                    Rodoki[i].ReturnPassword() == Password
                    )
                {
                    ID_Now = Rodoki[i].ID;
                    
                    return true;
                }
                //вернуть проверку ниже
                 else
   
                if (Detki[i].ReturnFamily() == Familiya&&
                    Detki[i].ReturnName() == Name&&
                    Detki[i].ReturnPassword() == Password)
                {
                    ID_Now = Detki[i].ID;
                    return true;
                }
                
                if (Senseys[i].ReturnFamily() == Familiya &&
                    Senseys[i].ReturnName() == Name &&
                    Senseys[i].ReturnPassword() == Password)
                {
                    ID_Now = Senseys[i].ID;
                    return true;
                }
                

            }
            return false;
        }

      

        public static teacher GetTeacherObject(int ID_Search)
        {
            foreach (teacher teach in Senseys)
            {
                if (teach.ID == ID_Search)
                    return teach;
            }
            return null;
        }

        public static student GetStudentObject(int ID_Search)
        {
            foreach (student stud in Detki)
            {
                if (stud.ID == ID_Search)
                    return stud;
            }
            return null;
            
        }

        public static parents GetParentsObject(int ID_Search)
        {
            foreach (parents Par in Rodoki)
            {
                if (Par.ID == ID_Search)
                    return Par;
            }
            return null;
        }

        public static int[] GetRemarksStudent(int ID_To_Seacrh)
        {
            //для начала подсчитаем количество оценок
            int count = 0;
            foreach(day denki in Days)
            {
                if (denki.ID_Student == ID_To_Seacrh) count++;
            }

            int[] remarks = new int[count];
            int i = 0;
            foreach(day denki in Days)
            {
                if (denki.ID_Student == ID_To_Seacrh)
                    remarks[i++] = denki.Mark;
            }
            return remarks;

        }

        public static int CountStudentsInClass(string NameClass)
        {
            int count = 0;
            foreach (student stud in Detki )
            {
               if (stud.Class == NameClass) count++;

            }
            return count;
        }

        public static void DeleteNote(int ID_Search)
        {
            Rodoki[ID_Search].NoteAboutChildren = "Замечаний нет";
        }

        public static bool WriteNote(string _Familiya, string _Name, int _ID_Teacher, string _TextNote)
        {
            foreach (parents Searching in Rodoki)
            {
                if (Searching.ReturnFamily1() == _Familiya && Searching.ReturnName1() == _Name
                    ||
                    Searching.ReturnFamily2() == _Familiya && Searching.ReturnName2() == _Name
                    )
                {

                    Searching.NoteAboutChildren = "Учитель " + GetTeacherObject( ID_Now).ReturnFamily() + "Сообщает Вам:" + _TextNote;
                    return true;
                }
            }       
            return false; //возвращает правду если родитель найден и ложь в противном случае
        }

      
        public static void AddDay(int _Day, int _month, int _ID_Teacher, string _Familiya, string _Name, int _Mark)
        {

            int _ID_Student = 0;
            foreach(student Stud in Detki)
            {
                if (Stud.ReturnFamily() == _Familiya && Stud.ReturnName() == _Name)
                {
                    _ID_Student = Stud.ID;
                }
            }
            if (_ID_Student!=0)
            Days.Add(new day(_Day,_month,_ID_Teacher,_ID_Student,_Mark));

        }

        public static void ChangeClassStudent(int _ID_Student, string _NewClass)
        {
            foreach (student stud in Detki)
            {
                if (stud.ID == _ID_Student)
                    stud.Class = _NewClass;
            }
            Detki[_ID_Student].Class = _NewClass;
        }
    }
}
