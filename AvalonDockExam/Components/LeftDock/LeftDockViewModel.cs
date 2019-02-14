using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.LeftDock
{
    public class LeftDockViewModel
    {
        LeftDockView _view = null;
        LeftDockModel _model = null;

        public LeftDockViewModel(LeftDockView _view)
        {
            this._view = _view;
            this._model = new LeftDockModel(_view);
        }

        internal void btnClicked()
        {
            System.Windows.MessageBox.Show("Left Dock 버튼 클릭됨");
        }
    }
        
}
