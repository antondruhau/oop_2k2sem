   M S B A M L   `   `   `  ����A  =lab6-7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab6_7lab6_7  5   	   clr-namespace:lab6_7lab6_7  5   	       lab6_7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,MyNamespaceclr-namespace:lab6_7     5   	   (controlclr-namespace:lab6_7     5   	   -   5          �Name$  MainWindow1��5   	    � Title$ Grocery Store��5	   	   $	��610��6   $	��900��6,   $	��900��68   $	��600��6G    � Icon$$ iconfinder_Harvest_2998126.ico��6W    � Topmost .  � 	Resources 5
         
UserCursor  ButtonCursor �� 
TargetType  menuButtons �� Property �� Value  centeredText��%-  &	        &	 %     &	 P     &	 K    ��5   
   D:\banana.cur��63   ��5   
   D:\bananaOpened.cur��6;   �� 5   
   " ��6   .�5      ��  � ��$ Arial Black)�6+   6A   �� 5       � �� �#99aab56=   �� 5       � �� �#2c2f336=   �� 5       � ��$ 0q�60   6<   �� 5       � ��$ 30��6'   64   5      �� 5   
   " ��6   .�5      ��  �@��TextAlignment$ Center=�6.   6?   �� 5       � �� �#99aab56=   �� 5       � ��$ 
ArialBlack)�6+   6@   5      5      .��5      �  � Cursor# [  6   
���   �	 � RowDefinitions	 5   
   �� 5      $
��230* �6   �� 5      $	��29* �6   �� 5      $	��31* �6   
 � ColumnDefinitions
 5    
   �� 5!      $
��227* �6   �� 5"      $
��666* �6   .+�5$   
   �� $��0,0,3,0q�6   ���#2c2f33$��0,0,18.2,-4q�6A   $��3��6V   $��0��6g   ._�5%      �� $��0��6   $��0��6)   $��3��66   $��0,0,-23.8,0q�6G     	MenuStyle#���  6\   .+�5&      �� -   5         ��Name$ 	LabelMenu��5&      $
��15pt(�6/    �� Padding$ 14q�6?   $��50��6L    	 Texts#���  6X    �� TextAlignment$ Center=�6x   $
��Bold"�6�     menu#���  6�   6�   �� 5'      -   5         ��Name$ ButtonOutputBasket��5'      $��	0,10,0,20q�65   # [ 6H     ButtonsStyle#���  6o   .��5(      �� $
��Wrap=�6      OutputBasket#���  64   #���  6Z   6}   5)      �� 5*      -   5        $ ButtonEditBasket��5*      #���  63   # [ 6Z   $��0,0,0,20q�6�   .��5+      �� $
��Wrap=�6     	 
EditBasket#��� 	 64   #���  6X   6z   5,      �� 5-      -   5        $ ButtonAddGood��5-      #���  60   # [ 6W   .��5.      �� $
��Wrap=�6     
 AddGood#��� 
 64   #���  6U   6w   5/      �� 50      -   5        $ ButtonEN��50      $��50��6+   $��50��67   $��
-80,20,0,0q�6B   # [ 6V   
������ $��0q�6�   
 � Tag$ ru-RU��6�   .��51      �� $"��united-states-of-america.png��6   6D   52      �� 53      -   5        $ ButtonRU��53      $��50��6+   $��50��67   $��
80,-50,0 0q�6B   # [ 6V   
������ $��0q�6�   .��54      �� $��
russia.png��6   $ en-US��60   6>   55      �� 56        ChangeTheme#���  6   #���  6A   $
��Bold"�6a   $��14(�6s   $��	20,20,0,0q�6�   6�   �� 57      -   5         ��Name$ ComboBoxThemes��57      ���#2c2f33$	��150��6H   $��
-10,10,0,0q�6T   .@�58      ��   
LightTheme#���  6#   �� 59        	DarkTheme#���  6#   5:      5;      5<      �� 5=   
   $��0��6   $��1��6%   $��
0,0,3.2,62q�62   $��2��6F   .+�5>      �� -	   5        $ ButtonExitApplication��5>      $
��auto��5?      $��50��5@      $��4,4,0,0q�5A        
ButtonExit#���  5B      $
��Bold"�5C      $��0q�5D      $��16(�5E      # [ 5F      ��5G      �� 5H      " ��6    �� Triggers 5I      :� 5J       :� RoutedEvent$ 
MouseEnter��6+   [�5K   "   �� 5L   &   .��5M   *   �� .��5N   .   W�  g� Duration$ 	0:0:0.150D�6>    �� TargetProperty$ FontSize�6S   	 W� To$ 20X�6x   6�   5O   +   5P   '   5R      :� 5S      $ 
MouseLeave��6+   [�5T   "   �� 5U   &   .��5V   *   �� .��5W   .   W� $ 	0:0:0.150D�6>   $ FontSize�6S   $ 16X�6x   6�   5X   +   5Y   '   5[      .�5]      ��  � �� �#EF5B516I   5^      5`      5b      �� 5c   
   -
   5         ��Name$  StackPanelExitConfirmation��5c      $��0��69   $��4��6F   $��1��6W     BackgroundStyle#���  6g   $y�Hidden=�6�   .+�5d      ��   TypeExit#���  6   #���  6:   $ Center=�6Z   $��	0,150,0,0q�6q   $��20(�6�   6�   *   $lab6_7.CustomControlExitConfirmation  5e      -   5          Name$ CustomControlTextBoxExit��5e   4   *   $lab6_7.CustomControlExitConfirmation   TextChanged$* $CustomControlTextBoxExit_TextChanged��6�   $	��200��6V   $��40��6b   $��0,20,0,0q�6n    �� TextAlignment$ Center=�6�   6�   �� 5f      -   5        $ ButtonCacnelExit��5f      $	��200��6/   $��40��6;   $��16(�6G   $��0q�6U   $��0,20,0,0q�6i   $
��Bold"�6{     
CacnelExit#���  6�   ��5g      �� 5h      " ��6   .�5i      ��  � �� �#EF5B516I   5j      5l      5m      �� 5o   
   -   5        $ StackPanelMainFrame��5o      $��1��62   #���  6B   $��2.8,0,0.6,-4q�6l   $��3��6�   $y�Visible=�6�   .+�5p      �� $��shopping-basket.png��6   $	��260��61   $��0,80,0,0q�6>   �� 5q        MainText#���  6   $
��24pt(�6;   $��50��6K   $��0,50,0,0q�6W     Welcome#���  6i   6�   �� 5r      #���  6   $
��18pt(�6;   $��40��6K   $��	0,-10,0,0q�6W     GoodBuys#���  6j   6�   5s      5t      5u      