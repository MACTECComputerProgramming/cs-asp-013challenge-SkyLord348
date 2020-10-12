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
            //Variables

            string subOrderDescription = "6in., ";

            double totalPrice = 3.50;


            //Get Size

            if (checkBoxLarge.IsChecked == true)
            {
                totalPrice = 5.00;

                subOrderDescription = "12in., ";

            }
            //Get Bread
            if (radioButtonWheat.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Wheat Bread, ";


            }
            else if (radioButtonItalian.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Italian, ";


            }
            else if (radioButtonFlatBread.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Flat Bread, ";

                totalPrice = totalPrice + .50;
            }



            //Get Meat

            if (radioButtonChicken.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Roasted Chicken, ";


            }
            else if (radioButtonPepperoni.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Pepperoni, ";

            }
            else if (radioButtonHam.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Ham, ";

            }
            else if (radioButtonMeatBall.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Meatball, ";

                totalPrice = totalPrice + 1.00;

            }

            //Get Cheese
            if (checkBoxAmerican.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "American cheese, ";

                totalPrice = totalPrice + 0.25;

            }
            else if (checkBoxSwiss.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Swiss cheese, ";

                totalPrice = totalPrice + 0.30;
            }
            else if (checkBoxProvolone.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Provolone cheese, ";

                totalPrice = totalPrice + 0.50;
            }
            else if (checkBoxPepperjack.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Pepperjack cheese, ";

                totalPrice = totalPrice + 0.75;
            }


            //Get Veggies
            if (checkBoxCucumber.IsChecked== true)
            {
                subOrderDescription = subOrderDescription + "Cucumber";

            }
            else if (checkBoxGreenPepper.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Green Pepper";


            }
            else if (checkBoxLettuce.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Lettuce";


            }
            else if (checkBoxRedOnion.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Red Onion";


            }
            else if (checkBoxAll.IsChecked == true)
            {
                subOrderDescription = subOrderDescription + "Cucumber, Green Pepper, Lettuce, Red Onion";


            }




            //Check for special
            if ((radioButtonItalian.IsChecked == true)&&(radioButtonChicken.IsChecked == true)&&(checkBoxAmerican.IsChecked == true)
                &&(checkBoxPepperjack.IsChecked == true)&&(checkBoxLettuce.IsChecked == true))
            {
                subOrderDescription = subOrderDescription + "**Special! $2.00 off**";

                totalPrice = totalPrice - 2.0;
            }



            //Output


            labelOutput.Content = subOrderDescription + " $" + totalPrice;

        }
    }
}
