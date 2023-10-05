

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        
        Task1_a(5);
        Console.WriteLine($"cem:{Task1_b(5)}");
    }
    
    static void Task1_a(int b){
        int sum = 0;
        for(int i = 0; i < b; i++){
            if(i % 2 == 0){
             sum += i;   
            }
        }
        Console.WriteLine($"Cem:{sum}");
    }
    
    static int Task1_b(int b){
        int sum = 0;
        for(int i = 0; i < b; i++){
            if(i % 2 == 0){
             sum += i;   
            }
        }
       return sum;
    }
}
