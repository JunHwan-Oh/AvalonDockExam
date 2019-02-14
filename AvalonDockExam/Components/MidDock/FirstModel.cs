using AvalonDockExam.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.MidDock
{
    public class FirstModel : ModelBase
    {
        FirstView _view = null;

        public FirstModel(FirstView _view)
        {
            this._view = _view;
        }
    }
}
