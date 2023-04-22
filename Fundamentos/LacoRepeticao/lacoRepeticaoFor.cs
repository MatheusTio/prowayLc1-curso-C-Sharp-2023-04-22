using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class lacoRepeticaoFor
    {



        // metodo publico sem retorno e sem parametro
        public void Executar()
            {

            Exemplo01();
            Exemplo02();
        
            }

        // metodo privado sem retorno e sem parametro
        private void Exemplo01()
        {
            //int indice = 0;
            //while (indice < 5) 
            //{
            //    Console.WriteLine("Oie");
            //    //incrementando a variavel indice
            //    indice = indice + 1;

            
            //for (declaraçao da variavel; condição para execução do for:incremento)
            for (int indice = 0; indice < 5; indice = indice + 1)
                {
                Console.WriteLine("Oie");
                }
            
        }
        // metodo privado sem retorno e sem parametro
        private void Exemplo02()
        {



        }

    }
}
