   M S B A M L   `   `   `  ����T  PLibraryRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:LibraryRegistrationSystem.Pages.ReadersCardsPages1LibraryRegistrationSystem.Pages.ReadersCardsPages  5      K    ELibraryRegistrationSystem.Pages.ReadersCardsPages.EditReadersCardPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:LibraryRegistrationSystem.Pages.ReadersCardsPages     5        N� FontSize$  16(�5       N� Title$: 4Изменить читательский билет��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      .+�5   
   �� $��Год��6   $��Center=�6   $��20q�6:   |�.  6F   �� 5   
   $��Читатель��6   $��1��6$   $��Center=�61   $��20q�6L   |�.  6X   �� 5   
   $��
Отдел��6   $��2��6!   $��Center=�6.   $��20q�6I   |�.  6U   �� 5   
   $)��#Читательский номер��6   $��3��6.   $��Center=�6;   $��20q�6V   |�.  6b   �� 5   
   -   5         ��Name$ txtYear��5   9   $��0��5      $��1��6   $	��120��6E   
�������$��2q�6d   $
��Left=�5      $��32��6-   ��5   /   �� *Year+5   9   �� 5   
   -   5         ��Name$ listReaders��5    9   $��1��5      $��1��6     �� DisplayMemberPath$ FullName��6Q   $	��360��6n   
�������$��2q�6�   $
��Left=�5       $��32��6-    �� 
IsEditable .  �� SelectedItem 5   0   �� *	Reader1+	 �� SelectedValue	 5    `   �� *	Reader1+�� 5"   
   -   5        $ listDepartments��5#   9   $��2��5"      $��1��6    $ FullName��6U   $	��360��6r   
�������$��2q�6�   $
��Left=�5#      $��32��6-    .  5"   0   �� *Department1+	 5#   d   �� *Department1+�� 5%   
   $��3��6   $��1��6#   
 �� Orientation$
 
Horizontal=�63   .+�5&      �� -   5        $ txtCard��5'   9   $	��200��5&   3   
�������$��2q�6U   $
��Left=�5'      $��32��6-   ��5&      �� *LibraryCard+5'   9   �� 5(      -   5         ��Name$ btnGen��5(   3   $+��%Сгенерировать номер��6   $��15q�6X   5)      �� 5+   
   $��5��6   $��2��6"   $
 
Horizontal=�66   $��Center=�6O   .+�5,      �� -   5        $ 	btnCancel��5,   &   $��Отмена��6   $��15q�6Q   �� 5-      -   5        $ btnSave��5-   )   $��Сохранить��6   $��15q�6P   5.      5/      50      