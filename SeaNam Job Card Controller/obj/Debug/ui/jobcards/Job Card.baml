   M S B A M L   `   `   `  ����U  QSeaNam_Job_Card_Controller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SeaNam_Job_Card_ControllerSeaNam_Job_Card_Controller  5      4    .SeaNam_Job_Card_Controller.ui.jobcards.JobCard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:SeaNam_Job_Card_Controller     5      X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��800��5      $	��830��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��   MaterialDesignCardGroupBox#���  6   $��Job Card Details��6H   $
��10 0q�6b   .��5      ��  �� Orientation$ Vertical=�6   .+�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5       $
��Auto �6+   �� 5!      $��* �6+    5#      �� 5$      $��40 �6(   �� 5%      $��40 �6(   .+�5'      �� $��Right=�6   $��0��68   $	��1 5q�6H   .��6U   Job Card No:6c   �� 5(      $��0��6   $
��Left=�6+   $��1��6F    ! MaterialDesignOutlinedTextBox#���  5)      $	��1 5q�5*       � ToolTip$ The job card number.��5,      $��6q�5-      $	��260��5.      ��5+      �� *	JobCardNo+5.      �� 50      $��0��6   $��2��6)   $��Right=�69   $	��1 5q�6U   .��6b   Class:6j   �� 51      -   5         ��Name$ JobClassCombo��55      $��0��51      $��3��6,   $��6q�6<    " MaterialDesignOutlinedComboBox#���  52      $	��1 5q�53       �� 
IsEditable . |�. $ Class for this job.��56      $ �� IsSynchronizedWithCurrentItem$
 TrueY�58      	 �� SelectedValuePath$	 Id��59      $	��260��5:      
 �� SelectedItem
 57      �� *
JobClass+ � ContextMenu 5;      �� 5<      .@�5=   "   m� -   5        $
��Edit��5=   +   69   m� 5>   "   -   5        $��Delete��5>   +   6;   m� 5?   "   -   5        $��	Add Class��5?   +   6>   5@      5B      �� 5C      $��1��6   $��0��6)   $��Right=�69   $	��1 5q�6V   .��6c   Area:6j   �� 5D      -   5        $ WorkAreaCombo��5I      $��1��5D      $��1��6,   $��6q�6<   $
��Left=�6H    . |�. #���  5F      $	��1 5q�5G      $&  The area where the job was done.��5H      $
 TrueY�5K      $	��260��5L      
 5J      �� *
WorkArea+ 5N      �� 5O      .@�5P   "   m� -   5        $
��Edit��5P   +   69   m� 5Q   "   -   5        $��Delete��5Q   +   6;   m� 5R   "   -   5        $��Add Area��5R   +   6=   5S      5U      �� 5W      $��1��6   $��2��6)   $��Right=�69   $	��1 5q�6U   .��6b   Order Number(s):6t   �� 5X      -	   5        $ OrdersCombo��5Z      $��1��5X      $��3��6,   $��6q�6<    . #���  6Z   $	��1 5q�5Y      $! Orders related to this job.��5[      $
 TrueY�5]      $	 Id��5^       �� DisplayMemberPath$ OrderNo��5_      $	��260��5`      
 5\      �� *Orders+ 5a      �� 5b      .@�5c   "   m� -
   5        $
��Edit��5c   +   69   m� 5d   "   -   5        $��Delete��5d   +   6;   m� 5e   "   -   5        $��	Add Order��5e   +   6>   5f      5h      5i      �� 5j      $��Job Description��6   $��10q�64   .��5k      �� -   5        $��WorkDescription��5n      #���  5k      $	��100��6V   $
��Auto��6c   $&  Detailed description of the job.��5m       �� AcceptsReturn . ��5l      �� *JobDescription+5n   5   5o      5p      5q      �� 5r   
   #���  6   $��1��6H   $	�� 10q�6U   $��Time Management��5s      .��5t      �� $ 
Horizontal=�6   $��10q�62   .+�5u      �� $	��5 5q�6   .��6%   Start Time:62   &   Xceed.Wpf.Toolkit.DateTimePicker  5v      $	��5 5q�6&   $	��280��63   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5w   &   �� *	StartTime+�� 5x      $	��5 5q�6   .��6%   	End Time:60     5y      $	��5 5q�6&   $	��280��63    5z   &   �� *	EndTime+5{      5|      �� 5}   
   #���  6   $��2��6H   $��10q�6U   $��Job Questionnaire��5~      $	�� 10q�6.   .��5      �� $ Vertical=�6   .+�5�      �� $��5q�6    d� 	IsChecked 6&   �� *IsWorkDoneSatisfactory+.��6S   Was work done satisfactory?6p   �� 5�      $��5q�6    6&   �� *IsNeedReplacement+.��6O   Does it needs to be replaced?6n   �� 5�      $��5q�6    6&   �� *IsRecurringJob+.��6L   Is it a recurring job?6d   �� 5�      $��5q�6    6&   �� *IsTimeFrameSatisfactory+.��6U   !Was the timeframe satisfactory?6v   �� 5�      $��5q�6    6&   �� *IsJobDoneToExpectations+.��6T   .,Was the work down according to expectations?6�   �� 5�      $��10q�6   $8��2If you did not check all the boxes above, Explain.��6'   .��5�      �� #���  6   $��50��6V   $
��Auto��6b    . ��5�      �� *OtherExplanation+5�      5�      � 5�       5�      �� 5�      $��* �6+   �� 5�      $
��Auto �6+   �� 5�      $
��Auto �6+   .+�5�      �� -   5         ��Name$ SaveJobCardBtn��5�      $��1��65   $
��10 0q�6E   $ Save this job card.��5�      .��6Z   Save5�      �� 5�      -   5        $ ClearJobCardForm��5�      $��2��67   $
��10 0q�6G   .��5�   =   Clear5�      5�      5�      5�      5�      5�      