using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DiskSeek;
using DiskSeek.Algoritimos;

namespace DiskSeekUnitTest
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void TestSentidoIndoBorda()
        {
            decimal cilindroAnterior = 0;
            decimal cilindroAtual = 299;
            Algoritimos alg = new Sstf(300);
            alg.cilindroAnterior = cilindroAnterior;
            alg.cilindroAtual = cilindroAtual;

            Assert.AreEqual("Indo para a borda", alg.getSentido());
        }

        [TestMethod]
        public void TestSentidoIndoTrilha0()
        {
            decimal cilindroAnterior = 299;
            decimal cilindroAtual = 0;
            Algoritimos alg = new Sstf(299);
            alg.cilindroAnterior = cilindroAnterior;
            alg.cilindroAtual = cilindroAtual;

            Assert.AreEqual("Indo para a trilha 0", alg.getSentido());
        }

        [TestMethod]
        public void TestSentidoParado()
        {
            decimal cilindroAnterior = 0;
            decimal cilindroAtual = 0;
            Algoritimos alg = new Sstf(299);
            alg.cilindroAnterior = cilindroAnterior;
            alg.cilindroAtual = cilindroAtual;

            Assert.AreEqual("Parado", alg.getSentido());
        }
    }
}
