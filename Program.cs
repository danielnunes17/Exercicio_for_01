/*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.
Entrada: 8 ------ Saida: 1,3,5,7*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero inteiro: \n");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < numero; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine(i);
        }
    }
}