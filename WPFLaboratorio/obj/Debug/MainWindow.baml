   M S B A M L   `   `   `  ����I  EWPFLaboratorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFLaboratorioWPFLaboratorio  5   	       WPFLaboratorio.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFLaboratorio     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��900��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��99* �6   �� 5      $
��198* �6   �� 5      $
��461* �6   �� 5      $
��134* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ PersonasDataGrid��5      $��2��6Y   $
��Left=�6i   $��	10,10,0,0q�6�   $	��Top=�6�   $	��449��6�   $	��575��6�   $��4��6�   $��2��6�   ��6-   �� *personasRegistradas+6�   �� 5   
   -   5         ��Name$ textBox��5      $��1��6W   $
��Left=�6g   $��20��6�   $��	20,50,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��180��6�   ��6#   �� *$"nuevaPersona.NombrePersonaMostrada+6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��	23,50,0,0q�6B   $
��Wrap=�6U   $��Nombre Persona Muestra��6i   $	��Top=�6�   �� 5   
   -   5         ��Name$ label��5      $'��!Nombre de La persona Toma muestra��6   $
��Left=�6K   $��	23,49,0,0q�6f   $��1��6y   $	��Top=�6�   �� 5   
   -   5        $ textBox1��5      $��1��6[   $
��Left=�6k   $��23��6�   $��	20,49,0,0q�6�   $��1��6�   $
 Wrap=�6�   $	��Top=�6�   $	��180��6�   ��6$   �� *'%nuevaPersona.NombrePersonaTomaMuestra+6�   �� 5   
   -   5         ��Name$ button��5      $��Agregar��6!   $��1��63   $
��Left=�6C   $��	20,38,0,0q�6^   $��2��6q   $	��Top=�6~   $	��168��6�   $��43��6�   6�   5      5      