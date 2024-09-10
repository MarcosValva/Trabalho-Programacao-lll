namespace TrabalhoApresentacao.uteis
{
    public class AluguelCarro
    {
        //Define uma constante pública chamada PrecoDiario, que representa o preço diário do aluguel do carro
        public const double PrecoDiario = 100.00;

        //calcula o custo total do aluguel com base no número de dias
        //parâmetro 'dias' é o número de dias que o carro será alugado
        public double CalcularCusto(int dias)
        {
            return dias * PrecoDiario;
        }
    }
}
