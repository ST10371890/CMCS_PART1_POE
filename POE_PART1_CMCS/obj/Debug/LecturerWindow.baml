   M S B A M L   `   `   `  ����I  EPOE_PART1_CMCS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:POE_PART1_CMCSPOE_PART1_CMCS  5   	   #    POE_PART1_CMCS.LecturerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:POE_PART1_CMCS     5   	     � Title$  LecturerWindow��5   	   $	��612��6    $	��800��6-   .��5	      � ���#F0F4F7$��0,0,0,-6q�6    .+�5   
   �� ���#2D73B8$��50��6&   $	��Top=�62   ._�5      �� $'��!Lecturer Dashboard - Submit Claim��6   
�������$��18(�5   '   $��Center=�65   $��Center=�6P   5      �� 5   
   $!��Lecturer (Personal Details)��6   $��16(�67   $
��Bold"�6E   ���#0D47A1$��0,50,0,0q�5   %   $	��Top=�67   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��0,80,0,0q�6a   .+�5      �� $��10q�6   .+�5      �� $��Lecturer Name:��6   $��14(�62   ���#1565C06@   �� 5      $	��150��6   $��25��6&   5      �� 5      $��10q�6   .+�5      �� $��Lecturer Surname:��6   $��14(�65   ���#1565C06C   �� 5       $	��150��6   $��25��6&   5!      �� 5$      $��10q�6   .+�5%      �� $��Employee Number:��6   $��14(�64   ���#1565C06B   �� 5&      $	��150��6   $��25��6&   5'      �� 5*      $��10q�6   .+�5+      �� $��Contact Number:��6   $��14(�63   ���#1565C06A   �� 5,      $	��150��6   $��25��6&   5-      5.      &   System.Windows.Controls.DataGrid  51   
   -   5        $��	dgModules��51         AutoGenerateColumns .     CanUserAddRows . $	��150��6V   $	��Top=�6c   $��	0,170,0,0q�6{      Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Module Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
ModuleName+  54      $ Hours Worked��6%   $ * 6;    6E   �� *HoursWorked+  56      $ Hourly Rate��6%   $ * 6:    6D   �� *
HourlyRate+  58      $ Total Claim��6%   $ * 6:    6D   �� *
TotalClaim+5:      �� 5=   
   -   5        $��Add Another Module��5=      $	��190��6.   $
��Left=�6:   ���#42A5F5
�������$
��Bold"�5>   5   $��26,382,0,182q�6G    J� RenderTransformOrigin$ 0.5,0.5&�5?   %   z�5@      V� 5A      .~�5B      �� �� 5C      	 �� AngleX$	 -0.396Q�6$   �� 5D      T� 5E      
 T� X$
 -0.636Q�6)   5F      5H      �� 5K   
   -   5        $��Submit Claim��5K      $	��137��6(   $
��Left=�64   ���#0D47A1
�������$
��Bold"�5L   5   $��253,380,0,181q�6G   5M      �� 5P   
   $"��Upload Supporting Documents:��6   $��14(�68   ���#1565C0$��10,325,-10,231q�6[   �� 5Q   
   -   5        $��Upload Document��5Q      ���#42A5F5
�������$
��Bold"�6S   $��206,325,444,250q�6e   5R      5T      5V      