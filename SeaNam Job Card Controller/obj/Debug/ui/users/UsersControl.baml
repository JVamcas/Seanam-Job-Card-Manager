   M S B A M L   `   `   `  ����  SeaNam_Job_Card_Controller6    0SeaNam_Job_Card_Controller.ui.users.UsersControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5	      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� $��User Details��6   $	��0 5q�6-   .��5      � $	��400��6    5      �� 5      $
��Auto �6+   �� 5      $��* �6+    � RowDefinitions 5      �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5       $��40 �6(   �� 5!      $��40 �6(   �� 5"      $��40 �6(   .+�5$      �� $��0��6   $
�� 5 6q�6)   .��67   
First Name6C   �� 5%      $��0��6   $��1��6+   $	��5 5q�5&      $��6q�5'       ! MaterialDesignOutlinedTextBox#���  5(      ��5)      �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5*      $��0��6   $��1��6,   $
�� 5 6q�69   .��6G   	Last Name6R   �� 5+      $��1��6   $��1��6+   $	��5 5q�5,      $��6q�5-      #���  5.      ��5/      �� *
LastName+$ PropertyChanged=��� 50      $��0��6   $��2��6,   $
�� 5 6q�69   .��6G   	Job Title6R   �� 51      -   5         ��Name$ JobTitleCombo��52      $��2��51      $��1��6,   $��6q�6<   $��Stretch=�6H    �� 
IsEditable . |�.  " MaterialDesignOutlinedComboBox#���  54      $	��5 5q�55       � ToolTip$) #The employee title e.g Electrician.��56      $ �� IsSynchronizedWithCurrentItem$
 TrueY�58      	 �� SelectedItem	 57      �� *EmployeeTitle+
 � ContextMenu
 59      �� 5:      .@�5;   "   m� -   5        $
��Edit��5;   +   69   m� 5<   "   -   5        $��Delete��5<   +   6;   m� 5=   "   -   5        $��Add Job Title��5=   +   6B   5>      5@      �� 5A      $��0��6   $��3��6,   $
�� 5 6q�69   .��6G   
User Group6S   �� 5B      -   5        $ UserGroupCombo��5C      $��3��5B      $��1��6,   $��6q�6<   $��Stretch=�6H    . |�. #���  5E      $	��5 5q�5F      $% The category for this employee.��5G      $
 TrueY�5I      	 5H      �� *	UserGroup+5J      �� 5K      $��4��6   $��5 q�6)   .��65   
Password6?   �� 5L      $��4��6   $��1��6+   $	��5 5q�5M      $��6q�5N      #���  5O      ��5P      �� *
Password+$ PropertyChanged=�� 5Q      $��1��6   $��5��6+   $��5q�68    5R      �� 5S      $��* �6/   �� 5T      $
��Auto �6/   �� 5U      $
��Auto �6/   .+�5W      �� -   5        $��1��5W   !   $	��5 0q�61   $ Save user details.��5X   !   .��6Z   Save5Z      �� 5[      -   5        $��2��5[   !   $	��5 0q�61   .��5\   >   Clear5^      5_      5`      5a      5b      �� 5c   
   $��1��6   $	��5 5q�6#   .��5d      � .+�5e      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesGrid��5e       �� AlternationCount$ 2��62      AlternatingRowBackground
 �iii�   Columns 5f      0  *System.Windows.Controls.DataGridTextColumn  5g      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6-      Header$ 
First Name��69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *	FirstName+  5h      $	 200 6-   $ 	last Name��69    6L   �� *
LastName+  5i      $	 200 6-   $ 	Job Title��69    6L   �� *EmployeeTitle+  5j      $	 200 6-   $ 
User Group��69    6M   �� *	UserGroup+5l      5m      5n      5o      5p      