   M S B A M L   `   `   `  ���� E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp      PracticApp.AddDeal   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PracticApp     -     � Title$  	AddClient��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources    UpperButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration    PracticApp.RealtorsDataSet  realtorsDataSet  dealViewSource �� Source �� Source  clientsViewSource  offerViewSource  demandViewSource��%�  &	        &	 �    &	     7  &	     7  &	 =    7  &	 Z    7  �� " ��.���  �@�OverridesDefaultStyle . ��  � ��$ 30����  � ��$	 200����  � ��$
 0,10q���  � ��$ 14(���  � �� �	#FF0091EA��  � ��
 �������  � ��$
 Bold"���  � ��$ Alegreya Sans SC)���  � �� �� " ��.R��� $��border��$��0q�#��z��$	 10��._��� $��Center=�$��Center=�
 :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF00609BX�$ 0:0:0.5D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0.5D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D�  ��  �� *Deal+8   ��  �� *	Clients+8   ��  �� *Offer+8   ��  �� *Demand+8   ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF97D9E1��� $ 	#FFD9AFD9�� � Offset$ 0.554Q�� $ 	#FFD8AFD9��$ 0.547Q�.���  � RowDefinitions �� $��30 ��� $��* � � ColumnDefinitions �� $	��150 ��� $��* �.+�� $��0��$��1��$��Right=�.+���  �� Orientation$ 
Horizontal=�.+��� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��_�� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��X�� $	��150��$	��420��$��0,2,2,0q�$��1��$��0��$��Center=�$��Center=����	#FFAC79B6._�� $��Center=�$��Center=�.+��� $	��120��$��Resources/logo.png���� $	��650��$	��420��$��0,2,0,0q�$��1��$��1�����	#FFAC79B6._��� $��10q�$
��Left=�$	��Top=�$ Vertical=�.+�� -    �Name$ grid1��$
��Left=�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� $ Vertical=�.+�&   System.Windows.Controls.DataGrid  -     Name$ dealDataGrid��   
IsReadOnly . $
��Left=�   AutoGenerateColumns .     EnableRowVirtualization . $	��200��   RowDetailsVisibilityMode$ VisibleWhenSelected=�$	��400������    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   demandIDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 	Demand ID��    Width5  /System.Windows.Controls.DataGridLengthConverter$  * 1  +System.Windows.Controls.DataGridBoundColumn!   Binding! �� *
DemandID+  -   offerIDColumn��$ Offer ID��$  * ! �� *	OfferID+� -   $ grid3��" � DataContext#" [ $
��Left=�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto �.+��� $��Предложение:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -	   # ��Name$# offerID��$��1��$ �� DisplayMemberPath$$ ID��$
��Left=�$
��Auto��$��3q�$��0��$��Center=�$	��120������ ���� .R�$� � -
   $ grid2��#" [ $
��Left=�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto �.+��� $��Потребность:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $# demandID��$��1��$$ ID��$
��Left=�$
��Auto��$��3q�$��0��$��Center=�$	��120������ ���� .R�$� �� $ 
Horizontal=�.+��� $7��1Комиссия клиента-продавца:��$��10(��� -   % ��Name$% commissionSell��$��10(��� $ 
Horizontal=�.+��� $;��5Комиссия клиента-покупателя:��$��10(��� -   $% commissionBuy��$��10(��� $ 
Horizontal=�.+��� $(��"Комиссия риелтора:��$��10(��� -   $% commissionRealtor��$��10(��� $ 
Horizontal=�.+��� $(��"Комиссия риелтора:��$��10(��� -   $% commissionCompany��$��10(��� $ 
Horizontal=�$��Bottom=�$
��Left=�#" [ .+��� -   #��[  $+��%Сохранить изменения��$��0,0,10,0q��� -   #��[  $#��Добавить сделку��$��0,0,10,0q��� -   #��[  $!��Удалить сделку��