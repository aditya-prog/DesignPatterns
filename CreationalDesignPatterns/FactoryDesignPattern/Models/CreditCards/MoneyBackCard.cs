namespace FactoryDesignPattern{
    public class MoneyBackcard : ICreditCard
    {
        public float GetAnnualCharges()
        {
            return 200.0f;
        }

        public string GetCardType()
        {
           return "MoneyBack regular";
        }

        public int GetCreditLimit()
        {
            return 100000;
        }
    }
}