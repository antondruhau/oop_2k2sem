   M S B A M L   `   `   `  ����A  =lab6-7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab6_7lab6_7  5   	       lab6_7.EditItem   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:lab6_7     5   	     � Title$  EditItem��5   	   $	��500��6   $	��600��6'   ���#23272a$	��600��6H   $	��500��6W    � 	Resources 5	       �� 
TargetType   centeredText �� Property �� Value  leftText  
paramsText��%  &	        &	 �     &	 �    �� 5
   
   " ��6   .�5      ��  �@��TextAlignment$ Center=�6.   6?   �� 5       � �� �#99aab56=   �� 5       � ��$ 
ArialBlack)�6+   6@   5      �� 5   
   " ��6   .�5      ��  �@��TextAlignment$
 Left=�6.   6=   �� 5       � �� �#99aab56=   �� 5       � ��$ 
ArialBlack)�6+   6@   �� 5       � ��$ 15(�6)   66   5      �� 5   
   " ��6   .�5      ��  �@��TextAlignment$
 Left=�6.   6=   �� 5       � �� �#99aab56=   �� 5       � ��$ 
ArialBlack)�6+   6@   �� 5       � ��$ 15(�6)   66   �� 5       � ��$ 20��6'   64   �� 5       � ��$ 20,20,200,0q�6'   6=   �� 5       � ��$	 150��6&   64   5      5      .��5      � .+�5    
   �� $��1��6   $��2��6%   $��
-400,0,0,0q�69   $��1��6M   $	��220��6Z   $��10��6f   .+�5!      �� -   5         ��Name$ ItemPicture��5!      $	��220��6)   $	��180��66   $��0,80,0,0q�6B   $��empty-cart.png��6T   6n   �� 5"      -   5         ��Name$ ButtonAddPicture��5"      $��	20,26,0,0q�6/   $	��190��6B   $��44��6N   ���#7289da$
��Bold"�6o   .��5#      �� #��[  6   $��12(�6B   $
��Wrap=�6P   ���#2c2f33  EditPicture#���  6y   6�   5$      �� 5%      -   5        $ ButtonSaveEditings��5%      $	��190��61   $��44��6=   $��	20,25,0,0q�6I   ���#7289da.��5&      �� #��[  6   ���#2c2f33$
��Bold"�6W     SaveEditings#���  6i   6�   5'      5(      �� 5)   
   $��1��6   $��1��6"   $��6��62   $��	200,0,0,0q�6F   .+�5*      �� $��1��6   $��2��6&   $��54��66   .+�5+      �� -   5         ��Name$ TextBlockNameGood��5+      #��[ 67     ItemName#���  6[   6   �� 5,      -   5         ��Name$ TextBoxNameGood��5,      $	��150��63   $��160,-24,0,0q�6?   $��20��6T   6b   5-      �� 5.      $��2��6   $��2��6&   $��54��66   .+�5/      �� -   5        $ TextBlockCategory��5/      #��[ 67     Category#���  6[   6   �� 50      -   5        	 ��Name$	 ComboBoxCategory��50      $	��150��65   $��20��6A   $��160,-22,0,0q�6M   .@�51      ��  
 Berrys#���  6#   �� 52       	 Dairy#���  6#   �� 53       
	 Fruits#��� 	 6#   �� 54       
 
Vegetables#��� 
 6#   55      56      �� 57      $��3��6   $��2��6&   $��53��66   .+�58      �� -   5        $ TextBlockPrice��58      #��[ 64    	 Price#���  6X   6y   �� 59      -	   5        $ TextBoxPrice��59      $	��100��60   $��160,-24,50,0q�6<   $��20��6R   6   �� 5:      -
   5        $ TextBlockCurrency��5:      #��[ 67   $��50��6Y   $��20��6d   $��300,-20,0,0q�6p     Currency#���  6�   6�   5;      �� 5<      $��4��6   $��2��6&   $��53��66   .+�5=      �� -   5        $ TextBlockCountry��5=      #��[ 66     Country#���  6Z   6}   �� 5>      -   5        $ TextBoxCountry��5>      $	��150��62   $��160,-24,0,0q�6>   $��20��6S   6a   5?      �� 5@      $��5��6   $��2��6&   $��53��66   .+�5A      �� -   5        $ TextBlockAvailable��5A      #��[ 68     	Available#���  6\   6�   	� 5B      -   5        
 	�Name$
 RadioButtonAvailable��5B      $��-134,-18.5,0,0q�6<   $��15��6T   6a   �� 5C      -   5        $ TextBlockNotAvailable��5C      #��[ 6;   $��150,-22,0,0q�6_     NotAvailable#���  6t   6�   	� 5D      -   5        $
 RadioButtonNotAvailable��5D      $��230,-19,0,0q�6?   $��15��6T   6a   5E      �� 5F      $��6��6   $��2��6&   $	��180��66   .+�5G      �� -   5        $ TextBlockDescription��5G      #��[ 6:     Description#���  6^   6�   �� 5H      -   5        $ TextBoxDescription��5H      $	��320��66   $	��100��6B   $��
-10,20,0,0q�6O   6e   5I      5J      5K      5L      