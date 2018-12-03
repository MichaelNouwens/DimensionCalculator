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

namespace DimensionCalculator.Compound_Interest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    //====================================================\\
    //COMPOUND INTEREST - CALCULATING R (PAGE)
    //====================================================\\
    public sealed partial class CompoundInterest_R : Page
    {
        //====================================================\\
        //==================(My global variables)==================\\
        double a;
        double p;
        double i=0;
        double n;
        //====================================================\\
        public CompoundInterest_R()
        {
            this.InitializeComponent();
        }
        //====================================================\\
        //==================(My calculation button)==================\\ - once it is clicked it shows the value
        private void btnCal_ci_i_Click(object sender, RoutedEventArgs e)
        {
            //this section of code might throw an error
            try
            {
                //assigning the local variables to the text that the user provides
                p = Convert.ToDouble(txtP_ci_i.Text);
                a = Convert.ToDouble(txtA_ci_i.Text);
                n = Convert.ToDouble(txtN_ci_i.Text);

                //This is the index for my combo box
                //anually - 0
                //semi-anually - 1 
                //monthly - 2
                //quarterly - 3


                //====================================================\\
                //==================(nested if statements)==================\\
                //if it is anually it should change the calculation by multiplying the number of years by 1 
                if (comboBox_compoundint_i.SelectedIndex == 0)
                {
                    n = n * 1; //multiplying n by 1
                    Com outPut = new Com(a, p, i, n);
                    txtOutput_ci_i.Text = Convert.ToString(outPut.calc_i(a, p, i, n)).ToString(); //output the result to the textbox

                }
                //if it is semi-anually it should change the calculation by multiplying the number of years by 2 
                //making half a year.
                else if (comboBox_compoundint_i.SelectedIndex == 1)
                {
                    n = n * 2; //multiplying n by 2
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_i.Text = Convert.ToString(outPut.calc_i(a, p, i, n)).ToString(); //output the result to the textbox
                }
                //if it is monthly it should change the calculation by multiplying the number of years by 12 
                else if (comboBox_compoundint_i.SelectedIndex == 2)
                {
                    n = n * 12; //multiplying n by 12
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_i.Text = Convert.ToString(outPut.calc_i(a, p, i, n)).ToString(); //output the result to the textbox
                }
                //if it is quarterly it should change the calculation by multiplying the number of years by 4
                else if (comboBox_compoundint_i.SelectedIndex == 3)
                {
                    n = n * 4;//multiplying n by 4
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_i.Text = Convert.ToString(outPut.calc_i(a, p, i, n)).ToString(); //output the result to the textbox
                }
                else //if the combo box is not selected at all - it should stay anually (so defualt it is anually)
                {             
                    n = n * 1; //multiplying n by 1
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_i.Text = Convert.ToString(outPut.calc_A(a, p, i, n)).ToString(); //output the result to the textbox
                }
                //====================================================\\
            }
            //the error is thrown and the exception is met
            catch (Exception c)
            {
                txtOutput_ci_i.Text = c.Message; //outputs the message of the exception
            }
        }


        //====================================================\\
        //==================(Navigation)==================\\
        private void btnBackCI_r2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CompoundInterest));  //back button
        }
        //====================================================\\
        //==================(My reset button)==================\\
        private void btnReset_ci_R_Click(object sender, RoutedEventArgs e)
        {
            //clearing all the text boxes and making the combo box blank
            txtA_ci_i.Text = "";
            txtN_ci_i.Text = "";
            txtOutput_ci_i.Text = "";
            txtP_ci_i.Text = "";
            comboBox_compoundint_i.SelectedIndex = -1;
        }
        //====================================================\\
    }
}
