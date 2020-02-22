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

namespace Samples.Views
{
    /// <summary>
    /// Interaction logic for HelloWorld.xaml
    /// </summary>
    public partial class HelloWorld : UserControl
    {
        Brush originalBrush;
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            var stackPanel = ((StackPanel)sender).Background = Brushes.LightBlue;
        }

        private void ControlBorder_MouseEnter(object sender, MouseEventArgs e)
        {
            var border = ((Border)sender);
            originalBrush = border.Background;
            border.Background = Brushes.LightBlue;
        }

        private void ControlBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            var border = ((Border)sender);
            border.Background = originalBrush;
        }
    }
}
