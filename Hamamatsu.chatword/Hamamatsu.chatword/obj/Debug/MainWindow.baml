   M S B A M L   `   `   `  ����M  IHamamatsu.chatword, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hamamatsu.chatwordHamamatsu.chatword  5   	   #    Hamamatsu.chatword.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Hamamatsu.chatword     5   	   -   5          �Name$  	AppWindow��5
   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � Icon$" Images/Logo/Develop-logo.png��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Welcome, Developer!��5   	   $	��600��6%   $	��900��62   ��5   	   �� *WindowMinimumWidth+��5   	   �� *WindowMinimumHeight+ � 	Resources 5      #   Hamamatsu.chatword.MainWindow �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� Padding �� FallbackValue ��Name   BackgroundLightBrush �� CornerRadius J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity J� OpacityMask !� Visual �� ElementName � RowDefinitions K� ZIndex � ColumnDefinitions  SystemIconButton  FontSizeRegular  GmarketSansTTFLight �� TextAlignment �� Orientation  WindowControlButton  WindowCloseButton �� 
StartPoint �� EndPoint  ForegroundLight � Color � Offset  ForegroundMain  BackgroundVeryLight��%B	  '        7   7  7  7  7  7  7  7  7  7  7  7  �� 5   
   "  6   .�5      ��  � ��	 5      �� 5      "
 �6&   .R�5      ��  6!   �� *OuterMarginSizeThickness+$ 10��._�5      � .+�5   "   �� $ 	Container��6)   8��   5   )   �� *WindowCornerRadius+$ 10���� 5   "    6)   �� *WindowCornerRadius+$ 10����5    )   �� *ForegroundLightBrush+$ White�� 5!   &     5"   *   $ 0Q�6;   $	 0.2Q�6K   5$   #   � 5'   "    5)   &   !� 5*   *    66   �� $ 	Container�� 5-   &   �� 50   *   ��68   �� *TitleHeightGridLength+$ 42���� 53   *   $
��Auto �68   �� 56   *   $��* �68   .+�5:   &   � $��0��6,   $ 1��6<    5;   *   �� 5=   .   $
��Auto �6?   �� 5?   .   $��* �6?   �� 5A   .   $
��Auto �6?   .+�5E   *   �� 8�� ��6[   �� *MenuCommand+.��5F   .   �� $��/Images/Logo/Logom.png��64   5G   +   (� 5I   *   $��0��62   $��3��6B   $��5q�6V   .��5J   .   �� .+�5K   2   �� $
��Bold"�6<   8�� 8�� $��0,0,0,-5q�6�   �� 5L   6   $�H��6:   
���  ��6C   �� 6V   $�A��6Z   
���  ��6c   �� 6v   $�M��6z   
���  ��6�   �� 6�   $�A��6�   
���  ��6�   �� 6�   $�M��6�   
���  ��6�   �� 6�   $�A��6�   
���  ��6�   �� 6�   $�T��6�   
���  ��6  �� 6  $�S��6  
���  ��6#  �� 66  $�U��6:  
���  ��6C  5N   3   �� 5O   2   $��Photon is our Business��6<   
���   �$ Center=�6m   5Q   /   5R   +   �� 5U   *   $��2��65   $ 
Horizontal=�6E   .+�5V   .   �� 8�� $��_��6�   ��65   �� *MinimizeCommand+6�   �� 5W   .   8�� $	��[ ]��6�   ��65   �� *MaximizeCommand+6�   �� 5X   .   8�� $��X��6�   ��65   �� *CloseCommand+6�   5Y   +   5Z   '   �� 5\   &   $��1��6-   $��6��6:   $��	0 0.2 0 0q�6E   ��5^   *   �� 5_   .   $	 0,0&�6B   $	 1,0&�6S   .��5`   2   � 8  $	 0.0Q�6h   � 5a   2   8  $	 0.5Q�6g   � 5b   2   8 	 $	 1.0Q�6h   5c   /   ��5g   *   �� 5h   .   $	 0,0&�6B   $	 0,1&�6S   .��5i   2   � 8 
 $	 0.0Q�6l   � 5j   2   8  $	 1.0Q�6h   5k   /   5m   '   �� 5p   &   $��2��6-    6:   �� *InnerContentPadding+._�5q   *   �� #��z��6;   5r   '   5s   #   5t      5u      5v      5x      5y      5z      '  !System.Windows.Shell.WindowChrome   WindowChrome 5|        5}   
      CornerRadius$ 0��5�          GlassFrameThickness$  0q�5�      !   ResizeBorderThickness! 5~      �� *ResizeBorderThickness+"   CaptionHeight" 5      �� *TitleHeight+5�      .��5�      �  	 ForegroundLightBrush#��[	 6    5�   
   �� 5�      $	��300 �6   �� 5�      $��* �6   .+�5�   
    � -   5        #  �Name$# 	MainFrame��5�       $��1��6   ��63   �� *CurrentPage+$ �� 	Converter$ 6   0Hamamatsu.chatword.ApplicationPageValueConverter  (   "Hamamatsu.chatword.SideMenuControl  5�   
   5�      5�      5�      