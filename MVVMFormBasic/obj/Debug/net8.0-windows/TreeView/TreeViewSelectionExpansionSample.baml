   M S B A M L   `   `   `  ����H  DMVVMFormBasic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MVVMFormBasic.TreeViewMVVMFormBasic.TreeView  5      =    7MVVMFormBasic.TreeView.TreeViewSelectionExpansionSample   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:MVVMFormBasic.TreeView     5      .��5	      ]� $��10q�6   .+�5
   
   � $��0,10,0,0q�6   $��Bottom=�6&   $��Center=�6>   .+�5      �� -   5        $��btnSelectNext��5      $	��120��6F   .��6R   Select next6_   �� 5      -   5        $��btnToggleExpansion��5      $	��120��6P   $��10,0,0,0q�6\   .��6n   Toggle expansion6�   5      R� 5   
   -   5        $��
trvPersons��5      ��5      �� 5        �� ItemsSource  6+   �� *
Children+.R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��20��6    $��/Images/USER.png��6+   $��0,0,5,0q�6E   �� 5      $��0,0,4,0q�6:   ��6$   �� *Name+6:   �� 5      $��0,0,4,0q�69   ��6$   �� *Age+69   5      5      ��5      �� 5       �� 
TargetType" Q�6   .�5"      ��  �� Property �@Q�
IsSelected �� Value 63   �� *
IsSelected+�� 5#       �@Q�
IsExpanded 63   �� *
IsExpanded+5$      5&      5'      5(      