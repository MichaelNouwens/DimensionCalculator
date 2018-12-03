using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//====================================================\\
//SIMPLE INTEREST (CInterest)
//====================================================\\

namespace DimensionCalculator
{
    //simple interest
    class CInterest
    {

        //public double Interest;
        /// <summary>
        //====================================================\\
        //==================(fields)==================\\     
        //A
        private double a;
        //private double ew = Math.Log(34);
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        //public double EndAmount { get; set; }
        //A = P(1 + rt)

        private double p;

        public double P
        {
            get { return p; }
            set { p = value; }
        }

        //rate
        private double i;

        public double I
        {
            get { return i; }
            set { i = value; }
        }
        //period - time
        private double n;

        public double N
        {
            get { return n; }
            set { n = value; }
        }
        //====================================================\\
        //==================(constructors)==================\\       
        public CInterest()
        {

        }

        public CInterest(double a_num, double p_num, double i_num, double n_num)
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

            a_num = (p_num * (1 + i_num * n_num));
            return a_num;
        }
        //calculating P
        public double calc_P(double a_num, double p_num, double i_num, double n_num)
        {
            A = a_num;
            P = p_num;
            I = i_num;
            N = n_num;

            p_num = (a_num / (1 + (i_num * n_num)));
            return p_num;
        }
        //calculating I
        public double calc_I(double a_num, double p_num, double i_num, double n_num)
        {
            A = a_num;
            P = p_num;
            I = i_num;
            N = n_num;

            i_num = ((a_num / p_num) - 1) / (n_num);
            return i_num;
        }
        //calculating N
        public double calc_N(double a_num, double p_num, double i_num, double n_num)
        {
            n_num = ((a_num / p_num) - 1) / (i_num);
            return n_num;
        }
        //====================================================\\
    }
}

