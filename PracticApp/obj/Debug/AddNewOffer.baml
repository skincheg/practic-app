   M S B A M L   `   `   `  ����E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp  5   	       PracticApp.AddNewOffer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PracticApp     5   	   -   5          � Title$  	AddClient��5   	   $	��300��6   $	��500��6(    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y    � 
ResizeMode$ NoResize=�6l   ���	#FFAE72AE$��4q�6�    � 	Resources 5	          PracticApp.RealtorsDataSet   realtorsDataSet  personViewSource �� Source �� Source  personClientsViewSource  UpperButton �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration  clientsViewSource  offerViewSource  realtorsViewSource  realtyViewSource��%�  &	        &	      7   &	 ?     7  &	 v     &	 �    7   &	 �    7   &	 
    7   &	 8    7     5
   
   6    �� 5   
    68   �� *Person+8   �� 5   
    6?   �� *FK_Clients_Person+8   �� 5   
   " ��6$   .�5      ��  �@�OverridesDefaultStyle	 . 66   �� 5       � ��$	 30��6'   �� 5       � ��$		 300��6&   �� 5       � ��$	 10q�6'   �� 5       � ��$	 14(�6)   �� 5       � ��	 �	#FF0091EA6+   �� 5       � ��
	 �����6+   �� 5       � ��$
	 Bold"�6+   �� 5       � ��$	 Alegreya Sans SC)�6+   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      �� $��border��6!   $��0q�5      #��z��5      $ 10��5      ._�5      �� $��Center=�6/   $��Center=�6L   5       5!      5#       5%      :� 5&      $ Button.MouseEnter��6   [�5'      �� 5(      .��5)      �� .��5*   "   �� $1 +(Button.Background).(SolidColorBrush.Color)�5+      $ 	#FF00609BX�5,      $ 0:0:0.5D�6"   5-      5.      50      :� 52      $ Button.MouseLeave��6   [�53      �� 54      .��55      �� .��56   "   �� $1 +(Button.Background).(SolidColorBrush.Color)�57      $ 	#FF0091EAX�58      $ 0:0:0.5D�6"   59      5:      5<      :� 5>      $ Button.Click��6   [�5?      �� 5@      .��5A      �� .��5B   "   �� $1 +(Button.Background).(SolidColorBrush.Color)�5C      $ 	#FF002942X�5D      $ 0:0:0D�6"   5E      5F      5H      5L      �� 5M   
    69   �� *	Clients+8   �� 5N   
    67   �� *Offer+8   �� 5O   
    6:   �� *
Realtors+8   �� 5P   
    68   �� *Realty+8   5S      ��5T      �� 5U   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5V      �  � Color$ 	#FF97D9E1��6   � 5W      $ 	#FFD9AFD9��6    � Offset$ 0.554Q�6-   � 5X      $ 	#FFD8AFD9��6   $ 0.547Q�6-   5Y      .��5[      �  � DataContext# [ 6    � RowDefinitions 5\   
   �� 5]      $��30 �6   �� 5^      $��* �6    � ColumnDefinitions 5a   
   �� 5b      $��* �6   .+�5e   
   � $��0��6   $��Right=�6   .+�5f      ��  �� Orientation$ 
Horizontal=�6   .+�5g      �� -   5        $��30��5g      ���	#FFAC79B6
������ $��1q�6U   $��14(�6i   .��6�   X6�   5h      5i      � 5k   
   $��1��6   .+�5l      �� $��20q�6   .+�5m      �� -   5         ��Name$ grid2��5m   6   $ 
Horizontal=�6   # [ 6E   $
��Left=�6v   $	��Top=�6�   .+�5n      �� $	��100��6   $��Клиент:��6(   $
��Left=�6:   $��Center=�6U    J� RenderTransformOrigin$ 0.5,0.5&�6p   �� 5o      -   5         ��Name$ clientID��5o       �� DisplayMemberPath$ ID��61   $
��Left=�6H   $��23��6c   $��Center=�6�   $	��120��6�   ��6o   �� ��5p      �� 5q      .R�5r   "   $� 5s      5u      5v      �� 5w      $ 
Horizontal=�6   # [ 66   $
��Left=�6h   $	��Top=�6�   .+�5x      �� $	��100��6   $��Риэлтор:��6(   $
��Left=�6;   $��0��6V   $��Center=�6c   �� 5y      -   5        $ 	realtorID��5y      $ ID��62   $
��Left=�6I   $��23��6d   $��Center=�6�   $	��120��6�   ��6p   �� ��5z      �� 5{      .R�5|   "   $� 5}      5      5�      �� 5�      $ 
Horizontal=�6   # [ 66   $
��Left=�6f   $	��Top=�6�   .+�5�      �� $	��100��6   $��Недвижимость:��6(   $
��Left=�6@   $��0��6[   $��Center=�6h   �� 5�      -   5        $ realtyID��5�      $ ID��61   $
��Left=�6H   $��23��6c   $��Center=�6�   $	��120��6�   ��6o   �� ��5�      �� 5�      .R�5�   "   $� 5�      5�      5�      �� 5�      $ 
Horizontal=�6   $
��Left=�66   $	��Top=�6Q   .+�5�      �� $��	Цена:��6   $	��100��6,   $
��Left=�68   $��Center=�6S   �� 5�      -   5         ��Name$ price��5�      $��23��6-   $	��120��69   5�      5�      5�      �� 5�   
   $	��500��6   $	��270��6   $��0,2,0,0q�6*   $��1��6D   $��1��6Q   $��Center=�6a   $��Center=�6~   ���	#FFAC79B6._�5�      �� -   5        #��[ 5�      $-��'Добавить предложение��6:   $��Center=�6p   $��Bottom=�6�   5�      5�      5�      