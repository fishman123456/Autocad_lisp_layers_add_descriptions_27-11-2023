﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Autocad_lisp_layers_add_descriptions_27_11_2023
{
    public class LispToCollectDescriptions
    {
        public StringBuilder str = new StringBuilder();
        // программа для сбора слоёв и примечаний к ним 27-11-2023

        // начало сбора файла lisp
        public StringBuilder begin()
        {
            str.Append("(defun C:descrip (/ x1 x2 x3)\r\n");
            str.Append("(vl-load-com)\r\n");
            str.Append("(foreach kab '( ");
            return str; 
        }
        // здесь будет сбор имен слоёв

        // предконец сбора файла lisp
        public StringBuilder end()
        {
            str = new StringBuilder();
            str.Append(")\r\n");
            str.Append("(vla-put-description\r\n ");
            str.Append("(vlax-ename->vla-object (tblobjname \"LAYER\" kab))\r\n ");
            return str;
        }
        // вписываем пояснения которые берем из текстбокса

        public StringBuilder endof()
        {
            str = new StringBuilder();
            str.Append("\n)\n)\n");
            // завершение файла
            str.Append("(alert \"You win\")\n");
            str.Append(")");
            return str;
        }

        // пробуем mvvm
       
    }
}
