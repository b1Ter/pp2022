   M S B A M L   `   `   `  ����T  PLibraryRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:LibraryRegistrationSystem.Pages.BranchesPages-LibraryRegistrationSystem.Pages.BranchesPages  5      B    <LibraryRegistrationSystem.Pages.BranchesPages.EditBranchPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:LibraryRegistrationSystem.Pages.BranchesPages     5        N� FontSize$  16(�5       N� Title$# Изменить филиал��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $	��130 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��600 �6   �� 5      $��1* �6   .+�5   
   A�  A� Columns$ 2��6   $
��Left=�6"   $	��Top=�6=   .+�5      �� $
��ID: ��6   $
��Bold"�6$   �� 5      $��5q�6   $
��Wrap=�6#   ��67   �� *ID+�� 5      $��Телефон: ��6   $
��Bold"�6)   �� 5      $��5q�6    �� TextWrapping$
 Wrap=�6!   
�������$	��300��6H   $��36��6W   $	��Top=�6c   $��2q�6{   ��6�   �� *Phone+�� 5      $��Глава: ��6   $
��Bold"�6'   �� 5      $��5q�6   $
 Wrap=�6!   
�������$	��300��6H   $��36��6W   $	��Top=�6c   $��2q�6{   ��6�   �� *Header+5      A� 5   
   $ 2��6   $
��Left=�6"   $	��Top=�6=   $��1��6U   $��	6.8,0,0,0q�6e   .+�5      �� $��Название: ��6   $
��Bold"�6*   �� 5      $��5q�6   
�������$	��300��64   $��64��6C   $
 Wrap=�6R   $��36��6f   $	��Top=�6r   $��2q�6�   ��6�   �� *Name+�� 5       $��Адрес: ��6   $
��Bold"�6'   �� 5!      $��5q�6   
�������$	��300��64   $��64��6C   $
 Wrap=�6R   $��36��6f   $	��Top=�6r   $��2q�6�   ��6�   �� *	Address+�� 5"      $4��.Другие контактые данные: ��6   $
��Bold"�69   �� 5#      $��5q�6   
�������$	��300��64   $��64��6C   $	��Top=�6R   $��2q�6j   $
 Wrap=�5$      ��5#   ~   �� *ContactDetail+5$      5%      �� 5'   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��2��6;   $��Center=�6O   .+�5(      �� -   5         ��Name$ 	btnCancel��5(   &   $��Отмена��6   $��15q�6Q   �� 5)      -   5        $ btnSave��5)   )   $��Сохранить��6   $��15q�6P   5*      5+      5,      