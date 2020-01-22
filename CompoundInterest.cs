// Write a C# Program of Compound Interest 
// Formula-> A= P(1+r/n)^nt where A future Anual amount and P Principal Amount, r is Rate of interest n number of months and t=time

using System;
public class CompoundInterest{

	public static void Main(){
		try{
		Console.WriteLine("Enter the Principal Amount");
		float p_amount=float.Parse(Console.ReadLine());
		Console.WriteLine("Enter the Rate of Interest(%)");
		float rate=float.Parse(Console.ReadLine());
		Console.WriteLine("Enter the tunure period in Year");
		float time=float.Parse(Console.ReadLine());
		getCompoundInterest(p_amount,rate,time);
		}catch(Exception ex){
		  Console.WriteLine("Sorry {0}",ex.Message);		
		}
	}
	
	public static void getCompoundInterest(float p_amt,float rt,float t){
		double actualAmout=0;
		//int n=12;
		float r=(rt/100);
		actualAmout=p_amt*(Math.Pow((1+r/12),12*t));
		Console.WriteLine("Actual Amount:{0}",Math.Round(actualAmout,2));
	}

}