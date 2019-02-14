using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.RightDock
{
    public class RightDockViewModel2
    {
        RightDockView2 _view = null;
        RightDockModel2 _model = null;

        public RightDockViewModel2(RightDockView2 _view)
        {
            this._view = _view;
            this._model = new RightDockModel2(_view);
        }

        internal void btnClicked()
        {
            System.Windows.MessageBox.Show("Right Dock 2 버튼 클릭됨");
        }

    }
}
