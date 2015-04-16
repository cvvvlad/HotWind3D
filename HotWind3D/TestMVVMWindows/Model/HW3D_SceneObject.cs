using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace HotWind3D.Model
{
    public abstract class HW3D_SceneObject
    {
        public HW3D_Transform Transform { get; set; }

        static int AutoIncrementor=0;

        protected int _id;

        public HW3D_SceneObject()
        {
            _id = AutoIncrementor++;
        }

        public string Name
        {
            get
            {
                return GetName();
            }
        }

        protected virtual string GetName()
        {
            return "SceneObject "+_id;
        }
    }
}
