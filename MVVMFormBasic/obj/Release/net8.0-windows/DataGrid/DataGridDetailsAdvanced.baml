   M S B A M L   `   `   `  ���� H  DMVVMFormBasic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MVVMFormBasic.DataGridMVVMFormBasic.DataGrid  4    .MVVMFormBasic.DataGrid.DataGridDetailsAdvanced   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:MVVMFormBasic.DataGrid     .��� $��10q�.+�&   System.Windows.Controls.DataGrid  -   $��dgUsers��    AutoGenerateColumns$  False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $ Birthday�� �� *
Birthday+   RowDetailsTemplate �� .R�]� 
�������.+��� $
��Left=�$��64��$��10q����� *
ImageUrl+� $
��0,10q� � ColumnDefinitions �� $
��Auto ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $
��ID: ��$
��Bold"��� $��1������ *Id+�� $��Name: ��$
��Bold"�$��1���� $��1��$��1������ *Name+�� $��
Birthday: ��$
��Bold"�$��2���� $��1��$��2������ *
Birthday+ �� StringFormat$ D��