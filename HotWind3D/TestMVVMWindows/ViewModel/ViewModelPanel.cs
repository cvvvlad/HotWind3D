using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HotWind3D.ViewModel
{
    public class ViewModelPanel:Panel
    {
        public SimpleViewModelBase ViewModel { get; set; }

        public ViewModelPanel()
        {
            
        }
    }
}
