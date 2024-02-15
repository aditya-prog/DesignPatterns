namespace FactoryMethodDesignPattern{
    public abstract class BaseEmployeeFactory
    {   
        protected EmployeeModel _emp;
        public BaseEmployeeFactory(EmployeeModel emp)
        {
            _emp = emp;
        }
        // ApplySalary is implemented in base class because its implementation is common for both type of emp
        public IEmployee ApplySalary(){
            var empDetails = GetEmployee();
            _emp.HourlyPay = empDetails.GetPay();
            _emp.Bonus = empDetails.GetBonus();

            return empDetails;
        }
        protected abstract IEmployee GetEmployee();
    }
}