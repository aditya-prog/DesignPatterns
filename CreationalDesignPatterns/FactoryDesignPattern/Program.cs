using System;
using System.Collections.Generic;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryDesignPattern example....\n");
           
            ICreditCard card = CreditCardFactory.GetCreditCard(CreditCardType.Titanium);
            if(card != null){
                Console.WriteLine($"CardType: {card.GetCardType()} \nCreditLimit: {card.GetCreditLimit()} \nAnnualCharges: {card.GetAnnualCharges()}");
            }
            else{
                Console.WriteLine("Invalid card type...!!");
            }
        }
    }
}

 /*
            #################
            Details Of Factory Pattern
            ##################

             A factory is an object used for creating other objects.
             In technical terms, we can say that a factory is a class with a method.
             That method will create and return different objects based on the received 
             input parameter.

             In the Factory Design pattern, we create an object without exposing the Object
             Creation and Initialization logic to the client, and the client will refer to
             the newly created object using a common interface.
            
            #############
            When to use
            ############
            1) Complex Object Creation: When the creation logic of objects is complex and should 
                not be part of the client code. Factory pattern abstracts the instantiation process
                and hides the complexity from the client.
            2) Decoupling: It’s useful when there needs to be a decoupling between the implementation
                 of a class and its users. The Factory pattern allows for this by letting a class defer
                 instantiation to subclasses or another class.
            3) Conditional Object Creation: If the creation of an object depends on certain conditions or 
                configurations, the Factory pattern can encapsulate these conditions and ensure the creation
                of the appropriate object.

*/
