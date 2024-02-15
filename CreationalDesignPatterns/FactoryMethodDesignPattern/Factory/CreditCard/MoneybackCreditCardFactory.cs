using FactoryDesignPattern;

namespace FactoryMethodDesignPattern{
    public class MoneybackCreditCardFactory : CreditCardBaseFactory
    {
        public override ICreditCard GetCreditCard()
        {
            return new MoneyBackcard();
        }
    }
}