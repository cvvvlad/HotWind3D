using HotWind3D.Intefaces;
using HotWind3D.Messages.ViewModelArgs;
using HotWind3D.Model;
namespace HotWind3D.ViewModel
{
    class SceneObjectPropertiesViewModel :SimpleViewModelBase, IArgumentedViewModel<SceneObjectPropertiesViewModelArgs>
    {
        HW3D_SceneObject _sceneObject;
        public void ProccedArgs(SceneObjectPropertiesViewModelArgs args)
        {
           _sceneObject = args.SceneObject;
        }

        public override string Name
        {
            get
            {
                return "Object properties";
            }
        }
    }
}
