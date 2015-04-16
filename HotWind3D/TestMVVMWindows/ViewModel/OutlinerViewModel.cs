using HotWind3D.Intefaces;
using HotWind3D.Messages.ViewModelArgs;
using HotWind3D.Model;
using System.Collections.ObjectModel;

namespace HotWind3D.ViewModel
{
    public class OutlinerViewModel :SimpleViewModelBase, IArgumentedViewModel<OutlinerViewModelArgs>
    {
        HW3D_Scene _scene;
        public void ProccedArgs(OutlinerViewModelArgs args)
        {
            _scene = args.Scene;
            _scene.SceneObjects.CollectionChanged += SceneObjects_CollectionChanged;
        }

        void SceneObjects_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RaisePropertyChanged(SceneObjectsPropertyName);
        }

        private const string SceneObjectsPropertyName = "SceneObjects";
        public ObservableCollection<HW3D_SceneObject> SceneObjects
        {
            get
            {
                return _scene.SceneObjects;
            }
        }

        public override string Name
        {
            get
            {
                return "Outliner";
            }
        }
    }
}
