namespace FactoryMethodDesignPattern{
    public class EmployeeModel{
        public string Name { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int HourlyPay { get; set; }
        public int Bonus { get; set; }
        public int? HouseAllowance { get; set; }
        public int? MedicalAllowance { get; set; } 

        public override string ToString()
    {
        string result = $"Name: {Name}, " +
                        $"EmployeeType: {EmployeeType}, " +
                        $"HourlyPay: {HourlyPay}, " +
                        $"Bonus: {Bonus}";

        if (HouseAllowance.HasValue)
        {
            result += $", HouseAllowance: {HouseAllowance}";
        }

        if (MedicalAllowance.HasValue)
        {
            result += $", MedicalAllowance: {MedicalAllowance}";
        }

        return result;
    } 
    }
}