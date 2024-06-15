using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*A switchexpressão é avaliada uma vez
O valor da expressão é comparado com os valores de cadacase
Se houver uma correspondência, o bloco de código associado será executado
As palavras-chave breake defaultserão descritas posteriormente neste capítulo

O exemplo abaixo usa o número do dia da semana para calcular o nome dos animais:*/


namespace SwitchC_sharp
{
    internal class Exemplo01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 7:");

            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Gato");
                    break;
                case 2:
                    Console.WriteLine("Cachorro");
                    break;
                case 3:
                    Console.WriteLine("Galinha");
                    break;
                case 4:
                    Console.WriteLine("Coelho");
                    break;
                case 5:
                    Console.WriteLine("Elefante");
                    break;
                case 6:
                    Console.WriteLine("Borboleta");
                    break;
                case 7:
                    Console.WriteLine("Arara");
                    break;
            }
        }
    }
}
