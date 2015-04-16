using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using HotWind3D.Intefaces;

namespace HotWind3D.Factories
{
    public class ViewModelFactory : IViewModelFactory
    {
        public T GetInstance<T>() where T:ViewModelBase
        {
            return ServiceLocator.Current.GetInstance<T>();
        }

        public VMType GetInstance<VMType, ArgsType>(ArgsType args) 
                                where ArgsType:IViewModelArgs 
                                where VMType:ViewModelBase,IArgumentedViewModel<ArgsType>
        {
            VMType viewModel = ServiceLocator.Current.GetInstance<VMType>();
            viewModel.ProccedArgs(args);
            return viewModel;
        }
    }
}
