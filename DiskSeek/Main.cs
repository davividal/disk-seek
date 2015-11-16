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
using System.Windows.Forms.DataVisualization.Charting;

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
            if (fila.Text == "")
            {
                MessageBox.Show("Informe uma fila de processamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            grafico.Series.Clear();

            Algoritimos.Algoritimos alg1 = new Algoritimos.Sstf(maxCilindros.Value);
            Algoritimos.Algoritimos alg2 = new Algoritimos.Scan(maxCilindros.Value);
            Algoritimos.Algoritimos alg3 = new Algoritimos.Cscan(maxCilindros.Value);
            
            alg1.cilindroAnterior = cilindroAnterior.Value;
            alg1.cilindroAtual = cilindroAtual.Value;
            alg1.setSequencia(fila.Text);

            alg2.cilindroAnterior = cilindroAnterior.Value;
            alg2.cilindroAtual = cilindroAtual.Value;
            alg2.setSequencia(fila.Text);

            alg3.cilindroAnterior = cilindroAnterior.Value;
            alg3.cilindroAtual = cilindroAtual.Value;
            alg3.setSequencia(fila.Text);

            backgroundWorker1.RunWorkerAsync(alg1);
            backgroundWorker2.RunWorkerAsync(alg2);
            backgroundWorker3.RunWorkerAsync(alg3);

            sentidoLeitura.Text = alg1.getSentido();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Argument;

            alg.processa();

            e.Result = alg;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Result;

            sstfCilindros.Text = Convert.ToString(alg.getDistancia());
            sstfFila.Text = alg.getSequenciaLeitura();

            adicionaPontosGrafico("SSTF", alg);
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Argument;

            alg.processa();

            e.Result = alg;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Result;

            scanCilindros.Text = Convert.ToString(alg.getDistancia());
            scanFila.Text = alg.getSequenciaLeitura();

            adicionaPontosGrafico("SCAN", alg);
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Argument;

            alg.processa();

            e.Result = alg;
        }

        private List<DataPoint> sequenciaToPoints(List<String> sequencia)
        {
            List<DataPoint> pontos = new List<DataPoint>();
            List<Int32> blocos = sequencia.Select(blk => Convert.ToInt32(blk)).ToList();
            Int32 index = 0;

            foreach (var bloco in blocos)
            {
                DataPoint block = new DataPoint();
                block.SetValueXY(bloco, index++);
                pontos.Add(block);
            }

            return pontos;
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Algoritimos.Algoritimos alg = (Algoritimos.Algoritimos)e.Result;

            cscanCilindros.Text = Convert.ToString(alg.getDistancia());
            cscanFila.Text = alg.getSequenciaLeitura();

            adicionaPontosGrafico("CSCAN", alg);
        }

        private void adicionaPontosGrafico(String name, Algoritimos.Algoritimos alg)
        {
            grafico.Series.Add(name);
            Series serie = grafico.Series[grafico.Series.IndexOf(name)];
            foreach (var p in sequenciaToPoints(alg.getSequencia()))
            {
                serie.Points.Add(p);
                serie.ChartType = SeriesChartType.Line;
                serie.BorderWidth = 2;
            }

            grafico.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            grafico.ChartAreas[0].AxisX.Minimum = 0;
            grafico.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(maxCilindros.Value);
        }
    }
}
