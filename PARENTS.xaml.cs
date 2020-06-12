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
    /// Логика взаимодействия для PARENTS.xaml
    /// </summary>
    public partial class PARENTS : Window
    {
        parents MamkaPapka;
        public PARENTS()
        {
            InitializeComponent();
            MamkaPapka = Baza.GetParentsObject(Baza.ID_Now);
            Marks.Text = MamkaPapka.NoteAboutChildren;
        }
        public void Showme(object sender, RoutedEventArgs e)
        {
            string s = "";
            int[] ISeeMyChild = Baza.GetRemarksStudent(MamkaPapka.ID_child);

            foreach(int i in ISeeMyChild)
            {
                s += i.ToString() + " ";
            }
            MessageBox.Show(s);
        }
    }
}
