namespace BuilderDesignPattern
{
    public class ConfigHelper
    {
        public static Dictionary<string, string> GetDesktopConfig()
        {
            var desktopConfigs = new Dictionary<string, string>
            {
                // Inserting entries into the dictionary
                ["RAM"] = "8", // Example RAM size: 8GB
                ["HDD"] = "512", // Example HDD size: 512GB
                ["GraphicsCard"] = "NVIDIA GTX 1660", // Example graphics card type
                ["Keyboard"] = "Mechanical", // Example keyboard type
                ["Mouse"] = "Wireless", // Example mouse type
            };

            return desktopConfigs;
        }

        public static Dictionary<string, string> GetLaptopConfigs()
        {
            var laptopConfigs = new Dictionary<string, string>
            {
                // Inserting entries into the dictionary
                ["RAM"] = "16", // Example RAM size: 16GB
                ["HDD"] = "1024", // Example HDD size: 1TB (1024GB)
                ["GraphicsCard"] = "Intel Iris Xe", // Example graphics card type
                ["TouchScreen"] = "true" // Example touchscreen disabled (true/false)
            };

            return laptopConfigs;

        }
    }
}