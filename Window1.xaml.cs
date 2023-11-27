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

namespace Autocad_lisp_layers_add_descriptions_27_11_2023
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            CheckDateWork.CheckDate();
        }

        Window win = new Window();

        private void Button_Save_as_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Clear_ALL_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
