using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormExemplo.OrientacaoObjeto
{
    internal class FolhaPagamento
    {

        //Propriedades
        public string NomeColaborador;
        public double ValorHora;
        public int QuantidadeHoras;

        private const double aliquotaInss7MeioPorcento = 0.075;
        private const double aliquotaInss9Porcento = 0.09;
        private const double aliquotaInss12Porcento = 0.12;
        private const double aliquotaInss14Porcento = 0.14;

        //Método com retorno sem parâmetros = comportamentos
        public double CalcularSalarioBruto()
        {
            
             double salarioBruto = ValorHora * QuantidadeHoras;
           
            return salarioBruto;

        }

        public double CalcularInss()
        {
            double salarioBruto = CalcularSalarioBruto();
            double aliquota = ObterAliquota(salarioBruto);

            return salarioBruto * aliquota;
        }

        private double ObterAliquota(double salarioBruto)
        {
            if (salarioBruto <= 1_320.00)
            {
                return aliquotaInss7MeioPorcento;
            }
            if (salarioBruto <= 2_571.29)
            {
                return aliquotaInss9Porcento;
            }
            if (salarioBruto <= 3_856.94)
            {
                return aliquotaInss12Porcento;
            }
            return aliquotaInss14Porcento;
        }
    }
}
