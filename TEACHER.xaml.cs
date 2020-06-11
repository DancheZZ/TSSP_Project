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
    /// Логика взаимодействия для TEACHER.xaml
    /// </summary>
    public partial class TEACHER : Window
    {
        public TEACHER()
        {
            InitializeComponent();
            this.Closed += Exit;
        }

        public void Ozenki(object sender, RoutedEventArgs e)
        {
            TeacherAddDay DayGo = new TeacherAddDay();
            DayGo.Show();
        }

        public void GoNote(object sender, RoutedEventArgs e)
        {
            TeacherAddNote1 NoteGo = new TeacherAddNote1();
            NoteGo.Show();
        }

        public void Exit(object sender, EventArgs e)
        {
            Baza.Saveinfo();
            MessageBox.Show("yyyesss");
        }

    }
}
