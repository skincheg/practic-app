   M S B A M L   `   `   `  ���� E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp      PracticApp.AddDemand   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PracticApp     -     � Title$  	AddClient��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources    UpperButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration    PracticApp.RealtorsDataSet  realtorsDataSet  demandViewSource �� Source �� Source  clientsViewSource  realtorsViewSource  realtyTypeViewSource��%�  &	        &	 �    &	     7  &	      7  &	 ?    7  &	 _    7  �� " ��.���  �@�OverridesDefaultStyle . ��  � ��$ 30����  � ��$	 200����  � ��$
 0,10q���  � ��$ 14(���  � �� �	#FF0091EA��  � ��
 �������  � ��$
 Bold"���  � ��$ Alegreya Sans SC)���  � �� �� " ��.R��� $��border��$��0q�#��z��$	 10��._��� $��Center=�$��Center=�
 :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF00609BX�$ 0:0:0.5D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0.5D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D�  ��  �� *Demand+8   ��  �� *	Clients+8   ��  �� *
Realtors+8   ��  �� *
RealtyType+8   ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF97D9E1��� $ 	#FFD9AFD9�� � Offset$ 0.554Q�� $ 	#FFD8AFD9��$ 0.547Q�.���  � RowDefinitions �� $��30 ��� $��* � � ColumnDefinitions �� $	��150 ��� $��* �.+�� $��0��$��1��$��Right=�.+���  �� Orientation$ 
Horizontal=�.+��� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��_�� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��X�� $	��150��$	��420��$��0,2,2,0q�$��1��$��0��$��Center=�$��Center=����	#FFAC79B6._�� $��Center=�$��Center=�.+��� $	��120��$��Resources/logo.png���� $	��650��$	��420��$��0,2,0,0q�$��1��$��1�����	#FFAC79B6._��� $��10q�$
��Left=�$	��Top=�$ Vertical=� � DataContext# [ .+�� -    �Name$ grid1��$
��Left=�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� &   System.Windows.Controls.DataGrid  -     Name$ demandDataGrid��$
��Left=�   
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $	��150��   RowDetailsVisibilityMode$ VisibleWhenSelected=�$	��582������    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   clientIDColumn��,  &System.Windows.Controls.DataGridColumn    Header$  Клиент��!   Width5  /System.Windows.Controls.DataGridLengthConverter$! * 1  +System.Windows.Controls.DataGridBoundColumn"   Binding" �� *
ClientID+  -   realtorIDColumn��$  Риэлтор��$! * " �� *	RealtorID+  -   
typeColumn��$  Недвижимость��$! * " �� *Type+  -	   addressColumn��$  
Адрес��$! * " �� *	Address+  -
   minPriceColumn��$  Мин.цена��$! * " �� *
MinPrice+  -   maxPriceColumn��$  Макс.цена��$! * " �� *
MaxPrice+�� $ 
Horizontal=�.+��� .+��� $ 
Horizontal=�# [ .+��� $��80��$��Клиент:��$
��Left=�$��Center=��� -   # ��Name$# clientID��$ �� DisplayMemberPath$$ ID��$
��Left=�$��23��$��3q�$��Center=�$	��120������ ���� .R�$� �� $ 
Horizontal=�# [ .+��� $��80��$��Риэлтор:��$
��Left=�$��Center=��� -   $# 	realtorID��$$ ID��$
��Left=�$��23��$��3q�$��Center=�$	��120������ ���� .R�$� �� $ 
Horizontal=�# [ .+��� $��80��$��Тип:��$
��Left=�$��Center=��� -   $
# type��$
$ Type��$
��Left=�$��23��$��3q�$��Center=�$	��120������ ���� .R�$� �� $ 
Horizontal=�.+��� $��80��$��Адрес:��$
��Left=�$��Center=��� -   % ��Name$% address��$
��Left=�$��23��$��3q�$��Center=�$	��120���� $ 
Horizontal=�.+��� $��80��$��Мин.цена:��$
��Left=�$��Center=��� -   $% minPrice��$
��Left=�$��23��$��3q�$��Center=�$	��120���� $ 
Horizontal=�.+��� $��80��$��Макс.цена:��$
��Left=�$��Center=��� -   $% maxPrice��$
��Left=�$��23��$��3q�$��Center=�$	��120���� -   & ��Name$& apartmentPanel��$��0��$��20,0,0,0q�$ Vertical=�.+��� $ 
Horizontal=�.+��� $	��100��$��Мин.этаж:��$
��Left=�$��Center=��� -   $% apartmentMinFloor��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Макс.этаж:��$
��Left=�$��Center=��� -   $% apartmentMaxFloor��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Мин.площадь:��$
��Left=�$��Center=��� -   $% apartmentMinArea��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Макс.площадь:��$
��Left=�$��Center=��� -   $% apartmentMaxArea��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Мин.комнат:��$
��Left=�$��Center=��� -   $% apartmentMinRooms��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Макс.комнат:��$
��Left=�$��Center=��� -   $% apartmentMaxRooms��$	��120��$��23���� -   $& 
housePanel��$��0��$��20,0,0,0q�$ Vertical=�.+��� $ 
Horizontal=�.+��� $	��100��$��Мин.этажей:��$
��Left=�$��Center=��� -   $% houseMinFloors��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Макс.этажей:��$
��Left=�$��Center=��� -   $% houseMaxFloors��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Мин.площадь:��$
��Left=�$��Center=��� -   $% houseMinArea��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Макс.площадь:��$
��Left=�$��Center=��� -   $% houseMaxArea��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Мин.комнат:��$
��Left=�$��Center=��� -   $% houseMinRooms��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Макс.комнат:��$
��Left=�$��Center=��� -   $% houseMaxRooms��$	��120��$��23���� -    $& 	landPanel��$��0��$��20,0,0,0q�$ Vertical=�.+��� $ 
Horizontal=�.+��� $	��100��$��Мин.площадь:��$
��Left=�$��Center=��� -!   $% landMinArea��$	��120��$��23���� $ 
Horizontal=�.+��� $	��100��$��Макс.площадь:��$
��Left=�$��Center=��� -"   $% landMaxArea��$	��120��$��23���� $ 
Horizontal=�$��Bottom=�$
��Left=�.+��� -#   #��[  $+��%Сохранить изменения��$��0,0,10,0q��� -$   #��[  $-��'Добавить потребность��$��0,0,10,0q��� -%   #��[  $+��%Удалить потребность��