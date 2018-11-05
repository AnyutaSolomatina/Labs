using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static double rez, a, b;
        static string _operator;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите первый операнд");
                operand1();
                Console.WriteLine("Введите второй операнд");
                operand2();
                Console.WriteLine("Введите операцию");
                Operazia();
                switch (_operator)
                {
                    case "+": Slojenie(); break;
                    case "-": Vichitanie(); break;
                    case "/": Delenie(); break;
                    case "*": Umnojenie(); break;
                }
                Console.WriteLine(rez);
                Console.WriteLine("Введите exit для выхода или enter для продолжения  вычислений");
            } while (Console.ReadLine() != "exit");
        }



        private static void operand1()
        {
            a = Double.Parse(Console.ReadLine());
        }

        private static void operand2()
        {
            b = Double.Parse(Console.ReadLine());
        }

        private static void Operazia()
        {
            _operator = Console.ReadLine();
        }

        private static void Slojenie()
        {
            rez = a + b;
        }
        private static void Vichitanie()
        {
            rez = a - b;
        }
        private static void Delenie()
        {
            rez = a / b;
        }
        private static void Umnojenie()
        {
            rez = a * b;
        }
    }
}
