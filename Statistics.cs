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
        public char Letter;
        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            result.Low = Math.Min(grades[index], result.Low);
            result.High = Math.Max(grades[index], result.High);
        }
        public Statistics()
        {
            Count =0;
            Average = 0.0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}