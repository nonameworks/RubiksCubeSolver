   M S B A M L   `   `   `  ����E  ARubiksCube, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null1clr-namespace:RubiksCube.ViewRubiksCube.View  5   	       RubiksCube.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0ignorehttp://www.galasoft.ch/ignore     5   	   .viewclr-namespace:RubiksCube.View     5   	   $	��300��5	   	   $	��300��5
   	     � Title$  Rubik's Cube��5   	    � DataContext 5   	   �� *Main+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Skins/MainSkin.xaml?�6%   %    5      .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   .+�5"   
   �� $��3��6   .+�5#      �� $��20��6?   $��Scramble��6K   ��6   �� *Model.ScrambleCommand+6K   �� 5$      $��20��6<   $��Solve��6H   ��6   �� *Model.SolveCommand+6H   5%      �� 5'   
   $��2��6   $��Center=�6A   $��Center=�6^   ��6$   �� *Model.Score+6^      RubiksCube.View.Side  5)   
   $��1��67    6   �� *
Model.Left+67     5*   
   $��1��68   $��1��6E    6   �� *Model.Front+6E     5+   
   $��1��68   $��2��6E    6   �� *Model.Right+6E     5,   
   $��1��67   $��3��6D    6   �� *
Model.Back+6D     5.   
   $��0��66   $��1��6C    6   �� *	Model.Top+6C     5/   
   $��2��69   $��1��6F    6   �� *Model.Bottom+6F   51      52      