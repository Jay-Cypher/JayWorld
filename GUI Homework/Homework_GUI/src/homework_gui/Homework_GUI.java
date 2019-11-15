/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package homework_gui;

/**
 *
 * @author TG
 */
import javax.swing.JOptionPane;
public class Homework_GUI {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        double Total, Yrs, Interest, Calc, Calc1, Cacl2;
            String Totalstring, Yrsstring, InterestStr, CalculationStr;
        
        Totalstring=
                JOptionPane.showInputDialog ("Please enter the amount of money");
        Total = Double.parseDouble (Totalstring);
        
        Yrsstring = 
                JOptionPane.showInputDialog ("Now, enter the years of interest period");
        Yrs = Double.parseDouble (Yrsstring);
        
        InterestStr =
                JOptionPane.showInputDialog ("Enter the rate of the interest");
        Interest = Double.parseDouble (InterestStr);
        
        Calc = 1 + Interest;
        Calc1 = Math.pow (Calc,Yrs);
        Cacl2 = Total * Calc1;
        
        CalculationStr =  "Amount: $" + Total + "\n" +
                 " Years: " + Yrs + "\n" +
                 " Interest: $" + Interest + "\n" +
                 " Total Maturity $" + Cacl2 + "\n";
        
        JOptionPane.showMessageDialog(null, CalculationStr, "Rectangle", JOptionPane.INFORMATION_MESSAGE);
        
        
    }
    
}
