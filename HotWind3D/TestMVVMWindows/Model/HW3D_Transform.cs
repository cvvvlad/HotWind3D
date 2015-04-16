using HotWind3D.Intefaces;
namespace HotWind3D.Model
{
    public class HW3D_Transform:HW3D_IObjectComponent
    {
        HW3D_Vector3D _position;
        HW3D_Quaternion _rotation;
        HW3D_Vector3D _scale;

        public HW3D_Vector3D Position
        {
            get
            {
                return _position;
            }
        }

        public HW3D_Quaternion Rotation
        {
            get
            {
                return _rotation;
            }
        }

        public HW3D_Vector3D Scale
        {
            get
            {
                return _scale;
            }
        }

    }
}
