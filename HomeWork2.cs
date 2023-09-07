using System;
using System.IO.Compression;

public class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Please Input a Letter Grade");
       string b = Console.ReadLine();
       if(b=="A"){
        Console.WriteLine("4");
       }
       else if(b=="B"){
        Console.WriteLine("3");
       }
       else if(b=="C"){
        Console.WriteLine("2");
       }
       else if(b=="D"){
        Console.WriteLine("1");
       }
       else if(b=="F"){
        Console.WriteLine("0");
       }
       else{
        Console.WriteLine($"Wrong Letter Grade!");
       } 

       Console.WriteLine("Please input the first number");
    int x =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second number");
    int y =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third number");
    int z =Convert.ToInt16(Console.ReadLine());
    if(x<y && x<z){
        Console.WriteLine($"The smallest number value is: {x}");
    }
    else if(y<x && y<z){
        Console.WriteLine($"The smallest number value is: {y}");
    }
    else if(z<x && z<y){
        Console.WriteLine($"The smallest number value is: {z}");
    }
    }
}