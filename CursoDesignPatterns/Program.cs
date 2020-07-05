using CursoDesignPatterns.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Inicio - Strategy
            //Imposto ISS = new ISS();
            //Imposto ICMS = new ICMS();
            //Orcamento orcamento = new Orcamento(500.0);
            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, ISS);
            //calculador.RealizaCalculo(orcamento, ICMS);

            //Console.ReadKey();
            ////Fim - Strategy
            ///

            //Inicio - Chain of Responsability
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Videogame", 250));
            orcamento.AdicionaItem(new Item("Controle", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("Televisao", 250));
            orcamento.AdicionaItem(new Item("Celular", 250));
            orcamento.AdicionaItem(new Item("Patinete", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();
            //Fim - Strategy
        }
    }
}
