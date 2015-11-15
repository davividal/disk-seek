using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DiskSeek.Algoritimos;

namespace DiskSeekUnitTest
{
    [TestClass]
    public class ScanUnitTest
    {
        [TestMethod]
        public void TestNumeroCilindros()
        {
            String seqExercicio = "68,14,6,28,130,94,6,42";
            decimal cilindroAnterior = 37;
            decimal cilindroAtual = 20;
            Scan alg = new Scan(300);
            int distancia = 0;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            distancia = alg.getDistancia();

            Assert.AreEqual(150, distancia);
        }

        [TestMethod]
        public void TestSequenciaLeitura()
        {
            String seqExercicio = "68,14,6,28,130,94,6,42";
            decimal cilindroAnterior = 37;
            decimal cilindroAtual = 20;
            Scan alg = new Scan(300);
            String seqLeitura;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            seqLeitura = alg.getSequenciaLeitura();

            Assert.AreEqual("14,6,6,0,28,42,68,94,130", seqLeitura);
        }

        [TestMethod]
        public void TestNumeroCilindrosLista()
        {
            String seqExercicio = "100,198,199,101,199,10,11,5,10,3";
            decimal cilindroAnterior = 137;
            decimal cilindroAtual = 150;
            Scan alg = new Scan(200);
            int distancia = 0;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            distancia = alg.getDistancia();

            Assert.AreEqual(245, distancia);
        }

        [TestMethod]
        public void TestSequenciaLeituraLista()
        {
            String seqExercicio = "100,198,199,101,199,10,11,5,10,3";
            decimal cilindroAnterior = 137;
            decimal cilindroAtual = 150;
            Scan alg = new Scan(200);
            String seqLeitura;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            seqLeitura = alg.getSequenciaLeitura();

            Assert.AreEqual("198,199,199,101,100,11,10,10,5,3", seqLeitura);
        }
    }
}
