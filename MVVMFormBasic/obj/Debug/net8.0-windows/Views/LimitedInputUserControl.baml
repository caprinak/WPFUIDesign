   M S B A M L   `   `   `  ����H  DMVVMFormBasic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MVVMFormBasic.ViewsMVVMFormBasic.Views  5      9!clr-namespace:MVVMFormBasic.ModelMVVMFormBasic.Model  6>   1    +MVVMFormBasic.Views.LimitedInputUserControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:MVVMFormBasic.Views     5      3model!clr-namespace:MVVMFormBasic.Model     6>   .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5       $
��Auto �6   .+�5"   
   �� ��6   �� *Title+�� 5#   
   $��1��6   .��5$      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� ��6   ��  �� ElementName$ txtLimitedInput�� �� Path$ Text.Length��� 5*      $��/��6   �� 57      ��6   �� *	MaxLength+58      59      �� 5:   
   -   5        $��txtLimitedInput��5:   S   $��1��62   $��2��6?   $
��Auto=�6j    �� TextWrapping$
 Wrap=�6�    �� 	MaxLength 6   �� *	MaxLength+6�   5;      5<      