using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DiskSeek.Algoritimos;

namespace DiskSeekUnitTest
{
    [TestClass]
    public class CscanUnitTest
    {
        [TestMethod]
        public void TestNumeroCilindrosCscan()
        {
            String seqExercicio = "86,1470,913,1774,948,1509,1022,1750,130";
            decimal cilindroAnterior = 125;
            decimal cilindroAtual = 143;
            Cscan alg = new Cscan(4999);
            int distancia = 0;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            distancia = alg.getDistancia();

            Assert.AreEqual(4986, distancia);
        }

        [TestMethod]
        public void TestSequenciaLeituraCscan()
        {
            String seqExercicio = "86,1470,913,1774,948,1509,1022,1750,130";
            decimal cilindroAnterior = 125;
            decimal cilindroAtual = 143;
            Cscan alg = new Cscan(4999);
            String seqLeitura;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            seqLeitura = alg.getSequenciaLeitura();

            Assert.AreEqual("913,948,1022,1470,1509,1750,1774,4999,0,86,130", seqLeitura);
        }
    }
}
