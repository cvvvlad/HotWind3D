using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace HotWind3D.Model
{
    public class HW3D_Scene
    {
        private static int IdIncrementor = 0;

        private int _id;

        public HW3D_Scene()
        {
            _id = IdIncrementor++;
        }

        public string Name
        {
            get
            {
                return "Scene #"+_id;
            }
        }

        ObservableCollection<HW3D_SceneObject> _sceneObjects;

        public ObservableCollection<HW3D_SceneObject> SceneObjects
        {
            get 
            { 
                if(_sceneObjects == null)
                {
                    _sceneObjects = new ObservableCollection<HW3D_SceneObject>();
                }
                return _sceneObjects; 
            }
        }
    }
}
