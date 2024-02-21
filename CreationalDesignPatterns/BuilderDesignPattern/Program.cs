using System;
using System.Collections.Generic;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Desktop system
            var desktopConfigs = ConfigHelper.GetDesktopConfig();
            ISystemBuilder desktopBuilder = new DesktopBuilder();
            Director.BuildConfigurationOfSystem(desktopBuilder,desktopConfigs);

            var desktopSystem = desktopBuilder.GetSystem();
            Console.WriteLine("Desktop System: ");
            Console.WriteLine(desktopSystem);

            // Create Laptop system
            var laptopConfigs = ConfigHelper.GetLaptopConfigs();
            ISystemBuilder laptopBuilder = new LaptopBuilder();
            Director.BuildConfigurationOfSystem(laptopBuilder,laptopConfigs);

            var laptopSystem = laptopBuilder.GetSystem();
            Console.WriteLine("Laptop System: ");
            Console.WriteLine(laptopSystem);
        }
    }
}

/*
    The Builder pattern is a design pattern used to construct complex objects step by step.
    It allows you to produce different types and representations of an object using the same 
    construction process. 
    This pattern is particularly useful when you need to create a complex object having large number of 
    required and optional properties/configurations.

    This pattern helps to separate the construction of a complex object from its representation, 
    allowing the same construction process to create different representations.
*/
