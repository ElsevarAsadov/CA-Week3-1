

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        
        Console.WriteLine(Task2("Hello World Yo"));
    }
    
    static string Task2(string x){
        string noSpace = String.Empty;
        for(int i = 0; i < x.Length; i++){
            if(x[i] != ' '){
                noSpace += x[i];
            }
        }
        return noSpace;
    }
}
