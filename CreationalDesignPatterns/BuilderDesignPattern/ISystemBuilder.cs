namespace BuilderDesignPattern
{
    // Here we will declare all the parts to be built for the system
    public interface ISystemBuilder
    {
        void AddRAM(int size);
        void AddHDD(int size);
        void AddGraphicsCard(string type);
        void AddKeyboard(string type);
        void AddMouse(string type);
        void TouchScreen(bool enabled);

        ComputerSystem GetSystem();
    }
}