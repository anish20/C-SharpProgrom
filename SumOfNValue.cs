//Write a program in C# Sharp to display n terms of natural number and their sum

public class NValueSumOf{
	public static void Main(){
	 getNValue(5);
	}
	public static void getNValue(int number){
	int sum=0;
	 for(int i=1;i<=number;i++){
	 sum=sum+i;
	}
	Console.WriteLine("Sum is :"+sum);
	}
}