namespace PointApp.Model
{
    internal class Point3D : Point2D
    {
        public int Z { get; set; }

        public Point3D() : base()
        {

        }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override void Move5()
        {
            base.Move5();
            Z += 5;
        }

        public override string ToString()
        {
            return base.ToString() + $", {{{Z}}}";
        }
    }
}
