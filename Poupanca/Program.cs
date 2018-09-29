using System;

namespace Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca poupador1 = new ContaPoupanca(2000M);
            ContaPoupanca poupador2 = new ContaPoupanca(3000M);
            decimal saldoPoupador1 = 0.0M;
            decimal saldoPoupador2 = 0.0M;

            // Altera taxa de juros da poupança de todos correntistas
            Console.WriteLine("Taxa de Juros = 4%");
            ContaPoupanca.AlterarTaxaDeJuros(0.04);

            // Calcula saldo mensal para a nova taxa de juros
            saldoPoupador1 = poupador1.CalcularJurosMensal();
            saldoPoupador2 = poupador2.CalcularJurosMensal();
            Console.WriteLine("   Poupador 1 = {0:C}", saldoPoupador1);
            Console.WriteLine("   Poupador 2 = {0:C}", saldoPoupador2);


            Console.WriteLine("\nTaxa de Juros = 5%");
            ContaPoupanca.AlterarTaxaDeJuros(0.05);

            saldoPoupador1 = poupador1.CalcularJurosMensal();
            saldoPoupador2 = poupador2.CalcularJurosMensal();
            Console.WriteLine("   Poupador 1 = {0:C}", saldoPoupador1);
            Console.WriteLine("   Poupador 2 = {0:C}", saldoPoupador2);


            Console.Write("\n\nPressione qualquer tecla para sair . . .");
            Console.ReadKey(true);

        } // Fim do método Main

    } // Fim da classe Program

} // Fim do namespace Poupanca
