using AvalonDockExam.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.LeftDock
{
    public class LeftDockModel : ModelBase
    {
        LeftDockView _view = null;

        public LeftDockModel(LeftDockView _view)
        {
            this._view = _view;
        }
    }
}
