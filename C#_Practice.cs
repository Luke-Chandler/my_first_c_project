using System;
					
public class Program
{
	public static void Main()
	{
		//string forename;
		//string surname;
		//string age;
		
	    //Console.WriteLine("Please enter your first name");
		//forename = Console.ReadLine();
		//Console.WriteLine("Please enter your last name");
		//surname = Console.ReadLine();
		//Console.WriteLine("Please enter your age");
		//age = Console.ReadLine(); 
		
		//Console.WriteLine("Your name is " + forename + " " + surname + " and your age is " + age);
		
	//string first;
	//string second;
		//Console.WriteLine("Enter first number:");
		//first = Console.ReadLine();
        //Console.WriteLine("Enter second number:");
		//second = Console.ReadLine();
		
	
    //int a = int.Parse(first);
    //int b = int.Parse(second);
	//int c = a + b;
	//Console.WriteLine("The answer is " + c);
		
	    
		string teabags = "do you have enough teabags? Y/N";
		string kettleOn = "is the kettle on? Y/N";
		string addWaterFirst = "do you add milk? Y/N";
		string addSugar = "do you take sugar with your tea? Y/N";
		string response;
	
		do
		{
		
		Console.WriteLine(teabags);
		response = Console.ReadLine(); 
		if (response == "N")
		{
			Console.WriteLine (" Buy more teabags ");
			}
		}
		while (response == "N");
		
		do
		{
			Console.WriteLine(kettleOn);
			response = Console.ReadLine();
				if (response == "N")
		{
			Console.WriteLine (" Turn Kettle on ");
			}
		}
		while (response == "N");
		
		Console.WriteLine(addWaterFirst);
		response = Console.ReadLine();
			if (response == "Y")
		{
		   addWaterFirst = " milk? ";
		}
		else
		{
			addWaterFirst = " no milk ";
		}
		
		Console.WriteLine (addSugar);
		response = Console.ReadLine();			
		if (response == "Y")
		{
			Console.WriteLine("tea completed with sugar and" + addWaterFirst);
		}
		else
		{
		   Console.WriteLine("tea completed with no sugar and" + addWaterFirst); 
		}
		
     }
}