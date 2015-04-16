using HotWind3D.Intefaces;
using HotWind3D.Model;

namespace HotWind3D.Messages.ViewModelArgs
{
    public class SceneObjectPropertiesViewModelArgs:IViewModelArgs
    {
        public HW3D_SceneObject SceneObject;
        
        public SceneObjectPropertiesViewModelArgs(HW3D_SceneObject sceneObject)
        {
            SceneObject = sceneObject;
        }
    }
}
