using System;

namespace calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator(); // criando um objeto (chamando uma class)
            Console.WriteLine($"--------------------Calculadora--------------------");
            int operation;
            double number00, number01;

            do
            {
                Console.WriteLine($"\nEscolha a operação:\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Potenciação\n0 - Encerrar");
                operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número:");
                        number00 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        number01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado da soma:\n {number00} + {number01} = {calc.Somar(number00, number01)} \n");
                        Console.WriteLine("--------------------------------------------------------------");
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número:");
                        number00 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        number01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado da subtração:\n {number00} - {number01} = {calc.Subtrair(number00, number01)} \n");
                        Console.WriteLine("--------------------------------------------------------------");
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número:");
                        number00 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        number01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado da multiplicação:\n {number00} x {number01} = {calc.Multiplicar(number00, number01)} \n");
                        Console.WriteLine("--------------------------------------------------------------");
                        break;

                    case 4:
                        Console.WriteLine("Digite o dividendo:");
                        number00 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o divisor:");
                        number01 = Convert.ToDouble(Console.ReadLine());
                        try // força uma tentativa
                        {
                            Console.WriteLine($"Resultado da divisão:\n {number00} ÷ {number01} = {calc.Dividir(number00, number01)}\n");
                        }
                        catch (DivideByZeroException e) // erro
                        {
                            Console.WriteLine($"Erro: {e.Message}");
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        break;

                    case 5:
                        Console.WriteLine("Digite o número base:");
                        number00 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o expoente:");
                        number01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado da potência:\n {number00}^{number01} = {calc.Potenciar(number00, number01)}\n");
                        Console.WriteLine("--------------------------------------------------------------");
                        break;

                    case 0:
                        Console.WriteLine("--------------------Calculadora Encerrada--------------------");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente!\n");
                        break;
                }

            } while (operation != 0);
        }
    }
}
