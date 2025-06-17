using System;

public class ArmStrongnumber{

	public static void Main(String [] args){
int n = 53, num,arm=0,original=n;

while (n > 0)
{
    num = n % 10;
    arm+= (num*num*num);
	n/=10;
}
if (arm == original) {

    Console.Write("number"+ original+" is an Armstrong number");
}else{
Console.WriteLine(original+ " is Not armstrong number");
}



}
}