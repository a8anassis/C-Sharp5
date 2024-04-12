
namespace InterfacesApp.Service
{
    internal abstract class AbstractPoint : IMovable
    {
        public int X { get; set; }

        public virtual void Move5()
        {
            X += 5;
        }

        public virtual void Move10()
        {
            X += 10;
        }
    }
}
