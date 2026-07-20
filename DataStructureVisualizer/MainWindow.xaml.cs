using System.Windows;

namespace DataStructureVisualizer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Views.HomePage());
        }
    }
}