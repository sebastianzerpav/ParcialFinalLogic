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


        Console.WriteLine();
        bool escPresionado = false;

        while(escPresionado)
        {

        }
    }
    
}