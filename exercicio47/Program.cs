using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria
{/* Solicite os seguintes dados de uma conta bancária:
Saldo do cliente : Double ( não pode ser negativo)
Limite de cheque especial: Double. (não pode ser negativo)
Então, seu programa deverá entrar em um loop, solicitando as seguintes opção ao cliente:
“D” depósito
“S” saque
“V” visualizar o saldo
“X” sair do programa
Caso o usuário tenha escolhido “D”epósito, de vê-se acrescentar o valor ao saldo do cliente.
Caso o usuário tenha escolhido “S”aque, de vê-se subtrair o valor do saldo do cliente. O saldo pode ficar negativo
até o limite de cheque especial.
Caso o usuário tenha solicitado “V”isualizar o saldo, exiba o saldo no vídeo.
Caso o usuário tenha solicitado para sair do programa, saia do loop e termine a aplicação. */
    class Program
    {

        public static double Deposito(ref double saldo)
        {
            Console.WriteLine("Digite o valor do depósito");

            saldo += double.Parse(Console.ReadLine());
            return saldo;
        }

        public static void Saque(ref double saldo,double limite)
        {
            Console.WriteLine("Digite o valor do saque");
            double operacao = double.Parse(Console.ReadLine());
            if (saldo + operacao > limite)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Operação invalida, saque maior que o limite de crédito");
                Console.ResetColor();
            }
            else
                saldo -= operacao;
        }
           

           




        static void Main(string[] args)
        {
            double Saldo = 0;
            double Limite = 0;
            bool resp = true;
            if (Saldo <= 0 || Limite <= 0)
            {
                do
                {
                    Console.WriteLine("Digite um saldo maior que zero");
                    Saldo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite um limite maior que zero");
                    Limite = double.Parse(Console.ReadLine());
                }
                while (Saldo <= 0 || Limite <= 0);
            }
            
            do
            {
                Console.WriteLine("“D” depósito \n “S” saque \n “V” visualizar o saldo \n “X” sair do programa ");
                string opc = Console.ReadLine();
                switch (opc.ToUpper())
                {
                    case "D":
                        Console.Clear();
                       
                        Deposito(ref Saldo);
                        break;

                    case "S":
                        Console.Clear();
                        Saque(ref Saldo,Limite);
                        break;

                    case "V":
                        Console.Clear();
                        Console.WriteLine($"Seu saldo é de {Saldo.ToString("C2")}");
                        break;
                    case "X":
                        Console.WriteLine("FIM");
                        resp = false;
                        break;
                    default:

                        break;

                }

            }
            while (resp);
        }
    }
}
