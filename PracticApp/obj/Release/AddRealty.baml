   M S B A M L   `   `   `  ���� E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp      PracticApp.AddRealty   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PracticApp     -     � Title$  	AddClient��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources     PracticApp.RealtorsDataSet   realtorsDataSet  personViewSource �� Source �� Source  personClientsViewSource  UpperButton �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration  clientsViewSource  realtyViewSource # realtyRealtyAddressesViewSource  realtyAddressesViewSource��%F  &	        &	      7   &	 #     7  &	 L     &	 I    7   &	 h    7   &	 �    7  &	 �    7     ��  �� *Person+8   ��  �� *FK_Clients_Person+8   �� " ��.���  �@�OverridesDefaultStyle	 . ��  � ��$	 30����  � ��$		 200����  � ��$
	 0,10q���  � ��$	 14(���  � ��	 �	#FF0091EA��  � ��
	 �������  � ��$
	 Bold"���  � ��$	 Alegreya Sans SC)���  � ��	 �� "
 ��.R��� $��border��$��0q�#��z��$ 10��._��� $��Center=�$��Center=� :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF00609BX�$ 0:0:0.5D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0.5D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D���  �� *	Clients+8   ��  �� *Realty+8   ��  �� *FK_RealtyAddresses_Realty+8   ��  �� *RealtyAddresses+8   ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF97D9E1��� $ 	#FFD9AFD9�� � Offset$ 0.554Q�� $ 	#FFD8AFD9��$ 0.547Q�.���  � RowDefinitions �� $��30 ��� $��* � � ColumnDefinitions �� $	��150 ��� $��* �.+�� $��0��$��1��$��Right=�.+���  �� Orientation$ 
Horizontal=�.+��� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��_�� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��X�� $	��150��$	��420��$��0,2,2,0q�$��1��$��0��$��Center=�$��Center=����	#FFAC79B6._�� $��Center=�$��Center=�.+��� $	��120��$��Resources/logo.png���� $	��650��$	��420��$��0,2,0,0q�$��1��$��1�����	#FFAC79B6._��� $��10q�$
��Left=�$	��Top=�$ Vertical=� � DataContext# [ .+�&   System.Windows.Controls.DataGrid  -     Name$ realtyAddressesDataGrid��$��0,0,0,10q�   SelectionMode$ Single=�$
��Left=�   
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $	��150��   RowDetailsVisibilityMode$ VisibleWhenSelected=�$	��500������ # [    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   
cityColumn��,  &System.Windows.Controls.DataGridColumn    Header$
  City��!   Width5  /System.Windows.Controls.DataGridLengthConverter$! * 1  +System.Windows.Controls.DataGridBoundColumn"   Binding" �� *City+  -   streetColumn��$  Street��$! * " �� *Street+  -   houseColumn��$  House��$! 60 " �� *House+  -   
flatColumn��$
  Flat��$! 60 " �� *Flat+�� $��0,0,0,20q�$ 
Horizontal=�.+�	� -	   # 	�Name$# apartmentRB��$��0,0,20,0q�$ 	� 	GroupName$$ 
realtyType��.��Квартиры	� -
   $# houseRB��$��0,0,20,0q�$$ 
realtyType��.��
Дома	� -   $# landRB��$$ 
realtyType��.��Участки�� $ 
Horizontal=�.+��� .+��� $ 
Horizontal=�.+��� $��80��$��Город:��$
��Left=�$��Center=��� -   % ��Name$% cityTextBox��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Улица:��$
��Left=�$��Center=��� -   $% streetTextBox��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Дом:��$
��Left=�$��Center=��� -   $% houseTextBox��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Квартира:��$
��Left=�$��Center=��� -   $% flatTextBox��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Широта:��$
��Left=�$��Center=��� -   $% latitudeTextBox��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Долгота:��$
��Left=�$��Center=��� -   $% longitudeTextBox��$	��120��$��23���� -   & ��Name$& apartmentPanel��$��0��$��20,0,0,0q�$ Vertical=�.+��� $ 
Horizontal=�.+��� $��80��$��	Этаж:��$
��Left=�$��Center=��� -   $% apartmentFloor��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Комнат:��$
��Left=�$��Center=��� -   $% apartmentRooms��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Площадь:��$
��Left=�$��Center=��� -   $% apartmentArea��$	��120��$��23���� -   $& 
housePanel��$��0��$��20,0,0,0q�$ Vertical=�.+��� $ 
Horizontal=�.+��� $��80��$��Этажей:��$
��Left=�$��Center=��� -   $% 
houseFloor��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Комнат:��$
��Left=�$��Center=��� -   $% 
houseRooms��$	��120��$��23���� $ 
Horizontal=�.+��� $��80��$��Площадь:��$
��Left=�$��Center=��� -   $% 	houseArea��$	��120��$��23���� -   $& 	landPanel��$��0��$��20,0,0,0q�$ Vertical=�.+��� $ 
Horizontal=�.+��� $��80��$��Площадь:��$
��Left=�$��Center=��� -   $% landArea��$	��120��$��23���� $��Bottom=�$ 
Horizontal=�.+��� -   #��[ $+��%Сохранить изменения��$��0,0,10,0q��� -   #��[ $��Добавить��$��0,0,10,0q��� -   #��[ $��Удалить��