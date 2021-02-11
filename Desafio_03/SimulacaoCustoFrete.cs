using System;
using System.Collections.Generic;

namespace Desafio_03
{
    class SimulacaoCustoFrete
    {
        static void Main(string[] args)
        {
            int vagao_total = 0;
            int caminhao_total = 0;
            double custo_total = 0;

            Console.WriteLine("Quantas cargas voce deseja inserir no programa: ");
            int cont = Convert.ToInt32(Console.ReadLine());
            List<Carga> cargas = new List<Carga>();

            for(int i=0; i < cont; i++)
            {
                

                Console.WriteLine("Digite o valor da carga: ");
                double valor_carga = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o Peso da carga: ");
                double peso_carga = Convert.ToDouble(Console.ReadLine());

                var vagao = new Vagao(valor_carga, peso_carga);
                var caminhao = new Caminhao(valor_carga, peso_carga);

                if ( vagao.calculaFrete() < caminhao.calculaFrete() )
                {
                    cargas.Add(vagao);
                    vagao_total++;
                    custo_total+=vagao.calculaFrete();
                }
                else if (vagao.calculaFrete() > caminhao.calculaFrete() )
                {
                    cargas.Add(caminhao);
                    caminhao_total++;
                    custo_total+=caminhao.calculaFrete();
                }
                else
                {
                    cargas.Add(caminhao);
                    caminhao_total++;
                    custo_total+=caminhao.calculaFrete();
                }
            }

            Console.WriteLine($"Serao necessarios {caminhao_total} caminhoes, {vagao_total} vagoes e o custo total sera de R$ {custo_total}");

        }
    }
}
