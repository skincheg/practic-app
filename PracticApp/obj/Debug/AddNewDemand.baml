   M S B A M L   `   `   `  ����E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp  5   	       PracticApp.AddNewDemand   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PracticApp     5   	   -   5          � Title$  	AddClient��5   	   $	��300��6   $	��500��6(    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y    � 
ResizeMode$ NoResize=�6l   ���	#FFAE72AE$��4q�6�    � 	Resources 5	         UpperButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration    PracticApp.RealtorsDataSet  realtorsDataSet  demandViewSource �� Source �� Source  clientsViewSource  realtorsViewSource  realtyTypeViewSource��%R  &	        &	 <    &	 O    7  &	 {    7  &	 �    7  &	 �    7  �� 5
   
   " ��6$   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��$ 30��6'   �� 5       � ��$	 300��6&   �� 5       � ��$ 10q�6'   �� 5       � ��$ 14(�6)   �� 5       � �� �	#FF0091EA6+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Alegreya Sans SC)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�5      #��z��5      $	 10��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       
 5"      :� 5#      $ Button.MouseEnter��6   [�5$      �� 5%      .��5&      �� .��5'   "   �� $1 +(Button.Background).(SolidColorBrush.Color)�5(      $ 	#FF00609BX�5)      $ 0:0:0.5D�6"   5*      5+      5-      :� 5/      $ Button.MouseLeave��6   [�50      �� 51      .��52      �� .��53   "   �� $1 +(Button.Background).(SolidColorBrush.Color)�54      $ 	#FF0091EAX�55      $ 0:0:0.5D�6"   56      57      59      :� 5;      $ Button.Click��6   [�5<      �� 5=      .��5>      �� .��5?   "   �� $1 +(Button.Background).(SolidColorBrush.Color)�5@      $ 	#FF002942X�5A      $ 0:0:0D�6"   5B      5C      5E      5I        5J   
   6    �� 5K   
    68   �� *Demand+8   �� 5L   
    69   �� *	Clients+8   �� 5M   
    6:   �� *
Realtors+8   �� 5N   
    6<   �� *
RealtyType+8   5P      ��5Q      �� 5R   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5S      �  � Color$ 	#FF97D9E1��6   � 5T      $ 	#FFD9AFD9��6    � Offset$ 0.554Q�6-   � 5U      $ 	#FFD8AFD9��6   $ 0.547Q�6-   5V      .��5X      �  � DataContext# [ 6    � RowDefinitions 5Y   
   �� 5Z      $��30 �6   �� 5[      $��* �6    � ColumnDefinitions 5^   
   �� 5_      $��* �6   .+�5b   
   � $��0��6   $��Right=�6   .+�5c      ��  �� Orientation$ 
Horizontal=�6   .+�5d      �� -   5        $��30��5d      ���	#FFAC79B6
������ $��1q�6U   $��14(�6i   .��6�   X6�   5e      5f      � 5h   
   $��1��6   .+�5i      �� $��20q�6   .+�5j      �� $ 
Horizontal=�6   # [ 66   .+�5k      �� $��80��6   $��Клиент:��6'   $
��Left=�69   $��Center=�6U   �� 5l      -   5         ��Name$ clientID��5l       �� DisplayMemberPath$ ID��61   $
��Left=�6H   $��23��6c   $��3q�6�   $��Center=�6�   $	��120��6�   ��6o   �� ��5m      �� 5n      .R�5o   "   $� 5p      5r      5s      � 5u      -   5         �Name$ grid2��5u      # [ 6&   $
��Left=�6X   $��1��6s   $	��Top=�6�    5v      �� 5w      $
��Auto �6+   �� 5x      $
��Auto �6+    5z      �� 5{      $
��Auto �6(   .+�5}      �� $��Риелтор:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��0��6e   $��Center=�6r   �� 5~      -   5        $ iDComboBox1��5~      $��1��64   $ ID��6D   $
��Left=�6[   $
��Auto��6v   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�   ��6�   �� ��5      �� 5�      .R�5�   "   $� 5�      5�      5�      � 5�      -   5        $ grid3��5�      # [ 6&   $
��Left=�6Z   $��1��6u   $	��Top=�6�    5�      �� 5�      $
��Auto �6+   �� 5�      $
��Auto �6+    5�      �� 5�      $
��Auto �6(   .+�5�      �� $��Тип:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 5�      -   5        $ typeComboBox��5�      $��1��65   $
 Type��6E   $
��Left=�6^   $
��Auto��6y   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�   ��6�   �� ��5�      �� 5�      .R�5�   "   $� 5�      5�      5�      � 5�      -   5        $ grid4��5�      # [ 6&   $
��Left=�6V   $��1��6q   $	��Top=�6~    5�      �� 5�      $
��Auto �6+   �� 5�      $
��Auto �6+    5�      �� 5�      $
��Auto �6(   .+�5�      �� $��Адрес:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��0��6c   $��Center=�6p   �� 5�      -	   5         ��Name$ addressTextBox��5�      $��1��66   $
��Left=�6F   $��23��6a   $��3q�6m   $��0��6x   $��Center=�6�   $	��120��6   ��6�   �� *	Address+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6   5�      � 5�      -
   5        $ grid5��5�      # [ 6&   $
��Left=�6V   $��1��6q   $	��Top=�6~    5�      �� 5�      $
��Auto �6+   �� 5�      $
��Auto �6+    5�      �� 5�      $
��Auto �6(   .+�5�      �� $��Мин.цена:��6   $��0��60   $
��Left=�6@   $��3q�6[   $��0��6f   $��Center=�6s   �� 5�      -   5        $ minPriceTextBox��5�      $��1��67   $
��Left=�6G   $��23��6b   $��3q�6n   $��0��6y   $��Center=�6�   $	��120��6  ��6�   �� *
MinPrice+$ TwoWay=� .  . 6  5�      � 5�      -   5        $ grid6��5�      # [ 6&   $
��Left=�6V   $��1��6q   $	��Top=�6~    5�      �� 5�      $
��Auto �6+   �� 5�      $
��Auto �6+    5�      �� 5�      $
��Auto �6(   .+�5�      �� $��Макс.цена:��6   $��0��61   $
��Left=�6A   $��3q�6\   $��0��6g   $��Center=�6t   �� 5�      -   5        $ maxPriceTextBox��5�      $��1��67   $
��Left=�6G   $��23��6b   $��3q�6n   $��0��6y   $��Center=�6�   $	��120��6  ��6�   �� *
MaxPrice+$ TwoWay=� .  . 6  5�      �� 5�      -   5          ��Name$  
errorLabel��5�   7   $��10(�6   
���  ��67   5�      5�      �� 5�   
   $	��500��6   $	��270��6   $��0,2,0,0q�6*   $��1��6D   $��1��6Q   $��Center=�6a   $��Center=�6~   ���	#FFAC79B6._�5�      �� -   5        #��[  5�      $%��Добавить клиента��6:   $��Center=�6j   $��Bottom=�6�   5�      5�      5�      