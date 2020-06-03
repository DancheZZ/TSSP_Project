using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSSP_V3
{
    static class Baza
    {
        public static int ID_Now = 0;
     
        
        static parents[] Rodoki = new parents[5];
        static student[] Detki = new student[5];
        static teacher[] Senseys = new teacher[5];
        static day[] Days = new day[5];
        

        public static void  RegistrUsers()
        {
            Rodoki[0]= new parents("1", "1", "1", "1", "123", 100);
            Detki[0] = new student("2","2","2",'м',"9А",301);
            Senseys[0] = new teacher("3", "3", "3", "3", 30);
            Days[0] = new day(5,9,1,1,5);
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
                /* else
   
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
                */

            }
            return false;
        }

      

        public static teacher GetTeacherObject(int ID_Search)
        {
            return Senseys[ID_Search];
        }

        public static student GetStudentObject(int ID_Search)
        {
            return Detki[ID_Search];
        }

        public static parents GetParentsObject(int ID_Search)
        {
            return Rodoki[ID_Search];
        }

        public static int[] GetRemarksStudent(int ID_To_Seacrh)
        {
            //для начала подсчитаем количетсво оценок
            int count = 0;
            foreach(day denki in Days)
            {
                if (denki.ID_Student == ID_To_Seacrh) count++;
            }

            int[] remarks = new int[count];
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

        public static void WriteNote(int ID_Parent, string TextNote)
        {
            Rodoki[ID_Parent].NoteAboutChildren = TextNote;
        }

    }
}
