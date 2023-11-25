using System.Drawing;

public class ParcialFinal
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("¡Hola!");
        Console.WriteLine("¡Juguemos!");
        Console.WriteLine("\nPrimero vamos a crear una matriz");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n¿Cuántas filas quieres que tenga la matriz?");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Cuántas columnas quieres que tenga la matriz?");
        int n = int.Parse(Console.ReadLine());
        Console.Clear();

        int[,] juego = new int[m, n];
        int posicionX = 0, posicionY = 0;

        Random num = new Random();

        for (int f = 0; f < m; f++)
        {
            for (int c = 0; c < n; c++)
            {
                juego[f, c] = num.Next(1, 10);
            }
        }
        juego[posicionX, posicionY] = 0;

        for (int f = 0; f < m; f++)
        {
            for (int c = 0; c < n; c++)
            {
                if (f == posicionX && c == posicionY)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(juego[f, c] + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(juego[f, c] + "\t");
                }
            }
            Console.WriteLine();
        }

        bool escPresionado = false;

        while(escPresionado == false)
        {
            ConsoleKeyInfo teclaPresionada;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n¡DESCUBRE EL VALOR TOTAL DE LA SUMA DE TODOS LOS ELEMENTOS DE LA MATRIZ!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El color verde indica la posición donde te encuentras; si te mueves hacia alguna dirección," +
                " sumarás al cero el número al que te dirijas.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Usa las teclas de dirección.");
            Console.WriteLine("En cualquier momento, presiona la tecla Esc si quieres finalizar el juego.");
            Console.ResetColor();

            teclaPresionada = Console.ReadKey();

            Console.Clear();

            switch (teclaPresionada.Key)
            {
                
                case ConsoleKey.RightArrow:
                    if (posicionY < n - 1)
                    {
                        int aux = juego[posicionX, posicionY];
                        juego[posicionX, posicionY] = 0;
                        juego[posicionX, posicionY + 1] += aux;
                        posicionY++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (posicionY > 0)
                    {
                        int aux = juego[posicionX, posicionY];
                        juego[posicionX, posicionY] = 0;
                        juego[posicionX, posicionY - 1] += aux;
                        posicionY--;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (posicionX > 0)
                    {
                        int aux = juego[posicionX, posicionY];
                        juego[posicionX, posicionY] = 0;
                        juego[posicionX - 1, posicionY] += aux;
                        posicionX--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (posicionX < m - 1)
                    {
                        int aux = juego[posicionX, posicionY];
                        juego[posicionX, posicionY] = 0;
                        juego[posicionX + 1, posicionY] += aux;
                        posicionX++;
                    }
                    break;
                case ConsoleKey.Escape:
                    escPresionado = true;
                    break;
            }

            for (int f = 0; f < m; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (f == posicionX && c == posicionY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(juego[f, c] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(juego[f, c] + "\t");
                    }
                }
                Console.WriteLine();
            }

        }
    }
    
}