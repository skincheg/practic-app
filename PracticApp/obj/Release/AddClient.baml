   M S B A M L   `   `   `  ���� E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp      PracticApp.AddClient   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PracticApp     -     � Title$  	AddClient��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources     PracticApp.RealtorsDataSet   realtorsDataSet  personViewSource �� Source �� Source  personClientsViewSource  UpperButton �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration  clientsViewSource��%�  &	        &	      7   &	 #     7  &	 L     &	 I    7     ��  �� *Person+8   ��  �� *FK_Clients_Person+8   �� " ��.���  �@�OverridesDefaultStyle	 . ��  � ��$	 30����  � ��$		 200����  � ��$
	 0,10q���  � ��$	 14(���  � ��	 �	#FF0091EA��  � ��
	 �������  � ��$
	 Bold"���  � ��$	 Alegreya Sans SC)���  � ��	 �� "
 ��.R��� $��border��$��0q�#��z��$ 10��._��� $��Center=�$��Center=� :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF00609BX�$ 0:0:0.5D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0.5D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D���  �� *	Clients+8   ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF97D9E1��� $ 	#FFD9AFD9�� � Offset$ 0.554Q�� $ 	#FFD8AFD9��$ 0.547Q�.���  � RowDefinitions �� $��30 ��� $��* � � ColumnDefinitions �� $	��150 ��� $��* �.+�� $��0��$��1��$��Right=�.+���  �� Orientation$ 
Horizontal=�.+��� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��_�� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��X�� $	��150��$	��420��$��0,2,2,0q�$��1��$��0��$��Center=�$��Center=����	#FFAC79B6._�� $��Center=�$��Center=�.+��� $	��120��$��Resources/logo.png���� $	��650��$	��420��$��0,2,0,0q�$��1��$��1��$��Center=�$��Center=����	#FFAC79B6._��  � DataContext# [ .+��� $ 
Horizontal=�$��10q�$	��Top=�.+��� -    ��Name$ searchTextBox��$��30�� �� TextWrapping$
 Wrap=�$	��500���� $ 
Horizontal=�$��Bottom=�$
��Left=�$��10q�.+��� -   #��[ $+��%Сохранить изменения��$��0,0,10,0q��� -   #��[ $%��Добавить клиента��$��0,0,10,0q��� -   #��[ $#��Удалить клиента��&   System.Windows.Controls.DataGrid  -     Name$ personDataGrid1��$	��120��   
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $
��Left=�$	��Top=�$��	10,50,0,0q�$	��500��   RowDetailsVisibilityMode$ VisibleWhenSelected=�����     Columns  0  *System.Windows.Controls.DataGridTextColumn  -	   nameColumn1��,  &System.Windows.Controls.DataGridColumn!   Header$
! Name��"   Width5  /System.Windows.Controls.DataGridLengthConverter$" * 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# �� *Name+  -
   surnameColumn1��$! Surname��$" * # �� *	Surname+  -   patronymicColumn1��$! 
Patronymic��$" * # �� *
Patronymic+�� $��Center=�$��	0,100,0,0q�.+��� $ 
Horizontal=�.+��� $��Имя:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ 
ClientName��$��1��$
��Left=�$��23��$��3q�$��0��$��Center=�$	��120������ *Phone+$ �� Mode$$ TwoWay=�% �� NotifyOnValidationError% . & �� ValidatesOnExceptions& . �� $ 
Horizontal=�.+��� $��Фамилия:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ ClientSurname��$��1��$
��Left=�$��23��$��3q�$��0��$��Center=�$	��120������ *Phone+$$ TwoWay=�% . & . �� $ 
Horizontal=�.+��� $��Отчество:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ ClientPatronymic��$��1��$
��Left=�$��23��$��3q�$��0��$��Center=�$	��120������ *Phone+$$ TwoWay=�% . & . � -   ' �Name$' grid1��# [ $
��Left=�$��Center=� �� $
��Auto ��� $
��Auto � �� $
��Auto �.+��� $��Телефон:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ phoneTextBox��$��1��$
��Left=�$��23��$��3q�$��0��$��Center=�$	��120������ *Phone+$$ TwoWay=�% . & . � -   $' grid2��# [ $
��Left=�$��Center=� �� $
��Auto ��� $
��Auto � �� $
��Auto �.+��� $��Почта:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ emailTextBox��$��1��$
��Left=�$��23��$��3q�$��0��$��Center=�$	��120������ *Email+$$ TwoWay=�% . & . 