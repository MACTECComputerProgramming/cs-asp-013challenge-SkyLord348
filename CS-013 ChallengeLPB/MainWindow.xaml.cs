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

namespace CS_013_ChallengeLPB
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonSmall.IsChecked == true)
            {
                labelOutput.Content = "6 inch,";
                
                double x = 3.30;
            }
            else
            {
                double x = 0;
            }
            if (radioButtonFlatBread.IsChecked == true)
            {
                labelOutput.Content = "Flatbread,";
                double x = .50;

            }
            else
            {
                double x = 0;
            }
            if (checkBoxProvolone.IsChecked == true)
            {
                labelOutput.Content = "Provolone,";



            }































        }
    }
}
