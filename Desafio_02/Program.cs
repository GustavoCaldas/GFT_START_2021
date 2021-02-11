using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Digite o valor da carga do vagão: ");
            double valor_carga_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o Peso da carga do vagão: ");
            double peso_carga_1 = Convert.ToDouble(Console.ReadLine());
            
            var vagao1 = new Vagao(valor_carga_1, peso_carga_1);
            Console.WriteLine($"O frete do vagão deu {vagao1.calculaFrete()} !");

            Console.WriteLine("Digite o valor da carga do caminhão: ");
            double valor_caminhao_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o Peso da carga do caminhão: ");
            double peso_caminhao_1 = Convert.ToDouble(Console.ReadLine());

            var caminhao1 = new Caminhao(valor_caminhao_1, peso_caminhao_1);
            Console.WriteLine($"O frete do caminhão {caminhao1.calculaFrete()} !");
        }
    }
}
