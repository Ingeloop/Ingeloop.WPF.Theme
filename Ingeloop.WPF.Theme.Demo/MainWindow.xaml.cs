using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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

namespace Ingeloop.WPF.Theme.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SplashScreenButton_Click(object sender, RoutedEventArgs e)
        {
            string applicationName = Assembly.GetExecutingAssembly()?.GetName()?.Name;
            Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
            string versionName = $"v{currentVersion.Major}.{currentVersion.Minor}.{currentVersion.Build}";

            SplashScreenManager.ShowSplashScreen(applicationName, versionName, new Action(() => Thread.Sleep(1000)), 5000);
        }
    }
}
