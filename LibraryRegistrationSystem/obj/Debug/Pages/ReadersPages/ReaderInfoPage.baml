   M S B A M L   `   `   `  ����T  PLibraryRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:LibraryRegistrationSystem.Pages.ReadersPages,LibraryRegistrationSystem.Pages.ReadersPages  5      A    ;LibraryRegistrationSystem.Pages.ReadersPages.ReaderInfoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:LibraryRegistrationSystem.Pages.ReadersPages     5        N� Title$.  (Информация о читателе��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $	��110 �6   �� 5      $	��120��6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��459* �6   �� 5      $��1141* �6   .+�5   
   �� -   5         ��Name$ btnEditReader��5      $��Изменить��5      $��Right=�6$   $	��Top=�6@   $��10q�6X   $��1��6d   5   (   A� 5   
    A� Columns$ 2��6   $
��Left=�6"   $	��Top=�6=   $	��110��6U   $	��333��6b   .+�5      ��    txtUsual#��[  6   $
��ID: ��6:   $
��Bold"�6F   �� 5      #��[  6   ��6:   �� *ID+�� 5      #��[  6   $��Телефон: ��6:   $
��Bold"�6K   �� 5      #��[  6   ��6:   �� *Phone+�� 5      #��[  6   $)��#Электронная почта: ��6:   $
��Bold"�6U   �� 5      #��[  6   ��6:   �� *Email+5       A� 5"   
   $ 2��6   $
��Left=�6"   $	��Top=�6=   $��1��6U   $	��110��6e   $��	6.8,0,0,0q�6r   $	��512��6�   .+�5#      �� #��[  6   $��ФИО: ��6:   $
��Bold"�6G   �� 5$      #��[  6   ��6:   �� *
FullName+�� 5%      #��[  6   $!��Дата рождения: ��6:   $
��Bold"�6Q   �� 5&      #��[  6   ��6:   �� *
Birthday+�� 5'      #��[  6   $@��:Дата регистрации пользователя: ��6:   $
��Bold"�6a   �� 5(      #��[  6   ��6:   �� *RegistrationDate+5*      �� 5,   
    �� Orientation$ Vertical=�6   $��0,110,3.2,0.4q�6,   $��2��6C   .+�5-      �� #��[  6   $4��.Дополнительные контакты:��6:   $
��Bold"�6Z   �� 5.      #��[  6   ��6:   �� *ContactDetails+5/      �� 51   
   $ Vertical=�6   $��1��6,   $��6.8,110,0,0.4q�6<   $��2��6S   .+�52      �� #��[  6   $��Примечание:��6:   $
��Bold"�6M   �� 53      #��[  6   ��6:   �� *Notes+54      �� 56   
   $ Vertical=�6   $��1��6,   $��2��69   $��0,119.6,0,0q�6M   $��2��6b   .+�57      �� $+��%Читательские номера��6   $
��Bold"�63   #��[  6E   �� 59      $ 
Horizontal=�6   .+�5:      �� $��Год: ��6   #��[  6)   �� 5;      -   5         ��Name$ txtYear��5;      $��80��6M   $��10q�6[   
�������$��2q�5<      �� 5=      $��Филиал: ��6   #��[  6,   �� 5>      -   5         ��Name$ 	cmbBranch��5>      $	��210��6\    �� 
IsEditable .  $��10q�6~   	 �� DisplayMemberPath$
	 Name��5?      �� 5@      $��Отдел: ��6   #��[  6+   �� 5A      -   5        $ cmbDepartment��5A      $	��210��6d    .  $��10q�5B      $
	 Name��6'   �� 5C      -   5        $ btnReset��5C   )   $��
Сброс��6   $��10q�6R   �� 5D      -   5        $ btnAdd��5D   ,   $��Добавить��6   $��10q�6Q   �� 5E      -   5        $ 	btnRemove��5E   +   $��Удалить��6   $��10q�6V   5F      &   System.Windows.Controls.DataGrid  5H      -   5        
  Name$
 	dataCards��5H      $��18(�6*      AutoGenerateColumns .     
IsReadOnly .    Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ Год��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Year+  5K      $) #Читательский номер��6)   $ 1* 6E    6P   �� *LibraryCard+  5L      $ 
Отдел��6)      MinWidth$	 350Q�68    6G   �� *Department1.Name+  5M      $ Филиал��6)   $	 200Q�69    6H   �� *Department1.Branch1.Name+4  .System.Windows.Controls.DataGridTemplateColumn  5O      $	 160 6-      CellTemplate 5P      �� 5Q      .R�5R   "   �� $ btnEdit��6J   -	   5        $��16(�5R   )   $��Изменить��67   6[   5S      5U      5X      5Z      5[      5\      