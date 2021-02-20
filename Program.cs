using System;

namespace CodeWars
{
    
    class Program
    {   
        public static string CreatePhoneNumber(int[] numbers)
        {
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {

                if (i == 0)
                    result += '(';
                else if (i == 1)
                    result += '-';
                else if (i == 4)
                    result += ") ";
                
                else if (i == 7)
                       result += '-';
                else if (i == 9)
                    result += '-';

                result += numbers[i];
            }
            return result;
        }
        public static void DisplayArtsiomPhoneNumber(int[] numbers2)
        {
            Console.WriteLine($"\nArtsiom phone number is :");
            Console.WriteLine(CreatePhoneNumber(numbers2));
        }
        public static void DisplayAntonPhoneNumber(int[] numbers) 
        {
            Console.WriteLine($"\nAnton phone number is :");
            Console.WriteLine(CreatePhoneNumber(numbers));
        }
        static void Main(string[] args) 
        {
            int[] numbers = { 8, 0, 2, 9, 6, 5, 2, 8, 5, 8, 1 };
            int[] numbers2 = { 8, 0, 2, 9, 8, 8, 8, 9, 6, 4, 7 };
            DisplayArtsiomPhoneNumber(numbers2);
            DisplayAntonPhoneNumber(numbers); 
            Console.ReadLine();
        }  
}   }
