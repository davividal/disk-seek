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
            Scan alg = new Scan(299);
            int distancia = 0;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            distancia = alg.getDistancia();

            Assert.AreEqual(150, distancia);
        }

        [TestMethod]
        public void TestSequenciaLeitura()
        {
            String seqExercicio = "68,14,6,28,130,94,6,42";
            decimal cilindroAnterior = 37;
            decimal cilindroAtual = 20;
            Sstf alg = new Sstf(299);
            String seqLeitura;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            seqLeitura = alg.getSequenciaLeitura();

            Assert.AreEqual("14,6,6,0,28,42,68,94,130", seqLeitura);
        }
    }
}
