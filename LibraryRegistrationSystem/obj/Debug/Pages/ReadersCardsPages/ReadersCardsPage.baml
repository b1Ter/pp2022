   M S B A M L   `   `   `  ����T  PLibraryRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:LibraryRegistrationSystem.Pages.ReadersCardsPages1LibraryRegistrationSystem.Pages.ReadersCardsPages  5      H    BLibraryRegistrationSystem.Pages.ReadersCardsPages.ReadersCardsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:LibraryRegistrationSystem.Pages.ReadersCardsPages     5        N� FontSize$  16(�5       N� Title$+ %Читательские билеты��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��220 �6   �� 5      �� 5      $��10 �6   .+�5   
   � .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� $ Vertical=�6!   .+�5      �� $��ФИО��6$   $��10q�6/   �� 5      -   5         ��Name$ txtName��5   "   $	��300��63   $��10q�6B   
�������$��2q�5      5      �� 5      $ Vertical=�6!   $
��Left=�68   .+�5      �� $!��Года посещения��6$   $��10q�6:   �� 5      $ 
Horizontal=�6%   $��Center=�6>   .+�5      �� $��С��6(   $��10q�61   $��Center=�6=   �� 5      -   5        $ txtStartYear��5   &   $��80��6<   $	��100��6J   $��10q�6Y   
�������$��2q�5    !   $
��Left=�65   �� 5!      $
��по��6(   $��10q�62   $��Center=�6>   �� 5"      -   5        $ 
txtEndYear��5"   &   $��80��6:   $	��100��6H   $��10q�6W   
�������$��2q�5#   !   $
��Left=�65   5$      5%      5&      �� 5(      $ Vertical=�6   .+�5)      �� $ Vertical=�6!   .+�5*      �� $��Филиал��6$   $��10q�62   �� 5+      -   5         ��Name$ 	cmbBranch��5+   #   $	��240��66   $��10q�6E   
�������$��2q�5,   6    �� DisplayMemberPath$
 Name��6J   $	��300��6c   5-      �� 5.      $ Vertical=�6!   $
��Left=�68   .+�5/      �� $��
Отдел��6$   $��10q�61   �� 50      -   5        $ cmbDepartment��50   #   $	��240��6:   $��10q�6I   
�������$��2q�51   6   $	��300��6J   $
 Name��6Y   52      53      �� 54      -   5         ��Name$ btnReset��54      $+��%Сбросить фильтрацию��6+   $	��Top=�6I   $��
40,50,12,0q�6a   55      56      �� 58      $ Vertical=�6   $��Right=�60   $��40q�6L   .+�59      �� -   5        $ 	btnAddNew��59      $,��&Добавить новый билет��6,   $��10q�6c   �� 5:      -   5        $ 	btnRemove��5:      $��Удалить билет��6,   $��10q�6\   5;      5<      �� 5>   
   $��1��6   $ Vertical=�6"   .+�5?      �� -	   5        $ 	btnUpdate��5?      $#��Обновить данные��6@   $
��Left=�6Z   $��10q�6u   &   System.Windows.Controls.DataGrid  5A      -
   5          Name$ dataGrid��5A   &   $��20(�6   	   AutoGenerateColumns	 .  
   
IsReadOnly
 . "   VerticalScrollBarVisibility$
 Auto=�5B      $	��500��6;      Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 120Q�6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 170 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *LibraryCard+   Header 5E      �� 5F      $
��Wrap=�6(   $)��#Читательский билет��6<   5H        5I      $ Год��6)   $ 80Q�66    6D   �� *Year+  5J      $ ФИО��6)   $ 1* 66    6A   �� *Reader1.FullName+  5K      $ Дата рождения��6)   $	 200 6@    6L   �� *Reader1.Birthday+ �� StringFormat$ {0:dd.MM.yyyy}��  5L      $ Филиал��6)   $	 210Q�69    6H   �� *Department1.Branch1.Name+  5M      $ 
Отдел��6)   $	 210Q�68    6G   �� *Department1.Name+4  .System.Windows.Controls.DataGridTemplateColumn  5O      $	 120Q�6-      CellTemplate 5P      �� 5Q      .R�5R   "   �� $ btnEdit��6)   -   5        $��Изменить��5R   :   6M   5S      5U      5W      5X      5Y      5Z      