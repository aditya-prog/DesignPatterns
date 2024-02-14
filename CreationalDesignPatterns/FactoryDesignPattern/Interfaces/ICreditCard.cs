namespace FactoryDesignPattern{
    public interface ICreditCard{
        string GetCardType();
        int GetCreditLimit();
        float GetAnnualCharges();
    }
}