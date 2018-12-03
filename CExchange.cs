using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionCalculator
{
    //====================================================\\
    //EXCHANGE RATE (CExchange)
    //====================================================\\
    class CExchange
    {
        //====================================================\\
        //==================(fields)==================\\  

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }


        private double curr;

        public double Curr
        {
            get { return curr; }
            set { curr = value; }
        }

        //====================================================\\
        //==================(constructors)==================\\  

        public CExchange()
        {

        }

        public CExchange(double a, double curr)
        {
            a = Amount;
            curr = Curr;
        }
        //====================================================\\
        //==================(Methods)==================\\  
        public double CurrTimes(double a, double curr)
        {
            Amount = a;
            Curr = curr;
            return a * curr;
        }
        //====================================================\\
    }
}
