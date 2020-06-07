using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TSSP_V3
{
    /// <summary>
    /// Логика взаимодействия для STUDENT.xaml
    /// </summary>
    public partial class STUDENT : Window
    {
        student detka = null;
        public STUDENT()
        {
            detka = Baza.GetStudentObject(Baza.ID_Now);
            InitializeComponent();
            Новый_Класс.Text = detka.Class;
        }

        public void Zapros(object sender, RoutedEventArgs e)
        {
            string Result;
            if (teacher.ChangeClassStudent(detka.Class, Новый_Класс.Text, detka.ID))
            {
                Result = "Успешно!";
            }
            else
                Result = "Вы не можете изменить класс!";
            MessageBox.Show(Result);
        }

        public void Ozenki(object sender, RoutedEventArgs e)
        {
            int[] Palb = Baza.GetRemarksStudent(detka.ID);
            
            string Smotri = "";
            foreach(int i in Palb)
            {
                Smotri += i.ToString() + " ";
            }
            MessageBox.Show(Smotri);
        }

    }
}
