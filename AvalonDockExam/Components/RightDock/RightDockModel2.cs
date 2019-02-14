using AvalonDockExam.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.RightDock
{
    public class RightDockModel2 : ModelBase
    {
        RightDockView2 _view = null;

        public RightDockModel2(RightDockView2 _view)
        {
            this._view = _view;
        }
    }
}
