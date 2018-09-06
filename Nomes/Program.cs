using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            string[] N = new string[] { "André", "Romário", "Adamastor", "Astrogildo", "Robervaldo", "Juriscleison", "Jair", "Eduardo", "General", "Kleide" };
            string[] NM = new string[] { "Messias", "Silva", "Oliveira", "Juz", "Alex", "Claudio", "José", "Sei la", "nao sei", "ainda" };
            string[] SN = new string[] { "Bolsonaro", "Inácio", "da Silva", "Roberval", "Adan", "Gomes", "Bonner", "Vasconcelos", "Aleatorio", "kliu" };

            Pessoa[] p = new Pessoa[100];
            Random rnd = new Random();

            for (int i = 0; i < p.Length; i++)
            {
                string NC = N[rnd.Next(10)] + " " + NM[rnd.Next(10)] + " " + SN[rnd.Next(10)];
                var codigo = "2017" + (i + 1).ToString();
                p[i] = new Pessoa(Int32.Parse(codigo), NC);
                Console.WriteLine(p[i].codigo.ToString() + " - " + p[i].nome);
            }

            Console.WriteLine("");
            Console.WriteLine("Insira o nome a procurar");
            string texto = Console.ReadLine();

            for(int i =0; i < p.Length; i++)
            {
                if(p[i].nome.Contains(texto))
                {
                    Console.WriteLine(p[i].codigo + " | " + p[i].nome);
                }
            }

            Console.Read();
           
        }
    }
}