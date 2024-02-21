namespace BuilderDesignPattern
{
    public class LaptopBuilder : ISystemBuilder
    {
        private ComputerSystem _laptop;
        public LaptopBuilder()
        {
            _laptop = new ComputerSystem();
        }
        public void AddGraphicsCard(string type)
        {
            _laptop.GraphicsCard = type;
        }

        public void AddHDD(int size)
        {
            _laptop.HDD = size;
        }

        public void AddKeyboard(string type)
        {
            return; //This feature is not there for Laptop 
        }

        public void AddRAM(int size)
        {
            _laptop.RAM = size;
        }

        public void AddMouse(string type)
        {
            return; //This feature is not there for Laptop 
        }

        public void TouchScreen(bool enabled)
        {
            _laptop.TouchScreenEnabled = enabled;
        }

        public ComputerSystem GetSystem()
        {
            return _laptop;
        }
    }
}