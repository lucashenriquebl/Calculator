namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("1 - para Soma");
            Console.WriteLine("2 - para Subtração");
            Console.WriteLine("3 - para Multiplicação");
            Console.WriteLine("4 - para Divisão");
            Console.WriteLine("5 - para Porcentagem");
            Console.WriteLine("0 - para Sair");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Selecine uma opcão:");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Porcentagem(); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("");

            Console.WriteLine($"O Resultado da soma entre {v1} + {v2} = {resultado}");

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração entre {v1} - {v2} = {resultado}");

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 * v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação entre {v1} x {v2} = {resultado}");

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 / v2;

            Console.WriteLine("");

            Console.WriteLine($"O Resultado da divisão entre {v1} / {v2} = {resultado}");

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Digite a porcentagem:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor:");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 * v2 / 100;

            Console.WriteLine("");

            Console.WriteLine($"{v1}% de {v2} = {resultado}");

            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}