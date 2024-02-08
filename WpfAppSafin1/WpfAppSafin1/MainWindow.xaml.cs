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

namespace WpfAppSafin1
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
        private void Mouseenter1(object sender, MouseEventArgs e) 
        {

            Random random = new Random();

            double windowWidth = ActualWidth;
            double windowHeight = ActualHeight;

            double newX = random.NextDouble() * (windowWidth - myButton.Width);
            double newY = random.NextDouble() * (windowHeight - myButton.Height);

            myButton.Margin = new Thickness(newX, newY, 0, 0);
        }
    }
}
