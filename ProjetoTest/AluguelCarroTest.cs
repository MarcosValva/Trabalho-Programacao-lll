using System;
using TrabalhoApresentacao.uteis;

namespace TrabalhoApresentacao.Tests
{
    [TestClass]
    public class AluguelCarroTests
    {
        [TestMethod]
        public void TestCalcularCusto()
        {
            //cenário
            var aluguelCarro = new AluguelCarro();
            int dias = 5;
            double precoDiario = 100.00;
            double custoEsperado = dias * precoDiario;
            //ação
            double custoCalculado = aluguelCarro.CalcularCusto(dias);
            //teste
            Assert.AreEqual(custoEsperado, custoCalculado);
        }
    }
}
