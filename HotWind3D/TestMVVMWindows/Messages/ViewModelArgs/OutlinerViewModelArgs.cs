using HotWind3D.Model;
using HotWind3D.Intefaces;

namespace HotWind3D.Messages.ViewModelArgs
{
    public class OutlinerViewModelArgs:IViewModelArgs
    {
        public HW3D_Scene Scene { get; private set; }
        public OutlinerViewModelArgs(HW3D_Scene scene)
        {
            Scene = scene;
        }
    }
}
