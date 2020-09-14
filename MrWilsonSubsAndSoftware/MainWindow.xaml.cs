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

namespace MrWilsonSubsAndSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            headingtextBlock.Text = "Welcome to Mr. Wilson's Subs and Software!  Please order bellow." +
                "              *** Sorry at this time you can only order one sub at a time. We need a better web site.";
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {


            // Variables

            string subDiscription =" Six Inch ";

            double subTotalPrice = 3.50;


            // Get Size

            if (footLongRadioButton3.IsChecked == true)
            {
                subTotalPrice = 5.00;

                subDiscription = "Foot Long ";
            }



            // Get Bread

            if (wheatradioButton.IsChecked == true)
            {
                subDiscription = subDiscription + " Wheat bread "; 
            }
            else if (italianRadioButton1.IsChecked== true)
            {
                subDiscription = subDiscription + " Italian bread ";
            }
            else
            {
                subDiscription = subDiscription + " Flat bread ";

                subTotalPrice = subTotalPrice + .50;
            }

            //Get Meat
            if (hamradioButton.IsChecked == true)
            {
                subDiscription = subDiscription + " Ham , ";
            }
            else if (ChickenradioButton3.IsChecked == true)
            {
                subDiscription = subDiscription + " Roasted Chicken, ";
            }
            else if (MeatBallradioButton4.IsChecked == true)
            {
                subDiscription = subDiscription + " Meatball, ";

                subTotalPrice = subTotalPrice + 1.00;

            }
            else
            {
                subDiscription = subDiscription + " Steak, ";

                subTotalPrice = subTotalPrice + 1.50;
            }


            //Get Cheese

            if (AmericanCheckBox.IsChecked== true)
            {
                subDiscription = subDiscription + " American Cheese, ";

                subTotalPrice = subTotalPrice + .25;
            }

            if (swissCheckBox1.IsChecked == true)
            {
                subDiscription = subDiscription + " Swiss Cheese, ";

                subTotalPrice = subTotalPrice + .30;
            }

            if (pepperJackCheckBox2.IsChecked == true)
            {
                subDiscription = subDiscription + " PepperJack Cheese, ";

                subTotalPrice = subTotalPrice + .75;
            }



            //Get Veggies



            if(CucumberCheckBox.IsChecked == true) { subDiscription = subDiscription + " Cucumbers, "; }

            if (GreenPeppercheckBox1.IsChecked == true)
            {
                subDiscription = subDiscription + " Green Pepper, ";

                subTotalPrice = subTotalPrice + .25;
            }

            if (LettuceCheckBox2.IsChecked == true)
            {
                subDiscription = subDiscription + " Lettuce, ";

                subTotalPrice = subTotalPrice + .15;
            }

            if (OnioncheckBox3.IsChecked == true)
            {
                subDiscription = subDiscription + " Red Onion ";

                subTotalPrice = subTotalPrice + .10;
            }

            if (AllcheckBox4.IsChecked == true)
            {
                subDiscription = subDiscription + " Cucumbers, Green Pepper, Lettuce, Red Onion ";

                subTotalPrice = subTotalPrice + .25;
            }

            // Check for Special

            if ((wheatradioButton.IsChecked == true)&&(MeatBallradioButton4.IsChecked == true)&&
                (OnioncheckBox3.IsChecked== true)&&(AmericanCheckBox.IsChecked==true))
            {
                subDiscription = subDiscription + " Special**$2.00 Off ";

                subTotalPrice = subTotalPrice - 2.00;
            }

            //Print - Sub and Total Price

            subtextBlock.Text = subDiscription + " $ " + subTotalPrice;

        }
    }
}
