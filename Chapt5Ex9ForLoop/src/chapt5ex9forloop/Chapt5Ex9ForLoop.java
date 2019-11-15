/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package chapt5ex9forloop;

import java.util.Scanner;

/**
 *
 * @author jmmcclain600
 */
public class Chapt5Ex9ForLoop {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    int Total=0; 
    int TotalSquared=0;
Scanner Num= new Scanner(System.in);
System.out.println("Enter first Number");
int Num1= Num.nextInt();
System.out.println("Enter Second Number");
int Num2= Num.nextInt();
while (Num1>Num2)
{
System.out.println("First number is larger.");
System.out.println("Please enter a number");
Num1=Num.nextInt();
System.out.println("Pease enter a next number");
Num2=Num.nextInt();

}
int initial=Num1;
System.out.println();
System.out.println("The Odd Number between" + Num1 + "and"+ Num2 + "are" );
for (Num1=Num1; Num1<Num2; Num1++)
{if ((Num1%2)==1)
{
System.out.println(Num1);
}
}
System.out.println();
Num1=initial;
for (Num1=Num1; Num1<=Num2; Num1++)
{
if((Num1%2)==0);
{
    Total+=Num1;
}
}
System.out.println("The Total of the Even numbers are:" + Total);

for (int i=1; i<=10; i++)
{
    System.out.println(i+ "   "+(i*i));
    TotalSquared+=i*i;
    
}
System.out.println();
System.out.println("The Sum oof the sqaures of Odd Numbers:"+TotalSquared);
for (char letter= 'A'; letter<= 'Z'; letter++)
{
    System.out.print(letter+" ");
    
}
    }
}