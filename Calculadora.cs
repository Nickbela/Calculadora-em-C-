using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculadora  //classe
    {
        static void Main(string[] args) //método principal
        {
            Console.WriteLine(@"
        ░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
        ██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
        ██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░██║██║░░██║██████╔╝███████║
        ██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
        ╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
        ░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝");

            Console.WriteLine("Escolha a operação que deseja realizar");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");

            int respMenu;
            respMenu = Convert.ToInt32(Console.ReadLine());

            int num1;
            int num2;

            Console.WriteLine("Digite dois números: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (respMenu)
            {
                case 1:
                    Console.Write("O valor da soma dos número é: ");
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.Write("O valor da subtração dos números é:");
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.Write("O valor da multiplicação dos números é:");
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Não é possível realizar divisão com zero");
                    }
                    else
                    {
                        Console.Write("O valor da divisão dos números é:");
                        Console.WriteLine(num1 / num2);
                    }
                    break;
            }
            Console.ReadLine();

            //métodos adicionais são escritos abaixo do main
        }
    }
}