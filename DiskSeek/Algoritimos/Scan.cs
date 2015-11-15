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
    /// Marcelo
    /// </author>
    public class Scan : Algoritimos
    {
        public Scan(decimal maximo) : base(maximo){}

        protected override void ordenaSequencia()
        {
            decimal sentido = this.determinaSentido();

            Predicate<String> matchInternos = delegate(String block)
            {
                return Convert.ToDecimal(block) < this.cilindroAtual;
            };

            Predicate<String> matchExternos = delegate(String block)
            {
                return Convert.ToDecimal(block) > this.cilindroAtual;
            };

            List<string> ordenada = new List<string>();

            List<String> internos = this.sequencia.FindAll(matchInternos);
            List<String> externos = this.sequencia.FindAll(matchExternos);

            internos = internos.OrderBy(block => Convert.ToInt32(block)).ToList();
            externos = externos.OrderBy(blk => Convert.ToInt32(blk)).ToList();

            if (sentido > 0)
            {
                // Indo para a trilha 0
                if (internos.First() != "0") internos.Insert(0, "0");
                internos.Reverse();
                internos.AddRange(externos);
                this.sequencia = internos;
            }
            else
            {
                // Indo para fora
                if (externos.Last() != Convert.ToString(this.cilindroMaximo)) externos.Add(Convert.ToString(this.cilindroMaximo));
                internos.Reverse();
                externos.AddRange(internos);
                this.sequencia = externos;
            }
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
