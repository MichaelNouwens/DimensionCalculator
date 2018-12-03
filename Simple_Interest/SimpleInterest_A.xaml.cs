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
    //SIMPLE INTEREST - CALCULATING A (PAGE)
    //====================================================\\

    public sealed partial class SimpleInterest_A : Page
    {
        //====================================================\\
        //==================(My global variables)==================\\
        double a = 0;
        double p;
        double i;
        double n;
        //====================================================\\
        public SimpleInterest_A()
        {
            this.InitializeComponent();
        }

        //====================================================\\
        //==================(My calculation button)==================\\ - once it is clicked it shows the value
        private void btnCalc_si_A_Click(object sender, RoutedEventArgs e)
        {
            //this section of code might throw an error
            try
            {
                //assigning the local variables to the text that the user provides
                p = Convert.ToDouble(txtP_si_A.Text);
                i = Convert.ToDouble(txtR_si_A.Text);
                n = Convert.ToDouble(txtN_si_A.Text);

                //This is the index for my combo box
                //anually - 0
                //semi-anually - 1 
                //monthly - 2
                //quarterly - 3


                //====================================================\\
                //==================(nested if statements)==================\\
                //if it is anually it should change the calculation by changing the i value over 100
                if (comboBox_simpleinterest_A.SelectedIndex == 0)
                {
                    i = i / 100; //making i over 100
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_A.Text = Convert.ToString(outPut.calc_A(a, p, i, n)).ToString();//output value 

                }
                //if it is semi-anually it should change the calculation by changing the i value over 200 and times the number of years by 2 
                //making half a year.
                else if (comboBox_simpleinterest_A.SelectedIndex == 1)
                {
                    n = n * 2; //multiplying n by 2
                    i = i / 200; //making i over 200
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_A.Text = Convert.ToString(outPut.calc_A(a, p, i, n)).ToString(); //output the result to the textbox
                }
                ////if it is monthly it should change the calculation by changing the i value over 1200 and times the number of years by 12
                //making it monthly
                else if (comboBox_simpleinterest_A.SelectedIndex == 2)
                {
                    i = i / 1200; //making i over 1200
                    n = n * 12;  //multiplying n by 12
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_A.Text = Convert.ToString(outPut.calc_A(a, p, i, n)).ToString(); //output the result to the textbox
                }
                //if it is quarterly it should change the calculation by changing the i value over 400 and times the number of years by 4
                //making it quarterly
                else if (comboBox_simpleinterest_A.SelectedIndex == 3)
                {
                    i = i / 400; //making i over 400
                    n = n * 4;  //multiplying n by 4
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_A.Text = Convert.ToString(outPut.calc_A(a, p, i, n)).ToString(); //output the result to the textbox
                }
                else //if the combo box is not selected at all - it should stay anually (so defualt it is anually)
                {
                    i = i / 100; //making i over 100
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_A.Text = Convert.ToString(outPut.calc_A(a, p, i, n)).ToString(); //output the result to the textbox
                }
                //====================================================\\

            }
            //the error is thrown and the exception is met
            catch (Exception c)
            {
                txtOutput_si_A.Text = c.Message; //outputs the message of the exception
            }
        }
        //====================================================\\
        //==================(My reset button)==================\\
        private void btnReset_si_A_Click(object sender, RoutedEventArgs e)
        {
            //clearing all the text boxes and making the combo box blank
            txtP_si_A.Text = "";
            txtN_si_A.Text = "";
            txtR_si_A.Text = "";
            comboBox_simpleinterest_A.SelectedIndex = -1;
            txtOutput_si_A.Text = "";

        }
        //====================================================\\
        //==================(Navigation)==================\\
        private void btnBackSI_a1_Click(object sender, RoutedEventArgs e)
        {
            //navigation back to the main simple interest page
            this.Frame.Navigate(typeof(SimInterest));
        }
        //====================================================\\
    }
}
