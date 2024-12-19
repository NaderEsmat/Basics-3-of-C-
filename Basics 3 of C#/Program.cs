namespace Basics_3_of_C_
{
    internal class Program
    {
        /*  static void testpass(ref int x, ref int y)
          {
              Console.WriteLine("Inside Function Before swapping");
              Console.WriteLine($" X = {x} and Y = {y}");

              int Temp = x;
              x = y;
              y = Temp;
              Console.WriteLine("Inside Function After swapping");
              Console.WriteLine($"X = {x} and Y = {y}");

          } */

        /* static int PassRefType(ref int[] Array)
         {
             int sum = 0;

             Array = new int[] { 10, 20, 30 }; // it is changing the reference it points to to a new one


             for (int i = 0; i < Array.Length; i++)
             {
                 sum += Array[i];
             }

             return sum;
         } */

        //static void SumAndSub(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x-y;

        //}

        /*static void MinMaxArray(int[] Values)
        {

            Console.WriteLine($" Max of Set =  {Values.Max()}");
            Console.WriteLine($" Max of Set =  {Values.Min()}");

        }
        */

        static bool IsPrime (int num)
        {
            bool Flag = true;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % 2 == 0)
                {
                    Flag = false;
                    break;
                }

            }
              if (Flag)
            {
                Console.WriteLine($"{num} is Prime");
                   return Flag ;
            }

            else
            {
                Console.WriteLine($"{num} is not Prime");
                return Flag;
            }
            
               

           

        }

       

        static void Main(string[] args)
        {

            #region Question 1

            // Pasaing by value in value for a value type Does'nt change the original value 
            // Passing by ref for Value type make changes on the copy and therfore the original variables

            //int A = 5, B = 8;
            //Console.WriteLine($" A before swap function = {A} , B before = {B}");
            //testpass(A, B);

            //Console.WriteLine($" A after swap function = {A} , B after = {B}");

            // 2. : 

            //Console.WriteLine(" ----- Before Swap------");
            //Console.WriteLine($" A = {A} ,,, B before = {B}");

            //testpass(ref A, ref B);

            //Console.WriteLine(" ----- After Swap------");
            //Console.WriteLine($" A = {A} , B = {B}");

            #endregion

            #region Question 2 



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

            #region Question 3

            //Console.WriteLine("Enter value 1 :");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter value 2 :");
            //int num2 = int.Parse(Console.ReadLine());

            //SumAndSub(num1, num2, out int sum, out int sub);
            //Console.WriteLine($"Sum = {sum} .. Sub = {sub}");

            #endregion

            #region Question 4

            //int num = int.Parse(Console.ReadLine());
            //int rem = 0;

            //for (int i = num; i > 0; i--)
            //{
            //    rem += num % 10;
            //    num = num / 10;
            //}
            //Console.WriteLine(rem);



            #endregion

            #region Question 5

            //Console.Write("Enter a number to Test : ");
            //int numb = int.Parse(Console.ReadLine());

            //bool TheReturn = IsPrime(numb);
            //    Console.WriteLine(TheReturn);

            #endregion

            #region Question 6

            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //MinMaxArray(arr);


            #endregion

            #region Question 7

            //int factorial = 1;
            //Console.Write("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());

            //for(int i = num; i > 0; i--)
            //{
            //    factorial=factorial*i;
            //}

            //Console.WriteLine(factorial);

            #endregion

            #region Question 8



            #endregion

            #region Question 9

            //Console.Write("Enter matrix size : ");

            //int num; 
            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out num) && num > 1)
            //    {
            //        break;
            //    }                                     // Actually The defensive code from Chat GPT
            //    else                                  // We need a session for it , please
            //    {
            //        Console.WriteLine("Enter a valid number");
            //    }
            //}

            //int[,] identity = new int[num , num];

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //       if (i==j)
            //        { identity[i, j] = 1; }
            //       else {   identity[i, j] = 0; }

            //    }

            //}

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        Console.Write(identity[i, j] + "     ");
            //    }

            //    Console.WriteLine();

            //}


            #endregion

            #region Question 10

            //Console.WriteLine("Enter array size : ");
            //int size = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int[] array = new int[size];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Enter value : {i+1}");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //for (int i = 0; i < array.Length; i++)
            //{
            //   sum += array[i];
            //}
            //Console.WriteLine($"Sum of all numbers = {sum}");



            #endregion

            #region Question 11

            //Console.WriteLine("Enter first array size");
            //int size1 = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size1];


            //Console.WriteLine("Enter second array size");
            //int size2 = int.Parse(Console.ReadLine());
            //int[] arr2 = new int[size2];

            //int[] Merged = new int[size1 + size2];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine($"Enter value {i + 1} of arr1");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    Merged[i] = arr1[i];
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"Enter value {i + 1} of arr2");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //     Merged[arr1.Length + i] = arr2[i];
            //}

            //Array.Sort(Merged);

            //for (int i = 0; i < Merged.Length; i++)
            //{
            //    Console.Write(Merged[i] + " ");
            //}



            
        


        #endregion

            #region Question 12


        #endregion

            #region Question 13
        //Repeated 
        #endregion

            #region Question 14

        //  Console.WriteLine("Enter size : ");
        //  int size = int.Parse( Console.ReadLine() );
        //   int[] array = new int[size];

        //  for (int i = 0; i < array.Length; i++)
        //  {
        //      Console.WriteLine($"Enter value : {i + 1}");
        //      array[i] = int.Parse(Console.ReadLine());
        //  }

        //Array.Sort( array );



        //  for (int i = 0; i < array.Length; i++)
        //  {

        //      Console.Write(array[i] + "  ");


        //  }

        //  Console.WriteLine($"Second Largest = {array[size-2]} ");



        #endregion

            #region Question 15

        #endregion

            #region Question 17

            //string phrase = Console.ReadLine();
            //string[] words = phrase.Split(' ');

            //Array.Reverse(words);
                  
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i] + " ");
            //}

        #endregion

            #region Question 18

        #endregion

            #region Question 19

        //Console.WriteLine("Enter array size : ");
        //int size = int.Parse(Console.ReadLine());
        //int[] arr = new int[size];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"Enter value : {i + 1}");
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = size-1 ; i >= 0 ; i--)
        //{
        //    Console.Write(arr[i] + "  ");
        //}
        #endregion
 






    }
    }
}
