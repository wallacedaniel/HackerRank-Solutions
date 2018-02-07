

// C# Solutions for HackerRank.com  - Algorithms Track - Implementation Page 1     


// ***********Grading Students***********
// Rounding student grades
// https://www.hackerrank.com/challenges/grading/problem

// HR starter code
static void Main(String[] args) {
	int n = Convert.ToInt32(Console.ReadLine());
	int[] grades = new int[n];
	for(int grades_i = 0; grades_i < n; grades_i++){
	   grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
	}
	int[] result = solve(grades);
	Console.WriteLine(String.Join("\n", result));
}

// Sample input to run in Visual Studio: 

// int n = 4;
// int[] grades = new int[]{73, 67, 38, 33};

//for (int i = 0; i < result.Length; i++)
//{
//	ResultLabel.Text += result[i].ToString() + <br>;
//}

// Sample output:
// 75
// 67
// 40
// 33

static int[] solve(int[] grades) {
		
	int[] solution = new int[grades.Length];
	for (int i = 0; i < grades.Length; i++)
	{
		int roundCheck = grades[i];
		int diffCount = 0;
		while(roundCheck % 5 != 0)
		{
			roundCheck += 1;
			diffCount += 1;
		}
		if(diffCount < 3 && grades[i] >= 38)
		{
			grades[i] = roundCheck;
			solution[i] = grades[i];
		}
		else
		{
			solution[i] = grades[i];
		}
	}
	return solution;
}

    


	

	
	





// ***********Apples and Oranges************
// Detects values which overlap on a number line
// https://www.hackerrank.com/challenges/apple-and-orange/problem

// HR starter code
static void Main(String[] args) {
	string[] tokens_s = Console.ReadLine().Split(' ');
	int s = Convert.ToInt32(tokens_s[0]);
	int t = Convert.ToInt32(tokens_s[1]);
	string[] tokens_a = Console.ReadLine().Split(' ');
	int a = Convert.ToInt32(tokens_a[0]);
	int b = Convert.ToInt32(tokens_a[1]);
	string[] tokens_m = Console.ReadLine().Split(' ');
	int m = Convert.ToInt32(tokens_m[0]);
	int n = Convert.ToInt32(tokens_m[1]);
	string[] apple_temp = Console.ReadLine().Split(' ');
	int[] apple = Array.ConvertAll(apple_temp,Int32.Parse);
	string[] orange_temp = Console.ReadLine().Split(' ');
	int[] orange = Array.ConvertAll(orange_temp,Int32.Parse);
	countApplesAndOranges(s, t, a, b, apple, orange);
}


static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
	// Complete this function
}


	int appleHit = 0;
	for (int i = 0; i < apple.Length; i++)
	{
		if (a + apple[i] >= s && a + apple[i] <= t)
		{
			appleHit += 1;
		}
	}

	int orangeHit = 0;
	for (int i = 0; i < orange.Length; i++)
	{
		if (b + orange[i] >= s && b + orange[i] <= t)
		{
			orangeHit += 1;
		}
	}

	//Label1.Text = appleHit.ToString() + orangeHit.ToString();

	Console.WriteLine(appleHit.ToString());
	Console.WriteLine(orangeHit.ToString());  
    }
}






Sample Input 0

7 11
5 15
3 2
-2 2 1
5 -6
Sample Output 0

1 1













//*********Kangaroo***********
// Determines whether two incrementing values will ever be equal on equal iteration

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        
        int x1Count = 0;
        int x2Count = 0;
        int yesCheck= 0;
        
        while(x1 < 100000000 && x2 < 100000000){
            x1 += v1;
            x2 += v2;
            x1Count += 1;
            x2Count += 1;
            if(x1Count == x2Count && x1 == x2){
                Console.WriteLine("YES");
                yesCheck = 1;
                break;
            }
        }
        if (yesCheck != 1)
        {
            Console.WriteLine("NO");
        } 
    }
}

//*********Between Two Sets***********
// Counts instances of common factors from numbers between two number sets which are factorable for all numbers within the sets

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse); 

        int setCount = 0;

        for (int i = a.Max(); i <= b.Min(); i++)
        {
            bool firstCheck = true;
            bool secondCheck = false;

            for (int j = 0; j < n; j++)
            {
                if (i % a[j] != 0)
                {
                    firstCheck = false;
                }
            }

            if (firstCheck == true)
            {
                for (int k = 0; k < m; k++)
                {
                    if (b[k] % i != 0)
                    {
                        secondCheck = false;
                        break;
                    }
                    else
                    {
                        secondCheck = true;
                    }
                }
            }

            if(secondCheck == true)
            {
                setCount += 1;
            }
        }
        Console.Write(setCount.ToString());
    }
}

//**********Breaking the Records***********
// Determines the instances within an iteration where the value breaks the previous record for lowest/ highest value.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s){
        // Complete this function
        int highChange = 0;
        int lowChange = 0;
        int high = s[0];
        int low = s[0];
        int[] resultArray = new int[2];
        for (int i = 0; i < s.Length; i++){
            if(s[i] > high){
                high = s[i];
                highChange += 1;
            }
            if(s[i] < low){
                low = s[i];
                lowChange += 1;   
            }
        }
        resultArray[0] = highChange;
        resultArray[1] = lowChange;
        return resultArray;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}

//********Birthday Chocolate**********
// Counts instances where a given quantity of values from a sequence of values, sum to another given value

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getWays(int[] squares, int d, int m){
        int result = 0;
                           
        if (squares.Length == 1)
        {
            if(squares[0] == d)
            {
                result += 1;
            }
        }
        else
        {
            for (int i = 0; i < (squares.Length - m) + 1; i++)
            {
                List<int> temp = new List<int>();
                int index = i;

                for (int j = 0; j < m; j++)
                {
                    temp.Add(squares[index]);
                    index += 1;
                }
                if (temp.Sum() == d)
                {
                    result += 1;
                }
            }
        }
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = getWays(s, d, m);
        Console.WriteLine(result);
    }
}


//********Divisible Sum Pairs**********
// Determine pairs whose sums are divisible by a given integer

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        // write your code here
        int pairCount = 0;

        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if ((a[i] + a[j]) % k == 0)
                {
                    pairCount += 1;    
                }
            }
        }
        //Label1.Text = pairCount.ToString();
        Console.WriteLine(pairCount.ToString());
    }
}

//********Migratory Birds*************
// Determines the value with highest frequency within a collection of values.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] types_temp = Console.ReadLine().Split(' ');
        int[] types = Array.ConvertAll(types_temp,Int32.Parse);
        // your code goes here

        int[] typeCounts = new int[] {0, 0, 0, 0, 0};

        for (int i = 0; i < n; i++)
        {
            if (types[i] == 1) typeCounts[0] += 1;
            if (types[i] == 2) typeCounts[1] += 1;
            if (types[i] == 3) typeCounts[2] += 1;
            if (types[i] == 4) typeCounts[3] += 1;
            if (types[i] == 5) typeCounts[4] += 1;
        }

        int maxValue = typeCounts.Max();

        for (int i = 0; i < 5; i++)
        {
            if(typeCounts[i] == maxValue)
            {
                Console.Write((i+1).ToString());
                break;
            }   
        }
    }
}

//*******Day of the Programmer**********
// Determines the date on which a particular day of the year lands depending on year and calendar in effect. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string solve(int year){
        DateTime day = new DateTime(year,9,13);
        string result = "";
        if(year >= 1700 && year <= 1917)
        {
            if (year % 4 == 0)
            {
                day = day.AddDays(-1);
            }
        }
        else if (year == 1918)
        {
            day = day.AddDays(13);
        }
        else
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                day = day.AddDays(-1);
            }
        }
        result = day.ToString("dd.MM.yyyy");
        return result;
    }

    static void Main(String[] args) {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}

//**********Bon Appetit************
// Determines whether a shared meal has been properly split

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {

        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int k = arr[1];
        
        string[] items_temp = Console.ReadLine().Split(' ');
        int[] items = Array.ConvertAll(items_temp,Int32.Parse);
        
        int b = int.Parse(Console.ReadLine());
        
        int annasTotal = (items.Sum() - items[k]) / 2;

        if (b == annasTotal)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine((b - annasTotal).ToString());
        }

    }
}











