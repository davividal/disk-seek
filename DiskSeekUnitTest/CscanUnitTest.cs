using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DiskSeek.Algoritimos;

namespace DiskSeekUnitTest
{
    [TestClass]
    public class CscanUnitTest
    {
        [TestMethod]
        public void TestNumeroCilindros()
        {
            String seqExercicio = "86,1470,913,1774,948,1509,1022,1750,130";
            decimal cilindroAnterior = 125;
            decimal cilindroAtual = 143;
            Cscan alg = new Cscan(4999);
            int distancia = 0;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            distancia = alg.getDistancia();

            Assert.AreEqual(5026, distancia);
        }

        [TestMethod]
        public void TestSequenciaLeitura()
        {
            String seqExercicio = "86,1470,913,1774,948,1509,1022,1750,130";
            decimal cilindroAnterior = 125;
            decimal cilindroAtual = 143;
            Sstf alg = new Sstf(4999);
            String seqLeitura;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            seqLeitura = alg.getSequenciaLeitura();

            Assert.AreEqual("913,948,1022,1470,1509,1750,1774,4999,0,86,130", seqLeitura);
        }
    }
}
