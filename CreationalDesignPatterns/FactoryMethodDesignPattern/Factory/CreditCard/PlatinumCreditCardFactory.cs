using FactoryDesignPattern;

namespace FactoryMethodDesignPattern{
    public class PlatinumCardFactory : CreditCardBaseFactory
    {
        public override ICreditCard GetCreditCard()
        {
            return new PlatinumCard();
        }
    }
}