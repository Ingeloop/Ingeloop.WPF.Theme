using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Ingeloop.WPF.Theme
{
    /// <summary>
    /// Interaction logic for IngeloopSplashScreen.xaml
    /// </summary>
    public partial class IngeloopSplashScreen : Window
    {
        public IngeloopSplashScreen(string applicationName, string versionName)
        {
            InitializeComponent();

            AppNameTextBlock.Text = applicationName;
            AppVersionTextBlock.Text = versionName;
        }
    }
}
