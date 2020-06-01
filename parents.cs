using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSSP_V3
{
    class parents
    {
        public static int CountParents = 200;
       public int ID;
        string Family1;
        string Name1; //фамилия и имя первого родителя
        string Family2;
        string Name2;// фамилия и имя второго родителя
        string Password; //пароль
        int ID_child; //ID ребенка
 public string NoteAboutChildren; //замечание о ребенке
        parents(string F1,string F2,string N1, string N2, string P, int id_child)
        {
            Family1 = F1;
            Name1 = N1;
            Family2 = F2;
            Name2 = N2;
            Password = P;
            ID = CountParents;//присваиваем айдишник текущему последнему
            CountParents++;//увеличиваем последний айди
            ID_child = id_child;
            NoteAboutChildren = "Замечаний нет";
        }

        public string ReturnName1()
        {
            return Name1;
        }

        public string ReturnName2()
        {
            return Name2;
        }

        public string ReturnFamily1()
        {
            return Family1;
        }

        public string ReturnFamily2()
        {
            return Family2;
        }

        public string ReturnPassword()
        {
            return Password;
        }




        public void TakeNote (string Note)
    {
      NoteAboutChildren = Note;
    }

    public void Look() // сделать возвр. тип int[]
    {
       
    }




    }
}
