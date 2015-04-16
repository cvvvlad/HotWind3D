using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;

namespace HotWind3D.ViewModel
{
    public class UnityLocator:IServiceLocator
    {
        IUnityContainer _unity;
        public UnityLocator(IUnityContainer unity)
        {
            _unity = unity;
        }

        public IEnumerable<TService> GetAllInstances<TService>()
        {
            return _unity.ResolveAll<TService>();
        }

        public IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return _unity.ResolveAll(serviceType);
        }

        public TService GetInstance<TService>(string key)
        {
            return _unity.Resolve<TService>(key);
        }

        public TService GetInstance<TService>()
        {
            return _unity.Resolve<TService>();
        }

        public object GetInstance(Type serviceType, string key)
        {
            return _unity.Resolve(serviceType, key);
        }

        public object GetInstance(Type serviceType)
        {
            return _unity.Resolve(serviceType);
        }

        public object GetService(Type serviceType)
        {
            return _unity.Resolve(serviceType);
        }
    }
}
