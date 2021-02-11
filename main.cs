using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Lab3b");


double sales=0;

Console.WriteLine("Enter salesperson name");
Console.ReadLine();

Console.WriteLine("Enter sales amount");

double commission = Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("sales commission is" +  commission );
 commission = 200 + (0.09 * sales);
 if (sales == 0-2999)
 {
   Console.WriteLine("Poor");
 }


 if (sales == 3000-4999)
 {
   Console.WriteLine("Average");
 }


 if (sales == 5000-9999)
 {
   Console.WriteLine("Good");
 }


 if (sales == 10000-14999)
 {
   Console.WriteLine("Excellent");
 }
  

 if (sales > 15000)
 {
   Console.WriteLine("Outstanding");
 }
 }
}