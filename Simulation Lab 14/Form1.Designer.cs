namespace Simulation_Lab_14
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edLambda = new System.Windows.Forms.NumericUpDown();
            this.edMu = new System.Windows.Forms.NumericUpDown();
            this.edT = new System.Windows.Forms.NumericUpDown();
            this.edOperators = new System.Windows.Forms.NumericUpDown();
            this.edNumber = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of operators\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lyambda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mu";
            // 
            // edLambda
            // 
            this.edLambda.DecimalPlaces = 2;
            this.edLambda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edLambda.Location = new System.Drawing.Point(231, 179);
            this.edLambda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edLambda.Name = "edLambda";
            this.edLambda.Size = new System.Drawing.Size(90, 26);
            this.edLambda.TabIndex = 5;
            this.edLambda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edLambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edMu
            // 
            this.edMu.DecimalPlaces = 2;
            this.edMu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edMu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edMu.Location = new System.Drawing.Point(231, 233);
            this.edMu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edMu.Name = "edMu";
            this.edMu.Size = new System.Drawing.Size(90, 26);
            this.edMu.TabIndex = 6;
            this.edMu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edMu.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // edT
            // 
            this.edT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edT.Location = new System.Drawing.Point(231, 123);
            this.edT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edT.Name = "edT";
            this.edT.Size = new System.Drawing.Size(90, 26);
            this.edT.TabIndex = 7;
            this.edT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edT.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // edOperators
            // 
            this.edOperators.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edOperators.Location = new System.Drawing.Point(231, 71);
            this.edOperators.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edOperators.Name = "edOperators";
            this.edOperators.Size = new System.Drawing.Size(90, 26);
            this.edOperators.TabIndex = 8;
            this.edOperators.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edOperators.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // edNumber
            // 
            this.edNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edNumber.Location = new System.Drawing.Point(231, 24);
            this.edNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edNumber.Name = "edNumber";
            this.edNumber.Size = new System.Drawing.Size(90, 26);
            this.edNumber.TabIndex = 9;
            this.edNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(383, 24);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Empirical Data";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Theoretical Data";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(689, 290);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(231, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.edNumber);
            this.Controls.Add(this.edOperators);
            this.Controls.Add(this.edT);
            this.Controls.Add(this.edMu);
            this.Controls.Add(this.edLambda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edLambda;
        private System.Windows.Forms.NumericUpDown edMu;
        private System.Windows.Forms.NumericUpDown edT;
        private System.Windows.Forms.NumericUpDown edOperators;
        private System.Windows.Forms.NumericUpDown edNumber;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}

