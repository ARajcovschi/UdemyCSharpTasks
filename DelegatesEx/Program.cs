using System;

namespace DelegatesEx
{
    class Program
    {
        public delegate float OperationDelegate(float num1, float num2);

        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        } 
        public static float Substract(float num1, float num2)
        {
            return num1 - num2;
        } 
        public static float Multiply (float num1, float num2)
        {
            return num1 * num2;
        } 
        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
        public static float ApplyOperation(float num1, float num2, OperationDelegate o)
        {
            float result = o(num1, num2);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ApplyOperation(1.2f, 1.5f, Substract)); 
        }
    }
}
