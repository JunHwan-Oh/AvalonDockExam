using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockExam.Components.MidDock
{
    public class FirstViewModel
    {
        FirstView _view = null;
        FirstModel _model = null;

        public FirstViewModel(FirstView _view)
        {
            this._view = _view;
            this._model = new FirstModel(_view);
        }

        internal void btnClicked()
        {
            System.Windows.MessageBox.Show("First View 버튼 클릭됨");
        }
    }
}
