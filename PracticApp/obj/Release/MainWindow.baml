   M S B A M L   `   `   `  ���� E  APracticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PracticApp
PracticApp      PracticApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PracticApp     -     � Title$   ��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF97D9E1��� $ 	#FFD9AFD9�� � Offset$ 0.554Q� � 	Resources    UpperButton	 �� 
TargetType
 �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration  
OutlineBtn �� From��%�  &	        &	 �    �� "	 ��.��� 
 �@�OverridesDefaultStyle . �� 
 � ��$ 35���� 
 � ��$	 0,5q��� 
 � ��$ 18(��� 
 � �� �	#FF0091EA�� 
 � ��
 ������� 
 � ��$
 Bold"��� 
 � ��$ Alegreya Sans SC)��� 
 � �� �� " ��.R��� $��border��$��0q�#��z��$ 10��._��� $��Center=�$��Center=� :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF00609BX�$ 0:0:0.5D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0.5D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D��� "	 ��.��� 
 �@�OverridesDefaultStyle . �� 
 � ��$ 35���� 
 � ��$	 0,5q��� 
 � ��$ 18(��� 
 � ��
 ������� 
 � �� �	#FF0091EA�� 
 � ��$
 Bold"��� 
 � ��$ Alegreya Sans SC)��� 
 � �� �� " ��.R��� $��border��$��2q����	#FF0091EA#��z��$ 10��._��� $��Center=�$��Center=� :� $ Button.MouseEnter��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ WhiteX�$ 	#FF002942X�$ 0:0:0.5D��� $1 +(Button.Foreground).(SolidColorBrush.Color)�$ WhiteX�$ 0:0:0D�:� $ Button.MouseLeave��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ WhiteX�$ 0:0:0.5D��� $1 +(Button.Foreground).(SolidColorBrush.Color)�$ 	#FF0091EAX�$ 0:0:0D�:� $ Button.Click��[��� .���� .���� $1 +(Button.Background).(SolidColorBrush.Color)�$ 	#FF002942X�$ 0:0:0D��� $1 +(Button.Foreground).(SolidColorBrush.Color)�$ WhiteX�$ 0:0:0D�.���  � RowDefinitions �� $��30 ��� $	��100 ��� $��* �.+�� $��0��$��Right=�.+���  �� Orientation$ 
Horizontal=�.+��� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��_�� -   $��30�����	#FFAC79B6
������ $��1q�$��14(�.��X� $��1��.+��� $��Resources/logo.png��$��80��� $��2��.+��� $	��500��$ Vertical=�$��Center=�.+��� -   #��[  .���� $*��$Работа с риэлторами���� -   #��[  .���� $(��"Работа с клиентами���� -   #��[ .���� $0��*Работа с недвижимостью���� -   #��[ .���� $0��*Работа с предложениями���� -   #��[ .���� $0��*Работа с потребностями���� -	   #��[ .���� $(��"Работа со сделками��