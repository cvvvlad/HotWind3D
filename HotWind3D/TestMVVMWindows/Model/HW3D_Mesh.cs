using System.Collections.Generic;

namespace HotWind3D.Model
{
    public class HW3D_Mesh:HW3D_SceneObject
    {

        #region Fields
        protected List<HW3D_Vector3D> _vertices;
        protected List<int> _triangleIndices;
        protected HW3D_Material _material;
        protected HW3D_Transform _transform;

        #endregion


        #region Props
        public List<HW3D_Vector3D> Vertices
        {
            get
            {
                return _vertices;
            }
        }
        public List<int> TriangleIndices
        {
            get
            {
                return _triangleIndices;
            }
        }
        public HW3D_Material Material
        {
            get
            {
                return _material;
            }
        }

        #endregion

        #region Ctor
        public HW3D_Mesh()
        {
        }

        #endregion

        #region Methods
        public HW3D_Mesh ToMesh()
        {
            return this as HW3D_Mesh;
        }

        #endregion
    }
}
