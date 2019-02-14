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

namespace AvalonDockExam.Components.RightDock
{
    /// <summary>
    /// RightDockView2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RightDockView2 : UserControl
    {
        public RightDockView2()
        {
            InitializeComponent();
            this.DataContext = new RightDockViewModel2(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((RightDockViewModel2)this.DataContext).btnClicked();
        }
    }
}
