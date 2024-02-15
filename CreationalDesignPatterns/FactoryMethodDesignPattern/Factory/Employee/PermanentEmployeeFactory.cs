namespace FactoryMethodDesignPattern{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(EmployeeModel emp) : base(emp)
        {
        }

        protected override IEmployee GetEmployee()
        {
            // Before returning employee, here only apply House allowance in emp Model object
            // because HouseAllow is specific to PermEmployee only
            PermanentEmployee empDetails = new PermanentEmployee();
            _emp.HouseAllowance = empDetails.GetHomeAllowance();
            return empDetails;
        }
    }
}