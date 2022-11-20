using System;
class HelloWorld {
  static void Main() {
    int usd,inr,val=81;
    Console.WriteLine("Enter the Dollar");
    usd=Convert.ToInt32(Console.ReadLine());
    inr=usd*val;
    Console.WriteLine("The Dollar of :"+usd+"amount is: "+inr);
    
    }
}