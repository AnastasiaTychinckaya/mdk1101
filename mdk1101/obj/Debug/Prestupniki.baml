   M S B A M L   `   `   `  ����B  >mdk1101, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:mdk1101mdk1101  5   	       mdk1101.Prestupniki   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:mdk1101     5   	     � Title$  Window2��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��609* �6   �� 5      $
��191* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ prestup��5         AutoGenerateColumns .  $��22,12,140,217q�6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *cartoteka_id+6T     5      $ Имя��6%    62   �� *name+6M     5      $ Фамилия��6%    66   �� *	surname+6T     5      $ Описание��6%    67   �� *
opisanie+6V   5      �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��47��6?   $��
63,266,0,0q�6K   $	��Top=�6_   $	��106��6w   6�   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��47��6>   $��198,266,0,0q�6J   $	��Top=�6_   $	��106��6w   6�   �� 5   
   $ ��Редактировать��6   $
��Left=�6)   $��47��6D   $��333,266,0,0q�6P   $	��Top=�6e   $	��106��6}   5      5      