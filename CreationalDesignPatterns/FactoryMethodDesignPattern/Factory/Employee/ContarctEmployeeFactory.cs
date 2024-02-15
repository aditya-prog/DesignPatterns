namespace FactoryMethodDesignPattern{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(EmployeeModel emp) : base(emp)
        {
        }

        protected override IEmployee GetEmployee()
        {
            // Before returning employee, here only apply Medical allowance in emp Model object
            // because MedicalAllow is specific to ContractEmployee only
            ContractEmployee empDetails = new ContractEmployee();
            _emp.MedicalAllowance = empDetails.GetMedicalAllowance();
            return empDetails;
        }
    }
}