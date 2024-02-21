namespace BuilderDesignPattern
{
    // This is the complex object which needs to be created
    public class ComputerSystem
    {
        public int RAM { get; set; }
        public int HDD { get; set; }
        public string GraphicsCard { get; set; }
        public string KeyBoard { get; set; } // Specific for Desktop
        public string Mouse { get; set; } // Specific for Desktop
        public bool TouchScreenEnabled { get; set; } // specific for Laptop

        public override string ToString()
        {
            string result = $"RAM: {RAM}GB, HDD: {HDD}GB, Graphics Card: {GraphicsCard}";

            if (KeyBoard != null && Mouse != null)
            {
                // Desktop configuration
                result += $", KeyBoard: {KeyBoard}, Mouse: {Mouse}";
            }
            else if (TouchScreenEnabled)
            {
                // Laptop configuration with touchscreen
                result += $", Touchscreen: Enabled";
            }
            else
            {
                // Laptop configuration without touchscreen
                result += $", Touchscreen: Disabled";
            }

            return result;
        }
    }
}