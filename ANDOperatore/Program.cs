﻿// Math >= 90 Biology >= 90 Chemistry >= 90

int math, biology, chemistry;


Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemisty result:");
chemistry  = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90) //kui need koik true ss accepted
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else 
{
 Console.WriteLine("Your application cannot be approved. ");   
}