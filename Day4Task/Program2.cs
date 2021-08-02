using System;
abstract class Mship
{
public abstract void memberShip();
}

class Silver:Mship
{
public override void memberShip()
{
Console.WriteLine("Silver: 3days accomodation at Resort");
}
}

class Gold:Mship
{
public override void memberShip()
{
Console.WriteLine("Gold: 5days accomodation at Resort and 2dinners on the house");
}
}

class Platinum:Mship
{
public override void memberShip()
{
Console.WriteLine("Platinum: 7days accomodation at Resort and 5dinners on the house");
}
}

class mClass
{
public static void Main()
{
Silver obj1=new Silver();
obj1.memberShip();
Gold obj2=new Gold();
obj2.memberShip();
Platinum obj3=new Platinum();
obj3.memberShip();

}
}