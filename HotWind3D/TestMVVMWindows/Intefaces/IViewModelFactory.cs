using GalaSoft.MvvmLight;
namespace HotWind3D.Intefaces
{
    public interface IViewModelFactory
    {
        T GetInstance<T>() where T : ViewModelBase;

        VMType GetInstance<VMType, ArgsType>(ArgsType args)
            where ArgsType : IViewModelArgs
            where VMType : ViewModelBase, IArgumentedViewModel<ArgsType>;
    }
}
