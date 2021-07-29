using System;
class Package
{
public static void Main()
{
Console.WriteLine("Enter your TV Channel Package");
String package=Console.ReadLine();
  switch(package)
  {
   case "Package A": Console.WriteLine("Rate: 250");
   break;
   case "Package B": Console.WriteLine("Rate: 450");
   break;
   case "Package C": Console.WriteLine("Rate: 350");
   break;
   default: Console.WriteLine("Please enter the correct package");
   break;
   }
}
}
