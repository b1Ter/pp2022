   M S B A M L   `   `   `  ����T  PLibraryRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LibraryRegistrationSystemLibraryRegistrationSystem  5   	   *    $LibraryRegistrationSystem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LibraryRegistrationSystem     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6?     � WindowState$  	Maximized=�5      $��18(�62    � Title$K EЕдиная система регистрации читателей��5   	   $	��450��66   $	��800��6C   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��210 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2��65   $��Stretch=�6I   .��5      � .+�5      �� $��20(�6   
���������6*   ��  �� ElementName$ 	MainFrame�� �� Path$ Content.Title�6e   5      5      � 5   
   $��Stretch=�6   $��1��6-      PrimaryHueMidBrush#��[  6:    5      �� 5      $��70 �6    �� 5      $
��326* �6    .+�5      �� $��Stretch=�6   $��Disabled=�69   $
��Auto=�6b   $��1��6�   .��5      �� -   5         ��Name$
 Menu��5      $��10q�6+   5      5        � 5!   
   -   5          �Name$ 	MainFrame��5!      $��1��6#   $��1��60   	  � NavigationUIVisibility$	 Hidden=�6@   5"      5#      