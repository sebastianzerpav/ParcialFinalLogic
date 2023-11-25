using System.Drawing;

public class ParcialFinal
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Hola!");
        Console.WriteLine("¿Cuántas filas tendrá la matriz?");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Cuántas columnas tendrá la matriz?");
        int n = int.Parse(Console.ReadLine());

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

        Console.WriteLine();

        for (int f = 0; f < m; f++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write(juego[f, c] + "\t");
            }
            Console.WriteLine();
        }

        bool escPresionado = false;

        while(escPresionado == false)
        {
            ConsoleKeyInfo teclaPresionada;

            Console.WriteLine("Usa las teclas de dirección para sumar, al cero, el número en la dirección indicada");
            Console.WriteLine("Presiona la tecla Esc para salir");

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