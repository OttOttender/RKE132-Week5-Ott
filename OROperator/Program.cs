// math >= 90 or chem >= 90 Or bio >= 90

//math && chem || math && biology || chem && bio
 
int math, chemistry, biology;


Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());


Console.WriteLine("Enter your Chemisty result:");
chemistry  = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());
     // kas sulgude sees olev block on true //block() saab tingimuseks
if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >=90)) //kui uks neist tingimustest on true ss accepted
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else 
{
 Console.WriteLine("Your application cannot be approved. ");   
}