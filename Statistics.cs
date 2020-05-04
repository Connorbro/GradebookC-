using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch(Average)
            {
                case var d when d >= 90.0:
                return 'A';
                break;

                case var d when d >= 80.0:
                return  'B';
                break;

                case var d when d >= 70.0:
                return  'C';
                break;

                case var d when d >= 60.0:
                return  'D';
                break;

                case var d when d >= 50.0:
                return 'E';
                break;

                case var d when d >= 40.0:
                return  'F';
                

                case var d when d >= 30.0:
                return  'G';
                

                case var d when d >= 20.0:
                return  'U';
                
            }
            }
        }
        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }
        public Statistics()
        {
            Count =0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}