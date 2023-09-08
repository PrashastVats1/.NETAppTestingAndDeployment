namespace OurCalcLib
{
    public class SimpleCalc
    {
        public int FirstNumber { get; set; }
        public int SecindNumber { get; set; }
        public int Add()
        {
            int result = FirstNumber + SecindNumber;
            return result;
            //return 0;
        }
    }
}