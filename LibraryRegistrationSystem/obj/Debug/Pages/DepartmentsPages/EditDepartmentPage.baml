   M S B A M L   `   `   `  ����T  PLibraryRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LibraryRegistrationSystem.Pages.DepartmentsPages0LibraryRegistrationSystem.Pages.DepartmentsPages  5      I    CLibraryRegistrationSystem.Pages.DepartmentsPages.EditDepartmentPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:LibraryRegistrationSystem.Pages.DepartmentsPages     5        N� FontSize$  16(�5       N� Title$! Изменить отдел��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��60 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��150��6   $	��200 �6.   �� 5      .+�5   
   �� $��ID��6   $��Right=�6   $��Center=�6:   $
��Bold"�6U   $��10q�6g   �� 5   
   $
��Left=�6(   $��Center=�6C   $��10q�6^   $��1��6j   ��6   �� *ID+6j   �� 5   
   $��Филиал��6   $��Right=�6"   $��Center=�6>   $
��Bold"�6Y   $��10q�6k   $��1��6w   �� 5   
   -   5         ��Name$ listBranches��5   a   $��1��5      $��1��6     �� DisplayMemberPath$
 Name��6Q   $	��360��6j   $��10q�6y   
�������$��2q�5   &   $
��Left=�6:   $��32��6U    �� 
IsEditable .  �� SelectedItem 5   0   �� *	Branch1+ �� SelectedValue 5      �� *	Branch1+�� 5   
   $��
Отдел��6   $��Right=�6!   $��Center=�6=   $
��Bold"�6X   $��10q�6j   $��2��6v   �� 5    
   -   5        	 ��Name$	 txtName��5!   9   $��2��5       $��1��6   $	��350��6E   
�������$��2q�6g   $
��Left=�5!      $��32��6-   $��10q�6J   ��5    /   �� *Name+5!   J   �� 5#   
   $��3��6   $��2��6"   
 �� Orientation$
 
Horizontal=�66   $��Center=�6O   $	��Top=�6l   .+�5$      �� -   5         ��Name$ 	btnCancel��5$   &   $��Отмена��6   $��15q�6Q   �� 5%      -   5        $ btnSave��5%   )   $��Сохранить��6   $��15q�6P   5&      5'      5(      