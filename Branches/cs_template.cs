using System;
					
public class Program
{
    
	public static void Main()
	{   
        Int varA = 1;
        Int varB = 2;
        Int varC = 3;
        Int varD = 4;   
		
        Int operationResult = operation(varA, varB, varC, varD);
        Int operation2Result = operation2(varA,VarB);
        Console.WriteLine("Result value for 1: ", op_result);
	}

    public Int operation(Int a, Int b, Int c, Int d) {
        Int result = a+b+c+d;
        return result;
    }

    public Int operation2(Int a, Int b){
        Int result = a-b;
        return result;
    }
}


