using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite o Primeiro Número:");
        int x;
        x = int.Parse(Console.ReadLine());
        
       
        Console.WriteLine ("Digite o Segundo Número:");
        int y;
        y = int.Parse(Console.ReadLine());
        
        
        if (x > y) {
            Console.WriteLine("Ordem Decrescente");
        }
        else if (y > x) {
            Console.WriteLine("Ordem Decrescente");
        }
        else if (x > y) {
            Console.WriteLine("Ordem Crescente");
        }
        else if (y < x) {
            Console.WriteLine("Ordem Crescente");
        }
        
    }
}
