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

        

        public static void  RegistrUsers()
        {
            Rodoki[0]= new parents("1", "1", "1", "1", "123", 100);
            Detki[0] = new student("2","2","2",'м',"9А",301);
            Senseys[0] = new teacher("3", "3", "3", "3", 30);
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

      

        public static teacher GetTeacherObject()
        {
            return Senseys[ID_Now];
        }

        public static student GetStudentObject()
        {
            return Detki[ID_Now];
        }

        public static parents GetParentsObject()
        {
            return Rodoki[ID_Now];
        }


    }
}
