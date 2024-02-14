namespace FactoryDesignPattern{
    public class TitaniumCard : ICreditCard
    {
        public float GetAnnualCharges()
        {
            return 500.0f;
        }

        public string GetCardType()
        {
           return "Titanium Pro";
        }

        public int GetCreditLimit()
        {
            return 500000;
        }
    }
}