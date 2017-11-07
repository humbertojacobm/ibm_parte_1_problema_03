using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01Problema03
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------
            //DECLARACION DE VARIABLES
            //--------------------------------------
            const string ReadyWord = "LISTO";
            const string ExitWord = "SALIR";
            const string MessageOnlyPositiveNumber = "Debe ingresar solamente números positivos";
            List<double> coins = new List<double>();
            List<double> amounts = new List<double>() { 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200 };

            MoneyParts _moneyParts = new MoneyParts();
            double Number = 0;

            //--------------------------------------
            //INICIO DEL PROGRAMA
            //--------------------------------------
            Console.WriteLine("INSTRUCCIONES");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("01. Siempre presione ENTER para avanzar");
            Console.WriteLine("02. Para salir del programa escriba SALIR (respete las mayúsculas)");
            Console.WriteLine("03. Ingrese números, presione ENTER para agregar al arreglo");            
            Console.WriteLine("-------------------------------------");

            string word = Console.ReadLine();            

            while (word != ReadyWord)
            {
                if (ExitWord == word)
                {
                    break;
                }                
                Number = 0;

                bool ResultOfCast = double.TryParse(word, out Number);

                if (ResultOfCast)
                {
                    if (Number > 0)
                    {                        
                        word = word.Replace('.', ',');
                        _moneyParts.Built(coins, amounts, 0, 0, Convert.ToDouble(word));
                    }
                    else
                    {
                        Console.WriteLine(MessageOnlyPositiveNumber);
                    }
                }
                else
                {
                    Console.WriteLine(MessageOnlyPositiveNumber);
                }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Fin de la instrucción");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Ingrese el siguiente número");
                word = Console.ReadLine();
            }

            GoOut();

        }        

        static void GoOut()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("GRACIAS POR UTILIZAR EL PROGRAMA, para salir presione alguna tecla");
            Console.ReadKey();
        }
    }
}
