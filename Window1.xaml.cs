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
using System.Xml.Linq;

namespace Autocad_lisp_layers_add_descriptions_27_11_2023
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        LispToCollectDescriptions str = new LispToCollectDescriptions();
        public Window1()
        {
            InitializeComponent();
            CheckDateWork.CheckDate();
        }

        private void ButtonClearALL_Click(object sender, RoutedEventArgs e)
        {

        }
        // 28-11-2023 начало положено 9-15
        // Нужно добавить из текстбокса слои и пояснения к ним
        private void ButtonSaveFile_Click(object sender, RoutedEventArgs e)
        {
            #region
            // расделителем может служить один символ, поэтому строку создаём, т е массив символов
            string[] separator = { "\n", "\r" };
            // добавляем данные в список из текстбокса TextBoxLayName - первый текстбокс имя слоя 
            string[] massTextBoxLayname = TextBoxLayName.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            // добавляем данные в список из текстбокса TextBoxLayName - первый текстбокс имя слоя 
            string[] massTextBoxDescriptions = TextBoxDescriptions.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            #endregion
            // построитель строки для сохранения в файл
            StringBuilder sbor = new StringBuilder();
            // построитель строки для сохранения из текстбокса
            StringBuilder Laysbor = new StringBuilder();
            try
            {
                // добавляем начало в строку
                sbor.Append(str.begin());
                // добавляем слои из текстбокса в строку
                foreach (var item in massTextBoxLayname)
                {
                    Laysbor.Append(" \"");
                    Laysbor.Append(item);
                    Laysbor.Append("\" ");
                }
                // добавляем слои из текстбокса в строку для сохранения в файл
                sbor.Append(Laysbor.ToString());
                sbor.Append(str.end());
                Laysbor = new StringBuilder();
                //  // добавляем пояснения из текстбокса в строку
                foreach (var item in massTextBoxDescriptions)
                {
                    // пробуем добавить множественное пояснение
                    //Laysbor.Append("(vla - put - description");
                    //Laysbor.Append("((vlax - ename->vla - object(tblobjname \"LAYER\" kab))");
                    // если что удалить множественное пояснение
                    Laysbor.Append(" \"");
                    Laysbor.Append(item);
                    Laysbor.Append("\" ");
                }
                // добавляем слои из текстбокса в строку для сохранения в файл
                sbor.Append(Laysbor.ToString());
                sbor.Append(str.endof());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так {ex.Message}");
            }
            SaveFileLisp.SaveToFile(sbor.ToString());
        }

        private void ButtonBuildFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
