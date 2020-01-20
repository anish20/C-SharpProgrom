
//P-1 Write a program and print 5 rows and 5 columns sape as squre


public class SqureShape{
public static void Main(){
int row,col=5;
row=col;
for(int i=1;i<=row;i++){
	for(int j=1;j<=col;j++){
	Console.Write(" * "); //Create Columns in same line and until loop terminate	
	}
	Console.WriteLine(" ");	//Each time create new Row Until look terminate
				
	}
}
}