namespace FactoryMethodDesignPattern{
    public class ContractEmployee : IEmployee
    {
        public int GetBonus()
        {
            return 10000;
        }

        public int GetPay()
        {
            return 4000;
        }

        // Below method is only specific to Contract employee, hence we have not placed in base class
        public int GetMedicalAllowance(){
            return 2000;
        }
    }
}