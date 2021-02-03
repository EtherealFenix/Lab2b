using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please input your first number:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input your second number:");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double sum = num1+num2;
    Console.WriteLine("Sum = "+sum);
    double diff = num1-num2;
    Console.WriteLine("Difference = "+diff);
    double product = num1*num2;
    Console.WriteLine("Product = "+product);
    double quotient =num1/num2;
    Console.WriteLine("Quotient = "+quotient);
    double remainder = num1%num2;
    Console.WriteLine("Remainder = "+remainder);
    
  }
}