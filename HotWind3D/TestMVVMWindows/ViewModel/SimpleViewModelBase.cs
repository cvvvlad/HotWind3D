using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotWind3D.ViewModel
{
    public abstract class SimpleViewModelBase:ViewModelBase
    {
        private static int IdIncrementor = 0;

        public int Id { get; private set; }

        public abstract string Name { get; }   

        public SimpleViewModelBase()
        {
            Id = IdIncrementor++;
        }
    }
}
