using System;

namespace coolOrange_CandidateChallenge
{

	public class Arrays
	{

        public static int FindMaxValue(int[] array, int position1, int position2)
		{
    		if (position1 > position2 || position1 < 0 || position2 >= array.Length)
    		{
        		throw new ArgumentOutOfRangeException("Invalid positions provided.");
    		}
    		int max = int.MinValue;
    		for (int i = position1; i <= position2; i++) // Include position2
    		{
        		if (array[i] > max)
        		{
            		max = array[i];
        		}
    		}
    		return max;
		}


        public static int FindMinPosition(int[] array, int position1, int position2)
		{
    		if (position1 > position2 || position1 < 0 || position2 >= array.Length)
    		{
        		throw new ArgumentOutOfRangeException("Invalid positions provided.");
    		}
    		int min = int.MaxValue;
    		int pos = -1;
    		for (int i = position1; i <= position2; i++)
    		{
        		if (array[i] < min)
        		{
            		min = array[i];
            		pos = i;
        		}
    		}
    		return pos;
		}


        public static void Swap(int[] array, int position1, int position2) //Done
		{
			int speicher1 = array[position1];
			int speicher2 = array[position2];
			array[position1] = speicher2;
			array[position2] = speicher1;
		}

        public static void ShiftLeftByOne(int[] array, int position1, int position2) //Done
		{
			int temp = array[position1];
            for(int i = position1; i<position2; i++){
                array[i] = array[i+1];
            }
            array[position2-1] = temp;
		}

        public static int[] CreateRandomArray(int size, int minValue, int maxValue) //Done
		{
			int[] array = new int[size];
			Random rnd = new Random();
			for(int i = 0; i<size; i++){
				array[i] = rnd.Next(minValue, maxValue);
			}
			return array;
		}

        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue) //Done
        {
            int[,] array = new int[rows, columns];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            return array;
        }

        public static int[,] CopyArray(int[] array) //Done
		{
			int[,] returnArray = new int[2, array.Length];
            
            for(int i = 0; i<array.Length; i++){
                returnArray[0, i] = array[i];
                returnArray[1, i] = array[i];
            }
            return returnArray;
		}

        public static int FindInSortedArray(int[] array, int number) //Done
		{
   			int low = 0;
    		int high = array.Length - 1;

    		while (low <= high)
   			{
        		int mid = low + (high - low) / 2;

        		if (array[mid] == number)
        		{
            		return mid;
        		}

        		if (array[mid] > number)
        		{
            		high = mid - 1;
        		}
        		else
        		{
            		low = mid + 1;
        		}
    		}
   			return -1;
		}

    }
}