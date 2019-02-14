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

namespace AvalonDockExam.Components.MidDock
{
    /// <summary>
    /// SecondView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
            this.DataContext = new SecondViewModel(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((SecondViewModel)this.DataContext).btnClicked();
        }
    }
}
