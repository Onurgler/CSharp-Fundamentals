namespace object_oriented_fundamentals_onur
{
    public class Employ
    {
        public int empno;
        public string name;
        public string dept;
        public string desig;
        public double basic;

        public override string ToString()
        {
            return "Employ No: " + empno + " Name: " + name + " Basic: " + basic;
        }
    }
}