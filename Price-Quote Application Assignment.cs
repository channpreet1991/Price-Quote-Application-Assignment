int length,width,height,weight; 
 
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");  
Console.WriteLine("Enter weight");
 
if weight>50  
Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");  
 

Console.WriteLine("Choose an option from the following list:");  
Console.WriteLine("\ta -Enter Width");  
Console.WriteLine("\ts -Enter  Height");  
Console.WriteLine("\tm -Enter Length"); 
if length + width+ height > 50 
  
Console.Write("Package too big to be shipped via Package Express.");  

res=((length*width*height)*weight)/100;

Console.WriteLine("$"res);