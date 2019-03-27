## Mise en oeuvre des notions d'héritage en C# ##
# TP HERITAGE #

Ce TD à pour but d'assimiler les notions d'héritage en c#.

Pour ce faire nous avons créer plusieurs classe : 

![classe_heritage.png](https://image.noelshack.com/fichiers/2019/13/3/1553692874-classe-heritage.png)

Le but ici est de minimiser les données membres de chaque classe en mettant en place l'héritage.
On remarquera que les animaux peuvent être regroupé selon leurs groupes (mammifère, félin ou cétacé)

La classe mammifère sera la classe principal auquelle toutes les autres devront hérité, l'image ci-dessous démontrera plus clairement le schéma :
![diagramme.png](https://image.noelshack.com/fichiers/2019/13/3/1553693745-diagramme.png)

Au niveau du code, rien de plus simple niveau syntaxe

![code.png](https://image.noelshack.com/fichiers/2019/13/3/1553694016-code.png)

La classe Felin herite des données membres de la classe mammifère et possède sa propre donnée membre j'ai nommé "nombrePattes".

Cette méthode de développement facilite le codage et épure davantage le code afin d'anticiper le clean code.
