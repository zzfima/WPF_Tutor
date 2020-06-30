using System.Windows;
using System.Windows.Media;

namespace WpfResources
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

        private void changeResourceButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush v =  this.FindResource("brushResource") as SolidColorBrush;
            v.Color = Colors.Red;
        }
    }
}
