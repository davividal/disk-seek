using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DiskSeek;
using DiskSeek.Algoritimos;

namespace DiskSeekUnitTest
{
    [TestClass]
    public class MainTest
    {
        private decimal cilindroMaximo = 300;

        [TestMethod]
        public void TestSentidoIndoBorda()
        {
            decimal cilindroAnterior = 0;
            decimal cilindroAtual = 299;
            Algoritimos alg = new Sstf(this.cilindroMaximo);
            alg.cilindroAnterior = cilindroAnterior;
            alg.cilindroAtual = cilindroAtual;

            Assert.AreEqual("Indo para a borda", alg.getSentido());
        }

        [TestMethod]
        public void TestSentidoIndoTrilha0()
        {
            decimal cilindroAnterior = 299;
            decimal cilindroAtual = 0;
            Algoritimos alg = new Sstf(this.cilindroMaximo);
            alg.cilindroAnterior = cilindroAnterior;
            alg.cilindroAtual = cilindroAtual;

            Assert.AreEqual("Indo para a trilha 0", alg.getSentido());
        }

        [TestMethod]
        public void TestSentidoIntroTrilha0Intermediario()
        {
            decimal cilindroAnterior = 43;
            decimal cilindroAtual = 30;
            Algoritimos alg = new Sstf(this.cilindroMaximo);
            alg.cilindroAnterior = cilindroAnterior;
            alg.cilindroAtual = cilindroAtual;

            Assert.AreEqual("Indo para a trilha 0", alg.getSentido());
        }

        [TestMethod]
        public void TestSentidoParado()
        {
            decimal cilindroAnterior = 0;
            decimal cilindroAtual = 0;
            Algoritimos alg = new Sstf(this.cilindroMaximo);
            alg.cilindroAnterior = cilindroAnterior;
            alg.cilindroAtual = cilindroAtual;

            Assert.AreEqual("Parado", alg.getSentido());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Valor anterior maior que o cilindro máximo.")]
        public void TestAnteriorIgualMaximo()
        {
            decimal cilindroMaximo = 300;
            decimal cilindroTeste = 300;

            Algoritimos alg = new Sstf(cilindroMaximo);
            alg.cilindroAnterior = cilindroTeste;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Valor anterior maior que o cilindro máximo.")]
        public void TestAtualIgualMaximo()
        {
            decimal cilindroMaximo = 300;
            decimal cilindroTeste = 300;

            Algoritimos alg = new Sstf(cilindroMaximo);
            alg.cilindroAtual = cilindroTeste;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Valor anterior maior que o cilindro máximo.")]
        public void TestAnteriorMaiorMaximo()
        {
            decimal cilindroMaximo = 300;
            decimal cilindroTeste = 350;

            Algoritimos alg = new Sstf(cilindroMaximo);
            alg.cilindroAnterior = cilindroTeste;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Valor anterior maior que o cilindro máximo.")]
        public void TestAtualMaiorMaximo()
        {
            decimal cilindroMaximo = 300;
            decimal cilindroTeste = 350;

            Algoritimos alg = new Sstf(cilindroMaximo);
            alg.cilindroAtual = cilindroTeste;
        }
    }
}
