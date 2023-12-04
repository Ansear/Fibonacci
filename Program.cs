using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("Seleccione el programa \n 1.Programa 1 \n 2.Programa 2 \n 3.Programa 3");
        int opc = Convert.ToInt16(Console.ReadLine());
        switch (opc)
        {
            case 1:
                Console.WriteLine("Ingrese n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int j = 0;
                int k = 1;
                for (int i = 2; i <= n; i++)
                {
                    int c = k;
                    k += j;
                    j = c;
                }
                Console.WriteLine($"F{n} = {k}");
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int a = 0;
                int b = 1;

                for (int i = 2; i <= num; i++)
                {
                    int c = b;
                    b += a;
                    a = c;
                    if (b == num)
                    {
                        Console.WriteLine($"{num} Es un numero de Fibonacci");
                        break;
                    }
                    else if (b > num)
                    {
                        Console.WriteLine($"{num} No es un numero de Fibonacci");
                        break;
                    }
                }
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int d = 0;
                int e = 1;
                for (int i = 0; i <= m; i++)
                {
                    if (i == m)
                        break;
                    Console.Write($" {d}");
                    int f = e;
                    e += d;
                    d = f;
                }
                break;
            default:
                Console.WriteLine("Valor Ingresado invalido");

                break;
        }

    }
}