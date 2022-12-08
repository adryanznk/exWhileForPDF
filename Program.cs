using System;

namespace Aula_5_18_11_exercícios_PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            //While - Atividade 1
            double x = 1;
            double y = 1;

            while ((x != 0) && (y != 0))
            {
                Console.WriteLine("Insira um valor para X e outro para Y: ");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());

                if ((x > 0) && (y > 0)) { Console.WriteLine("Primeiro."); }
                else if ((x < 0) && (y > 0)) { Console.WriteLine("Segundo."); }
                else if ((x < 0) && (y < 0)) { Console.WriteLine("Terceiro."); }
                else if ((x > 0) && (y < 0)) { Console.WriteLine("Quarto."); }
            }

            //While - Atividade 2
            int x = 0;
            int a = 0;
            int g = 0;
            int d = 0;

            while (x != 4)
            {
                Console.WriteLine("Informe o tipo de combustível abastecido, sendo \n" +
                    "1. Álcool  2. Gasolina  3. Diesel  4. SAIR");
                x = int.Parse(Console.ReadLine());

                if (x == 1) { a = a + 1; }
                else if (x == 2) { g = g + 1; }
                else if (x == 3) { d = d + 1; }
            }
            Console.WriteLine("MUITO OBRIGADO! \n" +
                "Álcool: " + a + "\n" +
                "Gasolina: " + g + "\n" +
                "Diesel: " + d);

            //For - Atividade 1
            Console.WriteLine("Informe um valor inteiro para X (1<= x <= 1000): ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //For - Atividade 2
            int fora = 0;
            int dentro = 0;

            Console.WriteLine("Quantos valores você deseja informar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe um valor: ");
                int x = int.Parse(Console.ReadLine());

                if ((x >= 10) && (x <= 20)) { dentro = dentro + 1; }
                else { fora = fora + 1; }
            }
            Console.WriteLine(dentro + " in \n" +
                fora + " out");

            //For - Atividade 3
            Console.WriteLine("Informe o número de casos de teste: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe os três valores: ");
                double v1 = double.Parse(Console.ReadLine());
                double v2 = double.Parse(Console.ReadLine());
                double v3 = double.Parse(Console.ReadLine());

                Console.WriteLine("\n" + ((v1 * 2 + v2 * 3 + v3 * 5) / (2 + 3 + 5)).ToString("F1") + "\n");
            }

        }
    }
}
