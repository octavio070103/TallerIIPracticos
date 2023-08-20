namespace Practico4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxNum = new System.Windows.Forms.ListBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblListaNm = new System.Windows.Forms.Label();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.chartNumGenerados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumGenerados)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxNum
            // 
            this.listBoxNum.FormattingEnabled = true;
            this.listBoxNum.Location = new System.Drawing.Point(312, 103);
            this.listBoxNum.Name = "listBoxNum";
            this.listBoxNum.Size = new System.Drawing.Size(347, 212);
            this.listBoxNum.TabIndex = 0;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(12, 111);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(15, 145);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(56, 108);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 3;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(56, 142);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 4;
            // 
            // lblListaNm
            // 
            this.lblListaNm.AutoSize = true;
            this.lblListaNm.Location = new System.Drawing.Point(376, 70);
            this.lblListaNm.Name = "lblListaNm";
            this.lblListaNm.Size = new System.Drawing.Size(89, 13);
            this.lblListaNm.TabIndex = 5;
            this.lblListaNm.Text = "Lista de Numeros";
            // 
            // btnFuncion
            // 
            this.btnFuncion.Location = new System.Drawing.Point(177, 103);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(102, 20);
            this.btnFuncion.TabIndex = 6;
            this.btnFuncion.Text = "Generar Funcion";
            this.btnFuncion.UseVisualStyleBackColor = true;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(177, 216);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 20);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(177, 138);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(102, 20);
            this.btnPares.TabIndex = 8;
            this.btnPares.Text = "Numeros Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnPrimos
            // 
            this.btnPrimos.Location = new System.Drawing.Point(177, 190);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(102, 20);
            this.btnPrimos.TabIndex = 9;
            this.btnPrimos.Text = "Numeros Primos";
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(177, 164);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(102, 20);
            this.btnImpares.TabIndex = 10;
            this.btnImpares.Text = "Numeros Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // chartNumGenerados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNumGenerados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNumGenerados.Legends.Add(legend1);
            this.chartNumGenerados.Location = new System.Drawing.Point(-2, 242);
            this.chartNumGenerados.Name = "chartNumGenerados";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNumGenerados.Series.Add(series1);
            this.chartNumGenerados.Size = new System.Drawing.Size(308, 222);
            this.chartNumGenerados.TabIndex = 11;
            this.chartNumGenerados.Text = "Numeros Generados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.chartNumGenerados);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnPrimos);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFuncion);
            this.Controls.Add(this.lblListaNm);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.listBoxNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumGenerados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNum;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblListaNm;
        private System.Windows.Forms.Button btnFuncion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.Button btnPrimos;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumGenerados;
    }
}

