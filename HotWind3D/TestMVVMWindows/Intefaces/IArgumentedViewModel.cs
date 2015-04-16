
namespace HotWind3D.Intefaces
{
    public interface IArgumentedViewModel<ArgsType> where ArgsType:IViewModelArgs
    {
        void ProccedArgs(ArgsType args);
    }
}
