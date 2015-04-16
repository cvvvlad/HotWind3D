using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using HotWind3D.Factories;
using HotWind3D.Intefaces;
using Microsoft.Practices.Unity;

namespace HotWind3D.ViewModel
{
    public class ViewModelLocator
    {
        IUnityContainer _unity;

        public ViewModelLocator()
        {
            _unity = new UnityContainer();
            var unityLocator = new UnityLocator(_unity);

            ServiceLocator.SetLocatorProvider(() => unityLocator);
            _unity.RegisterType<MainViewModel>();
            _unity.RegisterType<IViewModelFactory, ViewModelFactory>();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        
        public static void Cleanup()
        {
        }
    }
}