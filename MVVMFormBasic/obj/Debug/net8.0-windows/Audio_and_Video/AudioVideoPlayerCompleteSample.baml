   M S B A M L   `   `   `  ����H  DMVVMFormBasic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:MVVMFormBasic.Audio_and_VideoMVVMFormBasic.Audio_and_Video  5      B    <MVVMFormBasic.Audio_and_Video.AudioVideoPlayerCompleteSample   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:MVVMFormBasic.Audio_and_Video     5        J� CommandBindings  5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ ApplicationCommands.Open��5
      6Y     5   
   -   5        $ MediaCommands.Play��5      6S     5   
   -   5        $ MediaCommands.Pause��5      6U     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      � -   5         � 	Resources 5   
    �� 
TargetType �� Property �� Value��%W   '��       �� 5      " ��6   .�5      ��  � ��$ 30��6*   67   5      5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   c� .@�5      �� $��ApplicationCommands.Open��6   .��5      �� $��/Images/folder.png��6   5      �� 5      �� 5      $��MediaCommands.Play��6   .��5       �� $��/Images/play-button.png��6   5!      �� 5"      $��MediaCommands.Pause��6   .��5#      �� $��/Images/pause-button.png��6   5$      �� 5%      $��MediaCommands.Stop��6   .��5&      �� $��/Images/music-stop.png��6   5'      5(      r� 5)   
   -   5        $��mePlayer��5)      $��1��6'    r� LoadedBehavior$ Manual=�64    r� Stretch$
 None=�6L   �� 5*   
   $��2��6   ��5+      �� 5,      .R�5-      � 	 � ColumnDefinitions	 5.      �� 5/      $
��Auto �6/   �� 50      $��* �6/   �� 51      $
��Auto �6/   53      54      .@�56      �� .��57      �� -   5        $��lblProgressStatus��57      
00:00:006?   58      �� 59      $��1��6   $��Stretch=�6,   .��5:      �� -   5        $��sliProgress��5:      6�   5;      �� 5<      $��2��6   .��5=      � -	   5        $��pbVolume��5=      $��50��6.   $��12��69   
 � Maximum$
 1Q�6E    � Value 6Q   ��  �� ElementName$ mePlayer�� �� Path$ Volume�5>      5?      5@      5A      