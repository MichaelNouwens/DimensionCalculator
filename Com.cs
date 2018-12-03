using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//====================================================\\
//COMPOUND INTEREST (Com)
//====================================================\\
namespace DimensionCalculator
{
    class Com
    {
        //====================================================\\
        //==================(fields)==================\\   

        //A
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        //P
        private double p;

        public double P
        {
            get { return p; }
            set { p = value; }
        }

        //I
        private double i;

        public double I
        {
            get { return i; }
            set { i = value; }
        }

        //N
        private double n;

        public double N
        {
            get { return n; }
            set { n = value; }
        }
        //====================================================\\
        //==================(Constructors)==================\\   
        
        public Com()
        {

        }

        public Com(double a_num, double p_num, double i_num, double n_num)
        {
            a_num = A;
            p_num = P;
            i_num = I;
            n_num = N;
        }
        //====================================================\\
        //==================(methods)==================\\  
        
        //calculating A
        public double calc_A(double a_num, double p_num, double i_num, double n_num)
        {
            A = a_num;
            P = p_num;
            I = i_num;
            N = n_num;

            double var1 = Math.Pow((1 + i_num), n_num);
            double var2 = var1 * p_num;
            a_num = var2;
            return a_num;

        }

        //calculating P
        public double calc_P(double a_num, double p_num, double i_num, double n_num)
        {
            A = a_num;
            P = p_num;
            I = i_num;
            N = n_num;

         
            double value = (1 + i_num);
            double power = n_num;
            double temp = Math.Pow(value, power);
            p_num = (a_num / temp);
            return p_num;
        }

        //calculating I
        public double calc_i(double a_num, double p_num, double i_num, double n_num)
        {
            A = a_num;
            P = p_num;
            I = i_num;
            N = n_num;

            double num = a_num / p_num;
            i_num = (Math.Ceiling(Math.Pow(num, (double)1 / n_num) ));
            return i_num;
        }

        //Calculating N
        public double calc_n(double a_num, double p_num, double i_num, double n_num)
        {
            A = a_num;
            P = p_num;
            I = i_num;
            N = n_num;

            n_num = ((Math.Log(a_num / p_num)) / ((Math.Log(1 + i_num))));
            return n_num;
        }
        //====================================================\\
    }
}
