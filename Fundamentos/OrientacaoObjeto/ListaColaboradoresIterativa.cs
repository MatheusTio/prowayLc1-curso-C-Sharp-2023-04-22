using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjeto
{
    internal class ListaColaboradoresIterativa
    {

        public void CalcularFolhasPagamento()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            Console.WriteLine("Nome: ");
            folhaPagamento.NomeColaborador = Console.ReadLine().Trim();
            Console.WriteLine("Quantidade de horas: ");
            folhaPagamento.QuantidadeHoras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor Hora: ");
            folhaPagamento.ValorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($@"Folha de pagamento{folhaPagamento.NomeColaborador}
            
            Salário Bruto: {folhaPagamento.CalcularSalarioBruto()}
            INSS: {folhaPagamento.CalcularInss()}");
        
        }
    }
}
