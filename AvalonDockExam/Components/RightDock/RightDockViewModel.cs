using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.RightDock
{
    public class RightDockViewModel
    {
        RightDockView _view = null;
        RightDockModel _model = null;

        public RightDockViewModel(RightDockView _view)
        {
            this._view = _view;
            this._model = new RightDockModel(_view);
        }

        internal void btnClicked()
        {
            System.Windows.MessageBox.Show("Right Dock 1 버튼 클릭됨");
        }

    }
}
