using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp3
{
    public class Phone
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public decimal Price { get; set; }
    }

    public class Company
    {
        public string Title { get; set; }
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Phone _phone;

        public Phone Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();


            Phone = new Phone
            {
                Name = "Lumia 630",
                Company = new Company { Title = "Microsoft" },
                Price = 1000
            };

            this.DataContext = Phone;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phone.Name += "8";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
