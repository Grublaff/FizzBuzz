using System;

namespace FizzBuzz{
    class Program{
        static void Main(string[] args){
            String[] input = Console.ReadLine().Split(" ");
            int[] inputArray = Array.ConvertAll(input, int.Parse);
            for (int i = 1; i < inputArray[2]+1; i++){
                string toLog = string.Empty;
                if (i % inputArray[0] == 0){
                    toLog = "Fizz";
                }
                if (i % inputArray[1] ==0){
                    toLog = "Buzz";
                }
                if (i % inputArray[1] == 0 && i % inputArray[0] == 0){
                    toLog = "FizzBuzz";
                }
                if (String.IsNullOrEmpty(toLog)){
                    toLog = i.ToString();
                }
                Console.WriteLine(toLog);  
            }
        }
    }
}
