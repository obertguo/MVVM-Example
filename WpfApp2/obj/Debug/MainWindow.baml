   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��300��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6!   $��2��61   $
��Left=�6d   $��10q�6   ��6E   ��  �� Path$ FullName�6   �� 5   
   $��1��6   $��0��6!   $��
First Name��61   $
��Bold"�6C   $��Right=�6U   �� 5   
   $��1��6   $��1��6   $	��200��6t   $
��Left=�6�   $��10q�6�   ��6/   �� $ 	FirstName� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��2��6   $��0��6!   $��	Last Name��61   $
��Bold"�6B   $��Right=�6T   �� 5   
   $��2��6   $��1��6   $	��200��6s   $
��Left=�6   $��10q�6�   ��6/   �� $ LastName�$ PropertyChanged=�6�   �� 5   
   $��3��6   $��0��6!   $	��Age��61   $
��Bold"�6<   $��Right=�6N   �� 5   
   $��3��6   $��1��6   $	��200��6n   $
��Left=�6z   $��10q�6�   ��6/   �� $	 Age�$ PropertyChanged=�6�   �� 5!   
   $��4��6   $��0��6   $��3��6.   $��10q�6B   $��
Click Here��6N   $(��"This is a parameter passed in XAML��6�   ��6c   �� $ CmdClickEvent�6�   5"      5#      