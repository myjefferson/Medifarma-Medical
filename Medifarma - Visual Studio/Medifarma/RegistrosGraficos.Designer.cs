namespace Medifarma
{
    partial class RegistrosGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ConsutasMedico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ConsultasPacienteFeminino = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsutasMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasPacienteFeminino)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsutasMedico
            // 
            chartArea1.Name = "ChartArea1";
            this.ConsutasMedico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ConsutasMedico.Legends.Add(legend1);
            this.ConsutasMedico.Location = new System.Drawing.Point(15, 187);
            this.ConsutasMedico.Name = "ConsutasMedico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series5";
            this.ConsutasMedico.Series.Add(series1);
            this.ConsutasMedico.Size = new System.Drawing.Size(365, 300);
            this.ConsutasMedico.TabIndex = 0;
            this.ConsutasMedico.Text = "chart1";
            // 
            // ConsultasPacienteFeminino
            // 
            chartArea2.Name = "ChartArea1";
            this.ConsultasPacienteFeminino.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ConsultasPacienteFeminino.Legends.Add(legend2);
            this.ConsultasPacienteFeminino.Location = new System.Drawing.Point(400, 187);
            this.ConsultasPacienteFeminino.Name = "ConsultasPacienteFeminino";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ConsultasPacienteFeminino.Series.Add(series2);
            this.ConsultasPacienteFeminino.Size = new System.Drawing.Size(371, 300);
            this.ConsultasPacienteFeminino.TabIndex = 0;
            this.ConsultasPacienteFeminino.Text = "chart1";
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Fechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fechar.Location = new System.Drawing.Point(767, -1);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(37, 35);
            this.Fechar.TabIndex = 14;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // RegistrosGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(799, 536);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.ConsultasPacienteFeminino);
            this.Controls.Add(this.ConsutasMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegistrosGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrosGraficos";
            this.Load += new System.EventHandler(this.RegistrosGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsutasMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasPacienteFeminino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ConsutasMedico;
        private System.Windows.Forms.DataVisualization.Charting.Chart ConsultasPacienteFeminino;
        private System.Windows.Forms.Button Fechar;
    }
}