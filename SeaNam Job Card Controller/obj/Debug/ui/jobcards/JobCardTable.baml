   M S B A M L   `   `   `  ����U  QSeaNam_Job_Card_Controller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:SeaNam_Job_Card_Controller.model SeaNam_Job_Card_Controller.model  5      9    3SeaNam_Job_Card_Controller.ui.jobcards.JobCardTable   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :model.clr-namespace:SeaNam_Job_Card_Controller.model  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Job Card Table��5      $	��900��6   $
��Auto��6+    � 	Resources 5       �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� Padding �� TextAlignment  StronglyRecommended �� Content �� ColumnCollection �� Columns��%�  '��       &	 �    �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      "	 ��6&   .R�5      �� $	��1,2q�6!   
�������._�5      �� $
 ContentHeader��6)   
�������
���� ��#��z��5   =   $ 5q�5   )   #��z��65   $
 Left=�6U   $��16(�5   )   $
��Bold"�67   5      5      5      �� 5        �@�OverridesDefaultStyle . 66   �� 5!       � ��$ Segoe UI)�6+   �� 5"       � ��$ 16(�6)   5#      �� 5%   
   "	 ��5&      .R�5'      �� 
�������.+�5(      �� # z��6'   # z 5)   '   �� 5*      
����ح�$��Strongly Recommended��63   5+      5,      5-      .��5.      �  � RowDefinitions 5/   
   �� 50      $��* �6   �� 51      $
��Auto �6   .+�53   
   �� $��0��6   $��10q�54      ��6   �� *JobCardList+ �� View 55      �� 56       �� AllowsColumnReorder . .P�57      �� $��Job Card No��6%    �� Width$
 Auto��6:    �� DisplayMemberBinding 6G   ��  �� Path$ 	JobCardNo��� 58      $��	Job Title��6%   $
 Auto��68    6E   �� *
JobTitle+�� 59      $��Job Description��6%   $	 200��6>    �� CellTemplate 5:      �� 5;      .R�5<   "   �� $
 Left=�6,   $��WrapWithOverflow=�6A   ��6a   �� *JobDescription+5=      5?      �� 5@      $��	Job Class��6%   $
 Auto��68    6E   �� *
JobClass+�� 5A      $��	Work Area��6%   $
 Auto��68    6E   �� *
WorkArea+�� 5B      $��Completed By��6%   $
 Auto��6;    6H   �� *
Employee+�� 5C      $��Date Created��6%   $
 Auto��6;    6H   �� *
CreateDate+�� 5D      $��
Start Time��6%   $
 Auto��69    6F   �� *	StartTime+�� 5E      $��End Time��6%   $
 Auto��67    6D   �� *	EndTime+5F      5H      � 5J   
   $��1��6    � ColumnDefinitions 5K      �� 5L      $��* �6#   �� 5M      $
��Auto �6#   �� 5N      $
��Auto �6#   .+�5P      ��  � ToolTip$ Enter job card number.��6   
�������$��5q�6J    ! MaterialDesignOutlinedTextBox#���  5Q      $��1��6N   $	��200��6^   $��10q�6j   �� 5R      $ Find job card��6   $��2��6X   $��10q�6h   ��6-   0  *MaterialDesignThemes.Wpf.PackIconExtension  *Search+6h   5S      5T      5U      