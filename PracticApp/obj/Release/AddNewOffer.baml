   M S B A M L   `   `   `  ���� E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp      PracticApp.AddNewOffer   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PracticApp     -     � Title$  	AddClient��$	��300��$	��500�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=����	#FFAE72AE$��4q� � 	Resources     PracticApp.RealtorsDataSet   realtorsDataSet  personViewSource �� Source �� Source  personClientsViewSource  UpperButton �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration  clientsViewSource  offerViewSource  realtorsViewSource  realtyViewSource��%)  &	        &	      7   &	 #     7  &	 L     &	 G    7   &	 f    7   &	 �    7   &	 �    7     ��  �� *Person+8   ��  �� *FK_Clients_Person+8   �� " ��.���  �@�OverridesDefaultStyle	 . ��  � ��$	 30����  � ��$		 300����  � ��$	 10q���  � ��$	 14(���  � ��	 �	#FF0091EA��  � ��
	 �������  � ��$
	 Bold"���  � ��$	 Alegreya Sans SC)���  � ��	 �� "
 ��.R��� $��border��$��0q�#��z��$ 10��._��� $��Center=�$��Center=� :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF00609BX�$ 0:0:0.5D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0.5D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D���  �� *	Clients+8   ��  �� *Offer+8   ��  �� *
Realtors+8   ��  �� *Realty+8   ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF97D9E1��� $ 	#FFD9AFD9�� � Offset$ 0.554Q�� $ 	#FFD8AFD9��$ 0.547Q�.���  � DataContext# [  � RowDefinitions �� $��30 ��� $��* � � ColumnDefinitions �� $��* �.+�� $��0��$��Right=�.+���  �� Orientation$ 
Horizontal=�.+��� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��X� $��1��.+��� $��20q�.+��� -    ��Name$ grid2��$ 
Horizontal=�# [ $
��Left=�$	��Top=�.+��� $	��100��$��Клиент:��$
��Left=�$��Center=� J� RenderTransformOrigin$ 0.5,0.5&��� -    ��Name$ clientID�� �� DisplayMemberPath$ ID��$
��Left=�$��23��$��Center=�$	��120������ ���� .R�$� �� $ 
Horizontal=�# [ $
��Left=�$	��Top=�.+��� $	��100��$��Риэлтор:��$
��Left=�$��0��$��Center=��� -   $ 	realtorID��$ ID��$
��Left=�$��23��$��Center=�$	��120������ ���� .R�$� �� $ 
Horizontal=�# [ $
��Left=�$	��Top=�.+��� $	��100��$��Недвижимость:��$
��Left=�$��0��$��Center=��� -   $ realtyID��$ ID��$
��Left=�$��23��$��Center=�$	��120������ ���� .R�$� �� $ 
Horizontal=�$
��Left=�$	��Top=�.+��� $��	Цена:��$	��100��$
��Left=�$��Center=��� -    ��Name$ price��$��23��$	��120���� $	��500��$	��270��$��0,2,0,0q�$��1��$��1��$��Center=�$��Center=����	#FFAC79B6._��� -   #��[ $-��'Добавить предложение��$��Center=�$��Bottom=�