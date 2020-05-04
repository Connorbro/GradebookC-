namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public double High;
        public double Low;
        public char Letter;
        public Statistics()
        {
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
        }
    }
}