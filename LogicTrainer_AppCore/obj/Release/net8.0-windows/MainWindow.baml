   M S B A M L   `   `   `  ���� O  KLogicTrainer_AppCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LogicTrainer_AppLogicTrainer_App  !    LogicTrainer_App.MainWindow   S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:LogicTrainer_App     -   $
��home��  � WindowStartupLocation$  CenterScreen=�
������  � AllowsTransparency$
 True�� � 
ResizeMode$ NoResize=� � WindowState$ Normal=� � WindowStyle$
 None=� � Title$ 
MainWindow��$	��700��$
��1200�� � Icon$ /Icons/Icons8.png��.����  �� CornerRadius$ 8��   PrimaryBackgroundColor#���   ._��  � ShowGridLines$
 True��	 � ColumnDefinitions	 �� $
��Auto ��� .+��� $ 8 0 0 8��  SecundaryBackgroundColor#���  ._�� -   
 �Name$
 gridMenu��$��60�� � RowDefinitions �� $��60 ��� $��80 ��� $
��Auto ��� .+��� $��1�� �� Orientation$ 
Horizontal=�$	��Top=�.+�F�   logo#���  $��16 0 0 0q� �� Stretch$
 Fill=�  PrimaryBlueColor#���  $��25��$��25��$
��Left=��� $��	Logic App��  PrimaryTextColor#���  $��SemiBold"�#���  $��10(�$��Center=�$
��Left=�$��	14 0 10 0q�d� -    d�Name$ btnMenu��$��Right=�$��0q�
������ $��Center=�  MenuIconStyle#��[ $��0 0 15 0q� � Triggers :�  :� RoutedEvent$ ToggleButton.Unchecked��.[��� .���� -    ��Name$ HideStackPanel��.��W�  �� 
TargetName$ gridMenu�� �� TargetProperty$ Width� g� 	BeginTime	 0:0:0 W� From 120	 W� To 60 g� Duration$ 0:0:0.3D�:� $ ToggleButton.Checked��.[��� .���� -   $ ShowStackPanel��.��W� $ gridMenu��$ Width�	 0:0:0 60 120$ 0:0:0.3D��� $��3��.+�	� -    	�Name$ rdHome�� d� 	IsChecked$
 TrueY�$
��Home��  MenuRadioButtonStyle#���    home
 � Tag# �  	� -   $ rdAbout��$��About��#���    more# �  $��0 5 0 5q��� $��3��$��Bottom=�$ 
Horizontal=�$	��200��$��0 0 0 20q�.+�A� $��40��$��40��$��10 0 0 0q�����  �� ImageSource$ Images/lefanal.png���� $��Beacon��#���  $��14(�$��5,5,0,0q�$��SemiBold"�$��Center=�$
��Left=��� $��3��$��Center=�$ 
Horizontal=�$	��200��$��15 0 0 0q�.+�d� -   $ Themes��$ FalseY� 	 ToggleButtonStyle#��� 	 �� $��Themes��#���  $��5,0,0,0q�$��14(�$��Normal"�$��Right=�$��Right=�� $��1�� �� $��60 ��� $��70 ��� .+��� $��0��$��4��$��Right=�$	��Top=�$��0,5,10,0q�$��30��$ 
Horizontal=�$��RightToLeft=�.+��� -	    ��Name$ btnClose�� 
 IIconButtonsStyle#��[
  	 close#���  $ IsCloseButton���� -
   $ 
btnRestore��$	��5,0q�����  �� 
TargetType" �� �� BasedOn# [
 .���  �� Property � ��  maximize  �� Value#  �  ! �� Triggers! �� " �� Binding" �� # �� ElementName$
# home��$ �� Path$$ WindowState�% �� Value% 	Maximized.a���  � ��  restore#  �  �� -   $ btnMinimize��#��� 
   minimize#���  �� $��1��$ 
Horizontal=�.+�#  MaterialDesignThemes.Wpf.Card  $��10,0,0,0q�$	��140��$��40��&   UniformCornerRadius$& 20Q�  PrimaryCardColor#���  .���� -   $
 NotG��$	��120��$��30��  MenuButtonStyle#���  .���� $ 
Horizontal=�.+��� $��0,0,0,0q�$��Icons/NOT2.png���� $��5,0,0,0q�$��NOT GATE��  $��10,0,0,0q�$	��140��$��40��$& 20Q�#���  .���� -   $	 OrG��$	��120��$��30��#���  .���� $ 
Horizontal=�.+��� $��Icons/OR2.png���� $��5,0,0,0q�$��OR GATE��  $��10,0,0,0q�$	��140��$��40��$& 20Q�#���  .���� -   $
 NorG��$	��120��$��30��#���  .���� $ 
Horizontal=�.+��� $��Icons/NOR2.png���� $��5,0,0,0q�$��NOR GATE��  $��10,0,0,0q�$	��140��$��40��$& 20Q�#���  .���� -   $
 AndG��$	��120��$��30��#���  .���� $ 
Horizontal=�.+��� $��Icons/AND2.png���� $��5,0,0,0q�$��AND GATE��  $��10,0,0,0q�$	��140��$��40��$& 20Q�#���  .���� -   $ NandG��$	��120��$��30��#���  .���� $ 
Horizontal=�.+��� $��Icons/NAND2.png���� $��5,0,0,0q�$��	NAND GATE��  $��15,0,0,0q�$	��140��$��40��$& 20Q�#���  .���� -   $ ExOrG��$	��120��$��30��#���  .���� $ 
Horizontal=�.+��� $��Icons/XOR2.png���� $��	EXOR GATE��  $��10,0,0,0q�$	��140��$��40��$& 20Q�#���  .���� -   $ ExNorG��$	��120��$��30��#���  .���� $ 
Horizontal=�.+��� $��Icons/XNOR2.png���� $��5,0,0,0q�$��	XNOR GATE��  $& 20Q�$��30,0,0,0q�$��Fanal��$��16(�$��Heavy"�
�������$��30���� $��2��$��10q�._� � -   '  �Name$' PagesNavigation��(  � NavigationUIVisibility$( Hidden=�$��	0,0,233,0q��� -   ) ��Name$) stackbox��$ Vertical=�$��70��$	��100��$��2��$��Right=�$��0,285,52,185q�.+��� -   * ��Name$	* tt1��$��40���� -   $	* tt2��$��40���� -   $	* tt3��$��40���� -   $	* tt4��$��40���� $ 
Horizontal=�$	��200��$	��108��$��2��$
��Left=�$	��Top=�$��899,159,0,0q�.+�&   System.Windows.Controls.DataGrid  -   +  Name$+ dagrid��#���  ,   AutoGenerateColumns$, False��$	��100��$��90��- � 	Resources- =  7System.Windows.Controls.Primitives.DataGridColumnHeader  PrimaryGrayColor��%�   '        �� "  .���  � ��#  �  ��  � ��$  Medium"���  � ��$  30����  � ��$  Center=���  � ��$  0,0,0,2q���  � ��#  �   .   Columns. 0  *System.Windows.Controls.DataGridTextColumn  -   	in1column��,  &System.Windows.Controls.DataGridColumn/   Header$/ 	 Switch 1��0   Width5  /System.Windows.Controls.DataGridLengthConverter$0 * 1  +System.Windows.Controls.DataGridBoundColumn1   Binding1 �� *input1+4  .System.Windows.Controls.DataGridTemplateColumn    -   $+ dagrid2��#���  $, False��$	��100��$��90��- ��%�   '        �� "  .���  � ��#  �  ��  � ��$  Medium"���  � ��$  30����  � ��$  Center=���  � ��$  0,0,0,2q���  � ��#  �   .   -   	in2column��$/ 	 Switch 2��$0 * 1 �� *input2+  