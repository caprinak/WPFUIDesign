   M S B A M L   `   `   `  ���� H  DMVVMFormBasic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MVVMFormBasic.VMLMVVMFormBasic.VML  9!clr-namespace:MVVMFormBasic.ViewsMVVMFormBasic.Views  %    MVVMFormBasic.Views.StudentView   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /vmlclr-namespace:MVVMFormBasic.VML     3local!clr-namespace:MVVMFormBasic.Views     (   "MVVMFormBasic.VML.ViewModelLocator    AutoHookedUpViewModel$
  True��.���  � RowDefinitions �� �� ��  � 	Resources ��%    .+��� $��0��$
��Left=�.+��� ����  �� Path$ Students� �� SelectedItem �� *SelectedStudent+���� .R���  �� Orientation$ 
Horizontal=�.+��� $	��100��$��0 5 5 3q����� $ 	FirstName� �� Mode$ TwoWay=��� $	��100��$��0 5 5 3q����� $ LastName�$ TwoWay=��� $��0 5 3 5q����� $ FullName�$ OneWay=��� $��Delete��$
��Left=�$	��Top=�$��75������ *DeleteCommand+�� $��1��.+��   �� 
TargetType �� Property	 �� Value��%�   '��       '�� <     �� " ��.���  � ��$		 150����  � ��
	 ������ " ��.���  � ��$		 150����  � ��
	 �����.+��� $��Hit me��$
��Left=��� $��Touch me��$��Right=��� $	��200����     btnStyleAlmond  btnStyleOrange  DialogButtonStyle
 �� 
TargetType��%�   &	        &	 %     &	 J     �� " ��.���  � ��
	 ������� " ��.���  � ��
	 � ����� " ��.���  � ��	 �� "
 ��.R�� .+�A� #��z��#��z���� $��Center=�$��Center=�.+��� #��[  .��Free Education�� #��[ .��Free Education�� .��Share for better�� #��[ $��Control template��]� $��2��   templateButton��%�   &	       '�� �     �� .R��� $��Stretch=�$��Stretch=�$	��100��.+��� $��Images/logo.jpg��$	��200��$��Uniform=�$	��200���� ���� �� " ��.���  � ��$		 150��.+��� -    ��Name$
 btn1��#��[ �� -   $
 btn2��#��[ �� -   $��Right=�$��click��$	��100��$	��100��