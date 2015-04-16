using GalaSoft.MvvmLight.Command;
using HotWind3D.Intefaces;
using HotWind3D.Model;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using System.Collections.ObjectModel;
using HotWind3D.Messages.ViewModelArgs;
using System.Collections.Generic;
using System;
using GalaSoft.MvvmLight;

namespace HotWind3D.ViewModel
{
    public class MainViewModel : SimpleViewModelBase
    {
        #region Fields

        HW3D_Scene _scene;
        IViewModelFactory _viewModelFactory;

        #endregion

        #region Ctor

        public MainViewModel(IViewModelFactory viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
            _scene = new HW3D_Scene();
            _scene.SceneObjects.CollectionChanged += SceneObjects_CollectionChanged;

            var leftViewModelArgs = new ViewportViewModelArgs(_scene);
            LeftViewModel = GetViewModel<ViewportViewModel, ViewportViewModelArgs>(leftViewModelArgs);

            var outlinerViewModelArgs = new OutlinerViewModelArgs(_scene);
            GetViewModel<OutlinerViewModel, OutlinerViewModelArgs>(outlinerViewModelArgs);
        }

        #endregion

        #region Commands
        //private RelayCommand _rotateLeftCommand;
        //public RelayCommand RotateLeftCommand
        //{
        //    get
        //    {
        //        return _rotateLeftCommand??(_rotateLeftCommand = new RelayCommand(RotateLeft));
        //    }
        //}

        #endregion

        #region Props

        public override string Name
        {
            get
            {
                return "HotWind3D";
            }
        }

        private List<SimpleViewModelBase> _windows;
        public List<SimpleViewModelBase> Windows
        {
            get
            {
                return _windows ?? (_windows = new List<SimpleViewModelBase>());
            }
        }

        private const string SceneObjectsPropertyName = "SceneObjects";
        public ObservableCollection<HW3D_SceneObject> SceneObjects
        {
            get
            {
                return _scene.SceneObjects;
            }
        }

        private const string LeftViewModelPropertyName = "LeftViewModel";
        private SimpleViewModelBase _leftViewModel;
        public SimpleViewModelBase LeftViewModel
        {
            get
            {
                return _leftViewModel;
            }
            set
            {
                _leftViewModel = value;
                RaisePropertyChanged(LeftViewModelPropertyName);
            }
        }

        private const string RightViewModelPropertyName = "RightViewModel";
        private SimpleViewModelBase _rightViewModel;
        public SimpleViewModelBase RightViewModel
        {
            get
            {
                return _rightViewModel;
            }
            set
            {
                _rightViewModel = value;
                RaisePropertyChanged(RightViewModelPropertyName);
            }
        }

        private const string SelectedViewModelPropertyName = "SelectedViewModel";
        private SimpleViewModelBase _selectedViewModel;
        public SimpleViewModelBase SelectedViewModel
        {
            get
            {
                return _selectedViewModel;
            }
            set
            {
                if (_selectedViewModel == value) return;
                _selectedViewModel = value;
                RaisePropertyChanged(SelectedViewModelPropertyName);
            }
        }

        #endregion

        #region Methods

        SimpleViewModelBase GetViewModel<VMType>() where VMType : SimpleViewModelBase
        {
            var viewModel = _viewModelFactory.GetInstance<VMType>();
            if (!Windows.Contains(viewModel))
                Windows.Add(viewModel);
            return viewModel;
        }

        SimpleViewModelBase GetViewModel<VMType, ArgsType>(ArgsType args)
            where VMType : SimpleViewModelBase, IArgumentedViewModel<ArgsType>
            where ArgsType : IViewModelArgs
        {
            var viewModel = _viewModelFactory.GetInstance<VMType, ArgsType>(args) as SimpleViewModelBase;

            if(!Windows.Contains(viewModel))
                Windows.Add(viewModel);
            return viewModel;
        }

        void SceneObjects_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RaisePropertyChanged(SceneObjectsPropertyName);
        }

        //private void RotateLeft()
        //{
        //    double angle = 20;

        //    ModelVisual3D cube = null;
        //    foreach (var child in LeftViewModel.CurrentViewport.Children)
        //    {
        //        if (!(child is ModelVisual3D)) continue;
        //        var model = child as ModelVisual3D;
        //        if (model.Content is GeometryModel3D) cube = model;
        //    }
        //    Transform3DCollection transformGroup = cube.Transform.GetValue(Transform3DGroup.ChildrenProperty) as Transform3DCollection;

        //    RotateTransform3D currentRotateTransform3D = null;
        //    if (transformGroup.Count > 0)
        //    {
        //        foreach (var tranform in transformGroup)
        //        {
        //            if (tranform is RotateTransform3D)
        //            {
        //                currentRotateTransform3D = tranform as RotateTransform3D;
        //            }
        //        }
        //    }

        //    if (currentRotateTransform3D != null)
        //    {
        //        var currentRotation = currentRotateTransform3D.Rotation as AxisAngleRotation3D;
        //        angle = angle + currentRotation.Angle;
        //    }

        //    var rotation = new AxisAngleRotation3D(new Vector3D(0, 1, 0), angle);
        //    var newTransformGroup = new Transform3DGroup();
        //    newTransformGroup.Children.Add(new RotateTransform3D(rotation));
        //    cube.Transform = newTransformGroup;
        //}

        #endregion

    }
}