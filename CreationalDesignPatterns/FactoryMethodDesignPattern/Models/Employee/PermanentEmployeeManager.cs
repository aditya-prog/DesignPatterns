namespace FactoryMethodDesignPattern{
    public class PermanentEmployee : IEmployee
    {
        public int GetBonus()
        {
            return 20000;
        }

        public int GetPay()
        {
            return 6000;
        }

        // Below method is only specific to Permanent employee , hence we have not placed in base class
        public int GetHomeAllowance(){
            return 2000;
        }
    }
}