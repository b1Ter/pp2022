   M S B A M L   `   `   `  ����T  PLibraryRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:LibraryRegistrationSystem.Pages.BranchesPages-LibraryRegistrationSystem.Pages.BranchesPages  5      B    <LibraryRegistrationSystem.Pages.BranchesPages.BranchInfoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:LibraryRegistrationSystem.Pages.BranchesPages     5        N� FontSize$  16(�5       N� Title$, &Информация о филиале��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $	��140 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��600 �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ btnEditBranch��5      $��Изменить��5      $��Right=�6$   $	��Top=�6@   $��10q�6X   $��1��6d   5   (   A� 5   
    A� Columns$ 2��6   $
��Left=�6"   $	��Top=�6=   $	��110��6U   .+�5      �� $
��ID: ��6   $
��Bold"�6$   �� 5      $	��300��6   ��6'   �� *ID+�� 5      $��Телефон: ��6   $
��Bold"�6)   �� 5      $	��300��6   ��6'   �� *Phone+�� 5      $��Глава: ��6   $
��Bold"�6'   �� 5      $	��300��6   $
��Wrap=�6?   $��34��6S   ��6'   �� *Header+6S   5      A� 5    
   $ 2��6   $
��Left=�6"   $	��Top=�6=   $��1��6U   $	��110��6e   $��	6.8,0,0,0q�6r   .+�5!      �� $��Название: ��6   $
��Bold"�6*   �� 5"      $	��300��6   ��6'   �� *Name+�� 5#      $��Адрес: ��6   $
��Bold"�6'   �� 5$      $
��Wrap=�6   $��34��6,   $	��340��6;   ��6J   �� *	Address+�� 5%      $4��.Другие контактые данные: ��6   $
��Bold"�69   �� 5&      $
��Wrap=�6   $��34��6,   $	��340��6;   ��6J   �� *ContactDetail+5'      �� 5)   
    �� Orientation$ Vertical=�6   $��1��6,   $��2��69   $��
0,20.6,0,0q�6M   $��2��6a   $��Center=�6r   .+�5*      � $��Center=�6   .+�5+      �� $��Отделы��6   $
��Bold"�6*   $
��Left=�6<   $��Center=�6W   �� 5,      $��1��6   $��1��6-   $ 
Horizontal=�6:   $��Right=�6S   $	��Top=�6o   .+�5-      �� -   5        $ btnAdd��5-   0   $��Добавить��6   $��10q�6U   �� 5.      -   5        $ 	btnRemove��5.   /   $��Удалить��6   $��10q�6Z   5/      50      &   System.Windows.Controls.DataGrid  51      -   5          Name$ dataDepartments��51      $��18(�60      AutoGenerateColumns .  	   
IsReadOnly	 . $��0,30,0,0q�6l   
   Columns
 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *ID+  54      $ 
Отдел��6)   $ 1* 68    6C   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  56      $	 160 6-      CellTemplate 57      �� 58      .R�59   "   �� $ btnEdit��6J   -   5        $��16(�59   )   $��Изменить��67   6[   5:      5<      5?      5@      5A      5B      