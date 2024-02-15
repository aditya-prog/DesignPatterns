namespace FactoryMethodDesignPattern{
    public class EmployeeManagerFactory
    {   
        // Factory of factory i.e this factory class returns other factory classes
        public static BaseEmployeeFactory GetEmployeeFactory(EmployeeModel emp){
            if(emp.EmployeeType == EmployeeType.Permanent){
                return new PermanentEmployeeFactory(emp);
            }
            else if(emp.EmployeeType == EmployeeType.Contracted){
                return new ContractEmployeeFactory(emp);
            }
            else{
                throw new ArgumentException("Invalid argument type..");
            }
        }
    }
}