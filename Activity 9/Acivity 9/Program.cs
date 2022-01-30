

//Kevin Reynoso //Course Number: CST-150-0500//This is my own work

using System;


namespace activity9
{
    class Program
    {

        public static int showAddition(int sum1, int sum2)
        {
            int Total = sum1 + sum2;
            return Total;
        }

        public static double showAverage(double avg1, double avg2, double avg3, double avg4, double avg5)
        {
            double Average = (avg1 + avg2 + avg3 + avg4 + avg5) / 5;
            return Average;
        }

        public static int showRandomAddtion(int random1, int random2)
        {
            int randomAdditon = random1 + random2;
            return randomAdditon;
        }

        public static bool checkSum(string str)
        {
            int booleanValue = str.Length;
            int boolSumCheck = 0;

            for (int i = 0; i < booleanValue; i++)
            {
                boolSumCheck += (str[i] - '0');
            }
            return (boolSumCheck % 3 == 0);
        }

        public static void showShortestWord(string s1, string s2)
        {
            if (s1.Length < s2.Length)
            {
                Console.WriteLine(s1);
            }
            else if (s2.Length < s1.Length)
            {
                Console.WriteLine(s2);
            }
        }

        public static int showLargestValue(int[] arr)
        {
            int big = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > big)
                {
                    big = arr[i];
                }
            }
            return big;
        }

        public static int[] showUpToFifty()
        {
            int[] fiftyValues = new int[50];
            Random rand = new Random();

            for (int i = 0; i < fiftyValues.Length; i++)
            {
                fiftyValues[i] = rand.Next(10, 50);
            }

            return fiftyValues;
        }

        public static bool showBooleanValue(bool a8, bool b8)
        {
            if(a8 == true && b8 == true)
            {
                return true;
            }
            else if(a8 == false && b8== false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double showMixProduct(int a, double b)
        {
            return a * b;
        }

        public static double showArrayAverage(int [,]arr1)
        {
            int counting = 0;
            int result = 0;
            for(int i =0; i <arr1.GetLength(0); i++)
            {
                for(int j=0; j<arr1.GetLength(1); j++)
                {
                    result += arr1[i,j];
                    counting++;
                }
            }
            return result/counting;
        }


         static void Main(string[] args)
         {
            //1st method
            int add1 = 4, add2 = 6 , additionResult = 0;
            additionResult = showAddition(add1, add2);
            Console.WriteLine("Addition Result: {0}", additionResult);
            Console.WriteLine();

            //2nd method
            double avg_1 = 3.4, avg_2 = 7.7, avg_3 = 42.4, avg_4 = 67.3, avg_5 = 987.2, averageResult=0.0;
            averageResult = showAverage(avg_1,avg_2,avg_3,avg_4,avg_5);
            Console.WriteLine("Average Result: {0}",averageResult);
            Console.WriteLine();

            //3rd method
            Random random01 = new Random(); 
            Random random02 = new Random();
            int randomAdd1 = random01.Next();
            int randomAdd2 = random02.Next();
            int randomAddResult = showRandomAddtion((int)random01.Next(), (int)random02.Next());
            Console.WriteLine("Random Additon Result: {0}", randomAddResult);
            Console.WriteLine();

            //4th method
            Console.WriteLine("Condition for Boolean Sum:");
            int a4 = 30, b4 = 67, c4 = 83;
            int boolResult = (a4 + b4 + c4);
            if(checkSum(boolResult.ToString()))
            {
                Console.WriteLine(boolResult);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine();

            //5th method 
            Console.WriteLine("Smallest Word:");
            showShortestWord("Mexico", "Xochimilco");
            Console.WriteLine();

            //6th method
            int[] MaxValue = { 2, 32, 445, 6554, 22311, 23134, 433 };
            Console.WriteLine("Max Value Number:");
            Console.WriteLine(showLargestValue(MaxValue));
            Console.WriteLine();

            //7th method 
            Console.WriteLine("Array With 50 Values:");
             int []newArray = showUpToFifty();
             foreach(var item in newArray)
             {
                 Console.Write(item + " ");
             }
             Console.WriteLine();
            Console.WriteLine();

            //8th method 
            Console.WriteLine("Boolean Conditon:");
            Console.WriteLine(showBooleanValue(false,false));
            Console.WriteLine();

            //9th method 
            Console.WriteLine("Mixed Product:");
            Console.WriteLine(showMixProduct(12, 42.54));
            Console.WriteLine();

            //10th method
            Console.WriteLine("Average of 2D Array:");
            int[,] exampleArray = {{ 1,2,3},{ 7, 6, 5},{ 4, 8,9 }};
            Console.WriteLine(showArrayAverage(exampleArray));
        }

    }

}