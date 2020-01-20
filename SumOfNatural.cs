//Write a C# Sharp program to find the sum of first 10 natural numbers.
//Nutural number always start with 1
public class SumOfNautural{
	public static void Main(){
	 int sum =0;
	 int i=1;
	for(i=1;i<=10;i++){
	 sum=sum+i;
	}
	Console.WriteLine("Sum is:"+sum);
	}
}