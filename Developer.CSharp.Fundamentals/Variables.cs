namespace Developer.CSharp.Fundamentals
{
    public class Variables
    {
        private int myInt = 1;
        private float myFloat = 1f;
        private bool myBoolean = true;
        private string myName = "John";
        private char myChar = 'a';
        private double myDouble = 1.75;

        public static void GetValue()
        {
            var x = 1;          // var ---> const int
            var y = 2;          // var ---> const int
            var sum = x + y;    // sum will also be defined as an integer  
        }
    }
}