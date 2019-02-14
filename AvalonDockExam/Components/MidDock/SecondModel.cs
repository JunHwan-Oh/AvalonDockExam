using AvalonDockExam.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.MidDock
{
    public class SecondModel : ModelBase
    {
        SecondView _view = null;

        public SecondModel(SecondView _view)
        {
            this._view = _view;
        }
    }
}
