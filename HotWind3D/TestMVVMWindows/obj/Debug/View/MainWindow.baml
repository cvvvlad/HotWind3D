   M S B A M L   `   `   `  ����D  @HotWind3D, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HotWind3D.ViewHotWind3D.View  5   	   9!clr-namespace:HotWind3D.ViewModelHotWind3D.ViewModel  5   	       HotWind3D.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -viewclr-namespace:HotWind3D.View     5   	   0vm!clr-namespace:HotWind3D.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5   	   �� *MainViewModel+   Locator �� Source# [   � 	Resources 5         HotWind3D.View.Outliner  Outliner��%   &	         5	   
   6   5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��12* �6   �� 5      $	��17* �6   �� 5      $
��135* �6   .+�5   
   o� $��0��6   $��3��6   .@�5      m� $��Window��6   .@�5      m� $��Outliner��6    m� CommandParameter# [ 6S    m� Command 6-   �� *ShowWindowCommand+6S   5      5      o� 5   
   $��1��6   $��Center=�6   $��3��67   $	��0,3q�6K   � 5   
   $��2��6   $��0��6   .+�5      �� $��Stretch=�6   $��Stretch=�6:   ��6X   �� *LeftViewModel+5      �� 5   
   $��2��6   $��1��6$   $��Stretch=�64   $��5��6P   � 5    
   $��2��6   $��2��6    5!      �� 5"      $��24 �6    �� 5#      $
��Auto �6    .+�5%      �� -   5         ��Name$ ComboBoxWindows��5%   E   $��0��6   ��6%   �� *	Windows+	 �� SelectedItem	 6^   �� *SelectedViewModel+��5&      �� 5'      .R�5(      �� ��6$   �� *Name+5)      5+      �� 5,      $��Stretch=�6   $��Stretch=�69   $��1��6W   ��6d   �� *SelectedViewModel+5-      5.      5/      