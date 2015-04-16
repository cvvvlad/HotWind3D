using HotWind3D.Model;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace HotWind3D.Converters
{
    public class HW3D_MeshConverter:IValueConverter
    {
        public ModelVisual3D Convert(HW3D_Mesh hw3dMesh)
        {
            var mesh = new MeshGeometry3D();
            for (int i = 0; i < hw3dMesh.Vertices.Count;i++ )
            {
                var vertex = hw3dMesh.Vertices[i];
                mesh.Positions.Add(new Point3D(vertex.X, vertex.Y, vertex.Z));
            }

            for(int i=0;i<hw3dMesh.TriangleIndices.Count;i++)
            {
                mesh.TriangleIndices.Add(hw3dMesh.TriangleIndices[i]);
            }

            var geometryModel = new GeometryModel3D(mesh, new DiffuseMaterial(new SolidColorBrush(Colors.Orange)));
            var model = new ModelVisual3D();
            model.Content = geometryModel;
            return model;
        }

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Convert(value as HW3D_Mesh);
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}
