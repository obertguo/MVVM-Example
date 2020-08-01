using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Initialize view model
            ViewModel viewModel = new ViewModel();

            //Bind XAML to viewmodel through datacontext
            DataContext = viewModel;

            InitializeComponent();
        }
    }
}
