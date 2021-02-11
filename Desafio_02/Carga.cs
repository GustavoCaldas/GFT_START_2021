namespace Desafio_02
{
    public class Carga
    {
        public double Valor { get; set; }
        public double Peso { get; set; }

        public Carga(double valor, double peso)
        {
            Valor = valor;
            Peso = peso;
        }
    }
}