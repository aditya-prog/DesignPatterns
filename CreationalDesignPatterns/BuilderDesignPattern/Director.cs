namespace BuilderDesignPattern
{
    // This class is just responsible for building the features of the system.
    public class Director
    {
        public static void BuildConfigurationOfSystem(ISystemBuilder systemBuilder,
                    Dictionary<string, string> configs)
        {
            if(configs.TryGetValue("RAM", out string ramSize))
            {
                systemBuilder.AddRAM(int.Parse(ramSize));
            }
            
            if(configs.TryGetValue("HDD", out string hddSize))
            {
                systemBuilder.AddHDD(int.Parse(hddSize));
            }

            if(configs.TryGetValue("GraphicsCard", out string grahicsType))
            {
                systemBuilder.AddGraphicsCard(grahicsType);
            }
            if(configs.TryGetValue("Keyboard", out string keyboard))
            {
                systemBuilder.AddKeyboard(keyboard);
            }
            if(configs.TryGetValue("Mouse", out string mouse))
            {
                systemBuilder.AddMouse(mouse);
            }
            if(configs.TryGetValue("TouchScreen", out string enabled))
            {
                systemBuilder.TouchScreen(bool.Parse(enabled));
            }
            

        }
    }
}