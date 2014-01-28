using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JaggedArrays
{
    public partial class JaggedArrays : Form
    {
        public JaggedArrays()
        {
            InitializeComponent();
            Simple2DArray();
            JaggedArrayDeclaration();
            ArrayLength();
            ArrayRank();
            ArrayClearing();
            MultidimensionalArrayClearing();
            ArrayCloning();
        }

        private void Simple2DArray()
        {
            // Simple two-row, four-column two-dimensional array of float values
            float[,] declaredAllocatedWithDefaultInitialization2DArray = new float[2, 4];
        }

        private void JaggedArrayDeclaration()
        {
            // A jagged array as a one-dimensional two-element array where each element is a one-dimensional array of floats
            float[][] sampleOne1DJaggedArray = new float[2][];
        }

        private void ArrayLength()
        {
            // One-dimensional array
            int[] length1DArray = new int[4];

            Console.WriteLine("1D Array - " +
                "L: " + length1DArray.Length +
                ", GL: " + length1DArray.GetLength(0)
            );

            // Output: 1D Array - L: 4, GL: 4

            // Two-dimensional array
            int[,] length2DArray = new int[4, 5];

            Console.WriteLine("2D Array - " +
                "L: " + length2DArray.Length +
                ", GL(0): " + length2DArray.GetLength(0) +
                ", GL(1): " + length2DArray.GetLength(1)
            );

            // Output: 2D Array - L: 20, GL(0): 4, GL(1): 5

            // One-dimensional jagged array of one-dimensional arrays
            int[][] length1DJaggedArray1DArray = 
    {
        new int[6],
        new int[5]
    };

            Console.WriteLine("1D Jagged Array 1D Array - " +
                "L: " + length1DJaggedArray1DArray.Length +
                ", L(0): " + length1DJaggedArray1DArray[0].Length +
                ", L(1): " + length1DJaggedArray1DArray[1].Length +
                ", GL(0): " + length1DJaggedArray1DArray.GetLength(0) +
                ", GL(0,0): " + length1DJaggedArray1DArray[0].GetLength(0) +
                ", GL(1,0): " + length1DJaggedArray1DArray[1].GetLength(0)
            );

            // Output: 1D Jagged Array 1D Array - L: 2, L(0): 6, L(1): 5, GL(0): 2, GL(0,0): 6, GL(1,0): 5
        }

        private void ArrayRank()
        {
            // One-dimensional array
            int[] sample1DArray = new int[4];
            Console.WriteLine("1D Array Rank: " + sample1DArray.Rank);

            // Output: 1D Array Rank: 1 

            // Two-dimensional array
            int[,] sample2DArray = new int[4, 5];
            Console.WriteLine("2D Array Rank: " + sample2DArray.Rank);

            // Output: 2D Array Rank: 2 

            // Three-dimensional array
            int[, ,] sample3DArray = new int[4, 5, 6];
            Console.WriteLine("3D Array Rank: " + sample3DArray.Rank);

            // Output: 3D Array Rank: 3

            // A one-dimensional jagged array where each element is a one-dimensional array
            float[][] sample1DJaggedArray1DArray = new float[1][];
            sample1DJaggedArray1DArray[0] = new float[3];
            Console.WriteLine("1D Jagged Array 1D Array Rank: " +
                sample1DJaggedArray1DArray.Rank +
                ", (0): " + sample1DJaggedArray1DArray[0].Rank
            );

            // Output: 1D Jagged Array 1D Array Rank: 1, (0): 1

            // A two-dimensional jagged array where each element is a one-dimensional array
            float[,][] sample2DJaggedArray1DArray = new float[1, 2][];
            sample2DJaggedArray1DArray[0, 0] = new float[2];
            sample2DJaggedArray1DArray[0, 1] = new float[3];
            Console.WriteLine("2D Jagged Array 1D Array Rank: " +
                sample2DJaggedArray1DArray.Rank +
                ", (0, 0): " + sample2DJaggedArray1DArray[0, 0].Rank +
                ", (0, 1): " + sample2DJaggedArray1DArray[0, 1].Rank
            );

            // Output: 2D Jagged Array 1D Array Rank: 2, (0, 0): 1, (0, 1): 1

            // A one-dimensional jagged array where each element is a two-dimensional array
            float[][,] sample1DJaggedArray2DArray = new float[2][,];
            sample1DJaggedArray2DArray[0] = new float[1, 2];
            sample1DJaggedArray2DArray[1] = new float[2, 3];
            Console.WriteLine("1D Jagged Array 2D Array Rank: " +
                sample1DJaggedArray2DArray.Rank +
                ", (0): " + sample1DJaggedArray2DArray[0].Rank +
                ", (1): " + sample1DJaggedArray2DArray[1].Rank
            );

            // Output: 1D Jagged Array 2D Array Rank: 1, (0): 2, (1): 2 
        }

        private void ArrayClearing()
        {
            // Clearing a one-dimensional array
            int[] clearSample1DArray = new int[] { 0, 1, 2, 3, 4, 5 };

            Array.Clear(clearSample1DArray, 2, 4);
        }

        private void MultidimensionalArrayClearing()
        {
            // Clearing a two-dimensional array
            int[,] clearSample2DArray = new int[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };

            Array.Clear(clearSample2DArray, 2, 3);
        }

        private void ArrayCloning()
        {
            // Using Clone
            // Create a one-dimensional jagged array
            int[][] original1DJaggedArray = new int[2][];

            // Create each element of the jagged array, and initialize the values
            original1DJaggedArray[0] = new int[] { 1, 2, 3, 4 };
            original1DJaggedArray[1] = new int[] { 5, 6, 7 };

            // Output rom the original array the value of the second element in the first jagged array
            Console.WriteLine("Original: " + original1DJaggedArray[0][1]);

            // Output: 2

            // Clone the jagged array
            int[][] new1DJaggdArray = (int[][])original1DJaggedArray.Clone();

            // Output from the new array the value of the second element in the first jagged array
            Console.WriteLine("New: " + new1DJaggdArray[0][1]);

            // Output: 2

            // Modify in the original array the second element in the first jagged array
            original1DJaggedArray[0][1] = 10;

            // Output the same element from both jagged arrays to confirm the values are identical
            Console.WriteLine("Original After: " + original1DJaggedArray[0][1]);

            // Output: 10

            Console.WriteLine("New After: " + new1DJaggdArray[0][1]);

            // Output: 10
        }
    }
}
