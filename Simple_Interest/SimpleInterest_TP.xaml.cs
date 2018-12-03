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
    //SIMPLE INTEREST - CALCULATING N (PAGE)
    //====================================================\\
    public sealed partial class SimpleInterest_TP : Page
    {
        //====================================================\\
        //==================(My global variables)==================\\
        double n =0;
        double a;
        double p;
        double i;
        //====================================================\\
        public SimpleInterest_TP()
        {
            this.InitializeComponent();
        }
        //====================================================\\
        //==================(Navigation)==================\\
        private void btnBackSI_tp_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SimInterest));
        }

        //====================================================\\
        //==================(My calculation button)==================\\ - once it is clicked it shows the value
        private void btnCalc_si_N_Click(object sender, RoutedEventArgs e)
        {
            //this section of code might throw an error
            try
            {
                //assigning the local variables to the text that the user provides
                a = Convert.ToDouble(txtA_si_N.Text);
                p = Convert.ToDouble(txtP_si_N.Text);
                i = Convert.ToDouble(txtR_si_N.Text);


                //This is the index for my combo box
                //anually - 0
                //semi-anually - 1 
                //monthly - 2
                //quarterly - 3


                //====================================================\\
                //==================(nested if statements)==================\\
                //if it is anually it should change the calculation by changing the i value over 100
                if (comboBox_simpleinterest_N.SelectedIndex == 0)
                {
                    i = i / 100; //making i over 100
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString();

                }
                else if (comboBox_simpleinterest_N.SelectedIndex == 1)
                {
                    //// n = n * 2; //multiplying n by 2
                    // i = i / 200; //making i over 200
                    // CInterest outPut = new CInterest(a, p, i, n);  //instance of the class (CInterest)
                    // txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString(); //output value 

                    i = i / 100; //making i over 100
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString();
                }
                else if (comboBox_simpleinterest_N.SelectedIndex == 2)
                {
                    //    i = i / 1200; //making i over 1200
                    ////    n = n * 12; //multiplying n by 12
                    //    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    //    txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString(); //output value 

                    i = i / 100; //making i over 100
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString();
                }
                else if (comboBox_simpleinterest_N.SelectedIndex == 3)
                {
                    // i = i / 400; //making i over 400
                    //// n = n * 4; //multiplying n by 4
                    // CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    // txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString(); //output value 

                    i = i / 100; //making i over 100
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString();
                }
                else //if the combo box is not selected at all - it should stay anually (so defualt it is anually)
                {
                    i = i / 100; //making i over 100
                    CInterest outPut = new CInterest(a, p, i, n); //instance of the class (CInterest)
                    txtOutput_si_N.Text = Convert.ToString(outPut.calc_N(a, p, i, n)).ToString(); //output value 
                }
                //====================================================\\
            }
            //the error is thrown and the exception is met
            catch (Exception c) 
            {
                txtOutput_si_N.Text = c.Message;//outputs the message of the exception
            }
        }
        //====================================================\\
        //==================(My reset button)==================\\
        private void btnReset_si_N_Click(object sender, RoutedEventArgs e)
        {
            //clearing all the text boxes and making the combo box blank
            txtA_si_N.Text = "";
            txtOutput_si_N.Text = "";
            txtP_si_N.Text = "";
            txtR_si_N.Text = "";
            comboBox_simpleinterest_N.SelectedIndex = -1;

        }
        //====================================================\\
    }
}
