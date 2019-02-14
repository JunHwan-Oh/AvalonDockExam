using AvalonDockExam.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.RightDock
{
    public class RightDockModel : ModelBase
    {
        RightDockView _view = null;

        public RightDockModel(RightDockView _view)
        {
            this._view = _view;
        }
    }
}
