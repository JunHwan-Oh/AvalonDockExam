using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.MidDock
{
    public class SecondViewModel
    {
        SecondView _view = null;
        SecondModel _model = null;

        public SecondViewModel(SecondView _view)
        {
            this._view = _view;
            this._model = new SecondModel(_view);
        }

        internal void btnClicked()
        {
            System.Windows.MessageBox.Show("Second View 버튼 클릭됨");
        }
    }
}
