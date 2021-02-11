namespace Desafio_02
{
    public class Caminhao : Transporte
    {
        public Caminhao(double valor, double peso) : base(valor, peso)
        {
            Valor = valor;
            Peso = peso;
        }
        public override double calculaFrete(){
            double frete = 0.12 * Peso + 0.3 * Valor;

            if ( Valor > 40000 )
                frete -= frete*0.25; 

            return frete;
        }
    }
}