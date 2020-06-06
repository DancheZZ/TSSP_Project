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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TSSP_V3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Baza.RegistrUsers();
        }

        private void Vvod(object sender, RoutedEventArgs e)
        {
            if (Baza.Search(Имя.Text, Фамилия.Text, Пароль.Text) )
            {
                if (Baza.ID_Now>=100 && Baza.ID_Now<200)//открыть окно ученика
                {
                    STUDENT stud = new STUDENT();
                    stud.Show();
                }
                if (Baza.ID_Now>=200 && Baza.ID_Now<300)//Открыть окно родителя
                {
                    PARENTS par = new PARENTS();
                    par.Show();
                }
                if (Baza.ID_Now>=300)//Открыть окно учителя
                {
                    TEACHER teach = new TEACHER();
                    teach.Show();
                }

            }
            else
            {
                MessageBox.Show("Введены неправильные данные!");
            }


        }

     


    }
}
