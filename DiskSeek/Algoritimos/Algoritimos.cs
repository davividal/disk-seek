﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskSeek.Algoritimos
{
    public abstract class Algoritimos
    {
        private decimal cilindroMaximo;

        private decimal _cilindroAtual;

        public decimal cilindroAtual
        {
            get { return _cilindroAtual; }
            set {
                if (value >= cilindroMaximo)
                {
                    throw new ArgumentException("Cilindro atual maior que cilindro máximo.");
                }

                _cilindroAtual = value;
                
            }
        }

        private decimal _cilindroAnterior;

        public decimal cilindroAnterior
        {
            get { return _cilindroAnterior; }
            set {
                if (value >= cilindroMaximo)
                {
                    throw new ArgumentException("Cilindro anterior maior que cilindro máximo.");
                }

                _cilindroAnterior = value;
            }
        }

        public Algoritimos(decimal maximo)
        {
            this.cilindroMaximo = Convert.ToInt32(maximo);
        }

        /// <summary>
        /// Determina o sentido da cabeça de leitura de acordo com o cilindro atual
        /// e o cilindro anterior.
        /// </summary>
        /// <returns>Negativo se estiver indo em direção à trilha 0</returns>
        public decimal determinaSentido()
        {
            return cilindroAnterior - cilindroAtual;
        }

        public String getSentido()
        {
            if (determinaSentido() == 0)
            {
                return "Parado";
            }
            else
            {
                if (determinaSentido() < 0)
                {
                    return "Indo para a borda";
                }
                else
                {
                    return "Indo para a trilha 0";
                }
            }
        }

        abstract public int getDistancia();

        abstract public void setSequencia(String sequencia);

        abstract public String getSequenciaLeitura();
    }
}
