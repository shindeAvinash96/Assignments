using System;

public class ReverseNum{
	public static void Main(String [] args){

	int num=109,rev=0,ld=0,original=num;

	while(num>0){

	ld=num%10;
	rev=(rev*10)+ld;
	num/=10;
	
}

Console.Write("Reversed Number of "+original+" is"+ rev);



}
}