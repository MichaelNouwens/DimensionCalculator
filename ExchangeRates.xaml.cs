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
    //Exchange Rate Page
    //====================================================\\

    public sealed partial class ExchangeRates : Page
    {
        public ExchangeRates()
        {
            this.InitializeComponent();
        }
        //====================================================\\
        //==================(Navigation)==================\\  
        private void btnBack_exc_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage)); //goes back to main page
        }

        //This is index for combo box
        //0 - south africa      
        //1 - AUD Dollar
        //2 - US Dollar
        //3 - British Pound

        //====================================================\\
        //==================(Global Variables)==================\\  
        public static double inputAmount = 0.00;
        public static double OtherRate = 0.00;

        //====================================================\\
        //==================(Methods)==================\\  
        //Other - your own currency that you made up
        private void Other()
        {
            OtherRate = Convert.ToDouble(txtOther_Ex.Text);
            CExchange exchange = new CExchange(inputAmount, OtherRate);
            txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, OtherRate).ToString("#.###");
        }
        //Same - if it is the same currency (throws a specific error)
        private void Same()
        {
            if (comboBox_Con_from.SelectedIndex == 0 && comboBox_Con_To.SelectedIndex == 0)   //if both SA 
            {
                txtOutput_Ex.Text = "They are of the same currency (both ZAR Currency)"; //throw an error 

            }
            if (comboBox_Con_from.SelectedIndex == 1 && comboBox_Con_To.SelectedIndex == 1) //if both AUD
            {
                txtOutput_Ex.Text = "They are of the same currency (both AUD Currency)"; //throw an error 
            }
            if (comboBox_Con_from.SelectedIndex == 2 && comboBox_Con_To.SelectedIndex == 2) //if both US
            {
                txtOutput_Ex.Text = "They are of the same currency (both US Currency)"; //throw an error 
            }
            if (comboBox_Con_from.SelectedIndex == 3 && comboBox_Con_To.SelectedIndex == 3) //if both bri
            {
                txtOutput_Ex.Text = "They are of the same currency (both GBP Currency)"; //throw an error 
            }
        }

        //Australian Dollar to other exchange rates
        private void AUD()
        {
            //my local variables for AUD (unique)
            double sa = 10.3006;
            double us = 0.755711;
            double bri = 0.606857;

            //if AUD to ZA is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 1 && comboBox_Con_To.SelectedIndex == 0) //AUD -> SA
            {
                CExchange exchange = new CExchange(inputAmount, sa); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, sa).ToString("#.###"); //outputing the calculation in text box
            }
            //if AUD to US is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 1 && comboBox_Con_To.SelectedIndex == 2) //AUD -> US
            {
                CExchange exchange = new CExchange(inputAmount, us); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, us).ToString("#.###"); //outputing the calculation in text box
            }
            //if AUD to BRI is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 1 && comboBox_Con_To.SelectedIndex == 3) ///AUD -> bri
            {
                CExchange exchange = new CExchange(inputAmount, bri); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, bri).ToString("#.###"); //outputing the calculation in text box
            }
        }
        private void US()
        {
            //my local variables for US (unique)
            double aud = 1.32366;
            double sa = 13.6071;
            double bri = 0.803300;

            //if US to SA is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 2 && comboBox_Con_To.SelectedIndex == 0) //US -> SA
            {
                CExchange exchange = new CExchange(inputAmount, sa); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, sa).ToString("#.###"); //outputing the calculation in text box
            }
            //if US to AUD is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 2 && comboBox_Con_To.SelectedIndex == 1) //US -> AUD
            {
                CExchange exchange = new CExchange(inputAmount, aud); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, aud).ToString("#.###"); //outputing the calculation in text box
            }
            //if US to BRI is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 2 && comboBox_Con_To.SelectedIndex == 3) ///US -> bri
            {
                CExchange exchange = new CExchange(inputAmount, bri); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, bri).ToString("#.###"); //outputing the calculation in text box
            }
        }

        private void British()
        {
            //my local variables for BRI (unique)
            double aud = 1.64777;
            double sa = 16.9388;
            double us = 1.24493;

            //if BRI to SA is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 3 && comboBox_Con_To.SelectedIndex == 0) //bri -> SA
            {
                CExchange exchange = new CExchange(inputAmount, sa); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, sa).ToString("#.###"); //outputing the calculation in text box
            }
            //if BRI to AUD is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 3 && comboBox_Con_To.SelectedIndex == 1) //bri - >AUD
            {
                CExchange exchange = new CExchange(inputAmount, aud); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, aud).ToString("#.###"); //outputing the calculation in text box
            }
            //if BRI to US is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 3 && comboBox_Con_To.SelectedIndex == 2) ///bri - >US
            {
                CExchange exchange = new CExchange(inputAmount, us); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, us).ToString("#.###"); //outputing the calculation in text box
            }
        }
        private void SouthAfrica()
        {
            //my local variables for SA (unique)
            double aud = 0.0971424;
            double us = 0.0733933;
            double bri = 0.0589208;

            //if SA to AUD is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 0 && comboBox_Con_To.SelectedIndex == 1) //if  SA -> both AUD
            { 
                CExchange exchange = new CExchange(inputAmount, aud); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, aud).ToString("#.###"); //outputing the calculation in text box
            }
            //if SA to US is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 0 && comboBox_Con_To.SelectedIndex == 2) //if  SA -> US
            {
                CExchange exchange = new CExchange(inputAmount, us); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, us).ToString("#.###"); //outputing the calculation in text box
            }
            //if SA to BRI is selected - do these specific tasks
            if (comboBox_Con_from.SelectedIndex == 0 && comboBox_Con_To.SelectedIndex == 3) //if SA -> bri
            {
                CExchange exchange = new CExchange(inputAmount, bri); //instance of the CExchange class (passing two arguments)
                txtOutput_Ex.Text = exchange.CurrTimes(inputAmount, bri).ToString("#.###"); //outputing the calculation in text box
            }
        }

        //====================================================\\
        //==================(Convert button)==================\\  
        private void btnConvert_Ex_Click(object sender, RoutedEventArgs e)
        {
            //this section of code might throw an error
            try
            {
                //input the amount (user)
                inputAmount = Convert.ToDouble(txtAmount_Ex.Text);

                //if the text box of the other box is empty
                if(String.IsNullOrEmpty(txtOther_Ex.Text))
                {
                    //using current exchange rates.
                    //calling all of the methods (it goes through all of them to see if the arguments are true or false.
                    AUD();
                    US();
                    SouthAfrica();
                    British();
                    Same();
                }
                else // if it isn't empty the program knows you are putting in your own exchange rate
                {
                    Other();
                }

            }
            //the error is thrown and the exception is met
            catch (Exception c)
            {
                txtOutput_Ex.Text = c.Message; //outputs the message of the exception
            }
        }
        //====================================================\\
        //==================(My reset button)==================\\
        private void btnClear_Ex_Click(object sender, RoutedEventArgs e)
        {
            //clearing all the text boxes and making the combo box blank
            txtAmount_Ex.Text = "";
            txtOther_Ex.Text = "";
            txtOutput_Ex.Text = "";
            comboBox_Con_from.SelectedIndex = -1;
            comboBox_Con_To.SelectedItem = -1;
        }

        //====================================================\\
        //==================(My Current button)==================\\ - to prepare the interface for using current exchange rate conversion
        private void btnCurrent_Click(object sender, RoutedEventArgs e)
        {
            txtAmount_Ex.Text = ""; //amount clear - there is text already in it (to tell the user what to do)
            comboBox_Con_from.Visibility = Visibility.Visible; //make the two combo boxes visible to the user so you can use the current exchange rates.
            comboBox_Con_To.Visibility = Visibility.Visible;
            txtOther_Ex.IsReadOnly = true; //You must which button (what calculation you want to perform before these become accessable to user)
            txtAmount_Ex.IsReadOnly = false;
        }

        //====================================================\\
        //==================(My Other button)==================\\ - prepares the user interface for other conversion 

        private void btnOther_Click(object sender, RoutedEventArgs e)
        {
            txtAmount_Ex.Text = ""; //amount clear - there is text already in it (to tell the user what to do)
            txtAmount_Ex.IsReadOnly = false; 
            txtOther_Ex.IsReadOnly = false; //You must which button (what calculation you want to perform before these become accessable to user)
            comboBox_Con_from.Visibility = Visibility.Collapsed; //makes the combo box not visible (collapses them)
            comboBox_Con_To.Visibility = Visibility.Collapsed;
        }
        //====================================================\\

        //when the grid is loaded this set of code is executed
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtAmount_Ex.Text = "please choose 'other' or 'Current'"; //informs the user what they need to do because nothing works without
            txtAmount_Ex.IsReadOnly = true;                                                         //following orders
            comboBox_Con_from.Visibility = Visibility.Collapsed;
            comboBox_Con_To.Visibility = Visibility.Collapsed;
            txtOther_Ex.IsReadOnly = true;
        }
    }
}
