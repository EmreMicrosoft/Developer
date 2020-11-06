namespace Developer.CSharp.Fundamentals
{
    public class Arrays
    {
        private readonly int[] _digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly char[] _chars = new char[11]; // 11 is Lenght of the Array.


        // *** MULTIDIMENSIONAL ARRAYS *** //
        private readonly int[,] _matrix = new int[2, 2];

        public static int[,] DeclareArray(int[,] matrix)
        {
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;

            var predefinedMatrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            return predefinedMatrix;
        }
    }
}