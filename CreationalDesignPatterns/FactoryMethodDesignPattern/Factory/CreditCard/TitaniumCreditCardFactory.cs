using FactoryDesignPattern;

namespace FactoryMethodDesignPattern{
    public class TitaniumCreditCardFactory : CreditCardBaseFactory
    {
        public override ICreditCard GetCreditCard()
        {
            return new TitaniumCard();
        }
    }
}