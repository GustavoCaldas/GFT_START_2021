using System;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Armazenando Input do usuário na variável multiplicando.
            Console.WriteLine("Multiplicando: ");
            int multiplicando = Convert.ToInt32(Console.ReadLine());

            // Validações
            if ( multiplicando < 0 || multiplicando > 3000)
                throw new Exception("O Multiplicando não pode ser maior que 0 ou maior que 3000!");

            // Armazenando Input do usuário na variável inicio_intervalo.
            Console.WriteLine("Início do intervalo: ");
            int inicio_intervalo = Convert.ToInt32(Console.ReadLine());

            // Validações 
            if (inicio_intervalo < 0 || inicio_intervalo > 3000)
                throw new Exception("O Início do intervalo não pode ser maior que 0 ou maior que 3000!");

            // Armazenando Input do usuário na variável fim_intervalo.
            Console.WriteLine("Fim do intervalo: ");
            int fim_intervalo = Convert.ToInt32(Console.ReadLine());

            // Validações
            if (fim_intervalo < 0 || fim_intervalo > 3000)
                throw new Exception("O Fim do intervalo não pode ser maior que 0 ou maior que 3000!");

            if ( inicio_intervalo > fim_intervalo)
                throw new Exception("O início do intervalo deve ser maior que seu fim!");

            if ( fim_intervalo - inicio_intervalo > 10)
                throw new Exception("O intervalo não pode ter uma diferença maior que 10!");

            // Loop For para a saída dos resultados.
            for (; inicio_intervalo <= fim_intervalo; inicio_intervalo++ )
            {
                int resultado = multiplicando * inicio_intervalo;
                Console.WriteLine($"{multiplicando} x {inicio_intervalo} = {resultado}");
            }
        }
    }
}
