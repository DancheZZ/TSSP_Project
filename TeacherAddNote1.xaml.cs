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
    /// Логика взаимодействия для TeacherAddNote1.xaml
    /// </summary>
    public partial class TeacherAddNote1 : Window
    {
        teacher Teacher;
        public TeacherAddNote1()
        {
            Teacher = Baza.GetTeacherObject(Baza.ID_Now);
            InitializeComponent();
        }
        private void Vvod(object sender, RoutedEventArgs e)
        {
            Teacher.WriteNote(Имя.Text, Фамилия.Text,Запись.Text);
        }

    }
}
