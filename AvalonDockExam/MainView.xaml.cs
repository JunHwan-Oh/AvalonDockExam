using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AvalonDockExam
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(this);
        }


        // 아발론독의 경우 세로 사이즈는 고정값이기 때문에 화면 사이즈에 맞추어 바인딩시키면 아름답게 표현됨.
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((MainViewModel)this.DataContext).Model.DockHeight = e.NewSize.Height - 80;
        }
    }
}
