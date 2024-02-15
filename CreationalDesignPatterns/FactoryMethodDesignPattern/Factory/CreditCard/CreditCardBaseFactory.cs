namespace FactoryDesignPattern{
    // Define an interface / abstarct class for creating object, but let the subclasses decide which 
    // class to instantiate. So the instantiation defer to subclasses, and each subfactory will
    // have its own version of factory method implementation.
    // Advantage:  We can add new product types by simply creating a new subclass of CreditCardBaseFactory
    // without modifying existing code.
    public abstract class CreditCardBaseFactory{
        public abstract ICreditCard GetCreditCard();
    }
}