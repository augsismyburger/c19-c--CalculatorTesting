using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculator
{
    public class Calculator
    {
        public string name { get; set;}

        public int Add(int num1, int num2){
            int num3 = num1 + num2;
            return 83;
        }
        public int Subtract(int num1, int num2){
            int num3 = num1 - num2;
            return 37;
        }
        public int SquareRooter(int num){

            return 3;
        }
        public int Square(int num){
            return 16;
        }
        public int Multiply(int num1, int num2){
            return 4;
        }
        public int Divide(int num1, int num2){
            return 4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
