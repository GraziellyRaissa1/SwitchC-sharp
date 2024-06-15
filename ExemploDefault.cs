using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A defaultpalavra-chave é opcional e especifica algum código a ser executado se não houver correspondência de maiúsculas e minúsculas:

namespace SwitchC_sharp
{
    internal class ExemploDefault
    {
        public static void Main(string[] args)
        {
            int data = 4;
            switch (data)
            {
                case 1:
                    Console.WriteLine("Eu prefiro Natal.");
                    break;
                case 2:
                    Console.WriteLine("Eu prefiro Páscoa.");
                    break;
                default:
                    Console.WriteLine("Eu prefiro Ano Novo. ");
                    break;
            }
        }
    }
}
