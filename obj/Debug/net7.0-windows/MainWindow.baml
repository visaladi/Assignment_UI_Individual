   M S B A M L   `   `   `  ����H  DAssignment_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Assignment_UIAssignment_UI  5   	   9!clr-namespace:Assignment_UI.ViewsAssignment_UI.Views  5   	   C&clr-namespace:Assignment_UI.ViewModelsAssignment_UI.ViewModels  5   	       Assignment_UI.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Assignment_UI     5   	   3Views!clr-namespace:Assignment_UI.Views     5   	   =
ViewModels&clr-namespace:Assignment_UI.ViewModels     5   	     � WindowStyle$
  None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Student Management System��5   	   $	��450��6+   $	��500��68   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF757575��6   � 5      $ 	#FFCBCBCB��6    � Offset$ 0.051Q�6-   � 5      $ 	#FF727272��6   $ 0.102Q�6-   � 5      $ 	#FF3C3C3C��6   $ 0.174Q�6-   � 5      $ 	#FF3D3D3D��6   $ 0.326Q�6-   � 5      $ 	#FF707070��6   $
 0.55Q�6-   � 5      $ 	#FF1A1A1A��6   $ 1Q�6-   � 5      $ 	#FF0EB118��6   $ 1Q�6-   5       � DataContext 5      2   ,Assignment_UI.ViewModels.MainWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       $��* �6   �� 5!      $
��Auto �6   .+�5#   
   �� 	 �� Orientation$	 
Horizontal=�6   .+�5$      �� $E��?                    WPF APPLICATION FOR THE STUDENT DATA ENTRY ��6   $��5q�6b   $	��486��6m   
�������$��15(�6�   
���   �
 J� RenderTransformOrigin$
 0.5,0.5&�6�   $��20��6�   z�5%      V� 5&      .~�5'      �� �� 5(      �� 5)       �� Angle$
 0.29Q�6*   T� 5*      5+      5-      5.      &    Assignment_UI.Views.StudentsView  51   
   $��1��6   $��20q�6T    6*   �� *StudentsViewModel+6T   �� 53   
   $��25,195,25,42q�6   $��1��6,   $��2��69   .+�55      �� $��Insert Student��6      	ButtonOne#��[  6.   ��6Q   �� *%#StudentsViewModel.AddStudentCommand+��56      �� 57      $ 0.5,1&�6*   $ 0.5,0&�6;   .��58      � $ Black��6'   � 59      $ 	#FFA22525��6'   $ 1Q�69   5:      5<      �� 5=      $��Edit Student��6   #��[  6,   ��6O   �� *&$StudentsViewModel.EditStudentCommand+��5>      �� 5?      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5@      � $ Black��6'   � 5A      $ 	#FFA22525��6'   $ 1Q�69   5B      5D      �� 5E      $��Delete Student��6   #��[  6.   ��6Q   �� *(&StudentsViewModel.DeleteStudentCommand+��5F      �� 5G      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5H      � $ Black��6'   � 5I      $ 	#FFA22525��6'   $ 1Q�69   5J      5L      5M      �� 5N   
   -   5        $��Close��5N      $��2��6!   #��[  6.   
���   �5O   ,   5Q      5R      