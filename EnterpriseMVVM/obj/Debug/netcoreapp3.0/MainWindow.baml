   M S B A M L   `   `   `  ����I  EEnterpriseMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:EnterpriseMVVMEnterpriseMVVM  5   	       EnterpriseMVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:EnterpriseMVVM     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��379* �6   �� 5      $	��55* �6    � ColumnDefinitions 5   
   �� 5      $
��457* �6   �� 5      $
��343* �6   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6      CanUserAddRows$ False��6/      CanUserDeleteRows$ False��6F   ��6`   �� *
Products+ �� SelectedItem 6�   �� *SelectedItem+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1* 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6Y     5      $	 Content��6%   $
 1* 6R    66   �� *	Content+6_     5      $	 Price��6%   $
 1* 6^    64   �� *Price+ �� StringFormat$ C2��6k   5      � 5   
   $��1��6    5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5       �� $��Delete��6   $��0,0,1,0q�6H   ��6&   �� *DeleteCommand+6H   �� 5!      $��
Delete All��6   $��0,0,-1,0q�6O   $��1��6a   ��6*   �� *DeleteAllCommand+6a   5"      � 5#   
   $��1��6   .+�5$      �� .+�5%      �� $��DemiBold"�6   .��6.   Name:65   �� 5&      ��6   �� *	Txtname+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��6t   �� 5'      $��DemiBold"�6   .��6.   
Content:68   �� 5(      ��6   �� *
Txtcontent+$ PropertyChanged=�$
 True��6w   �� 5)      $��DemiBold"�6   .��6.   Price:66   �� 5*      ��6   �� *
Txtprice+$ PropertyChanged=�$
 True��6u   �� 5+      ��6   �� *
AddCommand+ �� NotifyOnValidationError$
 True��.��6U   Add6Z   �� 5,      ��6   �� *UpdateCommand+$
 True��.��6X   Update6`   5/      50      52      53      