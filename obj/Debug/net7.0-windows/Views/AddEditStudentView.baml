   M S B A M L   `   `   `  ����H  DAssignment_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Assignment_UI.ViewsAssignment_UI.Views  5   	   ,    &Assignment_UI.Views.AddEditStudentView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Assignment_UI.Views     5   	     � Title$  AddEditStudentView��5   	   $	��500��6$   $	��400��61    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�5)      �� $
 contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      � ��5C   
   �� 5D       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5E      �  � Color$ 	#FFDADC10��6   � 5F      $ White��6    � Offset$ 1Q�6-   5G       � RowDefinitions 5J   
   �� 5K      $
��Auto �6   �� 5L      $
��Auto �6   �� 5M      $
��Auto �6   �� 5N      $
��Auto �6   �� 5O      $
��Auto �6   �� 5P      $
��Auto �6   �� 5Q      $
��Auto �6    � ColumnDefinitions 5S   
   �� 5T      $
��Auto �6   �� 5U      $��* �6   .+�5X   
   �� $��First Name:��6   $��0��6&   $��10q�63   �� 5Y   
   $��0��65   $��1��6B   $��10q�6R   ��6   �� *Student.FirstName+6R   �� 5[   
   $��
Last Name:��6   $��1��6%   $��10q�62   �� 5\   
   $��1��64   $��1��6A   $��10q�6Q   ��6   �� *Student.LastName+6Q   �� 5^   
   $��Image :��6   $��2��6"   $��10q�6/   �� 5_   
   -   5        $��image��5_   &   $��18,42,218,46q�6   $
��Fill=�5`   	   $��1��6   $��1��6(   $��3��65   �� 5b   
   -   5        $��btnLoad��5c      $��21��5b      $
��Left=�6   $��
150,10,0,0q�5c   	   $	��Top=�6,   $	��115��5d   	   $��2��6   $��1��6"   ��63   �� *SelectPhotoCommand+.��6p   _Select image5f      �� 5j   
   $��Date of Birth:��6   $��3��6)   $��10q�66   (  "System.Windows.Controls.DatePicker  5k   
   $��3��6B   $��1��6O   $��10q�6_      SelectedDate 6   �� *Student.DateOfBirth+6_   �� 5m   
   $
��GPA:��6   $��4��6   $��10q�6,   �� 5n   
   $��4��6/   $��1��6<   $��10q�6L   ��6   �� *Student.GPA+6L   �� 5q   
    �� Orientation$ 
Horizontal=�6   $��6��6.   $
��Left=�6;   $��	76,0,0,30q�6V   $��2��6i   $	��246��6}   .+�5r      ��   	ButtonOne#���  6   $��Cancel��69   ���	#FFCE7507$��35��6�   $	��101��6�    J� RenderTransformOrigin$ 0.453,0.003&�6�   ��6J   �� *CancelCommand+6�   �� 5s      #���  6   $
��Save��69   ���	#FFCE7507$
��10,0q�6�   $��36��6�   $	��106��6�   ��6H   �� *SaveCommand+6�   5t      5v      5w      