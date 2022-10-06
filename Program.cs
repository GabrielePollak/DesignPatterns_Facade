using System;

namespace PFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new TaxiFacade();
            int opc;

            Console.WriteLine("             ----------------------PEDIDOS DE CARROS----------------------------                \n");

           


            do
            {
                Console.WriteLine("Informe a opção desejada:\n1-Carro convencional.\n2-Carro confort.\n\nOpção: ");
                opc = int.Parse(Console.ReadLine());

            } while (opc < 1 || opc > 2);


            if (opc == 1)
            {
                facade.BuscarCarroConvencional();
            }
            else
            {
                facade.BuscarCarroConfort();
            }




        }
    
    }
}
