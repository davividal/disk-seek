﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DiskSeek.Algoritimos;

namespace DiskSeekUnitTest
{
    [TestClass]
    public class SstfUnitTest
    {
        [TestMethod]
        public void TestNumeroCilindros()
        {
            String seqExercicio = "68,14,6,28,130,94,6,42";
            decimal cilindroAnterior = 37;
            decimal cilindroAtual = 20;
            Sstf alg = new Sstf(300);
            int distancia = 0;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            distancia = alg.getDistancia();

            Assert.AreEqual(138, distancia);
        }

        [TestMethod]
        public void TestSequenciaLeitura()
        {
            String seqExercicio = "68,14,6,28,130,94,6,42";
            decimal cilindroAnterior = 37;
            decimal cilindroAtual = 20;
            Sstf alg = new Sstf(300);
            String seqLeitura;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            seqLeitura = alg.getSequenciaLeitura();

            Assert.AreEqual("14,6,6,28,42,68,94,130", seqLeitura);
        }

        [TestMethod]
        public void TestExercicio2Distancia()
        {
            String seqExercicio = "86,1470,913,1774,948,1509,1022,1750,130";
            decimal cilindroAnterior = 125;
            decimal cilindroAtual = 143;
            Sstf alg = new Sstf(5000);
            int distancia = 0;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            distancia = alg.getDistancia();

            Assert.AreEqual(1745, distancia);
        }

        [TestMethod]
        public void TestExercicio2Sequencia()
        {
            String seqExercicio = "86,1470,913,1774,948,1509,1022,1750,130";
            decimal cilindroAnterior = 125;
            decimal cilindroAtual = 143;
            Sstf alg = new Sstf(5000);
            String seqLeitura;

            alg.cilindroAnterior = Convert.ToInt32(cilindroAnterior);
            alg.cilindroAtual = Convert.ToInt32(cilindroAtual);
            alg.setSequencia(seqExercicio);

            alg.processa();

            seqLeitura = alg.getSequenciaLeitura();

            Assert.AreEqual("130,86,913,948,1022,1470,1509,1750,1774", seqLeitura);
        }
    }
}
