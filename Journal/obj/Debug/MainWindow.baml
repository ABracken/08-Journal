   M S B A M L   `   `   `  ����D  @MyJournal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MyJournal	MyJournal  5   	       MyJournal.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MyJournal     5   	     � Title$  
My Journal��5   	   $	��500��6   $	��700��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��4* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $
��345* �6   �� 5      $��2* �6   �� 5      $
��345* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid_JournalEntries��5      $��
10,10,10,0q�64   $��Stretch=�6H   $��Stretch=�6f   $��3��6�   $
��Auto��6�   $
��Auto��6�   $��Stretch=�6�   $��Stretch=�6�      
IsReadOnly . 65  �� 5   
   -   5         ��Name$ textBox_Title��5      $��10,10,114,160q�6)    �� TextWrapping$
 Wrap=�6@   $��Stretch=�6T   $��Stretch=�6p   $��Write Title Here��6�   $��18(�6�   $��Verdana)�6�   $
��Auto��6  $
��Auto��6  $��3��6*  $��4��6>  $��Stretch=�6K  $��Stretch=�6p  �� 5   
   -   5        $ textBox_Entry��5      $
 Wrap=�6*   $��Stretch=�6>   $��10,46,114,10q�6Z   $��Stretch=�6p   $��4��6�   $��3��6�   $��Stretch=�6�   $��Stretch=�6�   $��Write Entry Text Here��6�   $��16(�6  $��Verdana)�6#  6Z  �� 5   
   -   5         ��Name$ button_Publish��5      $��Publish��6)   $��	0,0,10,10q�6;   $��34��6k   $��2��6w   $��4��6�   $��99��6�   $��Center=�6�   $��Center=�6�   $��Right=�6�   $��Bottom=�6  $��Verdana)�6  $��14(�61  5      5      