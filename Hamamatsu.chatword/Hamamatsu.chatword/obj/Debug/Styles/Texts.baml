   M S B A M L   `   `   `  ����M  IHamamatsu.chatword, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hamamatsu.chatwordHamamatsu.chatword  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   
HeaderText  BaseTextBlockStyle �� BasedOn �� Property  ForegroundMainBrush �� Value  	BaseStyle  FontSizeLarge  GmarketSansTTFLight �� 
TargetType ��Name J� SnapsToDevicePixels ��Name ��Name	 J� IsHitTestVisible

 � Tag �� Padding  ForegroundVeryDarkBrush �� Triggers �� Binding �� RelativeSource �� Value �� Triggers P� Property P� Value �� 
TargetName�    �Hamamatsu.chatword.BaseAttachedProperty`2[[Hamamatsu.chatword.MonitorPasswordProperty, Hamamatsu.chatword, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] �� 	Converter4   .Hamamatsu.chatword.BooleanToVisiblityConverter  Spinning Text  
fa-spinner �� 	Resources 	 Key �� TargetProperty W� From	 W� To g� Duration g� RepeatBehavior �� Self �� Path N� EnterActions ��Name 
 Spin N� ExitActions  �� BeginStoryboardName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      *local clr-namespace:Hamamatsu.chatword  5      %  &	        7  7  '�� �     7  7  7  7  7  'G� �    7  7  7  7  7  &	 #
    7  7  7 
 �� 5      "  ��6   8   .�5   
   ��  � ��8  6'   �� 5   
    � ��$ Center=�6.   �� 5	   
    � ��$ Center=�60   �� 5
   
    � ��$	 0 6q�6#   5      �� 5      "  ��6   8   .�5   
   ��  � ��8  6%   �� 5   
    � ��8  6'   �� 5   
    � ��$ 10q�6$   �� 5   
    � ��$ 0 5 0 5q�6#   �� 5   
    � ��
 �  ��6(   �� 5   
    � ��$ 0 0 0 1q�6,   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ border��6!   #��z��5   !   #��z��5   !   #��z��5   !    . ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       �� 5"      $ placeholder��5#   $   	 .  #��z
 5"   =   8�� # z��5%   $   $��Center=�5&   $   #��z��5'   $   8�� ��5*      �� 5+   "   "  ��6(   .�5,   &   ��  � y�$ 	Collapsed=�6C    5-   &   �� 5.   *    66   �� *Text+ �� *TemplatedParent+  6�   .a�5/   .   ��  � y�$ Visible=�6K   50   +   52   #   55      57       58      P� 59       � {� .  . �5:      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5;      P� 5<       �@J�IsMouseOver . . �5=      �� $ border��6<    � �� �	#FF7EB4EA6P   5>      P� 5?       �@J�IsKeyboardFocused . . �5@      �� $ border��6<    � �� �	#FF569DE56P   5A      5C      5E      5G      �� 5I      "  G�6   8   .�5J   
   ��  � ��8  6%   �� 5K   
    � ��8  6'   �� 5L   
    � ��$ 10q�6$   �� 5M   
    � ��$ 0 5 0 5q�6#   �� 5N   
    � ��
 �  ��6(   �� 5O   
    � ��$ 0 0 0 1q�6,   �� 5Q   
    �@  Value . 6@   �� 5R   
    � �� 5S      �� 5T      " G�6"   .R�5U      � .+�5V      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5W      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5X      �� 5Z      $ placeholder��5[   $   	 .  #��z
 5Z   =   8�� # z��5]   $   $��Center=�5^   $   #��z��5_   $   8�� y�5`   $   �� *local:HasTextProperty.Value+   5c      5e       5f      P� 5g       � {� .  . �5h      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5i      P� 5j       �@J�IsMouseOver . . �5k      �� $ border��6<    � �� �	#FF7EB4EA6P   5l      P� 5m       �@J�IsKeyboardFocused . . �5n      �� $ border��6<    � �� �	#FF569DE56P   5o      5q      5s      5u      �� 5w      "  ��6   8   .�5x   
   ��  � ��8  6'   �� 5y   
    � ��$	 ��6!   �� 5z   
    �@J�RenderTransformOrigin$ 0.5, 0.5&�62   �� 5|   
    � z� 5}      �� 5~      6$   5�       5�   
   ���� 5�      Spin	 .��5�      W� $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5�      $ 0X�5�      $	 360X�5�      $ 0:0:2D�5�      $ Forever��5�      5�      5�       5�   
   �� 5�       6   �� # Z $ 	IsVisible� True6l    5�      �� 5�      $ SpinStoryboard��6&   8�� 6<    5�      �� 5�      $  SpinStoryboard��6'   5�      5�      5�      