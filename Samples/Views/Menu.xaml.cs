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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            var buttonVal = ((Button)sender).Content.ToString();
            SetContentControl(buttonVal);

        }

        private void SetContentControl(string buttonVal)
        {
            MainWindow mainWindow = GetMainWindow();

            switch (buttonVal)
            {
                case "Hello World":
                    mainWindow.MainContentView.Content = new HelloWorld();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }

        private MainWindow GetMainWindow()
        {
            Grid grid = (Grid)this.Content;
            Menu menu = (Menu)grid.Parent;
            ContentControl cc = (ContentControl)menu.Parent;
            DockPanel dockPanel = (DockPanel)cc.Parent;
            Border border = (Border)dockPanel.Parent;
            MainWindow mainWindow = (MainWindow)border.Parent;
            return mainWindow;
        }
    }
}
