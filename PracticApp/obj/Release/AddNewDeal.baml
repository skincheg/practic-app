   M S B A M L   `   `   `  ���� E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp      PracticApp.AddNewDeal   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PracticApp     -     � Title$  	AddClient��$	��300��$	��500�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=����	#FFAE72AE$��4q� � 	Resources    UpperButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration    PracticApp.RealtorsDataSet  realtorsDataSet  dealViewSource �� Source �� Source  clientsViewSource  offerViewSource  demandViewSource��%�  &	        &	 �    &	      7  &	     7  &	 ;    7  &	 X    7  �� " ��.���  �@�OverridesDefaultStyle . ��  � ��$ 30����  � ��$	 300����  � ��$ 10q���  � ��$ 14(���  � �� �	#FF0091EA��  � ��
 �������  � ��$
 Bold"���  � ��$ Alegreya Sans SC)���  � �� �� " ��.R��� $��border��$��0q�#��z��$	 10��._��� $��Center=�$��Center=�
 :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF00609BX�$ 0:0:0.5D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0.5D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D�  ��  �� *Deal+8   ��  �� *	Clients+8   ��  �� *Offer+8   ��  �� *Demand+8   ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF97D9E1��� $ 	#FFD9AFD9�� � Offset$ 0.554Q�� $ 	#FFD8AFD9��$ 0.547Q�.���  � RowDefinitions �� $��30 ��� $��* � � ColumnDefinitions �� $��* �.+�� $��0��$��Right=�.+���  �� Orientation$ 
Horizontal=�.+��� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��X� $��1��.+��� $��20q�.+�� -    �Name$ grid3�� � DataContext# [ $
��Left=�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto �.+��� $��Предложение:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -    ��Name$ offerID��$��1�� �� DisplayMemberPath$ ID��$
��Left=�$
��Auto��$��3q�$��0��$��Center=�$	��120������ ���� .R�$� � -   $ grid2��# [ $
��Left=�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto �.+��� $��Потребность:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ demandID��$��1��$ ID��$
��Left=�$
��Auto��$��3q�$��0��$��Center=�$	��120������ ���� .R�$� �� -    ��Name$ 
errorLabel��$��10(�
���  ���� $	��500��$	��270��$��0,2,0,0q�$��1��$��1��$��Center=�$��Center=����	#FFAC79B6._��� -   #��[  $#��Добавить сделку��$��Center=�$��Bottom=�