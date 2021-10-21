using System;

namespace ProvaGama_XP
{
    class Program
    {
        static void Main(string[] args)
        {


            int valorSaque;
            Console.WriteLine("Qual o valor que deseja sacar? ");
            valorSaque = int.Parse(Console.ReadLine());

            var qtdNotaCem = 0;
            var qtdNotaCinquenta = 0;
            var qtdNotaVinte = 0;
            var qtdNotaDez = 0;
            var qtdNotaCinco = 0;

            var notaCem = new NotaCem();
            var notaCinquenta = new NotaCinquenta();
            var notaVinte = new NotaVinte();
            var notaDez = new NotaDez();
            var notaCinco = new NotaCem();
            
            while (valorSaque >= notaCem.Valor)
            {
                valorSaque = valorSaque - 100;
                qtdNotaCem++;
            }
            while (valorSaque >= notaCinquenta.Valor)
            {
                valorSaque = valorSaque - 50;
                qtdNotaCinquenta++;
            } 
            while (valorSaque >= notaVinte.Valor)
            {
                valorSaque = valorSaque - 20;
                qtdNotaVinte++;
            }
            while (valorSaque >= notaDez.Valor)
            {
                valorSaque = valorSaque - 10;
                qtdNotaDez++;
            }
            while (valorSaque >= notaCinco.Valor)
            {
                valorSaque = valorSaque - 5;
                qtdNotaCinco++;
            }

        }

    }
}
