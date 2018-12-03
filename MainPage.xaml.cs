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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DimensionCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //creates my operator list
        public enum Operator
        {
            //my list of operators stored in an enumuration.
            None,   //nothing is inputed 
            Add,   //add operator is activated
            Minus, //Minus operator is activated
            Divide, //Divide operator is activated
            Multiply //Multiply operator is activated
        }

        //My global variables
        private double total = 0; //my total at the end of my cycle
        private double currValue = 0; //the value I punch in
        private Operator currOperator; //the operator I select

        //my main page
        public MainPage()
        {
            //Initializes my main page
            this.InitializeComponent();
        }
        //====================================================\\
        //==================(My equals button)==================\\ - it will output once you click equals
        //My "=" (equals) button
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            //added a try/catch statement to prevent any mishaps from accuring.
            try
            {
                Calculate(); //calling my calculate method.
                txtFinalOutput.Text = Convert.ToString(total); //outputting the total in the output textbox.
                txtMessageErr.Text += "="; //shows what the user has typed in above the output textbox.
            }
            catch (Exception c) //catches any exception/error that the code above may throw.
            {
                txtMessageErr.Text = c.Message; //outputs the given message for the user to read.
            }
        }
        //====================================================\\
        //==================(My operator buttons)==================\\
        //My Divide "/" (div) button
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            //get my operator from the enum and apply it and then calculate it. (Divide)
            applyMyOpr(Operator.Divide);
            txtMessageErr.Text += "/"; //shows what the user has typed. (/)
        }
        //add
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //get my operator from the enum and apply it and then calculate it. (Add)
            applyMyOpr(Operator.Add);
            txtMessageErr.Text += "+";//shows what the user has typed. (+)
        }
        //Mulitply
        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            //get my operator from the enum and apply it and then calculate it. (multiply)
            applyMyOpr(Operator.Multiply);
            txtMessageErr.Text += "x";//shows what the user has typed. (*)
        }
        //subtract/minus
        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            //get my operator from the enum and apply it and then calculate it. (minus/subtract)
            applyMyOpr(Operator.Minus);
            txtMessageErr.Text += "-";//shows what the user has typed. (-)
        }
        //====================================================\\
        //==================(My digit buttons)==================\\
        //button 1
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string b1 = "1"; //giving a local variable (b1 - buttons 1) equals to 1.
            showMyInput(b1); //giving my method the digit which I have clicked (1)
        }
        //button 2
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string b2 = "2";//giving a local variable (b2 - buttons 2) equals to 2.
            showMyInput(b2);//giving my method the digit which I have clicked (2)
        }
        //button 3
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string b3 = "3";//giving a local variable (b3 - buttons 3) equals to 3.
            showMyInput(b3);//giving my method the digit which I have clicked (3)
        }
        //button 4
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string b4 = "4";//giving a local variable (b4 - button 4) equals to 4.
            showMyInput(b4);//giving my method the digit which I have clicked (4)
        }
        //button 5
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            string b5 = "5";//giving a local variable (b5 - button 5) equals to 5.
            showMyInput(b5);//giving my method the digit which I have clicked (5)
        }
        //button 6
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            string b6 = "6";//giving a local variable (b6 - button 6) equals to 6.
            showMyInput(b6);//giving my method the digit which I have clicked (6)
        }
        //button 7
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            string b7 = "7";//giving a local variable (b7 - button 7) equals to 7.
            showMyInput(b7);//giving my method the digit which I have clicked (7)
        }
        //button 8
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            string b8 = "8"; //giving a local variable (b8 - button 8) equals to 8.
            showMyInput(b8);//giving my method the digit which I have clicked (8)
        }
        //button 9
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            string b9 = "9";//giving a local variable (b9 - button 9) equals to 9.
            showMyInput(b9);//giving my method the digit which I have clicked (9)
        }
        //button 0 (zero)
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            string b0 = "0";//giving a local variable (b0 - button 0) equals to 0.
            showMyInput(b0);//giving my method the digit which I have clicked (0)
        }
        //button . (dot)
        private void btndot_Click(object sender, RoutedEventArgs e)
        {
            string dot = ".";//giving a local variable (bdot - button dot) equals to [.].
            showMyInput(dot);//giving my method the digit which I have clicked (.)

        }
        //====================================================\\
        //==================(My Methods)==================\\
        private void Calculate()
        {
            //if the operator selected is (Add [+]) then perform this task
            if (currOperator == Operator.Add)
            {
                // adds whatever the value of currValue is with the total.
                total += currValue;

            }
            //else if the operator selected is (minus/subtract [-]) it must perform this specific task:
            else if (currOperator == Operator.Minus)
            {
                // subtracts whatever the value of currValue is with the total.
                total -= currValue;
            }
            //else if the operator selected is (divide [/]) it must perform this specific task:
            else if (currOperator == Operator.Divide)
            {
                //if the current value entered is equal to 0 it should execute this code:
                if (currValue == 0)
                {
                    //clear the error text box 
                    txtMessageErr.Text = "";
                    total = 0; //make sure total is equal to zero
                    txtMessageErr.Text = "Cannot divide by zero"; //show the error message to the user.
                }
                else
                {
                    // divides whatever the value of currValue is with the total.
                    total /= currValue;
                }

            }
            //else if the operator selected is (multiply [*]) it must perform this specific task:
            else if (currOperator == Operator.Multiply)
            {
                total *= currValue;
            }
            //if nothing is pressed that means the operator is nothing 
            else
            {
                currOperator = Operator.None;
            }

            currValue = 0; //make sure the currert value is zero (going to output the value soon)
            currOperator = Operator.None; //same with the operator
        }

        //applying my operator that i have clicked to the calculation (if there is no more operators, it should activate my calculate method)
        private void applyMyOpr(Operator op)
        {
            //try run this section code - to prevent any mishaps from accuring.
            try
            {
                //if there is no more operators inputted, calculate.
                if (currOperator != Operator.None)
                {
                    Calculate();
                }
                else
                {
                    //else add more to the already running variable (total)
                    total = double.Parse(txtFinalOutput.Text);
                }
                txtFinalOutput.Text = ""; //clear the final output box for new input to be shown
                currOperator = op; //new variabe is equal to the current operator

            }
            //catches any exceptions that may be thrown from the above code.
            catch (Exception)
            {
                //output that message so the user may read it and be informed about the logic error they have made.
                txtMessageErr.Text = "You cannot use an operator without any digits";
            }
        }

        //passes the digit to my global variable "currValue".
        //shows the input being entered.
        private void showMyInput(String a)
        {
            //
            try
            {
                //keep on adding more digits to the final output text box
                txtFinalOutput.Text = txtFinalOutput.Text + a;
                //whatever digit is inputed inside the textbox is the current value
                currValue = double.Parse(txtFinalOutput.Text);
                //keep on adding more digits to the error output text box
                txtMessageErr.Text = txtMessageErr.Text + a;
            }
            //added a try/catch statement to prevent any mishaps from accuring.
            catch (Exception)
            {
                txtMessageErr.Text = "Something went wrong"; //output message
            }
        }
        //====================================================\\
        //==================(My clear button)==================\\
        private void btnAC_CE_Click(object sender, RoutedEventArgs e)
        {
            currOperator = Operator.None; //makes sure the operator is selected at none, because you are not doing anything with it yet.
            txtFinalOutput.Text = ""; //clears the text box - makes sure the output has nothing inside.
            total = 0; //makes sure the total is zero (makes sure it is equal to zero so that it may not interfere wit any more future calculations).
            txtMessageErr.Text = ""; //error message box clear so it doesn't confuse the user.

        }
        //====================================================\\
        //==================(My Navigation buttons)==================\\
        private void btnSimpleInterest_Click(object sender, RoutedEventArgs e)
        {
            //Navigates to the simple interest page with many buttons linking you to specific calculation pages.
            this.Frame.Navigate(typeof(SimInterest));
        }

        private void btnCompoundInterest_Click(object sender, RoutedEventArgs e)
        {
            //Navigates to the compound interest page with many buttons linking you to specific calculation pages.
            this.Frame.Navigate(typeof(CompoundInterest));
        }

        private void btnExchange_Rates_Click(object sender, RoutedEventArgs e)
        {
            //Navigates to the exchange rate page where you are able to input your own exchange rate or use a current one.
            this.Frame.Navigate(typeof(ExchangeRates));
        }

        private void btnAdd20nums_Click(object sender, RoutedEventArgs e)
        {
            //Navigates to the 20 numbers page where you may generate any set of 20 numbers and sort it using a common bubble sort method.
            this.Frame.Navigate(typeof(numtwenty));
        }

        private void btnAdd40nums_Click(object sender, RoutedEventArgs e)
        {
            ////Navigates to the 40 numbers page where you may generate any set of 40 numbers and sort it using a quick sort method. 
            this.Frame.Navigate(typeof(numforty));
        }


    }
    //====================================================\\
}
