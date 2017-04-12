


// C# Solutions for HackerRank.com  - Algorithms Track - Warmup Challenges     

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    //***********Simple Array Sum************
    // Sums an array of a given length.

	static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
		
        int i = 0;
        int sum = 0;
        while (i < n){
            sum += arr[i];
            i += 1;
        }
        Console.WriteLine(sum.ToString());
        
    }

	//************Compare the Triplets************
    //Compares values within two arrays.
	
	static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
		
		int a = 0;
        int b = 0;
        for(int i=0; i<3; i++){
            if(int.Parse(tokens_a0[i]) > int.Parse(tokens_b0[i])){
                a += 1;              
            }
            else if(int.Parse(tokens_b0[i]) > int.Parse(tokens_a0[i])){
                b += 1;    
            }
        }
        Console.WriteLine(a.ToString() + ' ' + b.ToString());
    }
	
	
	//************A Very Big Sum************
	// Sums a given quantity of large values.

	static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
		
		long solution = 0;

        for(int i=0; i<n; i++){
            
            solution += Convert.ToInt64(arr[i]);    
        }
        Console.WriteLine(solution.ToString());
    }

    //************Diagonal Difference************
    // Sums diagonal integers in a matrix, then takes the absolute value of their difference.

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
		
		//int n = 3;
		//int[][] a = new int[n][];

		//int[] a_1 = new int[3]{11,2,4};
		//int[] a_2 = new int[3] { 4, 5, 6 };
		//int[] a_3 = new int[3] { 10, 8, -12 };

		//a[0] = a_1;
		//a[1] = a_2;
		//a[2] = a_3;
		
		int primary = 0;
		
        for (int i = 0; i < n; i++)
        {  
            primary += a[i][i];
        }

        int secondary = 0;
        int secondIndex = n - 1;

        for (int i = 0; i < n; i++)
        {
            secondary += a[i][secondIndex];
            secondIndex -= 1;
        }

        int solution = Math.Abs(primary - secondary);
        Console.WriteLine(solution.ToString());
    }

    //*********Plus Minus ************
    // Determines percentage of positive, negative, and 0 integers in an array.

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
		int zeroCount = 0;
            int posCount = 0;
            int negCount = 0;
            
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                posCount += 1;
            }
            else if (arr[i] < 0)
            {
                negCount += 1;
            }
            else
            {
                zeroCount += 1;
            }
        }

        decimal posPercent = Convert.ToDecimal(posCount) / Convert.ToDecimal(n);
        decimal negPercent = Convert.ToDecimal(negCount) / Convert.ToDecimal(n);
        decimal zeroPercent = Convert.ToDecimal(zeroCount) / Convert.ToDecimal(n);

        Console.WriteLine(posPercent.ToString());
        Console.WriteLine(negPercent.ToString());
        Console.WriteLine(zeroPercent.ToString()); 
    }
	
	//*********Staircase************
    // Given an array, prints an ascending staircase of hashes with length and height of array.
	
	static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
		string hashString = "";
        string printSolution = "";

        for (int i = 0; i < n; i++)      
        {
            string solution = "";
            for (int j = 0; j < n; j++)   
            {
                hashString += "#";    
            }

            hashString = hashString.Substring((n - 1) - i, i + 1);
            int spaceLength = n - hashString.Length;
            string spaceString = "";

            for (int k = 0; k < spaceLength ; k++)
            {
                spaceString += " ";
            }

            solution = spaceString + hashString;
            solution += Environment.NewLine;
            printSolution += solution;
        }
        Console.WriteLine(printSolution);
    }
	
	//**********Min and Max Sum************
	// Determines minimum sum (removes largest) and maximum sum (removes smallest) of values in an array. 

	static void Main(string[] args) {
        
        string[] inputArr = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(inputArr, long.Parse);

            long minInt = arr.Min();
            int index = Array.IndexOf(arr, minInt);

            long[] minArr = removeIndex(arr, index);
            long minSum = minArr.Sum();

            long maxInt = arr.Max();
            index = Array.IndexOf(arr, maxInt);

            long[] maxArr = removeIndex(arr, index);
            long maxSum = maxArr.Sum();
            
            Console.WriteLine(maxSum.ToString() + " "  + minSum.ToString());  
    }
    
    public static long[] removeIndex(long[] arr, int removeIndex)
    {
        long[] newArr = new long[arr.Length - 1];
        for (int i = 0, j = 0; i < newArr.Length; i++, j++)
        {
            if (i == removeIndex)
            {
                j++;
            }
            newArr[i] = arr[j];
        }
        return newArr;
    }
	
	//*********Time Conversion************
	// Converts to military time (24 hr day)

	static void Main(String[] args) {
        string time = Console.ReadLine();
        DateTime formatTime = DateTime.Parse(time);
        Console.Write(formatTime.ToString("HH:mm:ss"));
    }

    //***********Birthday Cake Candles************
    // Counts the occurences of the max value in an array

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);
        
        int maxHeight = height.Max();

		int maxCount = 0;
		for (int i = 0; i < n; i++)
			if(height[i] == maxHeight)
			{
				maxCount += 1;    
			}
		{

		}
		Console.Write(maxCount.ToString());
    }
}
	
	











