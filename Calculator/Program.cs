using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Digite a contaque você deseja fazer:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair ");
            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção");
            int resultado=int.Parse(Console.ReadLine());

            switch(resultado)
            {
                case 1: Soma();
                break;
                case 2: Subtracao(); 
                break;
                case 3: Divisao();
                break;
                case 4: Multiplicacao();
                break;
                case 5: System.Environment.Exit(0);break;

            }
        }


        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos resultados é :" + (primeiroValor + segundoValor));
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da subtração é:" + (primeiroValor - segundoValor));
            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Número:");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("A divisão é:" + (primeiroValor / segundoValor));
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("A multiplicação é: " + (primeiroValor * segundoValor));
            Console.ReadKey();
            Menu();
        }
    }
}