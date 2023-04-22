using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class LacoRepeticaoWhile
    {

        // Metodo sem retonrno, dica void
        // Metodo sem parametros, dica não tem variavel dentro dos ()
        public void Executar()
        {
            int opcaoDesejada = 0;

            while (opcaoDesejada != 8001)
            {

                Console.WriteLine("Escolha uma das opçoes abaixo!");
                Console.WriteLine(
                    "\n1 - Exemplo 01" +
                    "\n2 - Exemplo 02" +
                    "\n3 - Exemplo 03" +
                    "\n8001 - Sair");

                opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                if (opcaoDesejada == 1)
                    Exemplo01();
                else if (opcaoDesejada == 2)
                    Exemplo02();
                else if (opcaoDesejada == 3)
                    Exemplo03();
                else if (opcaoDesejada == 8001)
                    Console.WriteLine("Opção Invalida");
                Console.WriteLine("Press and Key to Continue...");
                Console.ReadKey();
                Console.Clear();


            }


            Exemplo01();
            Exemplo02();
            Exemplo03();
        }

        public void Exemplo01()
            {
            int indice = 0;
            while (indice < 10) 
            {
                Console.WriteLine("Oie");
                indice = indice + 1;
            }

            Console.WriteLine("Terminou o exemplo de while");
            }


        /// <summary>
        /// Solicitar Nome e Sobrenome para o Usuario
        /// </summary>
        public void Exemplo02()
        {

            int indice = 0;
            while (indice < 3)
            {
                //Inputs = entradas
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine().Trim();

                Console.WriteLine("Sobrenome: ");
                string sobrenome = Console.ReadLine().Trim();
                //Processamento
                string nomeCompleto = nome + " " + sobrenome;

                //Output
                Console.WriteLine("Nome completo: " + nomeCompleto);
                indice = indice + 1;
            }
        }
            /// <summary>
            /// Exemplo pedir para o usuario a quantidade de notas
            /// que deseja cadrastrar, solicitando -as
            /// </summary>

            public void Exemplo03()
            {

            Console.WriteLine("Digite a qauntidade de notas que deseja registrar: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

            int indice = 0;

            //while (indice <= quantidadeDesejada - 1)

            double somaNotas = 0, maiorNota = 0, menorNota = 8001;

            while (indice < quantidadeDesejada)
            {

                Console.WriteLine("Nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                somaNotas = somaNotas + nota;

                if (nota > maiorNota)
                    maiorNota = nota;

                if (nota < menorNota)
                    menorNota = nota;

                //Incrementar em 1
                indice = indice + 1;
            
            }

            // /n é utilizado para qeubrar a linha 
            double media = somaNotas / quantidadeDesejada;
            Console.WriteLine(
                "Media: "+ media +
                "\nMaior nota: " + maiorNota +
                "\nMenor nota: "+menorNota);
            }
        }
    }

