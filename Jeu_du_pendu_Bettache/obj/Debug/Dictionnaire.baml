   M S B A M L   `   `   `  ����P  LJeu_du_pendu_Bettache, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Jeu_du_pendu_BettacheJeu_du_pendu_Bettache  5   	   (    "Jeu_du_pendu_Bettache.Dictionnaire   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Jeu_du_pendu_Bettache     5   	   -   5          � Title$  Dictionnaire��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ btnSupprimer��5
      $��	SUPPRIMER��6'   $
��Left=�6;   $��468,368,0,0q�6V   $	��Top=�6k   $��26��6�   $��96��6�   $
��Bold"�6�   6�   �� 5   
   $
��Left=�6   $��40��6+   $��495,324,0,0q�67   $	��Top=�6L   $��37��6d   $��/supprimer.png��6o   �� 5   
   -   5        $ 
btnAccueil��5      $��ACCUEIL��6%   $
��Left=�67   $��677,298,0,0q�6R   $	��Top=�6g   $��26��6   $��96��6�   $
��Bold"�6�   6�   �� 5   
   $
��Left=�6   $��59��6+   $��695,237,0,0q�67   $	��Top=�6L   $��60��6d   $��/accueil.jpg��6o   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgDictionnaire��5      $��364,43,138,138q�6+   $ �� IsSynchronizedWithCurrentItem$
 trueY�6C    �� DisplayMemberPath$	 mot��6�   ��6h   �� 6�   �� 5   
   -   5         ��Name$ grAjouterMot��5      $��Ajouter Mot��6)   $
��Left=�6>   $	��251��6Y   $��	76,45,0,0q�6f   $	��Top=�6y   $	��254��6�   $
��Bold"�6�   .��5      � $	��241��6    � ColumnDefinitions 5      �� 5      $	��53* �6'   �� 5      $	��68* �6'   .+�5      �� $
��Mot:��6   $
��Left=�6'   $��	27,39,0,0q�6B   $	��Top=�6U   $
��Bold"�6m   �� 5      -   5         ��Name$ txtMot��5      $
��Left=�6*   $��6,43,0,0q�6E    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��1��6�   �� 5      $��Niveau:��6   $��Center=�6*   $��0,97,0,0q�6G   $	��Top=�6Y   $
��Bold"�6q   �� 5      $��Langue:��6   $
��Left=�6*   $��	27,66,0,0q�6E   $	��Top=�6X   $
��Bold"�6p   �� 5      -   5        	 ��Name$	 cbLangue��5      $
��Left=�6-   $��6,69,0,0q�6H   $	��Top=�6Z   $	��120��6r   $��1��6~   .@�5      �� $��Anglais��6#   $
��Bold"�65   �� 5      $��Francais��6#   $
��Bold"�66   5      �� 5      -   5        $	 cbNiveau��5      $
��Left=�6-   $��6,99,0,0q�6H   $	��Top=�6Z   $	��120��6r   $��1��6~   .@�5      �� $��Facile��6#   $
��Bold"�64   �� 5      $��Moyen��6#   �� 5       $��	Defficile��6#   $
��Bold"�67   5!      �� 5"      $
��Left=�6   $��53��63   $��
84,144,0,0q�6?   $	��Top=�6S   $��46��6k   $��/ajouter.jpg��6v   $��2��6�   5#      5$      �� 5%   
   -	   5        $ 
btnAjouter��5%      $��Ajouter��6%   $
��Left=�67   $��150,256,0,0q�6R   $	��Top=�6g   $��79��6   $
��Bold"�6�   6�   5'      5(      