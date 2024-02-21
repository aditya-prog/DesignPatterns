namespace BuilderDesignPattern
{
    public class DesktopBuilder : ISystemBuilder
    {
        private ComputerSystem _desktop;
        public DesktopBuilder()
        {
            _desktop = new ComputerSystem();
        }
        public void AddGraphicsCard(string type)
        {
            _desktop.GraphicsCard = type;
        }

        public void AddHDD(int size)
        {
            _desktop.HDD = size;
        }

        public void AddKeyboard(string type)
        {
            _desktop.KeyBoard = type;
        }

        public void AddRAM(int size)
        {
            _desktop.RAM = size;
        }

        public void AddMouse(string type)
        {
            _desktop.Mouse = type;
        }

        public void TouchScreen(bool enabled)
        {
            return; // For Desktop Touch screen feature is not there
        }

        public ComputerSystem GetSystem()
        {
            return _desktop;
        }
    }
}