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
            cilindroAnterior.Maximum = maxCilindros.Value;
            cilindroAtual.Maximum = maxCilindros.Value;
        }

        private void maxCilindros_ValueChanged(object sender, EventArgs e)
        {
            cilindroAnterior.Maximum = ((NumericUpDown)sender).Value;
            cilindroAtual.Maximum = ((NumericUpDown)sender).Value;
        }

        private void processaFilas_Click(object sender, EventArgs e)
        {
            Algoritimos.Algoritimos alg1 = new Algoritimos.Sstf(maxCilindros.Value);
            Algoritimos.Algoritimos alg2 = new Algoritimos.Cscan(maxCilindros.Value);
            Algoritimos.Algoritimos alg3 = new Algoritimos.Scan(maxCilindros.Value);
            
            alg1.cilindroAnterior = cilindroAnterior.Value;
            alg1.cilindroAtual = cilindroAtual.Value;

            alg2.cilindroAnterior = cilindroAnterior.Value;
            alg2.cilindroAtual = cilindroAtual.Value;

            alg3.cilindroAnterior = cilindroAnterior.Value;
            alg3.cilindroAtual = cilindroAtual.Value;

            backgroundWorker1.RunWorkerAsync(alg1);
            backgroundWorker2.RunWorkerAsync(alg2);
            backgroundWorker3.RunWorkerAsync(alg3);

            sentidoLeitura.Text = alg1.getSentido();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Argument;

            e.Result = alg;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Result;

            sstfCilindros.Text = Convert.ToString(alg.getDistancia());
            sstfFila.Text = alg.getSequenciaLeitura();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Argument;

            e.Result = alg;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Result;

            scanCilindros.Text = Convert.ToString(alg.getDistancia());
            scanFila.Text = alg.getSequenciaLeitura();
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Argument;

            e.Result = alg;
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Result;

            cscanCilindros.Text = Convert.ToString(alg.getDistancia());
            cscanFila.Text = alg.getSequenciaLeitura();
        }
    }
}
