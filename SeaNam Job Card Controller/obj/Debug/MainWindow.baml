   M S B A M L   `   `   `  ����  SeaNam_Job_Card_Controller+    %SeaNam_Job_Card_Controller.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ SeaNam Job Cards Manager��5   	   $	��800��6*   $
��1200��67   .��5      � .+�5   
   �� $��10q�6   
������� � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName��%N  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� $��Border��6)   $��1,1,1,0q�67   
�������$ 4,4,0,0��5   )   $	��2,0q�6@   ._�5   &   �� $	 ContentSite��67   $��Center=�5   7   $��Center=�5   7   $��Header��5   7   $
��10,2q�5   7   5   #   
 5   "   P� 5    &    �@��
IsSelected . . �5!   *   �� $ Border��61    � ��
 ��·�6[   5"   '   P� 5#   &    �@��
IsSelected .  . �5$   *   �� $ Border��61    � ��
 �����6[   5%   '   5'      5)      5*      5+      .@�5,      �� $��	Job Cards��6   .��5-      � $��0 20 0 0q�6    � ColumnDefinitions 5.      �� 5/      $
��Auto �6+   $	��240��68   �� 50      $��* �6+   �� 51      $
��Auto �6+   $	��240��68    � RowDefinitions 53      �� 54      $
��Auto �6(   �� 55      $
��Auto �6(   �� 56      $��* �6(   .+�59      �� $��3��6    $��0��5:       $��1��5;        �� StrokeDashCap$ Square=�5<       
�������5=       �� 5>      $��3��6    $��1��5?       $��1��5@       $ Square=�5A       
�������5B       �� 5D      $��3��6    $��2��5E       $��1��5F       $ Round=�5G       
�������5H       �� 5J      -   5        $��
NewJobCard��5K       # MaterialDesignRaisedLightButton#���  5J      $��0��6W   $��0��6g   $��10 20q�5K   /   $��10q�6?   $��16(�6K   $	��180��5L      $	��100��5M      
�������$
��Bold"�5O      .��6J   New Job Card5Q      �� 5S      -   5        $��ViewEditJobCard��5T      #���  5S      $��1��6W   $��0��6d   $��10 20q�5T   4   $��10q�6D   $��16(�5U      $	��180��5V      $	��100��5W      
�������$
��Bold"�5Y      .��6O   View & Edit Job Cards5[       � 5\      -   5          �Name$ MainWindowPanel��5\   =   $��3��6   $��1��6-   $��Stretch=�6V   $��Center=�5]      $��Stretch=�6>   $��Center=�5^      
�������6@   5_      5`      �� 5a      ��5b      �� 5c      -   5        $��Users��5c      $��Stretch=�5e      .��5g       � -   5        $ UserWindowPanel��5g      $��Stretch=�62   $	��Top=�5h      $��Stretch=�68   $
��Left=�5i      
�������6;   5j      �� 5k      $��Reports��6   �� 5l      $
��Help��6   5m      5n      5o      