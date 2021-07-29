using System;
class Prog5
{
public static void Main()
{
String [][] prod = new String [3][];
prod[0] = new String[4] {"buscuit1", "buscuit2", "buscuit3", "buscuit4"};
prod[1] = new String[5] {"chocolate1", "chocolate2", "chocolate3", "chocolate4", "chocolate5"};
prod[2] = new String[6] {"chocodrink1", "chocodrink2", "chocodrink3", "chocodrink4", "chocodrink5", "chocodrink6"};
for(int i=0; i<prod.Length; i++)
{ 
  for(int j=0; j<prod[i].Length; j++)
  Console.Write(prod[i][j] + "\t");
  Console.WriteLine(); 
 }

String [][] prods = new String [4][];
prods[0] = new String[3] {"List", "ProductCategory", "No of Items"};
prods[1] = new String[3] {"a", "Biscuits", "There are 4 items"};
prods[2] = new String[3] {"b", "Chocolates", "There are 5 items"};
prods[3] = new String[3] {"c", "Drinks", "There are 6 items"};
for(int i=0; i<prods.Length; i++)
{ 
  for(int j=0; j<prods[i].Length; j++)
  Console.Write(prods[i][j] + "\t");
  Console.WriteLine(); 
 }

}
}
