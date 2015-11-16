using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskSeek.Algoritimos
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>
    /// Eduardo
    /// </author>
    public class Sstf : Algoritimos
    {
        public Sstf(decimal maximo) : base(maximo){}

        protected override void ordenaSequencia()
        {
            List<Int32> leitura = this.sequencia.Select(Int32.Parse).ToList();
            List<Int32> ordenada = new List<Int32>();
            Int32 atual = Convert.ToInt32(this.cilindroAtual);
            Int32 distancia;
            Int32 proximoBloco = 0;

            while (leitura.Count > 0)
            {
                distancia = Convert.ToInt32(this.cilindroMaximo) + 1;
                foreach (Int32 bloco in leitura) 
                {
                    if (Math.Abs(atual - bloco) <= distancia)
                    {
                        distancia = Math.Abs(atual - bloco);
                        proximoBloco = bloco;
                    }
                }
                ordenada.Add(proximoBloco);
                leitura.Remove(proximoBloco);
                atual = proximoBloco;
            }
            this.sequencia = ordenada.Select(blk => Convert.ToString(blk)).ToList();
        }

        protected override void calculaDistancia()
        {
            List<Int32> diferencas = new List<Int32>();
            for (int i = 0, diff = 0; i < this.sequencia.Count; i++)
            {
                if (i == 0)
                {
                    diff = Convert.ToInt32(this.sequencia[i]) - Convert.ToInt32(this.cilindroAtual);
                }
                else
                {
                    diff = Convert.ToInt32(this.sequencia[i]) - Convert.ToInt32(this.sequencia[i - 1]);
                }

                diferencas.Add(Math.Abs(diff));
            }
            this.distancia = diferencas.Aggregate((acc, next) => acc + next);
        }
    }
}
