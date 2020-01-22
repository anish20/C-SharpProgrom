//Write a program and get Simple Interest by userInput
// Formula -> SI= (P * R * T)/100
using System;
public class SimpleInterest{
	public static void Main(){
	try{
	 Console.WriteLine("Enter the Principal Amount");
	 float P=float.Parse(Console.ReadLine());
	 Console.WriteLine("Enter the Rate of Percent(%)");
	 float R= float.Parse(Console.ReadLine());
	 Console.WriteLine("Enter the tenure");
	 float T= float.Parse(Console.ReadLine());
	  	getSimpleInterest(P,R,T);
	}catch(Exception ex){
	   Console.WriteLine("Sorry {0}",ex.Message);
	}
	}

	public static void getSimpleInterest(float a,float r,float t){
	  try{
	  float result=0;
	  result = (a*r*t)/100;
	  Console.WriteLine("Result : {0}",result);
	  }catch(Exception ex){
	   Console.WriteLine("Sorry {0}",ex.Message);
	 }
	}
}