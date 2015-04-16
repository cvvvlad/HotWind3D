using System.Collections.Generic;

namespace HotWind3D.Model
{
    public class HW3D_Cube : HW3D_Mesh
    {
        protected override string GetName()
        {
            return string.Format("Cube #{0}",_id);
        }

        public HW3D_Cube(double a,HW3D_Material material)
        {
            _vertices = new List<HW3D_Vector3D>();

            _vertices.Add(new HW3D_Vector3D(0, 0, 0));
            _vertices.Add(new HW3D_Vector3D(a, 0, 0));
            _vertices.Add(new HW3D_Vector3D(a, a, 0));
            _vertices.Add(new HW3D_Vector3D(0, a, 0));

            _vertices.Add(new HW3D_Vector3D(0, 0, -a));
            _vertices.Add(new HW3D_Vector3D(a, 0, -a));
            _vertices.Add(new HW3D_Vector3D(a, a, -a));
            _vertices.Add(new HW3D_Vector3D(0, a, -a));

            _triangleIndices = new List<int>();
            _triangleIndices.AddRange(new[] { 0, 1, 2, 0, 2, 3 });
            _triangleIndices.AddRange(new[] { 1, 5, 6, 1, 6, 2 });
            _triangleIndices.AddRange(new[] { 5, 7, 6, 5, 4, 7 });
            _triangleIndices.AddRange(new[] { 4, 3, 7, 4, 0, 3 });
            _triangleIndices.AddRange(new[] { 3, 2, 6, 3, 6, 7 });
            _triangleIndices.AddRange(new[] { 0, 4, 5, 0, 5, 1 });
        }
    }
}
