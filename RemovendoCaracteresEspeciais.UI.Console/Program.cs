using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovendoCaracteresEspeciais.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escreva um nome com acento, para que possamos retirar os acentos: ");
            var userTextScreen = System.Console.ReadLine();
            var result = new RemoveCharacteres().RemoveEspecialCharecteres(userTextScreen);
            System.Console.WriteLine("Você digitou o seguinte texto sem acento: "+ result);
            System.Console.ReadLine();
        }
    }
}
