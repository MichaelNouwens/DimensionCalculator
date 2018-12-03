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
    //COMPOUND INTEREST - CALCULATING N (PAGE)
    //====================================================\\
    public sealed partial class CompoundInterest_N : Page
    {
        //====================================================\\
        //==================(My global variables)==================\\
        double a;
        double p;
        double i;
        double n=0;
        //====================================================\\
        public CompoundInterest_N()
        {
            this.InitializeComponent();
        }
        //====================================================\\
        //==================(Navigation)==================\\
        //back button
        private void btnBackCI_n_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CompoundInterest));
        }
        //====================================================\\
        //==================(My calculation button)==================\\ - once it is clicked it shows the value
        private void btnCal_ci_N_Click(object sender, RoutedEventArgs e)
        {
            //this section of code might throw an error
            try
            {
                //assigning the local variables to the text that the user provides
                p = Convert.ToDouble(txtP_ci_N.Text);
                a = Convert.ToDouble(txtA_ci_N.Text);
                i = Convert.ToDouble(txtI_ci_N.Text);

                //This is the index for my combo box
                //anually - 0
                //semi-anually - 1 
                //monthly - 2
                //quarterly - 3


                //====================================================\\
                //==================(nested if statements)==================\\
                //if it is anually it should change the calculation by changing the i value over 100
                if (comboBox_compoundint_N.SelectedIndex == 0)
                {
                    i = i / 100; //making i over 100
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_N.Text = Convert.ToString(outPut.calc_n(a, p, i, n) / 1).ToString();  //output the result to the textbox

                }
                //if it is semi-anually it should change the calculation by changing the i value over 200.
                //making half a year.
                else if (comboBox_compoundint_N.SelectedIndex == 1)
                {
                   // n = n * 2;
                    i = i / 200; //making i over 200
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_N.Text = Convert.ToString(outPut.calc_n(a, p, i, n) /2).ToString();  //output the result to the textbox
                }
                //if it is monthly it should change the calculation by changing the i value over 1200.
                //Making it monthly.
                else if (comboBox_compoundint_N.SelectedIndex == 2)
                {
                    i = i / 1200; //making i over 1200
                    //n = n * 12;
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_N.Text = Convert.ToString(outPut.calc_n(a, p, i, n) / 12).ToString();  //output the result to the textbox
                }
                //if it is quarterly it should change the calculation by changing the i value over 400.
                //making it quarterly.
                else if (comboBox_compoundint_N.SelectedIndex == 3)
                {
                    i = i / 400; //making i over 400
                    //n = n * 4;
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_N.Text = Convert.ToString(outPut.calc_n(a, p, i, n) / 4).ToString();  //output the result to the textbox
                }
                else //if the combo box is not selected at all - it should stay anually (so defualt it is anually)
                {
                    i = i / 100; //making i over 100
                    Com outPut = new Com(a, p, i, n); //instance of the class (Com)
                    txtOutput_ci_N.Text = Convert.ToString(outPut.calc_n(a, p, i, n) / 1).ToString();  //output the result to the textbox
                }
                //====================================================\\
            }
            //the error is thrown and the exception is met
            catch (Exception c)
            {
                txtOutput_ci_N.Text = c.Message; //outputs the message of the exception
            }
        }
        //====================================================\\
        //==================(My reset button)==================\\
        private void btnReset_ci_N_Click(object sender, RoutedEventArgs e)
        {
            //clearing all the text boxes and making the combo box blank
            txtA_ci_N.Text = "";
            txtI_ci_N.Text = "";
            txtP_ci_N.Text = "";
            txtOutput_ci_N.Text = "";
            comboBox_compoundint_N.SelectedIndex = -1;
        }
        //====================================================\\
    }
}

