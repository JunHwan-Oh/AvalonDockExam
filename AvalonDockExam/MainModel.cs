using AvalonDockExam.BaseClasses;
using AvalonDockExam.Components.LeftDock;
using AvalonDockExam.Components.MidDock;
using AvalonDockExam.Components.RightDock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam
{
    public class MainModel : ModelBase
    {
        MainView _view = null;


        LeftDockView _leftdockview = new LeftDockView();
        FirstView _firstview = new FirstView();
        SecondView _secondview = new SecondView();
        RightDockView _rightdockview = new RightDockView();
        RightDockView2 _rightdockview2 = new RightDockView2();


        public LeftDockView LeftDock_View { get { return _leftdockview; } set { _leftdockview = value; OnPropertyChanged(); } }
        public FirstView First_View { get { return _firstview; } set { _firstview = value; OnPropertyChanged(); } }
        public SecondView Second_View { get { return _secondview; } set { _secondview = value; OnPropertyChanged(); } }
        public RightDockView RightDock_View { get { return _rightdockview; } set { _rightdockview = value; OnPropertyChanged(); } }
        public RightDockView2 RightDock_View2 { get { return _rightdockview2; } set { _rightdockview2 = value; OnPropertyChanged(); } }


        double _dockheight = 700;
        public double DockHeight { get { return _dockheight; } set { _dockheight = value; OnPropertyChanged(); } }
        


        public MainModel(MainView _view)
        {
            this._view = _view;
        }
    }
}
