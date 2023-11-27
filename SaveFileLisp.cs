using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Autocad_lisp_layers_add_descriptions_27_11_2023
{
    public static class SaveFileLisp
    {
        // класс для записи в файл строки strLisp
        // передаём строку взятую частично из файла, частично из textbox - ов
        public static void SaveToFile(string strLisp)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "LSP Files(*.lsp)|*.lsp|All(*.*)|*";
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = dialog.FileName;

            try
            {
                if (dialog.ShowDialog() == true)
                {
                    string path = dialog.FileName;
                    StreamWriter sw = new StreamWriter(path, false);
                    using (sw)
                    {

                        sw.Write(strLisp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
