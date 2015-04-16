using HotWind3D.Converters;
using HotWind3D.Intefaces;
using HotWind3D.Messages.ViewModelArgs;
using HotWind3D.Model;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace HotWind3D.ViewModel
{
    public class ViewportViewModel:SimpleViewModelBase,IArgumentedViewModel<ViewportViewModelArgs>
    {
        HW3D_Scene _scene;
        HW3D_MeshConverter _meshConverter;

        private const string CurrentCameraPropertyName = "CurrentCamera";
        private Camera _currentCamera;
        public Camera CurrentCamera
        {
            get
            {
                if(_currentCamera == null)
                {
                    _currentCamera = new PerspectiveCamera()
                    {
                        LookDirection = new Vector3D(0, 0, -1),
                        Position = new Point3D(0, 1, 5)
                    };
                }
                return _currentCamera;
            }
            set
            {
                if (_currentCamera == value) return;
                _currentCamera = value;
                RaisePropertyChanged(CurrentCameraPropertyName);
            }
        }

        private Viewport3D _currentViewport;
        public Viewport3D CurrentViewport
        {
            get
            {
                if(_currentViewport == null)
                {
                    _currentViewport = new Viewport3D();
                    _currentViewport.Camera = CurrentCamera;
                    var light = new DirectionalLight()
                    {
                        Direction = new Vector3D(1, -1, 0)
                    };

                    var model = new ModelVisual3D();
                    model.Content = light;
                    _currentViewport.Children.Add(model);

                    foreach (var sceneObject in SceneObjects)
                    {
                        if (sceneObject is HW3D_Mesh)
                        {
                            var sceneObjectModel = _meshConverter.Convert(sceneObject as HW3D_Mesh);
                            if (!_currentViewport.Children.Contains(sceneObjectModel))
                                _currentViewport.Children.Add(sceneObjectModel);
                        }
                    }
                }
                
                return _currentViewport;
            }
        }

        private const string SceneObjectsPropertyName = "SceneObjects";
        public ObservableCollection<HW3D_SceneObject> SceneObjects
        {
            get
            {
                return _scene.SceneObjects;
            }
        }

        public ViewportViewModel()
        {
            _meshConverter = new HW3D_MeshConverter();
        }

        public void ProccedArgs(ViewportViewModelArgs args)
        {
            _scene = args.Scene;
            _scene.SceneObjects.Add(new HW3D_Cube(2,new HW3D_Material()));
        }

        public override string Name
        {
            get 
            {
                return "Viewport";
            }
        }
    }
}
