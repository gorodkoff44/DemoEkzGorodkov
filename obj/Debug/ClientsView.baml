   M S B A M L   `   `   `  ????J  FDemoEkzGorodkov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DemoEkzGorodkovDemoEkzGorodkov  5      !    DemoEkzGorodkov.ClientsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DemoEkzGorodkov     5        N? Title$  ClientsView??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      $??30 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridClient??5         AutoGenerateColumns .     
IsReadOnly . $??0,0,0,60q?6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ?? *	FirstName+6T     5      $ Имя??6%   $ * 6O    62   ?? *
LastName+6O     5      $ Отчество??6%   $ * 6V    67   ?? *
Patronymic+6V   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      ?? 5      .R?5      ?? 
 ??Name$
 btnView??6:   -   5        $??Посмотреть??5   %   6K   5      5        5      $
 auto 6)   	 5      ?? 5      .R?5      ?? $

 edit??6=   -   5        $ ??Редактировать??5   %   6K   5       5"      5$      ?? 5%   
   -   5        $	
 del??5%      $??1??6   $??Удалить??6?   $
??Left=?6Q   ?? 5&   
   -   5        $	
 add??5&      $??1??6   $??Добавить??6+   $??Right=?6>   6Z   5'      5(      