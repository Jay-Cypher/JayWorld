/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package homework2.calc;
import java.util.Scanner;
/**
 *
 * @author jmmcclain600
 */
public class HomeWork2Calc {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        double Number1, Number2;
        Scanner Calc = new Scanner(System.in);
        System.out.print("Enter the first number:");
        Number1 = Calc.nextDouble();
        System.out.print("Enter the second number:");
        Number2 = Calc.nextDouble();
        System.out.print("Enter an operator (+, -, *, /): ");
        char operator = Calc.next().charAt(0);
          Calc.close();
        double output;

        switch(operator)
        {
            case '+':
            	output = Number1 +  Number2;
                System.out.println(Number1+" "+operator+" "+Number2+": "+output);
                break;

            case '-':
            	output =  Number1 -  Number2;
                System.out.println(Number1+" "+operator+" "+Number2+": "+output);
                break;

            case '*':
            	output =  Number1 *  Number2;
                System.out.println(Number1+" "+operator+" "+Number2+": "+output);
                break;

            case '/':
            	
             if (Number2==0) 
             {
                 System.out.println("Unable to divide by O");   
             }
           else {
                 output =  Number1 /  Number2;
                 System.out.println(Number1+" "+operator+" "+Number2+": "+output);
                 }
            
          break; 
               
         default:
         System.out.printf("You have entered wrong operator");
        
             
             
        }
     
        
        
       
  
        
}
}