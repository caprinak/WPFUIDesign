   M S B A M L   `   `   `  ����H  DMVVMFormBasic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MVVMFormBasic.ViewsMVVMFormBasic.Views  5      &     MVVMFormBasic.Views.CheckBoxCtrl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:MVVMFormBasic.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��1��6   $��10q�6%   .+�5      �� $
��Bold"�6   .��6&   Application Options6;   �� 5      .��5      �� Enable feature �� 5      
��� � �$
��Bold"�6*   .�6<   ABC6A   5      5      �� 5       d� 	IsChecked$
 TrueY�6   .��5      � .+�5      �� Enable feature �� 5      $
��Bold"�6   .�6*   XYZ6/   5      �� 5      $=��7/MVVMFormBasic;component/Images/question-mark-10911.png��6   $��16��6]   $��16��6h   $	��5,0q�6t   5      5      �� 5       .��5!      �� Enable feature �� 5"      
����  � �� TextDecorations$ 	Underline{�6)   $
��Bold"�6E   .�6W   WWW6\   5#      5$      5%      �� 5'   
   $��10q�6   .+�5(      �� $
��Bold"�6   .��6&   Application Options6;   �� 5)      $
��10,5q�6   .+�56      �� -   5        $��cbAllFeatures��56   /    d� IsThreeState$
 True��6   .��6�   
Enable all6�   �� 57      $
��20,5q�6   .+�58      �� -   5        $��cbFeatureAbc��58      .��6{   Enable feature ABC6�   �� 59      -   5        $��cbFeatureXyz��59      $
 TrueY�63   .��6�   Enable feature XYZ6�   �� 5:      -   5        $��cbFeatureWww��5:      .��6{   Enable feature WWW6�   5;      5<      5=      5?      5@      