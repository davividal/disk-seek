using DiskSeek.Algoritimos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskSeek
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void processaFilas_Click(object sender, EventArgs e)
        {
            Algoritimos.Algoritimos alg1 = new Algoritimos.Sstf(300);
            
            alg1.cilindroAnterior = cilindroAnterior.Value;
            alg1.cilindroAtual = cilindroAtual.Value;

            sentidoLeitura.Text = alg1.getSentido();
        }
    }
}
