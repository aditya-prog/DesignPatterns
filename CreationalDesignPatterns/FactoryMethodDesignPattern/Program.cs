using System;
using System.Collections.Generic;
using FactoryDesignPattern;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine($"FactoryMethodDesignPattern..!! {Environment.NewLine}");

            // Example 1 : This is just extension of SimpleFactory pattern to overcome its limitation
            // of open-closed principle violation in factory class

            Console.WriteLine("Example 1: ...");
            ICreditCard card = new PlatinumCardFactory().GetCreditCard();
            Console.WriteLine($"CardType: {card.GetCardType()} \nCreditLimit: {card.GetCreditLimit()} \nAnnualCharges: {card.GetAnnualCharges()}");
            Console.WriteLine();

            // Example 2: From Kudvenkat
            // Here we will use combination of simple factory and factory method to solve a problem statement
            /*
                1) Differentiate employee as permanent and contarct and segregate their payscale as well as bonus
                based on employeeType (can be easily achieved with simple factory)

                2) Calculate permannet employee house rent allowance
                3) Calculate contract employee medical allowance
                Note: FactoryMethod is not always used for only creating and returning object,
                but also used for doing some business operation on some model obj, before returning the
                object
            */
            
            var permEmp = new EmployeeModel{Name = "Aditya", EmployeeType = EmployeeType.Permanent};
            var perEmployeeFactory = EmployeeManagerFactory.GetEmployeeFactory(permEmp);
            perEmployeeFactory.ApplySalary();

            var contractEmp = new EmployeeModel{Name = "Mahesh", EmployeeType = EmployeeType.Contracted};
            var contEmployeeFactory = EmployeeManagerFactory.GetEmployeeFactory(contractEmp);
            contEmployeeFactory.ApplySalary();

            // Now check original emp model, it must have some salary, bonus, house allowance applied
            Console.WriteLine("Example 2...");
            Console.WriteLine(permEmp);
            Console.WriteLine(contractEmp);

        }
    }
}

/*

Simple Factory Pattern:

In the Simple Factory pattern, there is a single factory class responsible for creating objects based on the input provided to it.
The factory class typically contains a method that accepts some parameters or configuration and returns an instance of the appropriate subclass.
It is simple to implement but lacks flexibility as it typically creates objects of a single type based on input.
It does not allow for customization or extension without modifying the factory class.
Factory Method Pattern:

The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.
Each subclass can implement its own version of the factory method, thus providing flexibility in object creation.
It promotes loose coupling by allowing the creation of objects to be delegated to subclasses.
It enables extensibility by allowing new subclasses to be added without modifying existing code.

*/
