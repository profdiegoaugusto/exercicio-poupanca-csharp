using System;

namespace Poupanca
{
    class ContaPoupanca
    {
        private decimal saldoPoupanca;
        private static double taxaDeJurosAnual;

        private const int MESES = 12;

        /// <summary>
        /// Cria uma nova conta poupança
        /// </summary>
        public ContaPoupanca()
        {
            saldoPoupanca = 0.0M;
            taxaDeJurosAnual = 0.0;
        }

        /// <summary>
        /// Cria uma nova conta poupança
        /// </summary>
        /// <param name="saldoPoupanca">O valor do saldo da poupança</param>
        public ContaPoupanca(decimal saldoPoupanca)
        {
            this.saldoPoupanca = saldoPoupanca;
            taxaDeJurosAnual = 0.0;
        }

        /// <summary>
        /// Pega ou configura o saldo atual da poupança
        /// </summary>
        public decimal Saldo
        {
            get { return saldoPoupanca; }
            set { saldoPoupanca = value; }
        }

        /// <summary>
        /// Pega ou configura a taxa de juros atual da poupança
        /// </summary>
        public static double TaxaJuros
        {
            get { return taxaDeJurosAnual; }
            set { taxaDeJurosAnual = value; }
        }

        /// <summary>
        /// Calcula o juros mensais da poupança acrescidos do saldo atual
        /// </summary>
        /// <returns>O valor decimal do novo saldo dos poupadores</returns>
        public decimal CalcularJurosMensal()
        {
            decimal jurosMensal = (saldoPoupanca * (decimal)taxaDeJurosAnual) / MESES;
            return jurosMensal + saldoPoupanca;
        }

        /// <summary>
        /// Altera a taxa de juros da conta poupança
        /// </summary>
        /// <param name="taxaDeJuros">Novo valor double para taxa de Juros</param>
        public static void AlterarTaxaDeJuros(double taxaDeJuros)
        {
            taxaDeJurosAnual = taxaDeJuros;
        }

    } // Fim da classe ContaPoupanca

} // Fim do namespace Poupanca
