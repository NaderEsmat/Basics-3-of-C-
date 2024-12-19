namespace Demo_3
{
    internal class Program
    {

        //static void PrintPattern(int counter, string pattern)
        //{
        //    for (int i = 0; i < counter; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //}

        //static void testpass(ref int x ,ref  int y)
        //{
        //    Console.WriteLine("Inside Function Before swapping");
        //    Console.WriteLine($" X = {x} and Y = {y}");

        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //    Console.WriteLine("Inside Function After swapping");
        //    Console.WriteLine($"X = {x} and Y = {y}");

        //}

        //static int PassRefType(ref int[] Array)
        //{
        //    int sum = 0;

        //    Array[0] = 6;
        //    Console.WriteLine(Array[0]);

        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        sum += Array[i];
        //    }

        //    return sum;
        //}

        static int PassRefType( ref int[] Array)
        {
            int sum = 0;

            Array = new int[] {10 , 20 , 30 }; // it is changing the reference it points to to a new one
           

            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }

            return sum;
        }


        static void SumAndMul (int x , int y , out int sum , out int mul)
        {
            sum = x + y;
            mul = x * y;

        }


        static void Main(string[] args)
        {
            // The Demo File 

            #region 1D Arrays
            // int[] arr;
            // Declaration of variable arr (in the stack) that points to an address in heap 

            //  arr = new int[3];

            //  New keyword 
            // 1. Alloctes the required number of bytes for the object in Heap ->  4 bytes * 3 objects = 12 byte 
            // 2. Initiallize the bytes with default values which is 0 
            // 3. Calls the user defined constructor if exists 
            // 4. Asssigns the object to the variable arr 

            //arr[0] = 1;
            //arr[1] = 2;      // Assigning values to the array manually                            
            //arr[2] = 3;      // Note : Arrays are Immeutable datatype , can;t change its value after creation 

            //Console.Write(arr[0]);          
            //Console.Write(arr[1]);
            //Console.Write(arr[2]);


            // Dealing with arrays is usally with for loop : 

            //int[] numbers;
            //numbers = new int[3]; 

            //for (int i =0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter value {i+1} : ");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Value {i + 1} = {numbers[i]} " );     
            //} 
            #endregion

            #region 2D Arrays 

            // Same for 1D but it has Rows (1D) & Columns

            /* as
                    00 01 02
                    10 11 12
                    20 21 22
            */

            //int[,] grades = new int[3, 2];

            //  for (int i = 0; i < 3 ; i++)
            //    {
            //        for (int j = 0; j < 2 ; j++)
            //        {
            //            Console.WriteLine($"Enter Grade {i}{j}");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine($"Grade {i}{j} =  {grades[i,j]}");

            //    }
            //}



            #endregion

            #region Functions 

            // Block of Code , resuable in any place in the app 

            // PrintPattern(5, "^_^");
            // function take an intger as a counter and a string (Shape) to print counter times

            // Stack Frames : 
            /* 
                Each Function in the program has frame 
                it is assigned in a stack called Stack frame 
                the Last function called it the first function to get out of the stack LIFO            
            */

            #endregion

            #region Passing parameters of value type

            // 1. Either by value 
            // 2. or By reference 


            // 1. :

            //int A = 5, B = 8;
            //Console.WriteLine($" A before swap function = {A} , B before = {B}");
            //testpass(A, B);

            //Console.WriteLine($" A after swap function = {A} , B after = {B}");

            // 2. : 

            //Console.WriteLine(" ----- Before Swap------");
            //Console.WriteLine($" A = {A} ,,, B before = {B}");

            //testpass(ref A,ref B);

            //Console.WriteLine(" ----- After Swap------");
            //Console.WriteLine($" A = {A} , B = {B}");

            #endregion

            #region Passing parameters of Reference type 

            //  int[] numbers = { 1, 2, 3, 4 };

            // Console.WriteLine(PassRefType(numbers)); // Passing by value
            // but here the value itself is a reference :)

            // Console.WriteLine(numbers[0]); // 6 not 1 becuase in the function i made arr[0] = 6 


            // Passing by reference 

            // Console.WriteLine(PassRefType(ref numbers)); // Passing by Ref

            // Console.WriteLine(numbers[0]); // 6 also 

            // in this example there is no difference between passing by value nor reference 

            // VIP But Note : Each Example has its own idea depends on the function written and required



            // Another example : 


            // int[] numbers = { 1, 2, 3, 4 };


            //Console.WriteLine(PassRefType(numbers)); // 60   passing by value Array ---> {10 , 20 , 30}
            // Console.WriteLine(numbers[0]); // 1   numbers --> {1 , 2 , 3 , 4 }


            // Passing by reference 

            // Console.WriteLine(PassRefType(ref numbers)); // 60   passing by value Array ---> {10 , 20 , 30}
            // Console.WriteLine(numbers[0]); // 10 

            // now the set {1,2,3,4} is unreachable 






            #endregion

            #region Output Parameters 

            // Creation of an output parameter to a function void and has no return 

            //int num1 = 4, num2 = 6  ; // int sum , int mul 

            //SumAndMul(num1, num2, out int  sum, out int mul);
            // Console.WriteLine($"Sum = {sum} and Mul = {mul}");



            #endregion

        }
    }
}
