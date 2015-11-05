namespace DiskSeek
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.processaFilas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fila = new System.Windows.Forms.TextBox();
            this.cilindroAtual = new System.Windows.Forms.NumericUpDown();
            this.cilindroAnterior = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sstfCilindros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sstfFila = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scanCilindros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.scanFila = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cscanCilindros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cscanFila = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sentidoLeitura = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cilindroAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindroAnterior)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 304);
            this.tabControl1.TabIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.processaFilas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.fila);
            this.tabPage1.Controls.Add(this.cilindroAtual);
            this.tabPage1.Controls.Add(this.cilindroAnterior);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados de Entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // processaFilas
            //
            this.processaFilas.Location = new System.Drawing.Point(306, 249);
            this.processaFilas.Name = "processaFilas";
            this.processaFilas.Size = new System.Drawing.Size(75, 23);
            this.processaFilas.TabIndex = 12;
            this.processaFilas.Text = "&Processar";
            this.processaFilas.UseVisualStyleBackColor = true;
            this.processaFilas.Click += new System.EventHandler(this.processaFilas_Click);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lista de leitura";
            //
            // fila
            //
            this.fila.AcceptsReturn = true;
            this.fila.Location = new System.Drawing.Point(6, 121);
            this.fila.Multiline = true;
            this.fila.Name = "fila";
            this.fila.Size = new System.Drawing.Size(375, 105);
            this.fila.TabIndex = 10;
            //
            // cilindroAtual
            //
            this.cilindroAtual.Location = new System.Drawing.Point(92, 52);
            this.cilindroAtual.Maximum = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.cilindroAtual.Name = "cilindroAtual";
            this.cilindroAtual.Size = new System.Drawing.Size(120, 20);
            this.cilindroAtual.TabIndex = 9;
            //
            // cilindroAnterior
            //
            this.cilindroAnterior.Location = new System.Drawing.Point(92, 26);
            this.cilindroAnterior.Maximum = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.cilindroAnterior.Name = "cilindroAnterior";
            this.cilindroAnterior.Size = new System.Drawing.Size(120, 20);
            this.cilindroAnterior.TabIndex = 8;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cilindro Atual";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cilindro Anterior";
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.sstfCilindros);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.sstfFila);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SSTF";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // sstfCilindros
            //
            this.sstfCilindros.Location = new System.Drawing.Point(116, 16);
            this.sstfCilindros.Name = "sstfCilindros";
            this.sstfCilindros.ReadOnly = true;
            this.sstfCilindros.Size = new System.Drawing.Size(100, 20);
            this.sstfCilindros.TabIndex = 3;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Número de cilindros";
            //
            // sstfFila
            //
            this.sstfFila.Location = new System.Drawing.Point(4, 63);
            this.sstfFila.Multiline = true;
            this.sstfFila.Name = "sstfFila";
            this.sstfFila.ReadOnly = true;
            this.sstfFila.Size = new System.Drawing.Size(378, 177);
            this.sstfFila.TabIndex = 1;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fila ordenada";
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.scanCilindros);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.scanFila);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(387, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SCAN";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // scanCilindros
            //
            this.scanCilindros.Location = new System.Drawing.Point(116, 16);
            this.scanCilindros.Name = "scanCilindros";
            this.scanCilindros.ReadOnly = true;
            this.scanCilindros.Size = new System.Drawing.Size(100, 20);
            this.scanCilindros.TabIndex = 7;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número de cilindros";
            //
            // scanFila
            //
            this.scanFila.Location = new System.Drawing.Point(4, 63);
            this.scanFila.Multiline = true;
            this.scanFila.Name = "scanFila";
            this.scanFila.ReadOnly = true;
            this.scanFila.Size = new System.Drawing.Size(378, 177);
            this.scanFila.TabIndex = 5;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fila ordenada";
            //
            // tabPage4
            //
            this.tabPage4.Controls.Add(this.cscanCilindros);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.cscanFila);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(387, 278);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CSCAN";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // cscanCilindros
            //
            this.cscanCilindros.Location = new System.Drawing.Point(116, 16);
            this.cscanCilindros.Name = "cscanCilindros";
            this.cscanCilindros.ReadOnly = true;
            this.cscanCilindros.Size = new System.Drawing.Size(100, 20);
            this.cscanCilindros.TabIndex = 7;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Número de cilindros";
            //
            // cscanFila
            //
            this.cscanFila.Location = new System.Drawing.Point(4, 63);
            this.cscanFila.Multiline = true;
            this.cscanFila.Name = "cscanFila";
            this.cscanFila.ReadOnly = true;
            this.cscanFila.Size = new System.Drawing.Size(378, 177);
            this.cscanFila.TabIndex = 5;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fila ordenada";
            //
            // statusStrip1
            //
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sentidoLeitura});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(421, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            //
            // sentidoLeitura
            //
            this.sentidoLeitura.Name = "sentidoLeitura";
            this.sentidoLeitura.Size = new System.Drawing.Size(0, 17);
            //
            // Main
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 348);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Disk Seek";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cilindroAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindroAnterior)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fila;
        private System.Windows.Forms.NumericUpDown cilindroAtual;
        private System.Windows.Forms.NumericUpDown cilindroAnterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox sstfCilindros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sstfFila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scanCilindros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox scanFila;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cscanCilindros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cscanFila;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button processaFilas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sentidoLeitura;

    }
}

