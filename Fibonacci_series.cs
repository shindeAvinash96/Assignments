using System;

public class Fibonacci_series{
	public static void Main(string[] args){

	//0 1 1 2 3 5 8 13

	int f1=0,f2=1,f3,n=8;

	Console.Write(f1+" "+f2 );


	for(int i=2;i<n;i++){

	f3=f1+f2;
	Console.Write(" "+f3);
	
	f1=f2;
	f2=f3;
}
	
}
}