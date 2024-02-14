namespace FactoryDesignPattern{
    public class CreditCardFactory{
        // This factory class Breaks Open Closed principle when new Card Type comes, which is a
        // limitation of simple Factory pattern
        public static ICreditCard GetCreditCard(CreditCardType cardType){
             return cardType switch
            {
                CreditCardType.MoneyBack => new MoneyBackcard(),
                CreditCardType.Platinum => new PlatinumCard(),
                CreditCardType.Titanium => new TitaniumCard(),
                _ => throw new Exception("InvalidCardTyepe")
            };
                
        }
    }
}