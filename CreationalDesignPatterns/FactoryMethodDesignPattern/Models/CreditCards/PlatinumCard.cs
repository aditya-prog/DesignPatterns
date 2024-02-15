namespace FactoryDesignPattern{
    public class PlatinumCard : ICreditCard
    {
        public float GetAnnualCharges()
        {
            return 300.0f;
        }

        public string GetCardType()
        {
           return "Platinum plus";
        }

        public int GetCreditLimit()
        {
            return 250000;
        }
    }
}