namespace InterfacesApp.Service
{
    internal interface IMovable
    {
        void Move5();

        void Move10()
        {
            Console.WriteLine("Move 10 units");
        }
    }
}
