using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2__Djalma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, insira uma data no formato DD/MM/AAAA: ");

            int mes;
            string cidade = "";
            var data_atual = Convert.ToDateTime(Console.ReadLine()); int cont;
            string mesextesno = null;

            Console.WriteLine();

            int dia = data_atual.Day;
            int ano = data_atual.Year;

            Console.Write("Selecione uma das cidades:\n\n1 - Atibaia\n2 - Bragança Paulista\n3 - Mairiporã" +
                "\n4 - Nazaré\n5 - Terra Preta\n6 - Extrema\n7 - Vargem \n->");

            cont = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (cont)
            {
                case 1:
                    cidade = "Atibaia";
                    break;

                case 2:
                    cidade = "Bragança Paulista";
                    break;

                case 3:
                    cidade = "Mairiporã";
                    break;

                case 4:
                    cidade = "Nazaré";
                    break;

                case 5:
                    cidade = "Terra Preta";
                    break;

                case 6:
                    cidade = "Extrema";
                    break;

                case 7:
                    cidade = "Vargem";
                    break;

            }

            dia = data_atual.Day;
            mes = data_atual.Month;
            ano = data_atual.Year;

            switch (mes)
            {
                case 1:
                    mesextesno = "Janeiro";
                    break;
                case 2:
                    mesextesno = "Fevereiro";
                    break;
                case 3:
                    mesextesno = "Março";
                    break;
                case 4:
                    mesextesno = "Abril";
                    break;
                case 5:
                    mesextesno = "Maio";
                    break;
                case 6:
                    mesextesno = "Junho";
                    break;
                case 7:
                    mesextesno = "Julho";
                    break;
                case 8:
                    mesextesno = "Agosto";
                    break;
                case 9:
                    mesextesno = "Setembro";
                    break;
                case 10:
                    mesextesno = "Outubro";
                    break;
                case 11:
                    mesextesno = "Novembro";
                    break;
                case 12:
                    mesextesno = "Dezembro";
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"{cidade}, {dia} de {mesextesno} de {ano}\n");

            Console.ReadKey();
        }
    }
}
