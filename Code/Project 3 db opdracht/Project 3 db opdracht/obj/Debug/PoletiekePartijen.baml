   M S B A M L   `   `   `  ����P  LProject 3 db opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Project_3_db_opdrachtProject_3_db_opdracht  5      -    'Project_3_db_opdracht.PoletiekePartijen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Project_3_db_opdracht     5        N� Title$  PoletiekePartijen��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��Partijen��5         AutoGenerateColumns .  ���	#FF376368$��1��6X   $��3��6h   $��0��6|   $��3��6�   $��20q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Partij id��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	partij_id+6c     5      $
 Name��6?   $ 80 6M    6%   �� *naam+6Z     5      $ Adres��6?   $ 80 6N    6%   �� *adres+6[     5      $ Telefoonnummer��6B   $ 80 6Z    6%   �� *
postcode+6g     5      $ 
Emailadres��6B   $ 80 6V    6%   �� *
gemeente+6c     5      $ Gemeente��6D   $ 80 6V    6%   �� *
emailadres+6c     5      $ Postcode��6H   $ 80 6Z    6%   �� *telefoonnummer+6g   5"      � 5#   
   $��0��6   $��0��6   $��2��6,    5$      �� 5%      $��1* �6#    5'      �� 5(      $��1* �6    �� 5)      $��1* �6    �� 5*      $��1* �6    �� 5+      $��1* �6    �� 5,      $��1* �6    �� 5-      $��1* �6    �� 5.      $��1* �6    .+�52      �� $��1��6   $��1��6#   $��Center=�63   $��23��6P    �� TextWrapping$
 Wrap=�6\   $��Adres��6p   $	��Top=�6}   $	��120��6�   $��5q�6�   �� 53      $��2��6   $��1��6#   $��Center=�63   $��23��6P   $
 Wrap=�6\   $��Telefoonnummer��6p   $	��Top=�6�   $	��120��6�   $��5q�6�   �� 54      $��0��6   $��1��6#   $��Center=�63   $��23��6P   $
 Wrap=�6\   $
��Naam��6p   $	��Top=�6|   $	��120��6�   $��5q�6�   �� 55      $��3��6   $��1��6#   $��Center=�63   $��23��6P   $
 Wrap=�6\   $��
emailadres��6p   $	��Top=�6�   $	��120��6�   $��5q�6�   �� 56      $��4��6   $��1��6#   $��Center=�63   $��23��6P   $
 Wrap=�6\   $��gemeente��6p   $	��Top=�6�   $	��120��6�   $��5q�6�   �� 57      $��5��6   $��1��6#   $��Center=�63   $��23��6P   $
 Wrap=�6\   $��Postcode��6p   $	��Top=�6�   $	��120��6�   $��5q�6�   �� 58      $��7��6   $��Create��6"   $��Center=�63   $	��Top=�6P   $	��120��6h   $��5q�6t   59      �� 5;   
   $��0��6   $��2��6%   .+�5<   
   �� $��Update��6   $
��Left=�6"   $	��Top=�6=   $	��120��6U   $��20q�6a   �� 5=   
   $��Delete��6   $
��Left=�6"   $	��Top=�6=   $	��120��6U   $��20q�6a   5>      5?      5@      