using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskSeek.Algoritimos
{
    public class Sstf : Algoritimos
    {
        private string sequenciaLeitura;

        public Sstf(decimal maximo) : base(maximo){}

        public override int getDistancia()
        {
            throw new NotImplementedException();
        }

        public override void setSequencia(string sequencia)
        {
            this.sequenciaLeitura = sequencia;
        }

        public override String getSequenciaLeitura()
        {
            throw new NotImplementedException();
        }
    }
}
