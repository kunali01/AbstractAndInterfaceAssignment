using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.
//1.Write a C# program to create an interface Flyable with a method called FlyObj().
//    Create three classes Spacecraft, Airplane, and Helicopter that implement the Flyable interface. 
//    Implement the FlyObj() method for each of the three classes.


interface IFlyable
{
    void FlyObj();
}

class Spacecraft : IFlyable
{
    public void FlyObj()
    {
        Console.WriteLine("Spacecraft is flying in space.");
    }
}

class Airplane : IFlyable
{
    public void FlyObj()
    {
        Console.WriteLine("Airplane is flying in the sky.");
    }
}

class Helicopter : IFlyable
{
    public void FlyObj()
    {
        Console.WriteLine("Helicopter is hovering in the air.");
    }
}

class Program4
{
    static void Main()
    {
        IFlyable spacecraft = new Spacecraft();
        spacecraft.FlyObj();

        IFlyable airplane = new Airplane();
        airplane.FlyObj();

        IFlyable helicopter = new Helicopter();
        helicopter.FlyObj();
    }
}
