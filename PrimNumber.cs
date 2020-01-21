// Write a C# program and find prime number

public class PrimNumber {
      public static void Main() {
		Console.WriteLine("Enter the Number");
		int n=Convert.ToInt32(Console.ReadLine());
		getPrime(n);
         }
	public static void getPrime(int num){
	int  a = 0;
         for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
               a++;
            }
         }

         if (a == 2) {
            Console.WriteLine("{0} a Prime Number", num);
         } else {
            Console.WriteLine("Not a Prime Number");
         }

	}
   }