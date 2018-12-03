using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    //====================================================\\
    //20 random numbers + bubble sort
    //====================================================\\
    public sealed partial class numtwenty : Page
    {
        //creating my array - making it global (so I can use the array more than once)
        public static int[] myArray = new int[20];
        public numtwenty()
        {
            this.InitializeComponent();
        }

        //====================================================\\
        //==================(navigation)==================\\
        
        private void btnBackCI_a_Click(object sender, RoutedEventArgs e)
        {
            //navigate back to home page
            this.Frame.Navigate(typeof(MainPage));
        }
        //====================================================\\
        //==================(method)==================\\
        //making a method that generates an array of random numbers
        private void myArraymethod()
        {
            //instance of random function - name it r_num (random number)
            Random r_num = new Random();
            //assigning a vaiable to randomize a number
            int randomNumber = r_num.Next(0, 1001);

            //creating a for loop statement
            for (int i = 0; i < myArray.Length; i++)
            {
                //creating while statement
                while (true)
                {
                    //assigning a variable to randomize a number
                    int num = r_num.Next(1, 1001);
                    //if there is not a number inside, put one inside
                    if (!myArray.Contains(num))
                    {
                        //assigning every index number to the variable
                        myArray[i] = num;
                    }
                    //break the while loop
                    break;
                }
                //output defualt
                txtNumGenOut_twn.Text = (string.Join(", ", myArray));
            }
        }
        //====================================================\\
        //==================(my generate [show] button)==================\\
        //generate code called from my method
        private void btnGenerate_twn_Click(object sender, RoutedEventArgs e)
        {
            //calling my method
            myArraymethod();
        }
        //====================================================\\
        //==================(my bubble sort)==================\\      
        private void btnBubbleSort_Click(object sender, RoutedEventArgs e)
        {
            //assigning temp to zero
            int temp = 0;
            //creating a outer loop
            for (int write = 0; write < myArray.Length; write++)
            {
                //creating my innerloop
                for (int sortme = 0; sortme < myArray.Length - 1; sortme++)
                {
                    //if it is bigger - swap
                    if (myArray[sortme] > myArray[sortme + 1])
                    {
                        //swapping using a temp
                        temp = myArray[sortme + 1];
                        myArray[sortme + 1] = myArray[sortme];
                        myArray[sortme] = temp;
                    }
                }
                //output the sort
                txtNumGenOut_twn.Text = (string.Join(", ", myArray));
            }
        }
        //====================================================\\
    }
}

