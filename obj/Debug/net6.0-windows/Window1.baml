   M S B A M L   `   `   `  ����j  fAutocad_lisp_layers_add_descriptions_27-11-2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Autocad_lisp_layers_add_descriptions_27_11_2023/Autocad_lisp_layers_add_descriptions_27_11_2023  5   	   =    7Autocad_lisp_layers_add_descriptions_27_11_2023.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Olocal=clr-namespace:Autocad_lisp_layers_add_descriptions_27_11_2023     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5!   
   �� -   5        $��TextBoxLayName��5!      $��1��6(   $��0��65   $��7��6E   $��2��6V   $��10q�6j    �� AcceptsReturn$
 True��5"      " �� VerticalScrollBarVisibility$
 Auto=�6!   6D   �� 5$   
   -   5        $��TextBoxDescriptions��5$      $��1��6-   $��2��6:   $��7��6J   $��2��6[   $��10q�6o   $
 True��5%      $
 Auto=�6$   6G   �� 5)   
   -   5         ��Name$ TextBlockLayerName��5)      $
��Wrap=�60   $��Имя слоя��6D   $��2��6T   $��Center=�5*      $��Center=�6*   $��20(�6E   $��0��6S   �� 5,   
   -   5        $ TextBoxDescriptionsName��5,      $
��Wrap=�65   $��Пояснение��6I   $��2��6Z   $��Center=�5-      $��Center=�6*   $��20(�6E   $��2��6S   �� 5/   
   -   5        $��ButtonBuildFile��5/      $��Собрать файл��6(   $��8��6?   $��0��6L   $��2��6\   $��10q�50      6   �� 52   
   -   5        $��ButtonSaveFile��52      $$��Сохранить в файл��6'   $��9��6B   $��2��6O   $��2��6_   $��10q�53      6   �� 55   
   -   5        $��ButtonClearALL��55      $��Очистить всё��6'   $��9��6>   $��0��6K   $��2��6[   $��10q�56   
   6   58      59      