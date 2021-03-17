using System;

namespace Array_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вывести элементы массива на экран в обратном порядке.


          

            int[] arr = { 3, 5, 7, 12, 41, 2, 6 };

            

            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.WriteLine(arr[i]);
            }

                for ( int i = arr.Length - 1; i >= 0; i--)
                {
                    

                    

                    Console.WriteLine(arr[i]);

                }
            
        }
    }
}
