using System;

namespace DesignPattern.Console {
    public class Program
    {
        public static void Main(string[] args)
        {
            // Use System explicitly, else it will throw error because namespace contains Console in its name
            System.Console.WriteLine("Hello Aditya"); 
        }
    }
}
