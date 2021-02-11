namespace Desafio_02
{
    public abstract class Transporte : Carga
    {
        public Transporte(double valor, double peso) : base(valor, peso)
        {
            Valor = valor;
            Peso = peso;
        }

       public abstract double calculaFrete();
    }
}