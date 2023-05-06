using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjeto
{
    internal class ListaColaboradores
    {
        public void CalculadrFolhasPagamento() 
        {

            //Objeto jose intancia da classe FolhaPagamento    
            FolhaPagamento jose = new FolhaPagamento();
            jose.NomeColaborador = "José";
            jose.QuantidadeHoras = 160;
            jose.ValorHora = 60.00;
            double salarioJose = jose.CalcularSalarioBruto();
            double inssJose = jose.CalcularInss();

            FolhaPagamento Matheus = new FolhaPagamento();
            Matheus.NomeColaborador = "José";
            Matheus.QuantidadeHoras = 250;
            Matheus.ValorHora = 60.00;
            double salarioMatheus = Matheus.CalcularSalarioBruto();
            double inssMatheus = Matheus.CalcularInss();

            FolhaPagamento Francisco = new FolhaPagamento();
            Francisco.NomeColaborador = "José";
            Francisco.QuantidadeHoras = 160;
            Francisco.ValorHora = 14.00;
            double salarioFrancisco = Francisco.CalcularSalarioBruto();
            double inssFrancisco = Francisco.CalcularInss();


            Console.WriteLine($@"Folha Pagamento {Francisco.NomeColaborador}
            Salário Líquido: {salarioFrancisco}

            Folha Pagamento: {Matheus.NomeColaborador}
            Salário Líquido: {salarioMatheus}

            Folha Pagamento: {jose.NomeColaborador}
            Salário Líquido: {salarioJose}");
                
        }
    }
}
