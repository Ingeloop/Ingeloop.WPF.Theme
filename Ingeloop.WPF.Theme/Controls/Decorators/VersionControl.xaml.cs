using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Ingeloop.WPF.Theme
{
    /// <summary>
    /// Interaction logic for VersionControl.xaml
    /// </summary>
    public partial class VersionControl : UserControl
    {
        public static readonly DependencyProperty ApplicationNameProperty = DependencyProperty.Register(
            nameof(ApplicationName), typeof(String), typeof(VersionControl), new PropertyMetadata(String.Empty));

        public static readonly DependencyProperty VersionProperty = DependencyProperty.Register(
            nameof(Version), typeof(String), typeof(VersionControl), new PropertyMetadata(String.Empty));

        public static readonly DependencyProperty AuthorProperty = DependencyProperty.Register(
            nameof(Author), typeof(String), typeof(VersionControl), new PropertyMetadata(String.Empty));

        public string ApplicationName
        {
            get { return (string)GetValue(ApplicationNameProperty); }
            set { SetValue(ApplicationNameProperty, value); }
        }

        public string Version
        {
            get { return (string)GetValue(VersionProperty); }
            set { SetValue(VersionProperty, value); }
        }

        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            set { SetValue(AuthorProperty, value); }
        }

        public VersionControl()
        {
            InitializeComponent();
        }

        private void VisitWebSiteButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.ingeloop.com");
        }
    }
}
