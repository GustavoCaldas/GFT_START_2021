namespace Desafio_02
{
    public class Vagao : Transporte
    {
        public Vagao(double valor, double peso) : base(valor, peso)
        {
            Valor = valor;
            Peso = peso;
        }
        public override double calculaFrete(){
            double frete = 0.2 * Peso + 0.1 * Valor;

            if ( Peso < 15000)
                frete += 5000;
            
            return frete;
        }
    }
}