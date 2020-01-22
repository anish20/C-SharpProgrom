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
	 Console.WriteLine("Enter the tenur in Year");
	 float T= float.Parse(Console.ReadLine());
	  	getSimpleInterest(P,R,T);
	}catch(Exception ex){
	   Console.WriteLine("Sorry {0}",ex.Message);
	}
	}

	public static void getSimpleInterest(float a,float r,float t){
	  try{
	  float result=0;
	  float monthlyInterest=0;
	  result = (a*r*t)/100;
	  Console.WriteLine("Per year Interest : {0} of Actual Amount {1}",result,a);
	  Console.WriteLine("Are you want to know Monthly interest Yes/No");
	  string check=Console.ReadLine();
	  if(check=="Yes" || check=="yes" || check=="y"){
	   monthlyInterest=(result/30);
	   Console.WriteLine("Monthly Interest : {0} of Actual Amount {1}",monthlyInterest,a);
	   }else if(check=="No" || check=="no" || check=="n"){
			Console.WriteLine("\n ----------Thank you----------");
	}else{
		Console.WriteLine("\n Sorry you have wrong Input");
	}
	 
	  }catch(Exception ex){
	   Console.WriteLine("Sorry {0}",ex.Message);
	 }
	}
}