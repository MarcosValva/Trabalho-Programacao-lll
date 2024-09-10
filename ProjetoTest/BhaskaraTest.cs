using System;
using TrabalhoApresentacao.uteis;

namespace TrabalhoApresentacao.Tests
{
    [TestClass]
    public class BhaskaraTest
    {
        [TestMethod]
        public void CalcularRaizes_EquacaoComRaizesReais_RetornaRaizesCorretas()
        {
            //cenário
            double a = 1;
            double b = -3;
            double c = 2;
            double raiz1Esperada = 2.0;
            double raiz2Esperada = 1.0;
            //ação
            (bool sucesso, double raiz1, double raiz2) = Bhaskara.CalcularRaizes(a, b, c);
            //teste
            Assert.IsTrue(sucesso);
            Assert.AreEqual(raiz1Esperada, raiz1, 0.01);
            Assert.AreEqual(raiz2Esperada, raiz2, 0.01);
        }

        [TestMethod]
        public void CalcularRaizes_EquacaoSemRaizesReais_RetornaFalso()
        {
            //cenário
            double a = 1;
            double b = 2;
            double c = 5;
            //ação
            (bool sucesso, double raiz1, double raiz2) = Bhaskara.CalcularRaizes(a, b, c);
            //teste
            Assert.IsFalse(sucesso);
        }
    }
}
