using System;
class bClass
{
public virtual void calculateTax(double Price)
{
double vat=Price*0.2;
Console.WriteLine("VAT " + vat);
}
}
class dClass : bClass
{
public override void calculateTax(double Price)
{
double gst=Price*0.12;
Console.WriteLine("GST " + gst);
}
}

class mClass
{
public static void Main()
{
 Console.WriteLine("Tax Calculation");
 Console.WriteLine("Enter the Price");
 double Price=Convert.ToDouble(Console.ReadLine());
bClass b1=new bClass();
b1.calculateTax(Price);
dClass d1=new dClass();
d1.calculateTax(Price);

}
}