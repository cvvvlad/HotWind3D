using HotWind3D.Intefaces;
using HotWind3D.Model;

namespace HotWind3D.Messages.ViewModelArgs
{
    public class ViewportViewModelArgs:IViewModelArgs
    {
        public HW3D_Scene Scene { get; private set; }

        public ViewportViewModelArgs(HW3D_Scene scene)
        {
            Scene = scene;
        }
    }
}
