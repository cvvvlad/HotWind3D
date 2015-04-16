
namespace HotWind3D.Model
{
    public class HW3D_Vector3D
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public HW3D_Vector3D(double x,double y,double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
