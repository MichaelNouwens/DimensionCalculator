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
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
     //====================================================\\
    //40 random numbers + quick sort
    //====================================================\\
    public sealed partial class numforty : Page
    {
        //creating my global array (variable) -  (so I can use the array more than once)
        public static int[] myArray = new int[40];


        public numforty()
        {
            this.InitializeComponent();
        }
        //====================================================\\
        //==================(navigation)==================\\
        //navigation - back to home page
        private void btnBackCI_a_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        //====================================================\\
        //==================(method)==================\\
        //creating my method
        private void myArraymethod()
        {
            //instance of random function - name it r_num (random number)
            Random r_num = new Random();
            int randomNumber = r_num.Next(0, 1001);

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
                txtNumGenOut_frt.Text = (string.Join(", ", myArray));
            }

        }
        //====================================================\\
        //==================(my generate [show] button)==================\\
        //calling my method to ouput
        private void btnGenerate_frt_Click(object sender, RoutedEventArgs e)
        {
            //calling my method 
            myArraymethod();
        }
      
        //====================================================\\
        //==================(my quick sort method)==================\\     
        public static void Quicksort(int[] elements, int left, int right)
        {
       //assigning variables
            int a = left, b = right;
            //splitting 
            int pivot = elements[(left + right) / 2];

            //compares left and right
            while (a <= b)
            {
                //compares elements on left side of the pivot
                //moves to the right depending on size
                while (elements[a].CompareTo(pivot) < 0)
                {

                    a++; //increments - (starts at zero) as the number becomes higher - left
                }
                //compares elements on right side of the pivot
                //moves to the left depending on size
                while (elements[b].CompareTo(pivot) > 0)
                { 
                    
                   b--; //decrements -(starts at highest value) as the number becomes lower - right
                }

                
                if (a <= b)
                {
                    // Swap
                    int tmp = elements[a]; //assign temp
                    elements[a] = elements[b]; //swap from j - i
                    elements[b] = tmp; //swaps to temp

                    a++; //increments - (starts at zero) as the number becomes higher - left
                    b--; //decrements - (starts at highest value) as the number becomes lower - right
                }
            }

            // Recursive calls - recycling 

            if (left < b)
            {
                Quicksort(elements, left, b);
            }

            if (a < right)
            {
                Quicksort(elements, a, right);
            }
        }

        //====================================================\\
        //==================(my quick sort button (sort))==================\\ 

        private void btnQuickSort_Click(object sender, RoutedEventArgs e)
        {
            // Sort the array
            Quicksort(myArray, 0, myArray.Length - 1);

            // Print the sorted array
            for (int i = 0; i < myArray.Length; i++)
            {          
                txtNumGenOut_frt.Text = (string.Join(", ", myArray));
            }

        }
        //====================================================\\
    }
}
